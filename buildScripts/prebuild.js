var wget = require('wget');
var mkdirp = require('mkdirp');
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