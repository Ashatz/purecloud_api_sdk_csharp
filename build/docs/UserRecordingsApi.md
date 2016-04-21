# ININ.PureCloudApi.Api.UserRecordingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**UserrecordingsGet**](UserRecordingsApi.md#userrecordingsget) | **GET** /api/v1/userrecordings | Get a list of user recordings. |
| [**UserrecordingsRecordingidDelete**](UserRecordingsApi.md#userrecordingsrecordingiddelete) | **DELETE** /api/v1/userrecordings/{recordingId} | Delete a user recording. |
| [**UserrecordingsRecordingidGet**](UserRecordingsApi.md#userrecordingsrecordingidget) | **GET** /api/v1/userrecordings/{recordingId} | Get a user recording. |
| [**UserrecordingsRecordingidMediaGet**](UserRecordingsApi.md#userrecordingsrecordingidmediaget) | **GET** /api/v1/userrecordings/{recordingId}/media | Download a user recording. |
| [**UserrecordingsRecordingidPut**](UserRecordingsApi.md#userrecordingsrecordingidput) | **PUT** /api/v1/userrecordings/{recordingId} | Update a user recording. |
| [**UserrecordingsSummaryGet**](UserRecordingsApi.md#userrecordingssummaryget) | **GET** /api/v1/userrecordings/summary | Get user recording summary |
{: class="table table-striped"}

<a name="UserrecordingsGet"></a>
## [**UserRecordingEntityListing**](UserRecordingEntityListing.html) UserrecordingsGet (int? pageSize = null, int? pageNumber = null, string expand = null)

Get a list of user recordings.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UserrecordingsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | conversation (optional) 

            try
            {
                // Get a list of user recordings.
                UserRecordingEntityListing result = apiInstance.UserrecordingsGet(pageSize, pageNumber, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.UserrecordingsGet: " + e.Message );
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
| **expand** | **string**| conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**UserRecordingEntityListing**](UserRecordingEntityListing.md)

<a name="UserrecordingsRecordingidDelete"></a>
## void UserrecordingsRecordingidDelete (string recordingId)

Delete a user recording.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UserrecordingsRecordingidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID

            try
            {
                // Delete a user recording.
                apiInstance.UserrecordingsRecordingidDelete(recordingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.UserrecordingsRecordingidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="UserrecordingsRecordingidGet"></a>
## [**UserRecording**](UserRecording.html) UserrecordingsRecordingidGet (string recordingId, string expand = null)

Get a user recording.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UserrecordingsRecordingidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID
            var expand = expand_example;  // string | conversation (optional) 

            try
            {
                // Get a user recording.
                UserRecording result = apiInstance.UserrecordingsRecordingidGet(recordingId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.UserrecordingsRecordingidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
| **expand** | **string**| conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**UserRecording**](UserRecording.md)

<a name="UserrecordingsRecordingidMediaGet"></a>
## [**DownloadResponse**](DownloadResponse.html) UserrecordingsRecordingidMediaGet (string recordingId, string formatId = null)

Download a user recording.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UserrecordingsRecordingidMediaGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID
            var formatId = formatId_example;  // string | The desired format (WEBM, WAV, etc.) (optional)  (default to WEBM)

            try
            {
                // Download a user recording.
                DownloadResponse result = apiInstance.UserrecordingsRecordingidMediaGet(recordingId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.UserrecordingsRecordingidMediaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
| **formatId** | **string**| The desired format (WEBM, WAV, etc.) | [optional] [default to WEBM] |
{: class="table table-striped"}

### Return type

[**DownloadResponse**](DownloadResponse.md)

<a name="UserrecordingsRecordingidPut"></a>
## [**UserRecording**](UserRecording.html) UserrecordingsRecordingidPut (string recordingId, UserRecording body = null, string expand = null)

Update a user recording.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UserrecordingsRecordingidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID
            var body = new UserRecording(); // UserRecording | UserRecording (optional) 
            var expand = expand_example;  // string | conversation (optional) 

            try
            {
                // Update a user recording.
                UserRecording result = apiInstance.UserrecordingsRecordingidPut(recordingId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.UserrecordingsRecordingidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
| **body** | [**UserRecording**](UserRecording.md)| UserRecording | [optional]  |
| **expand** | **string**| conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**UserRecording**](UserRecording.md)

<a name="UserrecordingsSummaryGet"></a>
## [**FaxSummary**](FaxSummary.html) UserrecordingsSummaryGet ()

Get user recording summary



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UserrecordingsSummaryGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();

            try
            {
                // Get user recording summary
                FaxSummary result = apiInstance.UserrecordingsSummaryGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.UserrecordingsSummaryGet: " + e.Message );
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

