---
title: WorkforceManagementApi
---
## ININ.PureCloudApi.Api.WorkforceManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetAdherence**](WorkforceManagementApi.html#getadherence) | **GET** /api/v2/workforcemanagement/adherence | Get a list of UserScheduleAdherence records for the requested users |
| [**GetManagementunitsMuIdUsersUserIdTimeoffrequests**](WorkforceManagementApi.html#getmanagementunitsmuidusersuseridtimeoffrequests) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests | Get a list of time off requests for any user |
| [**GetManagementunitsMuIdUsersUserIdTimeoffrequestsTimeoffrequestId**](WorkforceManagementApi.html#getmanagementunitsmuidusersuseridtimeoffrequeststimeoffrequestid) | **GET** /api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId} | Get a time off request by id |
| [**GetTimeoffrequests**](WorkforceManagementApi.html#gettimeoffrequests) | **GET** /api/v2/workforcemanagement/timeoffrequests | Get a list of time off requests for the current user |
| [**GetTimeoffrequestsTimeoffrequestId**](WorkforceManagementApi.html#gettimeoffrequeststimeoffrequestid) | **GET** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Get a time off request for the current user by id |
| [**PatchTimeoffrequestsTimeoffrequestId**](WorkforceManagementApi.html#patchtimeoffrequeststimeoffrequestid) | **PATCH** /api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId} | Mark a time off request for the current user as read or unread |
| [**PostLongtermforecasts**](WorkforceManagementApi.html#postlongtermforecasts) | **POST** /api/v2/workforcemanagement/longtermforecasts | Create a forecast |
{: class="table table-striped"}

<a name="getadherence"></a>

## [**UserScheduleAdherence**](UserScheduleAdherence.html) GetAdherence (List<string> userId)

Get a list of UserScheduleAdherence records for the requested users



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
            var userId = new List<string>(); // List<string> | User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request

            try
            {
                // Get a list of UserScheduleAdherence records for the requested users
                UserScheduleAdherence result = apiInstance.GetAdherence(userId);
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
| **userId** | [**List<string>**](string.html)| User Id(s) for which to fetch current schedule adherence information.  Max of 100 userIds per request |  |
{: class="table table-striped"}

### Return type

[**UserScheduleAdherence**](UserScheduleAdherence.html)

<a name="getmanagementunitsmuidusersuseridtimeoffrequests"></a>

## [**TimeOffRequestList**](TimeOffRequestList.html) GetManagementunitsMuIdUsersUserIdTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null)

Get a list of time off requests for any user



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

<a name="postlongtermforecasts"></a>

## [**ForecastCreationCompletion**](ForecastCreationCompletion.html) PostLongtermforecasts (ForecastCreation body)

Create a forecast



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

