---
title: PresenceApi
---
## ININ.PureCloudApi.Api.PresenceApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeletePresenceId**](PresenceApi.html#deletepresenceid) | **DELETE** /api/v2/presencedefinitions/{presenceId} | Delete a Presence Definition |
| [**GetPresenceId**](PresenceApi.html#getpresenceid) | **GET** /api/v2/presencedefinitions/{presenceId} | Get a Presence Definition |
| [**GetPresencedefinitions**](PresenceApi.html#getpresencedefinitions) | **GET** /api/v2/presencedefinitions | Get an Organization&#39;s list of Presence Definitions |
| [**GetSystempresences**](PresenceApi.html#getsystempresences) | **GET** /api/v2/systempresences | Get the list of SystemPresences |
| [**GetUserIdPresencesSourceId**](PresenceApi.html#getuseridpresencessourceid) | **GET** /api/v2/users/{userId}/presences/{sourceId} | Get a user&#39;s Presence |
| [**PatchUserIdPresencesSourceId**](PresenceApi.html#patchuseridpresencessourceid) | **PATCH** /api/v2/users/{userId}/presences/{sourceId} | Patch a user&#39;s Presence |
| [**PostPresencedefinitions**](PresenceApi.html#postpresencedefinitions) | **POST** /api/v2/presencedefinitions | Create a Presence Definition |
| [**PutPresenceId**](PresenceApi.html#putpresenceid) | **PUT** /api/v2/presencedefinitions/{presenceId} | Update a Presence Definition |
{: class="table table-striped"}

<a name="deletepresenceid"></a>

## [**OrganizationPresence**](OrganizationPresence.html) DeletePresenceId (string presenceId)

Delete a Presence Definition



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeletePresenceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var presenceId = presenceId_example;  // string | Organization Presence ID

            try
            {
                // Delete a Presence Definition
                OrganizationPresence result = apiInstance.DeletePresenceId(presenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.DeletePresenceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.html)

<a name="getpresenceid"></a>

## [**OrganizationPresence**](OrganizationPresence.html) GetPresenceId (string presenceId)

Get a Presence Definition



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPresenceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var presenceId = presenceId_example;  // string | Organization Presence ID

            try
            {
                // Get a Presence Definition
                OrganizationPresence result = apiInstance.GetPresenceId(presenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresenceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.html)

<a name="getpresencedefinitions"></a>

## [**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing.html) GetPresencedefinitions (int? pageNumber = null, int? pageSize = null, string deleted = null)

Get an Organization's list of Presence Definitions



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPresencedefinitionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var deleted = deleted_example;  // string | Deleted query can be true, false or all (optional)  (default to false)

            try
            {
                // Get an Organization's list of Presence Definitions
                OrganizationPresenceEntityListing result = apiInstance.GetPresencedefinitions(pageNumber, pageSize, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetPresencedefinitions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **deleted** | **string**| Deleted query can be true, false or all | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing.html)

<a name="getsystempresences"></a>

## [**List&lt;SystemPresence&gt;**](SystemPresence.html) GetSystempresences ()

Get the list of SystemPresences



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSystempresencesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();

            try
            {
                // Get the list of SystemPresences
                List&lt;SystemPresence&gt; result = apiInstance.GetSystempresences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetSystempresences: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<SystemPresence>**](SystemPresence.html)

<a name="getuseridpresencessourceid"></a>

## [**UserPresence**](UserPresence.html) GetUserIdPresencesSourceId (string userId, string sourceId)

Get a user's Presence



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdPresencesSourceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user Id
            var sourceId = sourceId_example;  // string | Source

            try
            {
                // Get a user's Presence
                UserPresence result = apiInstance.GetUserIdPresencesSourceId(userId, sourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetUserIdPresencesSourceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **sourceId** | **string**| Source |  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.html)

<a name="patchuseridpresencessourceid"></a>

## [**UserPresence**](UserPresence.html) PatchUserIdPresencesSourceId (string userId, string sourceId, UserPresence body)

Patch a user's Presence

The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. The 'id' is the only value required within the presenceDefinition. Option 3: Provide the message value. Option 1 can be combined with Option 2 and/or Option 3.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserIdPresencesSourceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user Id
            var sourceId = sourceId_example;  // string | Source
            var body = new UserPresence(); // UserPresence | User presence

            try
            {
                // Patch a user's Presence
                UserPresence result = apiInstance.PatchUserIdPresencesSourceId(userId, sourceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PatchUserIdPresencesSourceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **sourceId** | **string**| Source |  |
| **body** | [**UserPresence**](UserPresence.html)| User presence |  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.html)

<a name="postpresencedefinitions"></a>

## [**OrganizationPresence**](OrganizationPresence.html) PostPresencedefinitions (OrganizationPresence body)

Create a Presence Definition



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostPresencedefinitionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var body = new OrganizationPresence(); // OrganizationPresence | The Presence Definition to create

            try
            {
                // Create a Presence Definition
                OrganizationPresence result = apiInstance.PostPresencedefinitions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PostPresencedefinitions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OrganizationPresence**](OrganizationPresence.html)| The Presence Definition to create |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.html)

<a name="putpresenceid"></a>

## [**OrganizationPresence**](OrganizationPresence.html) PutPresenceId (string presenceId, OrganizationPresence body)

Update a Presence Definition



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutPresenceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var presenceId = presenceId_example;  // string | Organization Presence ID
            var body = new OrganizationPresence(); // OrganizationPresence | The OrganizationPresence to update

            try
            {
                // Update a Presence Definition
                OrganizationPresence result = apiInstance.PutPresenceId(presenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PutPresenceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
| **body** | [**OrganizationPresence**](OrganizationPresence.html)| The OrganizationPresence to update |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.html)

