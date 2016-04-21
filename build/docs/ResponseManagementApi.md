# ININ.PureCloudApi.Api.ResponseManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLibrariesLibraryId**](ResponseManagementApi.md#deletelibrarieslibraryid) | **DELETE** /api/v2/responsemanagement/libraries/{libraryId} | Delete an existing response library. |
| [**DeleteResponsesResponseId**](ResponseManagementApi.md#deleteresponsesresponseid) | **DELETE** /api/v2/responsemanagement/responses/{responseId} | Delete an existing response. |
| [**GetLibraries**](ResponseManagementApi.md#getlibraries) | **GET** /api/v2/responsemanagement/libraries | Gets a list of existing response libraries. |
| [**GetLibrariesLibraryId**](ResponseManagementApi.md#getlibrarieslibraryid) | **GET** /api/v2/responsemanagement/libraries/{libraryId} | Get details about an existing response library. |
| [**GetResponses**](ResponseManagementApi.md#getresponses) | **GET** /api/v2/responsemanagement/responses | Gets a list of existing responses. |
| [**GetResponsesResponseId**](ResponseManagementApi.md#getresponsesresponseid) | **GET** /api/v2/responsemanagement/responses/{responseId} | Get details about an existing response. |
| [**PostLibraries**](ResponseManagementApi.md#postlibraries) | **POST** /api/v2/responsemanagement/libraries | Create a response library. |
| [**PostResponses**](ResponseManagementApi.md#postresponses) | **POST** /api/v2/responsemanagement/responses | Create a response. |
| [**PostResponsesQuery**](ResponseManagementApi.md#postresponsesquery) | **POST** /api/v2/responsemanagement/responses/query | Query responses |
| [**PutLibrariesLibraryId**](ResponseManagementApi.md#putlibrarieslibraryid) | **PUT** /api/v2/responsemanagement/libraries/{libraryId} | Update an existing response library. |
| [**PutResponsesResponseId**](ResponseManagementApi.md#putresponsesresponseid) | **PUT** /api/v2/responsemanagement/responses/{responseId} | Update an existing response. |
{: class="table table-striped"}

<a name="DeleteLibrariesLibraryId"></a>
## void DeleteLibrariesLibraryId (string libraryId)

Delete an existing response library.

This will remove any responses associated with the library.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteLibrariesLibraryIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var libraryId = libraryId_example;  // string | Library ID

            try
            {
                // Delete an existing response library.
                apiInstance.DeleteLibrariesLibraryId(libraryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.DeleteLibrariesLibraryId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **libraryId** | **string**| Library ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteResponsesResponseId"></a>
## void DeleteResponsesResponseId (string responseId)

Delete an existing response.

This will remove the response from any libraries associated with it.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteResponsesResponseIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var responseId = responseId_example;  // string | Response ID

            try
            {
                // Delete an existing response.
                apiInstance.DeleteResponsesResponseId(responseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.DeleteResponsesResponseId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseId** | **string**| Response ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="GetLibraries"></a>
## [**LibraryEntityListing**](LibraryEntityListing.html) GetLibraries (int? pageNumber = null, int? pageSize = null)

Gets a list of existing response libraries.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLibrariesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            {
                // Gets a list of existing response libraries.
                LibraryEntityListing result = apiInstance.GetLibraries(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetLibraries: " + e.Message );
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

[**LibraryEntityListing**](LibraryEntityListing.md)

<a name="GetLibrariesLibraryId"></a>
## [**Library**](Library.html) GetLibrariesLibraryId (string libraryId)

Get details about an existing response library.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLibrariesLibraryIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var libraryId = libraryId_example;  // string | Library ID

            try
            {
                // Get details about an existing response library.
                Library result = apiInstance.GetLibrariesLibraryId(libraryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetLibrariesLibraryId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **libraryId** | **string**| Library ID |  |
{: class="table table-striped"}

### Return type

[**Library**](Library.md)

<a name="GetResponses"></a>
## [**ResponseEntityListing**](ResponseEntityListing.html) GetResponses (string libraryId, int? pageNumber = null, int? pageSize = null)

Gets a list of existing responses.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetResponsesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var libraryId = libraryId_example;  // string | Library ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            {
                // Gets a list of existing responses.
                ResponseEntityListing result = apiInstance.GetResponses(libraryId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetResponses: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **libraryId** | **string**| Library ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ResponseEntityListing**](ResponseEntityListing.md)

<a name="GetResponsesResponseId"></a>
## [**Response**](Response.html) GetResponsesResponseId (string responseId)

Get details about an existing response.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetResponsesResponseIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var responseId = responseId_example;  // string | Response ID

            try
            {
                // Get details about an existing response.
                Response result = apiInstance.GetResponsesResponseId(responseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetResponsesResponseId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseId** | **string**| Response ID |  |
{: class="table table-striped"}

### Return type

[**Response**](Response.md)

<a name="PostLibraries"></a>
## [**Library**](Library.html) PostLibraries (Library body = null)

Create a response library.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostLibrariesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var body = new Library(); // Library | Library (optional) 

            try
            {
                // Create a response library.
                Library result = apiInstance.PostLibraries(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PostLibraries: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Library**](Library.md)| Library | [optional]  |
{: class="table table-striped"}

### Return type

[**Library**](Library.md)

<a name="PostResponses"></a>
## [**Response**](Response.html) PostResponses (Response body = null)

Create a response.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostResponsesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var body = new Response(); // Response | Response (optional) 

            try
            {
                // Create a response.
                Response result = apiInstance.PostResponses(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PostResponses: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Response**](Response.md)| Response | [optional]  |
{: class="table table-striped"}

### Return type

[**Response**](Response.md)

<a name="PostResponsesQuery"></a>
## [**ResponseQueryResults**](ResponseQueryResults.html) PostResponsesQuery (ResponseQueryRequest body = null)

Query responses



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostResponsesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var body = new ResponseQueryRequest(); // ResponseQueryRequest | Response (optional) 

            try
            {
                // Query responses
                ResponseQueryResults result = apiInstance.PostResponsesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PostResponsesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResponseQueryRequest**](ResponseQueryRequest.md)| Response | [optional]  |
{: class="table table-striped"}

### Return type

[**ResponseQueryResults**](ResponseQueryResults.md)

<a name="PutLibrariesLibraryId"></a>
## [**Library**](Library.html) PutLibrariesLibraryId (string libraryId, Library body = null)

Update an existing response library.

Fields that can be updated: name. The most recent version is required for updates.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutLibrariesLibraryIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var libraryId = libraryId_example;  // string | Library ID
            var body = new Library(); // Library | Library (optional) 

            try
            {
                // Update an existing response library.
                Library result = apiInstance.PutLibrariesLibraryId(libraryId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PutLibrariesLibraryId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **libraryId** | **string**| Library ID |  |
| **body** | [**Library**](Library.md)| Library | [optional]  |
{: class="table table-striped"}

### Return type

[**Library**](Library.md)

<a name="PutResponsesResponseId"></a>
## [**Response**](Response.html) PutResponsesResponseId (string responseId, Response body = null)

Update an existing response.

Fields that can be updated: name, libraries, and texts. The most recent version is required for updates.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutResponsesResponseIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var responseId = responseId_example;  // string | Response ID
            var body = new Response(); // Response | Response (optional) 

            try
            {
                // Update an existing response.
                Response result = apiInstance.PutResponsesResponseId(responseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PutResponsesResponseId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseId** | **string**| Response ID |  |
| **body** | [**Response**](Response.md)| Response | [optional]  |
{: class="table table-striped"}

### Return type

[**Response**](Response.md)

