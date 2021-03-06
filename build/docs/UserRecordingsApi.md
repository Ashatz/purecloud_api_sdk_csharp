---
title: UserRecordingsApi
---
## ININ.PureCloudApi.Api.UserRecordingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**DeleteRecordingId**](UserRecordingsApi.html#deleterecordingid) | Delete a user recording. |
| [**GetRecordingId**](UserRecordingsApi.html#getrecordingid) | Get a user recording. |
| [**GetRecordingIdMedia**](UserRecordingsApi.html#getrecordingidmedia) | Download a user recording. |
| [**GetSummary**](UserRecordingsApi.html#getsummary) | Get user recording summary |
| [**GetUserrecordings**](UserRecordingsApi.html#getuserrecordings) | Get a list of user recordings. |
| [**PutRecordingId**](UserRecordingsApi.html#putrecordingid) | Update a user recording. |
{: class="table table-striped"}

<a name="deleterecordingid"></a>

## void DeleteRecordingId (string recordingId)

Delete a user recording.



Wraps DELETE /api/v2/userrecordings/{recordingId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteRecordingIdExample
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
                apiInstance.DeleteRecordingId(recordingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.DeleteRecordingId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getrecordingid"></a>

## [**UserRecording**](UserRecording.html) GetRecordingId (string recordingId, List<string> expand = null)

Get a user recording.



Wraps GET /api/v2/userrecordings/{recordingId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRecordingIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            {
                // Get a user recording.
                UserRecording result = apiInstance.GetRecordingId(recordingId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.GetRecordingId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional]  |
{: class="table table-striped"}

### Return type

[**UserRecording**](UserRecording.html)

<a name="getrecordingidmedia"></a>

## [**DownloadResponse**](DownloadResponse.html) GetRecordingIdMedia (string recordingId, string formatId = null)

Download a user recording.



Wraps GET /api/v2/userrecordings/{recordingId}/media 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRecordingIdMediaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID
            var formatId = formatId_example;  // string | The desired media format. (optional)  (default to WEBM)

            try
            {
                // Download a user recording.
                DownloadResponse result = apiInstance.GetRecordingIdMedia(recordingId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.GetRecordingIdMedia: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
| **formatId** | **string**| The desired media format. | [optional] [default to WEBM] |
{: class="table table-striped"}

### Return type

[**DownloadResponse**](DownloadResponse.html)

<a name="getsummary"></a>

## [**FaxSummary**](FaxSummary.html) GetSummary ()

Get user recording summary



Wraps GET /api/v2/userrecordings/summary 

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

            var apiInstance = new UserRecordingsApi();

            try
            {
                // Get user recording summary
                FaxSummary result = apiInstance.GetSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.GetSummary: " + e.Message );
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

<a name="getuserrecordings"></a>

## [**UserRecordingEntityListing**](UserRecordingEntityListing.html) GetUserrecordings (int? pageSize = null, int? pageNumber = null, List<string> expand = null)

Get a list of user recordings.



Wraps GET /api/v2/userrecordings 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserrecordingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            {
                // Get a list of user recordings.
                UserRecordingEntityListing result = apiInstance.GetUserrecordings(pageSize, pageNumber, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.GetUserrecordings: " + e.Message );
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional]  |
{: class="table table-striped"}

### Return type

[**UserRecordingEntityListing**](UserRecordingEntityListing.html)

<a name="putrecordingid"></a>

## [**UserRecording**](UserRecording.html) PutRecordingId (string recordingId, UserRecording body, List<string> expand = null)

Update a user recording.



Wraps PUT /api/v2/userrecordings/{recordingId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRecordingIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UserRecordingsApi();
            var recordingId = recordingId_example;  // string | User Recording ID
            var body = new UserRecording(); // UserRecording | UserRecording
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            {
                // Update a user recording.
                UserRecording result = apiInstance.PutRecordingId(recordingId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserRecordingsApi.PutRecordingId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingId** | **string**| User Recording ID |  |
| **body** | [**UserRecording**](UserRecording.html)| UserRecording |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional]  |
{: class="table table-striped"}

### Return type

[**UserRecording**](UserRecording.html)

