# ININ.PureCloudApi.Api.FaxApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteDocumentsDocumentId**](FaxApi.md#deletedocumentsdocumentid) | **DELETE** /api/v2/fax/documents/{documentId} | Delete a fax document. |
| [**GetDocuments**](FaxApi.md#getdocuments) | **GET** /api/v2/fax/documents | Get a list of fax documents. |
| [**GetDocumentsDocumentId**](FaxApi.md#getdocumentsdocumentid) | **GET** /api/v2/fax/documents/{documentId} | Get a document. |
| [**GetDocumentsDocumentIdContent**](FaxApi.md#getdocumentsdocumentidcontent) | **GET** /api/v2/fax/documents/{documentId}/content | Download a fax document. |
| [**GetSummary**](FaxApi.md#getsummary) | **GET** /api/v2/fax/summary | Get fax summary |
| [**PutDocumentsDocumentId**](FaxApi.md#putdocumentsdocumentid) | **PUT** /api/v2/fax/documents/{documentId} | Update a fax document. |
{: class="table table-striped"}

<a name="DeleteDocumentsDocumentId"></a>
## void DeleteDocumentsDocumentId (string documentId)

Delete a fax document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteDocumentsDocumentIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new FaxApi();
            var documentId = documentId_example;  // string | Document ID

            try
            {
                // Delete a fax document.
                apiInstance.DeleteDocumentsDocumentId(documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.DeleteDocumentsDocumentId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="GetDocuments"></a>
## [**FaxDocumentEntityListing**](FaxDocumentEntityListing.html) GetDocuments (int? pageSize = null, int? pageNumber = null)

Get a list of fax documents.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new FaxApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get a list of fax documents.
                FaxDocumentEntityListing result = apiInstance.GetDocuments(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetDocuments: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**FaxDocumentEntityListing**](FaxDocumentEntityListing.md)

<a name="GetDocumentsDocumentId"></a>
## [**FaxDocument**](FaxDocument.html) GetDocumentsDocumentId (string documentId)

Get a document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDocumentsDocumentIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new FaxApi();
            var documentId = documentId_example;  // string | Document ID

            try
            {
                // Get a document.
                FaxDocument result = apiInstance.GetDocumentsDocumentId(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetDocumentsDocumentId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
{: class="table table-striped"}

### Return type

[**FaxDocument**](FaxDocument.md)

<a name="GetDocumentsDocumentIdContent"></a>
## [**DownloadResponse**](DownloadResponse.html) GetDocumentsDocumentIdContent (string documentId)

Download a fax document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDocumentsDocumentIdContentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new FaxApi();
            var documentId = documentId_example;  // string | Document ID

            try
            {
                // Download a fax document.
                DownloadResponse result = apiInstance.GetDocumentsDocumentIdContent(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetDocumentsDocumentIdContent: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
{: class="table table-striped"}

### Return type

[**DownloadResponse**](DownloadResponse.md)

<a name="GetSummary"></a>
## [**FaxSummary**](FaxSummary.html) GetSummary ()

Get fax summary



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSummaryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new FaxApi();

            try
            {
                // Get fax summary
                FaxSummary result = apiInstance.GetSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetSummary: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**FaxSummary**](FaxSummary.md)

<a name="PutDocumentsDocumentId"></a>
## [**FaxDocument**](FaxDocument.html) PutDocumentsDocumentId (string documentId, FaxDocument body = null)

Update a fax document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutDocumentsDocumentIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new FaxApi();
            var documentId = documentId_example;  // string | Document ID
            var body = new FaxDocument(); // FaxDocument | Document (optional) 

            try
            {
                // Update a fax document.
                FaxDocument result = apiInstance.PutDocumentsDocumentId(documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.PutDocumentsDocumentId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **body** | [**FaxDocument**](FaxDocument.md)| Document | [optional]  |
{: class="table table-striped"}

### Return type

[**FaxDocument**](FaxDocument.md)

