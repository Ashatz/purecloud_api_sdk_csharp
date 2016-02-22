# PureCloud API SDK - C&#35;
Documentation can be found at http://developer.mypurecloud.com/api/rest/client-libraries/csharp/latest/

## Install using nuget

```
install-package PureCloudApiSdk
```

Pacakage info can be found at http://www.nuget.org/packages/PureCloudApiSdk/

# Using the Library

## Referencing the Library

If you've used the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to install the package, there are no additional steps. 

If you're building from source, or otherwise not using nuget, reference your version of ININ.PureCloudApi.dll in your project and add references or packages for [RestSharp](http://www.nuget.org/packages/RestSharp/) and [JSON.NET](http://www.nuget.org/packages/Newtonsoft.Json/)

## Authenticating

### Authorization Code and Implicit Grant

If the application will be authenticating as a person, the [Authorization Code](http://developer.mypurecloud.com/api/rest/authorization/use-authorization-code.html) or [Implicit Grant](http://developer.mypurecloud.com/api/rest/authorization/use-implicit-grant.html) OAuth 2 flows may be used from a [WebBrowser](https://msdn.microsoft.com/en-us/library/2te2y1x6.aspx) control, or other embedable browser. The authorization code or access token, respectively, can be parsed from the redirect URL in the browser control.

### Client Credentials Grant

For headless applications, the [Client Credentials Grant](http://developer.mypurecloud.com/api/rest/authorization/use-client-credentials.html) can be used via manually making the REST request to /token. 

### Setting the Access Token

Once an access token has been obtained from one of the above methods, it must be set in the SDK's configuration.

``` csharp
ININ.PureCloudApi.Client.Configuration.Default.AccessToken = "BL4Cb3EQIQFlqIItaj-zf5eIhAiP96zkucEuOI1g54dKQImd24P99ojbFHtpgUTJdRIkuUYfXMy0afEnZcWnEQ";
```

## Making Requests

There are two steps to making requests:
1. Instantiate one of the API classes in the ININ.PureCloudApi.Api namespace
2. Call the methods on the API object

Example of getting the authenticated user's information
``` csharp
// Instantiate instance of the Users API
var usersApi = new UsersApi();

// Get the logged in user
var me = usersApi.GetMe();
Console.WriteLine($"Hello, {me.DisplayName}");
```

# SDK Information

## REST Requests

The SDK library uses [RestSharp](http://restsharp.org/) to make the REST reqests. The majority of this work is done in [ApiClient.cs](https://github.com/MyPureCloud/purecloud_api_sdk_csharp/blob/master/build/src/main/csharp/ININ/PureCloudApi/Client/ApiClient.cs)

## Building from Source

### The Quick Way

The quick way is great for compiling using a script or if you just prefer working from the command line.

1. Clone the repo
2. Run [compile.bat](https://github.com/MyPureCloud/purecloud_api_sdk_csharp/blob/master/build/compile.bat)

### The Other Way

If you're working inside Visual Studio, adding the files to your project allows you to edit and build inside an IDE.

1. Clone the repo
2. Add all of the .cs files in the build directory to a project in Visual Studio
3. Build the proejct in Visual Studio

## SDK Source Code Generation

The source code for the SDK is created using the [swagger-codegen](https://github.com/MyPureCloud/swagger-codegen) project.
