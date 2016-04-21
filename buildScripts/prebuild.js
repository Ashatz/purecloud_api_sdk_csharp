var mkdirp = require('mkdirp');
var fs = require('fs');
var Q = require('q');
var pclib = require('purecloud-api-sdk-common');

var pclibSwaggerVersion = pclib.swaggerVersioning();
var progressTracker = 0;
var swaggerFilePath = 'swagger.json';
var versionFilePath = 'version.json';

updateVersion()
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

function updateVersion() {
	var deferred = Q.defer();

	pclib.updateSwaggerAndVersion(swaggerFilePath, versionFilePath, "mypurecloud.com", function(hasChanges){
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
	mkdirp.sync('bin');
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
