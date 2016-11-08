---
title: WorkforceManagementApi
---
## ININ.PureCloudApi.Api.WorkforceManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetAdherence**](WorkforceManagementApi.html#getadherence) | **GET** /api/v2/workforcemanagement/adherence | Get a list of UserScheduleAdherence records for the requested users |
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

