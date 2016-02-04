var wget = require('wget');
var mkdirp = require('mkdirp');
var fs = require('fs');
var Q = require('q');
var pclib = require('PureCloudApiLibraries');
var path = require('path');

var progressTracker = 0;
var packageVersion = '0.0.0';
var oldSwaggerPath = 'lib/swagger-old.json';
var newSwaggerPath = 'lib/swagger.json';
var versionFilePath = 'buildScripts/version.json';

downloadFile(
	'http://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.1.4/swagger-codegen-cli-2.1.4.jar', 
	'bin/swagger-codegen-cli.jar')
	.then(function() {
		//TODO: allow this to proceed once the swagger file is fixed
		return;
		// Download the latest swagger
		return downloadFile('https://api.mypurecloud.com/api/v1/docs/swagger', newSwaggerPath); 
	})
	.then(updateVersion)
	.then(writeConfig)
	.then(function() {
		console.log('prebuild script complete');
		// Have to explicitly exit because promises keep the node process running
		process.exit(0);
	})
	.catch(function(error) {
		console.log('Error encountered in prebuild script!');
		console.log(error);
		process.exit(1);
	});


function downloadFile(url, output) {
	var deferred = Q.defer();

	progressTracker = 0;
	var dirPath = '';
	if (output.indexOf('/') > -1)
		dirPath = output.substring(0, output.lastIndexOf("/"));
	else if (output.indexOf('\\') > -1)
		dirPath = output.substring(0, output.lastIndexOf("\\"));
	else
		console.log('output path does not contain a directory');

	mkdirp(dirPath, function(err) { 
		if (err) {
			console.log('Fatal error making directory: ');
			console.log(err);
			deferred.reject(err);
			return;
		}
	});

	console.log('Downloading ' + url);
	var download = wget.download(url, output);
	download.on('error', function(err) {
		console.log('Fatal error downloading file: ');
	    console.log(err);
		deferred.reject(err);
		return;
	});
	download.on('end', function(output) {
		/*Jenkins doesn't support clearLine. Lame.
		process.stdout.clearLine();
		process.stdout.cursorTo(0);
		*/
	    console.log('File downloaded to : ' + output);
	    deferred.resolve();
		return;
	});
	download.on('progress', function(progress) {
		// Report progress at 5% intervals
		var p = Number((progress * 100).toFixed(0));
		var progressInterval = 5;
		if (p > progressTracker && p % progressInterval == 0) {
			progressTracker = p;
			console.log(progressTracker + '%');
			/* Jenkins doesn't support clearLine. Lame.
			process.stdout.clearLine();
			process.stdout.cursorTo(0);
			var completed = new Array((progressTracker / progressInterval) + 1).join("█");
			var left = new Array(((100 - progressTracker) / progressInterval) + 1).join(" ");
			process.stdout.write('Progress [' + completed + left + '] ' + progressTracker + '%');  // write text
			*/
		}
	});

	return deferred.promise;
}

function updateVersion() {
	console.log('Verifying files...');
	if (!fs.existsSync(versionFilePath)) {
		console.log('Creating ' + versionFilePath);
		fs.writeFileSync(versionFilePath, '{"major":0,"minor":0,"point":0,"changelog":{}}', 'UTF-8');
	}
	if (!fs.existsSync(newSwaggerPath)) {
		throw new Error('Failed to find new swagger file at ' + newSwaggerPath);
	}
	if (!fs.existsSync(oldSwaggerPath)) {
		console.log('Creating ' + oldSwaggerPath + ' from ' + newSwaggerPath);
		fs.writeFileSync(oldSwaggerPath, fs.readFileSync(newSwaggerPath, 'UTF-8'), 'UTF-8');
	}

	// Temporarially using a static local file until swagger doc issues are resolved
	var versioning = pclib.swaggerVersioning();

	var oldVersion = versioning.getVersionString(versionFilePath);
	console.log('Old version: ' + oldVersion);

	// Read swagger files into memory
	console.log('Loading old swagger from ' + oldSwaggerPath);
	var oldSwagger = JSON.parse(fs.readFileSync(oldSwaggerPath, 'UTF-8'));
	console.log('Loading new swagger from ' + newSwaggerPath);
	var newSwagger = JSON.parse(fs.readFileSync(newSwaggerPath, 'UTF-8'));

	// Diff
	console.log('Diffing swagger...')
    var swaggerDifferences = versioning.checkAll(oldSwagger, newSwagger);

    // Update version file
    var hasChanges = versioning.updateVersionFile(swaggerDifferences, versionFilePath);

    // Overwrite old swagger file with latest data
    fs.writeFileSync(oldSwaggerPath, JSON.stringify(newSwagger), 'UTF-8');

    packageVersion = versioning.getVersionString(versionFilePath);
	console.log('New version: ' + packageVersion + (hasChanges ? '' : ' [UNCHANGED]'));
}

function writeConfig() {
	var deferred = Q.defer();

	console.log('Package version: ' + packageVersion + '.' + process.env['BUILD_NUMBER']);
	var config = {
		"packageName":"ININ.PureCloudApi",
		"packageVersion":packageVersion + '.' + process.env.BUILD_NUMBER,
		"packageTitle":"PureCloud Public API Library",
	    "packageProductName":"PureCloudPublicAPILibrary",
	    "packageDescription":"A .NET library to interface with the PureCloud Public API",
	    "packageCompany":"Interactive Intelligence, Inc.",
	    "packageCopyright":"Copyright © Interactive Intelligence, Inc. 2015"
	};

	fs.writeFile('bin/config-csharp.json', JSON.stringify(config), function(err) {
		if (err) {
			console.log('Failed to write config file!');
			console.log(err);
			deferred.reject(err);
			return;
		}

		console.log('Config file written');
	    deferred.resolve();
		return;
	});

	return deferred.promise;
}

function stringStartsWith (string, prefix) {
    return string.slice(0, prefix.length) == prefix;
}