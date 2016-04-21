# ININ.PureCloudApi.Api.OrphanedRecordingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**OrphanrecordingsGet**](OrphanedRecordingsApi.md#orphanrecordingsget) | **GET** /api/v1/orphanrecordings | Gets all orphan recordings |
| [**OrphanrecordingsOrphanidDelete**](OrphanedRecordingsApi.md#orphanrecordingsorphaniddelete) | **DELETE** /api/v1/orphanrecordings/{orphanId} |  deletes a single orphan recording |
| [**OrphanrecordingsOrphanidGet**](OrphanedRecordingsApi.md#orphanrecordingsorphanidget) | **GET** /api/v1/orphanrecordings/{orphanId} | Gets a single orphan recording |
{: class="table table-striped"}

<a name="OrphanrecordingsGet"></a>
## [**OrphanRecordingListing**](OrphanRecordingListing.html) OrphanrecordingsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null)

Gets all orphan recordings



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OrphanrecordingsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OrphanedRecordingsApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 

            try
            {
                // Gets all orphan recordings
                OrphanRecordingListing result = apiInstance.OrphanrecordingsGet(pageSize, pageNumber, sortBy, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrphanedRecordingsApi.OrphanrecordingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
{: class="table table-striped"}

### Return type

[**OrphanRecordingListing**](OrphanRecordingListing.md)

<a name="OrphanrecordingsOrphanidDelete"></a>
## [**OrphanRecording**](OrphanRecording.html) OrphanrecordingsOrphanidDelete (string orphanId)

 deletes a single orphan recording



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OrphanrecordingsOrphanidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OrphanedRecordingsApi();
            var orphanId = orphanId_example;  // string | Orphan ID

            try
            {
                //  deletes a single orphan recording
                OrphanRecording result = apiInstance.OrphanrecordingsOrphanidDelete(orphanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrphanedRecordingsApi.OrphanrecordingsOrphanidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |
{: class="table table-striped"}

### Return type

[**OrphanRecording**](OrphanRecording.md)

<a name="OrphanrecordingsOrphanidGet"></a>
## [**OrphanRecording**](OrphanRecording.html) OrphanrecordingsOrphanidGet (string orphanId)

Gets a single orphan recording



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OrphanrecordingsOrphanidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OrphanedRecordingsApi();
            var orphanId = orphanId_example;  // string | Orphan ID

            try
            {
                // Gets a single orphan recording
                OrphanRecording result = apiInstance.OrphanrecordingsOrphanidGet(orphanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrphanedRecordingsApi.OrphanrecordingsOrphanidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |
{: class="table table-striped"}

### Return type

[**OrphanRecording**](OrphanRecording.md)

