---
title: WorkforceManagementApi
---
## ININ.PureCloudApi.Api.WorkforceManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**GetAdherence**](WorkforceManagementApi.html#getadherence) | Get a list of UserScheduleAdherence records for the requested users |
| [**GetDecisionsDownloadsDownloadId**](WorkforceManagementApi.html#getdecisionsdownloadsdownloadid) | Get decisions download link |
| [**GetManagementunitsMuIdActivitycodes**](WorkforceManagementApi.html#getmanagementunitsmuidactivitycodes) | Get activity codes corresponding to a management unit |
| [**GetManagementunitsMuIdUsers**](WorkforceManagementApi.html#getmanagementunitsmuidusers) | Get agents in the management unit |
| [**GetManagementunitsMuIdUsersUserIdTimeoffrequests**](WorkforceManagementApi.html#getmanagementunitsmuidusersuseridtimeoffrequests) | Get a list of time off requests for any user |
| [**GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId**](WorkforceManagementApi.html#getmanagementunitsmuidusersuseridtimeoffrequeststimeoffrequestid) | Get a time off request by id |
| [**GetTimeoffrequests**](WorkforceManagementApi.html#gettimeoffrequests) | Get a list of time off requests for the current user |
| [**GetTimeoffrequestsTimeoffrequestId**](WorkforceManagementApi.html#gettimeoffrequeststimeoffrequestid) | Get a time off request for the current user by id |
| [**PatchTimeoffrequestsTimeoffrequestId**](WorkforceManagementApi.html#patchtimeoffrequeststimeoffrequestid) | Mark a time off request for the current user as read or unread |
| [**PostDecisionsDownloadsSearch**](WorkforceManagementApi.html#postdecisionsdownloadssearch) | Download decisions files metadata |
| [**PostLongtermforecasts**](WorkforceManagementApi.html#postlongtermforecasts) | Create a forecast |
| [**PostManagementunitsMuIdSchedulesSearch**](WorkforceManagementApi.html#postmanagementunitsmuidschedulessearch) | Get user schedules within the given time range |
| [**PostSchedules**](WorkforceManagementApi.html#postschedules) | Get a schedule for the current user |
{: class="table table-striped"}

<a name="getadherence"></a>

## [**List&lt;UserScheduleAdherence&gt;**](UserScheduleAdherence.html) GetAdherence (List<string> userId)

Get a list of UserScheduleAdherence records for the requested users



Wraps GET /api/v2/workforcemanagement/adherence 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetAdherenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var userId = new List<string>(); // List<string> | User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request

            try
            {
                // Get a list of UserScheduleAdherence records for the requested users
                List&lt;UserScheduleAdherence&gt; result = apiInstance.GetAdherence(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetAdherence: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | [**List<string>**](string.html)| User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request |  |
{: class="table table-striped"}

### Return type

[**List<UserScheduleAdherence>**](UserScheduleAdherence.html)

<a name="getdecisionsdownloadsdownloadid"></a>

## [**DecisionsDownloadLink**](DecisionsDownloadLink.html) GetDecisionsDownloadsDownloadId (string downloadId, string downloadfilename = null)

Get decisions download link



Wraps GET /api/v2/workforcemanagement/decisions/downloads/{downloadId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDecisionsDownloadsDownloadIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var downloadId = downloadId_example;  // string | The decisions file download id
            var downloadfilename = downloadfilename_example;  // string | The file name used to get the download url (optional)  (default to downloadfilename)

            try
            {
                // Get decisions download link
                DecisionsDownloadLink result = apiInstance.GetDecisionsDownloadsDownloadId(downloadId, downloadfilename);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetDecisionsDownloadsDownloadId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **downloadId** | **string**| The decisions file download id |  |
| **downloadfilename** | **string**| The file name used to get the download url | [optional] [default to downloadfilename] |
{: class="table table-striped"}

### Return type

[**DecisionsDownloadLink**](DecisionsDownloadLink.html)

<a name="getmanagementunitsmuidactivitycodes"></a>

## [**ActivityCodeContainer**](ActivityCodeContainer.html) GetManagementunitsMuIdActivitycodes (string muId)

Get activity codes corresponding to a management unit



Wraps GET /api/v2/workforcemanagement/managementunits/{muId}/activitycodes 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetManagementunitsMuIdActivitycodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit.

            try
            {
                // Get activity codes corresponding to a management unit
                ActivityCodeContainer result = apiInstance.GetManagementunitsMuIdActivitycodes(muId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetManagementunitsMuIdActivitycodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit. |  |
{: class="table table-striped"}

### Return type

[**ActivityCodeContainer**](ActivityCodeContainer.html)

<a name="getmanagementunitsmuidusers"></a>

## [**WfmUserEntityListing**](WfmUserEntityListing.html) GetManagementunitsMuIdUsers (string muId)

Get agents in the management unit



Wraps GET /api/v2/workforcemanagement/managementunits/{muId}/users 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetManagementunitsMuIdUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit.

            try
            {
                // Get agents in the management unit
                WfmUserEntityListing result = apiInstance.GetManagementunitsMuIdUsers(muId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetManagementunitsMuIdUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit. |  |
{: class="table table-striped"}

### Return type

[**WfmUserEntityListing**](WfmUserEntityListing.html)

<a name="getmanagementunitsmuidusersuseridtimeoffrequests"></a>

## [**TimeOffRequestList**](TimeOffRequestList.html) GetManagementunitsMuIdUsersUserIdTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null)

Get a list of time off requests for any user



Wraps GET /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetManagementunitsMuIdUsersUserIdTimeoffrequestsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit.
            var userId = userId_example;  // string | The userId to whom the Time Off Request applies.
            var recentlyReviewed = true;  // bool? | Limit results to requests that have been reviewed within the preceding 30 days (optional)  (default to false)

            try
            {
                // Get a list of time off requests for any user
                TimeOffRequestList result = apiInstance.GetManagementunitsMuIdUsersUserIdTimeoffrequests(muId, userId, recentlyReviewed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetManagementunitsMuIdUsersUserIdTimeoffrequests: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit. |  |
| **userId** | **string**| The userId to whom the Time Off Request applies. |  |
| **recentlyReviewed** | **bool?**| Limit results to requests that have been reviewed within the preceding 30 days | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**TimeOffRequestList**](TimeOffRequestList.html)

<a name="getmanagementunitsmuidusersuseridtimeoffrequeststimeoffrequestid"></a>

## [**TimeOffRequest**](TimeOffRequest.html) GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId (string muId, string userId, string timeOffRequestId)

Get a time off request by id



Wraps GET /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit.
            var userId = userId_example;  // string | The userId to whom the Time Off Request applies.
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id

            try
            {
                // Get a time off request by id
                TimeOffRequest result = apiInstance.GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId(muId, userId, timeOffRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit. |  |
| **userId** | **string**| The userId to whom the Time Off Request applies. |  |
| **timeOffRequestId** | **string**| Time Off Request Id |  |
{: class="table table-striped"}

### Return type

[**TimeOffRequest**](TimeOffRequest.html)

<a name="gettimeoffrequests"></a>

## [**TimeOffRequestList**](TimeOffRequestList.html) GetTimeoffrequests (bool? recentlyReviewed = null)

Get a list of time off requests for the current user



Wraps GET /api/v2/workforcemanagement/timeoffrequests 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetTimeoffrequestsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var recentlyReviewed = true;  // bool? | Limit results to requests that have been reviewed within the preceding 30 days (optional)  (default to false)

            try
            {
                // Get a list of time off requests for the current user
                TimeOffRequestList result = apiInstance.GetTimeoffrequests(recentlyReviewed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetTimeoffrequests: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recentlyReviewed** | **bool?**| Limit results to requests that have been reviewed within the preceding 30 days | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**TimeOffRequestList**](TimeOffRequestList.html)

<a name="gettimeoffrequeststimeoffrequestid"></a>

## [**TimeOffRequest**](TimeOffRequest.html) GetTimeoffrequestsTimeoffrequestId (string timeOffRequestId)

Get a time off request for the current user by id



Wraps GET /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetTimeoffrequestsTimeoffrequestIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id

            try
            {
                // Get a time off request for the current user by id
                TimeOffRequest result = apiInstance.GetTimeoffrequestsTimeoffrequestId(timeOffRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetTimeoffrequestsTimeoffrequestId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **timeOffRequestId** | **string**| Time Off Request Id |  |
{: class="table table-striped"}

### Return type

[**TimeOffRequest**](TimeOffRequest.html)

<a name="patchtimeoffrequeststimeoffrequestid"></a>

## void PatchTimeoffrequestsTimeoffrequestId (string timeOffRequestId, TimeOffRequestPatch body = null)

Mark a time off request for the current user as read or unread



Wraps PATCH /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchTimeoffrequestsTimeoffrequestIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var timeOffRequestId = timeOffRequestId_example;  // string | Time Off Request Id
            var body = new TimeOffRequestPatch(); // TimeOffRequestPatch |  (optional) 

            try
            {
                // Mark a time off request for the current user as read or unread
                apiInstance.PatchTimeoffrequestsTimeoffrequestId(timeOffRequestId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PatchTimeoffrequestsTimeoffrequestId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **timeOffRequestId** | **string**| Time Off Request Id |  |
| **body** | [**TimeOffRequestPatch**](TimeOffRequestPatch.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postdecisionsdownloadssearch"></a>

## [**DecisionsFileMetadataEntityListing**](DecisionsFileMetadataEntityListing.html) PostDecisionsDownloadsSearch (ForecastSearchRequest body)

Download decisions files metadata



Wraps POST /api/v2/workforcemanagement/decisions/downloads/search 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostDecisionsDownloadsSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var body = new ForecastSearchRequest(); // ForecastSearchRequest | 

            try
            {
                // Download decisions files metadata
                DecisionsFileMetadataEntityListing result = apiInstance.PostDecisionsDownloadsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostDecisionsDownloadsSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ForecastSearchRequest**](ForecastSearchRequest.html)|  |  |
{: class="table table-striped"}

### Return type

[**DecisionsFileMetadataEntityListing**](DecisionsFileMetadataEntityListing.html)

<a name="postlongtermforecasts"></a>

## [**ForecastCreationCompletion**](ForecastCreationCompletion.html) PostLongtermforecasts (ForecastCreation body)

Create a forecast



Wraps POST /api/v2/workforcemanagement/longtermforecasts 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostLongtermforecastsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var body = new ForecastCreation(); // ForecastCreation | The request body

            try
            {
                // Create a forecast
                ForecastCreationCompletion result = apiInstance.PostLongtermforecasts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostLongtermforecasts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ForecastCreation**](ForecastCreation.html)| The request body |  |
{: class="table table-striped"}

### Return type

[**ForecastCreationCompletion**](ForecastCreationCompletion.html)

<a name="postmanagementunitsmuidschedulessearch"></a>

## [**UserScheduleContainer**](UserScheduleContainer.html) PostManagementunitsMuIdSchedulesSearch (string muId, UserListScheduleRequestBody body = null)

Get user schedules within the given time range



Wraps POST /api/v2/workforcemanagement/managementunits/{muId}/schedules/search 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostManagementunitsMuIdSchedulesSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var muId = muId_example;  // string | The muId of the management unit.
            var body = new UserListScheduleRequestBody(); // UserListScheduleRequestBody | body (optional) 

            try
            {
                // Get user schedules within the given time range
                UserScheduleContainer result = apiInstance.PostManagementunitsMuIdSchedulesSearch(muId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostManagementunitsMuIdSchedulesSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **muId** | **string**| The muId of the management unit. |  |
| **body** | [**UserListScheduleRequestBody**](UserListScheduleRequestBody.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**UserScheduleContainer**](UserScheduleContainer.html)

<a name="postschedules"></a>

## [**UserScheduleContainer**](UserScheduleContainer.html) PostSchedules (CurrentUserScheduleRequestBody body = null)

Get a schedule for the current user



Wraps POST /api/v2/workforcemanagement/schedules 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostSchedulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var body = new CurrentUserScheduleRequestBody(); // CurrentUserScheduleRequestBody | body (optional) 

            try
            {
                // Get a schedule for the current user
                UserScheduleContainer result = apiInstance.PostSchedules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostSchedules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CurrentUserScheduleRequestBody**](CurrentUserScheduleRequestBody.html)| body | [optional]  |
{: class="table table-striped"}

### Return type

[**UserScheduleContainer**](UserScheduleContainer.html)

