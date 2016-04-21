var api = require('github-api-promise');
var dateFormat = require('dateformat');
var fs = require('fs');
var archiver = require('archiver');
var Q = require('q');
var release = require('purecloud-api-sdk-common').createRelease();

var dFormat = 'dddd, mmmm dS yyyy';
var tFormat = 'h:MM:ss TT';

var repo = 'purecloud_api_sdk_csharp';

main();


function main() {
	var version = '0.0.0.0';
	var token = null;
	var releaseNotes = '';

	function stringStartsWith (string, prefix) {
	    return string.slice(0, prefix.length) == prefix;
	}

	// Parse args
	process.argv.forEach(function (val, index, array) {
		if (stringStartsWith(val, '/version=')) {
			version = val.substring(9);
		} else if (stringStartsWith(val, '/token=')) {
			token = val.substring(7);
		}
	});

	try {
		releaseNotes = fs.readFileSync("RELEASENOTES", "UTF-8");
	} catch(err) {
		console.log(err);
	}

	// Create zip for release
	var zipFileName = version + '.zip'
	var zipFilePath = './bin/' + zipFileName;
	zipReleaseFiles(zipFilePath)
		.then(function() {

			console.log('zip file created, uploading....');

			release.release(token, repo, version, releaseNotes, zipFileName, zipFilePath);

		});
}

function zipReleaseFiles(zipPath) {
	var deferred = Q.defer();

	var output = fs.createWriteStream(zipPath);
	var archive = archiver('zip');

	// Callback for file write ended
	output.on('close', function() {
		console.log(zipPath + ' written with ' + archive.pointer() + ' total bytes');
		deferred.resolve();
	});

	// Callback for file write error
	archive.on('error', function(err) {
		deferred.reject(err);
	});

	archive.pipe(output);

	// Add files to archive and write it
	archive
		.append(fs.createReadStream('./build/bin/ININ.PureCloudApi.dll'), { name: 'ININ.PureCloudApi.dll' })
		.append(fs.createReadStream('./build/bin/ININ.PureCloudApi.xml'), { name: 'ININ.PureCloudApi.xml' })
		.append(fs.createReadStream('./build/bin/Newtonsoft.Json.dll'), { name: 'Newtonsoft.Json.dll' })
		.append(fs.createReadStream('./build/bin/RestSharp.dll'), { name: 'RestSharp.dll' })
		.finalize();

	return deferred.promise;
}
