# ININ.PureCloudApi.Api.FaxApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**FaxDocumentsDocumentidContentGet**](FaxApi.md#faxdocumentsdocumentidcontentget) | **GET** /api/v1/fax/documents/{documentId}/content | Download a fax document. |
| [**FaxDocumentsDocumentidDelete**](FaxApi.md#faxdocumentsdocumentiddelete) | **DELETE** /api/v1/fax/documents/{documentId} | Delete a fax document. |
| [**FaxDocumentsDocumentidGet**](FaxApi.md#faxdocumentsdocumentidget) | **GET** /api/v1/fax/documents/{documentId} | Get a document. |
| [**FaxDocumentsDocumentidPut**](FaxApi.md#faxdocumentsdocumentidput) | **PUT** /api/v1/fax/documents/{documentId} | Update a fax document. |
| [**FaxDocumentsGet**](FaxApi.md#faxdocumentsget) | **GET** /api/v1/fax/documents | Get a list of fax documents. |
| [**FaxSummaryGet**](FaxApi.md#faxsummaryget) | **GET** /api/v1/fax/summary | Get fax summary |
{: class="table table-striped"}

<a name="FaxDocumentsDocumentidContentGet"></a>
## [**DownloadResponse**](DownloadResponse.html) FaxDocumentsDocumentidContentGet (string documentId)

Download a fax document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class FaxDocumentsDocumentidContentGetExample
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
                DownloadResponse result = apiInstance.FaxDocumentsDocumentidContentGet(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxDocumentsDocumentidContentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
{: class="table table-striped"}

### Return type

[**DownloadResponse**](DownloadResponse.md)

<a name="FaxDocumentsDocumentidDelete"></a>
## void FaxDocumentsDocumentidDelete (string documentId)

Delete a fax document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class FaxDocumentsDocumentidDeleteExample
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
                apiInstance.FaxDocumentsDocumentidDelete(documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxDocumentsDocumentidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="FaxDocumentsDocumentidGet"></a>
## [**FaxDocument**](FaxDocument.html) FaxDocumentsDocumentidGet (string documentId)

Get a document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class FaxDocumentsDocumentidGetExample
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
                FaxDocument result = apiInstance.FaxDocumentsDocumentidGet(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxDocumentsDocumentidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
{: class="table table-striped"}

### Return type

[**FaxDocument**](FaxDocument.md)

<a name="FaxDocumentsDocumentidPut"></a>
## [**FaxDocument**](FaxDocument.html) FaxDocumentsDocumentidPut (string documentId, FaxDocument body = null)

Update a fax document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class FaxDocumentsDocumentidPutExample
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
                FaxDocument result = apiInstance.FaxDocumentsDocumentidPut(documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxDocumentsDocumentidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **body** | [**FaxDocument**](FaxDocument.md)| Document | [optional]  |
{: class="table table-striped"}

### Return type

[**FaxDocument**](FaxDocument.md)

<a name="FaxDocumentsGet"></a>
## [**FaxDocumentEntityListing**](FaxDocumentEntityListing.html) FaxDocumentsGet (int? pageSize = null, int? pageNumber = null)

Get a list of fax documents.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class FaxDocumentsGetExample
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
                FaxDocumentEntityListing result = apiInstance.FaxDocumentsGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxDocumentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**FaxDocumentEntityListing**](FaxDocumentEntityListing.md)

<a name="FaxSummaryGet"></a>
## [**FaxSummary**](FaxSummary.html) FaxSummaryGet ()

Get fax summary



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class FaxSummaryGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new FaxApi();

            try
            {
                // Get fax summary
                FaxSummary result = apiInstance.FaxSummaryGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxSummaryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**FaxSummary**](FaxSummary.md)

