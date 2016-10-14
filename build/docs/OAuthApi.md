---
title: OAuthApi
---
## ININ.PureCloudApi.Api.OAuthApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteClient**](OAuthApi.html#deleteclient) | **DELETE** /api/v2/oauth/clients/{clientId} | Delete OAuth Client |
| [**GetClient**](OAuthApi.html#getclient) | **GET** /api/v2/oauth/clients/{clientId} | Get OAuth Client |
| [**GetClients**](OAuthApi.html#getclients) | **GET** /api/v2/oauth/clients | The list of OAuth clients |
| [**PostClientSecret**](OAuthApi.html#postclientsecret) | **POST** /api/v2/oauth/clients/{clientId}/secret | Regenerate Client Secret |
| [**PostClients**](OAuthApi.html#postclients) | **POST** /api/v2/oauth/clients | Create OAuth client |
| [**PutClient**](OAuthApi.html#putclient) | **PUT** /api/v2/oauth/clients/{clientId} | Update OAuth Client |
{: class="table table-striped"}

<a name="deleteclient"></a>

## void DeleteClient (string clientId)

Delete OAuth Client



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteClientExample
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
                apiInstance.DeleteClient(clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.DeleteClient: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getclient"></a>

## [**OAuthClient**](OAuthClient.html) GetClient (string clientId)

Get OAuth Client



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetClientExample
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
                OAuthClient result = apiInstance.GetClient(clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetClient: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.html)

<a name="getclients"></a>

## [**OAuthClientEntityListing**](OAuthClientEntityListing.html) GetClients ()

The list of OAuth clients



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetClientsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // The list of OAuth clients
                OAuthClientEntityListing result = apiInstance.GetClients();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetClients: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OAuthClientEntityListing**](OAuthClientEntityListing.html)

<a name="postclientsecret"></a>

## void PostClientSecret (string clientId)

Regenerate Client Secret

This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostClientSecretExample
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
                apiInstance.PostClientSecret(clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PostClientSecret: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postclients"></a>

## [**OAuthClient**](OAuthClient.html) PostClients (OAuthClient body)

Create OAuth client

The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud.  The preferred authorizedGrantTypes is 'CODE' which requires applications to send a client ID and client secret. This is typically a web server.  If the client is unable to secure the client secret then the 'TOKEN' grant type aka IMPLICIT should be used. This is would be for browser or mobile apps.  If a client is to be used outside of the context of a user then the 'CLIENT-CREDENTIALS' grant may be used. In this case the client must be granted roles  via the 'roleIds' field.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostClientsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new OAuthClient(); // OAuthClient | Client

            try
            {
                // Create OAuth client
                OAuthClient result = apiInstance.PostClients(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PostClients: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OAuthClient**](OAuthClient.html)| Client |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.html)

<a name="putclient"></a>

## [**OAuthClient**](OAuthClient.html) PutClient (string clientId, OAuthClient body)

Update OAuth Client



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutClientExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID
            var body = new OAuthClient(); // OAuthClient | Client

            try
            {
                // Update OAuth Client
                OAuthClient result = apiInstance.PutClient(clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PutClient: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
| **body** | [**OAuthClient**](OAuthClient.html)| Client |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.html)

