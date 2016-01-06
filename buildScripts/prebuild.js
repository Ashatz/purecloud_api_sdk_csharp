var wget = require('wget');
var mkdirp = require('mkdirp');
var fs = require('fs');
var src = 'http://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.1.4/swagger-codegen-cli-2.1.4.jar';
var output = 'bin/swagger-codegen-cli.jar';
var progressTracker = 0;

mkdirp('bin', function(err) { 
	if (err) {
		console.log('Fatal error making directory: ');
		console.log(err);
		return;
	}

	console.log('Downloading ' + src);
	var download = wget.download(src, output);
	download.on('error', function(err) {
		console.log('Fatal error downloading file: ');
	    console.log(err);
	});
	download.on('end', function(output) {
	    console.log('File downloaded to : ' + output);
	    writeConfig();
	});
	download.on('progress', function(progress) {
		// Report progress at 5% intervals
		var p = Number((progress * 100).toFixed(0));
		if (p > progressTracker && p % 5 == 0) {
			progressTracker = p;
			console.log(progressTracker + '%');
		}
	});
});

function writeConfig() {
	var version = "0.0.0.0";
	process.argv.forEach(function (val, index, array) {
		console.log(index + ': ' + val);
		if (stringStartsWith(val, '/version=')) {
			version = val.substring(9);
			console.log('version = ' + version);
		}
	});

	var config = {
		"packageName":"ININ.PureCloudApi",
		"packageVersion":version,
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
		}
	});
}

function stringStartsWith (string, prefix) {
    return string.slice(0, prefix.length) == prefix;
}