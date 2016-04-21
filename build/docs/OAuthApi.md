# ININ.PureCloudApi.Api.OAuthApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**IdentityprovidersGet**](OAuthApi.md#identityprovidersget) | **GET** /api/v1/identityproviders | The list of identity providers |
| [**IdentityprovidersOneloginDelete**](OAuthApi.md#identityprovidersonelogindelete) | **DELETE** /api/v1/identityproviders/onelogin | Delete OneLogin Identity Provider |
| [**IdentityprovidersOneloginGet**](OAuthApi.md#identityprovidersoneloginget) | **GET** /api/v1/identityproviders/onelogin | Get OneLogin Identity Provider |
| [**IdentityprovidersOneloginPut**](OAuthApi.md#identityprovidersoneloginput) | **PUT** /api/v1/identityproviders/onelogin | Update/Create OneLogin Identity Provider |
| [**IdentityprovidersProvideridDelete**](OAuthApi.md#identityprovidersprovideriddelete) | **DELETE** /api/v1/identityproviders/{providerId} | Delete an identity provider |
| [**IdentityprovidersProvideridGet**](OAuthApi.md#identityprovidersprovideridget) | **GET** /api/v1/identityproviders/{providerId} | Get an identity provider |
| [**IdentityprovidersProvideridPut**](OAuthApi.md#identityprovidersprovideridput) | **PUT** /api/v1/identityproviders/{providerId} | Update an identity provider |
| [**IdentityprovidersPurecloudDelete**](OAuthApi.md#identityproviderspureclouddelete) | **DELETE** /api/v1/identityproviders/purecloud | Delete PureCloud Identity Provider |
| [**IdentityprovidersPurecloudGet**](OAuthApi.md#identityproviderspurecloudget) | **GET** /api/v1/identityproviders/purecloud | Get PureCloud Identity Provider |
| [**IdentityprovidersPurecloudPut**](OAuthApi.md#identityproviderspurecloudput) | **PUT** /api/v1/identityproviders/purecloud | Update/Create PureCloud Identity Provider |
| [**OauthClientsClientidDelete**](OAuthApi.md#oauthclientsclientiddelete) | **DELETE** /api/v1/oauth/clients/{clientId} | Delete OAuth Client |
| [**OauthClientsClientidGet**](OAuthApi.md#oauthclientsclientidget) | **GET** /api/v1/oauth/clients/{clientId} | Get OAuth Client |
| [**OauthClientsClientidPut**](OAuthApi.md#oauthclientsclientidput) | **PUT** /api/v1/oauth/clients/{clientId} | Update OAuth Client |
| [**OauthClientsClientidSecretPost**](OAuthApi.md#oauthclientsclientidsecretpost) | **POST** /api/v1/oauth/clients/{clientId}/secret | Regenerate Client Secret |
| [**OauthClientsGet**](OAuthApi.md#oauthclientsget) | **GET** /api/v1/oauth/clients | The list of OAuth clients |
| [**OauthClientsPost**](OAuthApi.md#oauthclientspost) | **POST** /api/v1/oauth/clients | Create OAuth client |
{: class="table table-striped"}

<a name="IdentityprovidersGet"></a>
## [**OAuthProviderEntityListing**](OAuthProviderEntityListing.html) IdentityprovidersGet ()

The list of identity providers



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // The list of identity providers
                OAuthProviderEntityListing result = apiInstance.IdentityprovidersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OAuthProviderEntityListing**](OAuthProviderEntityListing.md)

<a name="IdentityprovidersOneloginDelete"></a>
## void IdentityprovidersOneloginDelete ()

Delete OneLogin Identity Provider



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersOneloginDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Delete OneLogin Identity Provider
                apiInstance.IdentityprovidersOneloginDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersOneloginDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="IdentityprovidersOneloginGet"></a>
## [**OneLogin**](OneLogin.html) IdentityprovidersOneloginGet ()

Get OneLogin Identity Provider



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersOneloginGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Get OneLogin Identity Provider
                OneLogin result = apiInstance.IdentityprovidersOneloginGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersOneloginGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OneLogin**](OneLogin.md)

<a name="IdentityprovidersOneloginPut"></a>
## void IdentityprovidersOneloginPut (OneLogin body = null)

Update/Create OneLogin Identity Provider



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersOneloginPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new OneLogin(); // OneLogin | Provider (optional) 

            try
            {
                // Update/Create OneLogin Identity Provider
                apiInstance.IdentityprovidersOneloginPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersOneloginPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OneLogin**](OneLogin.md)| Provider | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="IdentityprovidersProvideridDelete"></a>
## void IdentityprovidersProvideridDelete ()

Delete an identity provider



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersProvideridDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Delete an identity provider
                apiInstance.IdentityprovidersProvideridDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersProvideridDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="IdentityprovidersProvideridGet"></a>
## [**OAuthProvider**](OAuthProvider.html) IdentityprovidersProvideridGet ()

Get an identity provider



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersProvideridGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Get an identity provider
                OAuthProvider result = apiInstance.IdentityprovidersProvideridGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersProvideridGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.md)

<a name="IdentityprovidersProvideridPut"></a>
## void IdentityprovidersProvideridPut (OAuthProvider body = null)

Update an identity provider



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersProvideridPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new OAuthProvider(); // OAuthProvider | Provider (optional) 

            try
            {
                // Update an identity provider
                apiInstance.IdentityprovidersProvideridPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersProvideridPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OAuthProvider**](OAuthProvider.md)| Provider | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="IdentityprovidersPurecloudDelete"></a>
## void IdentityprovidersPurecloudDelete ()

Delete PureCloud Identity Provider



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersPurecloudDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Delete PureCloud Identity Provider
                apiInstance.IdentityprovidersPurecloudDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersPurecloudDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="IdentityprovidersPurecloudGet"></a>
## [**PureCloud**](PureCloud.html) IdentityprovidersPurecloudGet ()

Get PureCloud Identity Provider



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersPurecloudGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Get PureCloud Identity Provider
                PureCloud result = apiInstance.IdentityprovidersPurecloudGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersPurecloudGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**PureCloud**](PureCloud.md)

<a name="IdentityprovidersPurecloudPut"></a>
## void IdentityprovidersPurecloudPut (PureCloud body = null)

Update/Create PureCloud Identity Provider



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class IdentityprovidersPurecloudPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new PureCloud(); // PureCloud | Provider (optional) 

            try
            {
                // Update/Create PureCloud Identity Provider
                apiInstance.IdentityprovidersPurecloudPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.IdentityprovidersPurecloudPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PureCloud**](PureCloud.md)| Provider | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="OauthClientsClientidDelete"></a>
## void OauthClientsClientidDelete (string clientId)

Delete OAuth Client



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OauthClientsClientidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID

            try
            {
                // Delete OAuth Client
                apiInstance.OauthClientsClientidDelete(clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthClientsClientidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="OauthClientsClientidGet"></a>
## [**OAuthClient**](OAuthClient.html) OauthClientsClientidGet (string clientId)

Get OAuth Client



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OauthClientsClientidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID

            try
            {
                // Get OAuth Client
                OAuthClient result = apiInstance.OauthClientsClientidGet(clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthClientsClientidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.md)

<a name="OauthClientsClientidPut"></a>
## [**OAuthClient**](OAuthClient.html) OauthClientsClientidPut (string clientId, OAuthClient body = null)

Update OAuth Client



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OauthClientsClientidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID
            var body = new OAuthClient(); // OAuthClient | Client (optional) 

            try
            {
                // Update OAuth Client
                OAuthClient result = apiInstance.OauthClientsClientidPut(clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthClientsClientidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
| **body** | [**OAuthClient**](OAuthClient.md)| Client | [optional]  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.md)

<a name="OauthClientsClientidSecretPost"></a>
## void OauthClientsClientidSecretPost (string clientId)

Regenerate Client Secret

This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OauthClientsClientidSecretPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID

            try
            {
                // Regenerate Client Secret
                apiInstance.OauthClientsClientidSecretPost(clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthClientsClientidSecretPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="OauthClientsGet"></a>
## [**OAuthClientEntityListing**](OAuthClientEntityListing.html) OauthClientsGet ()

The list of OAuth clients



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OauthClientsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // The list of OAuth clients
                OAuthClientEntityListing result = apiInstance.OauthClientsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthClientsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OAuthClientEntityListing**](OAuthClientEntityListing.md)

<a name="OauthClientsPost"></a>
## [**OAuthClient**](OAuthClient.html) OauthClientsPost (OAuthClient body = null)

Create OAuth client

The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is 'CODE' which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the 'TOKEN' grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the 'CLIENT-CREDENTIALS' grant may be used. In this case the client must be granted roles \nvia the 'roleIds' field.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OauthClientsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new OAuthClient(); // OAuthClient | Client (optional) 

            try
            {
                // Create OAuth client
                OAuthClient result = apiInstance.OauthClientsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthClientsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OAuthClient**](OAuthClient.md)| Client | [optional]  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.md)

