var api = require('github-api-promise');
var dateFormat = require('dateformat');

var dFormat = 'dddd, mmmm dS yyyy';
var tFormat = 'h:MM:ss TT';

api.config.owner = 'MyPureCloud';
api.config.repo = 'PureCloudApiLibrary_CSharp';

main();



function main() {
	var version = '0.0.0.0';

	// Parse args
	process.argv.forEach(function (val, index, array) {
		if (stringStartsWith(val, '/version=')) {
			version = val.substring(9);
		} else if (stringStartsWith(val, '/token=')) {
			api.config.token = val.substring(7);
		}
	});

	var createReleaseOptions = {
		"tag_name": version,
		"target_commitish": "master",
		"name": version,
		"body": "Jenkins build " + version,
		"draft": false,
		"prerelease": false
	};

	api.repos.releases.createRelease(createReleaseOptions)
		.then(function(res) {
			logRelease(res, 'Created ');

			api.repos.releases.uploadReleaseAsset(res.upload_url, 'ININ.PureCloudApi.dll', 'The DLL', './build/bin/ININ.PureCloudApi.dll')
				.then(function(res) {
					logAsset(res, 'Uploaded ');
				}, 
				function(err) {
					console.log('Request failed: ' + err);
				});
		}, 
		function(err) {
			console.log('Request failed: ' + err);
			throw err;
		});
}

// Log a single release
function logRelease(release, prefix) {
	if (prefix) {
		if (prefix.substring(prefix.length - 1) != ' ') {
			prefix += ' ';
		}
	} else {
		prefix = '';
	}
	console.log(prefix + 'release #' + release.id + ', "' + release.name + '", tag: ' + release.tag_name + ', published on ' + dateFormat(release.published_at, dFormat) + ' at ' + dateFormat(release.published_at, tFormat));
}

// Log a single asset
function logAsset(asset) {
	console.log('Asset "' + asset.name + '" (' + asset.label + ') #' + asset.id + ' uploaded by ' + asset.uploader.login + ' on ' + dateFormat(asset.updated_at, dFormat) + ' at ' + dateFormat(asset.updated_at, tFormat));
}