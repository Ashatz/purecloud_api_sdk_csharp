var mkdirp = require('mkdirp');
var fs = require('fs');
var Q = require('q');
var pclib = require('purecloud-api-sdk-common');

var pclibSwaggerVersion = pclib.swaggerVersioning();
var progressTracker = 0;
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
		console.log(error.stack);
		process.exit(1);
	});


function downloadFile(url, output, append) {
	var deferred = Q.defer();

	console.log('-------------------------------');
	console.log('----- Downloading ' + url);

	// Delete old file
	if (append != true) {
		if (fileExists(output)) {
			console.log('Deleting ' + output);
			fs.unlinkSync(output);
		} else {
			console.log('File does not exist: ' + output);
		}
	}

	// Set progress to 0
	progressTracker = 0;

	// Make sure output directory exists
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

	// Choose HTTP or HTTPS
	var options = require('url').parse(url);
	var httx = require('http');
	if (options.protocol == 'https:') {
		httx = require('https');
	}

	// Create write stream for output file
	var file = fs.createWriteStream(output);

	// Begin request
	var request = httx.request(url, function(res) {
		// Pipe output to file stream
		res.pipe(file);

		// Check headers
		var contentLength = res.headers['content-length'];
		console.log('inin-correlation-id: ' + res.headers['inin-correlation-id']);
		console.log('content-length: ' + contentLength);
		var dataLength = 0;

		res.on('end', function() {
		    console.log('File downloaded to : ' + output);
		    console.log('Data length: ' + dataLength);
		    // WARNING: DO NOT RESOLVE THE PROMISE HERE!!!!
		    // The file may not be finished writing as soon as the data is received. There can be a 
		    // race condition where the function called after resolving here can try to open the file 
		    // before the filestream has finished writing, which will truncate the file at that point 
		    // and leave you with a partial file.
			return;
		});

		res.on('data', function(chunk) {
			dataLength += chunk.length;

			// Don't report progress if there was no content-length header
			if (contentLength == undefined || contentLength == 0) return;

			// Report progress at 5% intervals
			var p = Number(((dataLength/contentLength) * 100).toFixed(0));
			var progressInterval = 5;
			if (p > progressTracker && p % progressInterval == 0) {
				progressTracker = p;
				console.log(progressTracker + '%');
			}
		});
	});

	file.once('finish', function() {
		console.log('----- Download complete -------');
		console.log('-------------------------------');
		// Resolve the promise. This must be done here when the file has completed writing its output 
		// so that the file will be ready for use in the next function.
		deferred.resolve();
	});

	// Finish building the request
	request.end();

	return deferred.promise;
}

function updateVersion() {
	var deferred = Q.defer();

	pclib.updateSwaggerAndVersion("swagger.json", "version.json", "mypurecloud.com", function(hasChanges){
        var version = pclibSwaggerVersion.getVersionString("version.json");

        if(hasChanges){
            console.log("has changes, new version: " + version)
            fs.writeFileSync("newVersion.md", version);

			versionJson = JSON.parse(fs.readFileSync("version.json", 'UTF-8'))

			var notes = pclibSwaggerVersion.getChangeReadmeText(versionJson.changelog[version]);
			fs.writeFileSync("RELEASENOTES", notes);
        }else{
            console.log("no changes, still version " + version)
        }

		 deferred.resolve();
    });

	return deferred.promise;
}

function writeConfig() {
	var deferred = Q.defer();

	var v = pclibSwaggerVersion.getVersionString("version.json") + '.' + process.env['BUILD_NUMBER'];
	console.log('Package version: ' + v);
	fs.writeFileSync('bin/VERSION', v, 'UTF-8');
	var config = {
		"packageName":"ININ.PureCloudApi",
		"packageVersion":v,
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

function stringStartsWith(string, prefix) {
    return string.slice(0, prefix.length) == prefix;
}

function fileExists(filepath) {
	if (!filepath) return false

	try {
		return fs.statSync(filepath).isFile()
	} catch (e) {
		return false
	}
}
