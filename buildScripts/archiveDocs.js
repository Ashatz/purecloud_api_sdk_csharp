var archiver = require('archiver');
var Q = require('q');
var fs = require('fs');

zipDoxygenFiles('doxygen-csharp.zip')
	.then(function() {
		console.log('archiveDocs script complete');
		// Have to explicitly exit because promises keep the node process running
		process.exit(0);
	})
	.catch(function(error) {
		console.log('Error encountered in archiveDocs script!');
		console.log(error);
		process.exit(1);
	});

function zipDoxygenFiles(zipPath) {
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

	archive.on('entry', function(entryData) {
		console.log('Adding file: ' + entryData.name);
	});

	archive.pipe(output);

	// Add files to archive and write it
	archive
		.directory('doxygen','')
		.finalize();

	return deferred.promise;
}