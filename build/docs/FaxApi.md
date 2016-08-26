---
title: FaxApi
---
## ININ.PureCloudApi.Api.FaxApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteDocument**](FaxApi.html#deletedocument) | **DELETE** /api/v2/fax/documents/{documentId} | Delete a fax document. |
| [**GetDocument**](FaxApi.html#getdocument) | **GET** /api/v2/fax/documents/{documentId} | Get a document. |
| [**GetDocumentContent**](FaxApi.html#getdocumentcontent) | **GET** /api/v2/fax/documents/{documentId}/content | Download a fax document. |
| [**GetDocuments**](FaxApi.html#getdocuments) | **GET** /api/v2/fax/documents | Get a list of fax documents. |
| [**GetSummary**](FaxApi.html#getsummary) | **GET** /api/v2/fax/summary | Get fax summary |
| [**PutDocument**](FaxApi.html#putdocument) | **PUT** /api/v2/fax/documents/{documentId} | Update a fax document. |
{: class="table table-striped"}

<a name="deletedocument"></a>

## void DeleteDocument (string documentId)

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
    public class DeleteDocumentExample
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
                apiInstance.DeleteDocument(documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.DeleteDocument: " + e.Message );
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

<a name="getdocument"></a>

## [**FaxDocument**](FaxDocument.html) GetDocument (string documentId)

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
    public class GetDocumentExample
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
                FaxDocument result = apiInstance.GetDocument(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetDocument: " + e.Message );
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

[**FaxDocument**](FaxDocument.html)

<a name="getdocumentcontent"></a>

## [**DownloadResponse**](DownloadResponse.html) GetDocumentContent (string documentId)

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
    public class GetDocumentContentExample
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
                DownloadResponse result = apiInstance.GetDocumentContent(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.GetDocumentContent: " + e.Message );
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

[**DownloadResponse**](DownloadResponse.html)

<a name="getdocuments"></a>

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

[**FaxDocumentEntityListing**](FaxDocumentEntityListing.html)

<a name="getsummary"></a>

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

[**FaxSummary**](FaxSummary.html)

<a name="putdocument"></a>

## [**FaxDocument**](FaxDocument.html) PutDocument (string documentId, FaxDocument body)

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
    public class PutDocumentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new FaxApi();
            var documentId = documentId_example;  // string | Document ID
            var body = new FaxDocument(); // FaxDocument | Document

            try
            {
                // Update a fax document.
                FaxDocument result = apiInstance.PutDocument(documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.PutDocument: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **body** | [**FaxDocument**](FaxDocument.html)| Document |  |
{: class="table table-striped"}

### Return type

[**FaxDocument**](FaxDocument.html)

