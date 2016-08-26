---
title: ResponseManagementApi
---
## ININ.PureCloudApi.Api.ResponseManagementApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLibrary**](ResponseManagementApi.html#deletelibrary) | **DELETE** /api/v2/responsemanagement/libraries/{libraryId} | Delete an existing response library. |
| [**DeleteResponse**](ResponseManagementApi.html#deleteresponse) | **DELETE** /api/v2/responsemanagement/responses/{responseId} | Delete an existing response. |
| [**GetLibraries**](ResponseManagementApi.html#getlibraries) | **GET** /api/v2/responsemanagement/libraries | Gets a list of existing response libraries. |
| [**GetLibrary**](ResponseManagementApi.html#getlibrary) | **GET** /api/v2/responsemanagement/libraries/{libraryId} | Get details about an existing response library. |
| [**GetResponse**](ResponseManagementApi.html#getresponse) | **GET** /api/v2/responsemanagement/responses/{responseId} | Get details about an existing response. |
| [**GetResponses**](ResponseManagementApi.html#getresponses) | **GET** /api/v2/responsemanagement/responses | Gets a list of existing responses. |
| [**PostLibraries**](ResponseManagementApi.html#postlibraries) | **POST** /api/v2/responsemanagement/libraries | Create a response library. |
| [**PostResponses**](ResponseManagementApi.html#postresponses) | **POST** /api/v2/responsemanagement/responses | Create a response. |
| [**PostResponsesQuery**](ResponseManagementApi.html#postresponsesquery) | **POST** /api/v2/responsemanagement/responses/query | Query responses |
| [**PutLibrary**](ResponseManagementApi.html#putlibrary) | **PUT** /api/v2/responsemanagement/libraries/{libraryId} | Update an existing response library. |
| [**PutResponse**](ResponseManagementApi.html#putresponse) | **PUT** /api/v2/responsemanagement/responses/{responseId} | Update an existing response. |
{: class="table table-striped"}

<a name="deletelibrary"></a>

## void DeleteLibrary (string libraryId)

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
    public class DeleteLibraryExample
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
                apiInstance.DeleteLibrary(libraryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.DeleteLibrary: " + e.Message );
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

<a name="deleteresponse"></a>

## void DeleteResponse (string responseId)

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
    public class DeleteResponseExample
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
                apiInstance.DeleteResponse(responseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.DeleteResponse: " + e.Message );
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

<a name="getlibraries"></a>

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

[**LibraryEntityListing**](LibraryEntityListing.html)

<a name="getlibrary"></a>

## [**Library**](Library.html) GetLibrary (string libraryId)

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
    public class GetLibraryExample
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
                Library result = apiInstance.GetLibrary(libraryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetLibrary: " + e.Message );
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

[**Library**](Library.html)

<a name="getresponse"></a>

## [**Response**](Response.html) GetResponse (string responseId)

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
    public class GetResponseExample
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
                Response result = apiInstance.GetResponse(responseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.GetResponse: " + e.Message );
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

[**Response**](Response.html)

<a name="getresponses"></a>

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

[**ResponseEntityListing**](ResponseEntityListing.html)

<a name="postlibraries"></a>

## [**Library**](Library.html) PostLibraries (Library body)

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
            var body = new Library(); // Library | Library

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
| **body** | [**Library**](Library.html)| Library |  |
{: class="table table-striped"}

### Return type

[**Library**](Library.html)

<a name="postresponses"></a>

## [**Response**](Response.html) PostResponses (Response body)

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
            var body = new Response(); // Response | Response

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
| **body** | [**Response**](Response.html)| Response |  |
{: class="table table-striped"}

### Return type

[**Response**](Response.html)

<a name="postresponsesquery"></a>

## [**ResponseQueryResults**](ResponseQueryResults.html) PostResponsesQuery (ResponseQueryRequest body)

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
            var body = new ResponseQueryRequest(); // ResponseQueryRequest | Response

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
| **body** | [**ResponseQueryRequest**](ResponseQueryRequest.html)| Response |  |
{: class="table table-striped"}

### Return type

[**ResponseQueryResults**](ResponseQueryResults.html)

<a name="putlibrary"></a>

## [**Library**](Library.html) PutLibrary (string libraryId, Library body)

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
    public class PutLibraryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var libraryId = libraryId_example;  // string | Library ID
            var body = new Library(); // Library | Library

            try
            {
                // Update an existing response library.
                Library result = apiInstance.PutLibrary(libraryId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PutLibrary: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **libraryId** | **string**| Library ID |  |
| **body** | [**Library**](Library.html)| Library |  |
{: class="table table-striped"}

### Return type

[**Library**](Library.html)

<a name="putresponse"></a>

## [**Response**](Response.html) PutResponse (string responseId, Response body)

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
    public class PutResponseExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ResponseManagementApi();
            var responseId = responseId_example;  // string | Response ID
            var body = new Response(); // Response | Response

            try
            {
                // Update an existing response.
                Response result = apiInstance.PutResponse(responseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResponseManagementApi.PutResponse: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **responseId** | **string**| Response ID |  |
| **body** | [**Response**](Response.html)| Response |  |
{: class="table table-striped"}

### Return type

[**Response**](Response.html)

