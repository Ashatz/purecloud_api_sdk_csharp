# ININ.PureCloudApi.Api.PresenceApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeletePresenceId**](PresenceApi.md#deletepresenceid) | **DELETE** /api/v2/presencedefinitions/{presenceId} | Delete an OrganizationPresence |
| [**GetPresenceId**](PresenceApi.md#getpresenceid) | **GET** /api/v2/presencedefinitions/{presenceId} | Get an OrganizationPresence |
| [**GetPresencedefinitions**](PresenceApi.md#getpresencedefinitions) | **GET** /api/v2/presencedefinitions | Get an Organization&#39;s list of Presences |
| [**GetUserIdPresencesSource**](PresenceApi.md#getuseridpresencessource) | **GET** /api/v2/users/{userId}/presences/{source} | Get a user&#39;s Presence |
| [**PatchUserIdPresencesSource**](PresenceApi.md#patchuseridpresencessource) | **PATCH** /api/v2/users/{userId}/presences/{source} | Patch a user&#39;s Presence |
| [**PostPresencedefinitions**](PresenceApi.md#postpresencedefinitions) | **POST** /api/v2/presencedefinitions | Create an OrganizationPresence |
| [**PutPresenceId**](PresenceApi.md#putpresenceid) | **PUT** /api/v2/presencedefinitions/{presenceId} | Update an OrganizationPresence |
{: class="table table-striped"}

<a name="DeletePresenceId"></a>
## [**OrganizationPresence**](OrganizationPresence.html) DeletePresenceId (string presenceId)

Delete an OrganizationPresence



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
                // Delete an OrganizationPresence
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

[**OrganizationPresence**](OrganizationPresence.md)

<a name="GetPresenceId"></a>
## [**OrganizationPresence**](OrganizationPresence.html) GetPresenceId (string presenceId)

Get an OrganizationPresence



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
                // Get an OrganizationPresence
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

[**OrganizationPresence**](OrganizationPresence.md)

<a name="GetPresencedefinitions"></a>
## [**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing.html) GetPresencedefinitions (int? pageNumber = null, int? pageSize = null)

Get an Organization's list of Presences



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

            try
            {
                // Get an Organization's list of Presences
                OrganizationPresenceEntityListing result = apiInstance.GetPresencedefinitions(pageNumber, pageSize);
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
{: class="table table-striped"}

### Return type

[**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing.md)

<a name="GetUserIdPresencesSource"></a>
## [**UserPresence**](UserPresence.html) GetUserIdPresencesSource (string userId, string source)

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
    public class GetUserIdPresencesSourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user Id
            var source = source_example;  // string | source

            try
            {
                // Get a user's Presence
                UserPresence result = apiInstance.GetUserIdPresencesSource(userId, source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.GetUserIdPresencesSource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **source** | **string**| source |  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.md)

<a name="PatchUserIdPresencesSource"></a>
## [**UserPresence**](UserPresence.html) PatchUserIdPresencesSource (string userId, string source, UserPresence body = null)

Patch a user's Presence

The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserIdPresencesSourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | user Id
            var source = source_example;  // string | source
            var body = new UserPresence(); // UserPresence |  (optional) 

            try
            {
                // Patch a user's Presence
                UserPresence result = apiInstance.PatchUserIdPresencesSource(userId, source, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PatchUserIdPresencesSource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **source** | **string**| source |  |
| **body** | [**UserPresence**](UserPresence.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.md)

<a name="PostPresencedefinitions"></a>
## [**OrganizationPresence**](OrganizationPresence.html) PostPresencedefinitions (OrganizationPresence body)

Create an OrganizationPresence



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
            var body = new OrganizationPresence(); // OrganizationPresence | The OrganizationPresence to create

            try
            {
                // Create an OrganizationPresence
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
| **body** | [**OrganizationPresence**](OrganizationPresence.md)| The OrganizationPresence to create |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.md)

<a name="PutPresenceId"></a>
## [**OrganizationPresence**](OrganizationPresence.html) PutPresenceId (string presenceId, OrganizationPresence body)

Update an OrganizationPresence



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
                // Update an OrganizationPresence
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
| **body** | [**OrganizationPresence**](OrganizationPresence.md)| The OrganizationPresence to update |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.md)

