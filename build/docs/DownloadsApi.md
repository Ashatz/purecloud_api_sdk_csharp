# ININ.PureCloudApi.Api.DownloadsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DownloadsCallbackGet**](DownloadsApi.md#downloadscallbackget) | **GET** /api/v1/downloads/callback | OAuth Callback used during code authorization grant flow. |
| [**DownloadsDownloadidGet**](DownloadsApi.md#downloadsdownloadidget) | **GET** /api/v1/downloads/{downloadId} | Issues a redirect to a signed secure download URL for specified download |
{: class="table table-striped"}

<a name="DownloadsCallbackGet"></a>
## void DownloadsCallbackGet (string code = null, string state = null)

OAuth Callback used during code authorization grant flow.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DownloadsCallbackGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new DownloadsApi();
            var code = code_example;  // string |  (optional) 
            var state = state_example;  // string |  (optional) 

            try
            {
                // OAuth Callback used during code authorization grant flow.
                apiInstance.DownloadsCallbackGet(code, state);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.DownloadsCallbackGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **code** | **string**|  | [optional]  |
| **state** | **string**|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DownloadsDownloadidGet"></a>
## [**UrlResponse**](UrlResponse.html) DownloadsDownloadidGet (string downloadId, string contentDisposition = null)

Issues a redirect to a signed secure download URL for specified download

this method will issue a redirect to the url to the content

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DownloadsDownloadidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new DownloadsApi();
            var downloadId = downloadId_example;  // string | Download ID
            var contentDisposition = contentDisposition_example;  // string |  (optional)  (default to attachment)

            try
            {
                // Issues a redirect to a signed secure download URL for specified download
                UrlResponse result = apiInstance.DownloadsDownloadidGet(downloadId, contentDisposition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.DownloadsDownloadidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **downloadId** | **string**| Download ID |  |
| **contentDisposition** | **string**|  | [optional] [default to attachment] |
{: class="table table-striped"}

### Return type

[**UrlResponse**](UrlResponse.md)

