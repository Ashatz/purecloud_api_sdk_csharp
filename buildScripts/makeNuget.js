var fs = require('fs');

try {
	var nuspecFilePath = 'bin/PureCloudApiSdk.nuspec';
	var content = '<?xml version="1.0" encoding="utf-8"?>' + 
	'<package xmlns="http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd">' + 
	    '<metadata>' + 
	        '<id>PureCloudApiSdk</id>' + 
	        '<title>PureCloud API SDK</title>' + 
	        '<summary>A .NET SDK for the PureCloud API</summary>' + 
	        '<projectUrl>https://github.com/MyPureCloud/purecloud_api_sdk_csharp</projectUrl>' + 
	        '<copyright>Interactive Intelligence, Inc.</copyright>' + 
	        '<licenseUrl>https://github.com/MyPureCloud/purecloud_api_sdk_csharp/blob/master/LICENSE</licenseUrl>' + 
	        '<iconUrl>https://raw.githubusercontent.com/MyPureCloud/purecloud_api_sdk_csharp/master/ininlogo64.png</iconUrl>' + 
	        '<tags>interactive intelligence inin purecloud pure cloud public api sdk</tags>' + 
	        '<language>en-us</language>' + 
	        '<version>' + version + '</version>' + 
	        '<authors>Interactive Intelligence</authors>' + 
	        '<requireLicenseAcceptance>false</requireLicenseAcceptance>' + 
	        '<description>PureCloud API SDK for .NET</description>' + 
	        '<dependencies>' + 
	            '<dependency id="Newtonsoft.Json" />' + 
	            '<dependency id="RestSharp" />' + 
	        '</dependencies>' + 
	    '</metadata>' + 
	    '<files>' + 
	        '<file src="build\\bin\\ININ.PureCloudApi.dll" target="lib\\ININ.PureCloudApi.dll" />' + 
	        '<file src="build\\bin\\ININ.PureCloudApi.xml" target="lib\\ININ.PureCloudApi.xml" />' + 
	    '</files>' + 
	'</package>';

	fs.writeFileSync(nuspecFilePath, content);

	console.log('nuspec file written to ' + nuspecFilePath);
} catch(err) {
	console.log(err);
	process.exit(1);
}