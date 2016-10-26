---
title: WorkforceManagementApi
---
## ININ.PureCloudApi.Api.WorkforceManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLongtermforecastsForecastId**](WorkforceManagementApi.html#deletelongtermforecastsforecastid) | **DELETE** /api/v2/workforcemanagement/longtermforecasts/{forecastId} | Delete a forecast |
| [**DeleteLongtermforecastsForecastIdModificationsForecastmodificationId**](WorkforceManagementApi.html#deletelongtermforecastsforecastidmodificationsforecastmodificationid) | **DELETE** /api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications/{forecastModificationId} | Delete a forecast modification |
| [**GetAdherence**](WorkforceManagementApi.html#getadherence) | **GET** /api/v2/workforcemanagement/adherence | Get a list of UserScheduleAdherence records for the requested users |
| [**GetLongtermforecastsForecastId**](WorkforceManagementApi.html#getlongtermforecastsforecastid) | **GET** /api/v2/workforcemanagement/longtermforecasts/{forecastId} | Get forecast |
| [**GetLongtermforecastsForecastIdModifications**](WorkforceManagementApi.html#getlongtermforecastsforecastidmodifications) | **GET** /api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications | Get forecast Modifications |
| [**PostLongtermforecasts**](WorkforceManagementApi.html#postlongtermforecasts) | **POST** /api/v2/workforcemanagement/longtermforecasts | Create a forecast |
| [**PostLongtermforecastsForecastIdModifications**](WorkforceManagementApi.html#postlongtermforecastsforecastidmodifications) | **POST** /api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications | Create a forecast modification |
| [**PostLongtermforecastsSearch**](WorkforceManagementApi.html#postlongtermforecastssearch) | **POST** /api/v2/workforcemanagement/longtermforecasts/search | Search forecasts |
| [**PutLongtermforecastsForecastIdModifications**](WorkforceManagementApi.html#putlongtermforecastsforecastidmodifications) | **PUT** /api/v2/workforcemanagement/longtermforecasts/{forecastId}/modifications | Update a forecast modification |
{: class="table table-striped"}

<a name="deletelongtermforecastsforecastid"></a>

## void DeleteLongtermforecastsForecastId (string forecastId)

Delete a forecast



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteLongtermforecastsForecastIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var forecastId = forecastId_example;  // string | The forecast id

            try
            {
                // Delete a forecast
                apiInstance.DeleteLongtermforecastsForecastId(forecastId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteLongtermforecastsForecastId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **forecastId** | **string**| The forecast id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletelongtermforecastsforecastidmodificationsforecastmodificationid"></a>

## void DeleteLongtermforecastsForecastIdModificationsForecastmodificationId (string forecastId, string forecastModificationId)

Delete a forecast modification



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteLongtermforecastsForecastIdModificationsForecastmodificationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var forecastId = forecastId_example;  // string | The forecast id
            var forecastModificationId = forecastModificationId_example;  // string | The forecast Modification id

            try
            {
                // Delete a forecast modification
                apiInstance.DeleteLongtermforecastsForecastIdModificationsForecastmodificationId(forecastId, forecastModificationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.DeleteLongtermforecastsForecastIdModificationsForecastmodificationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **forecastId** | **string**| The forecast id |  |
| **forecastModificationId** | **string**| The forecast Modification id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

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

<a name="getlongtermforecastsforecastid"></a>

## [**Forecast**](Forecast.html) GetLongtermforecastsForecastId (string forecastId)

Get forecast



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLongtermforecastsForecastIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var forecastId = forecastId_example;  // string | The forecast id

            try
            {
                // Get forecast
                Forecast result = apiInstance.GetLongtermforecastsForecastId(forecastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetLongtermforecastsForecastId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **forecastId** | **string**| The forecast id |  |
{: class="table table-striped"}

### Return type

[**Forecast**](Forecast.html)

<a name="getlongtermforecastsforecastidmodifications"></a>

## [**List&lt;ForecastModification&gt;**](ForecastModification.html) GetLongtermforecastsForecastIdModifications (string forecastId)

Get forecast Modifications



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLongtermforecastsForecastIdModificationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var forecastId = forecastId_example;  // string | The forecast id

            try
            {
                // Get forecast Modifications
                List&lt;ForecastModification&gt; result = apiInstance.GetLongtermforecastsForecastIdModifications(forecastId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.GetLongtermforecastsForecastIdModifications: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **forecastId** | **string**| The forecast id |  |
{: class="table table-striped"}

### Return type

[**List<ForecastModification>**](ForecastModification.html)

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

<a name="postlongtermforecastsforecastidmodifications"></a>

## [**ForecastModificationCreation**](ForecastModificationCreation.html) PostLongtermforecastsForecastIdModifications (string forecastId, ForecastModificationCreation body)

Create a forecast modification



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostLongtermforecastsForecastIdModificationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var forecastId = forecastId_example;  // string | The forecast id
            var body = new ForecastModificationCreation(); // ForecastModificationCreation | The request body

            try
            {
                // Create a forecast modification
                ForecastModificationCreation result = apiInstance.PostLongtermforecastsForecastIdModifications(forecastId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostLongtermforecastsForecastIdModifications: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **forecastId** | **string**| The forecast id |  |
| **body** | [**ForecastModificationCreation**](ForecastModificationCreation.html)| The request body |  |
{: class="table table-striped"}

### Return type

[**ForecastModificationCreation**](ForecastModificationCreation.html)

<a name="postlongtermforecastssearch"></a>

## [**ForecastMetadataEntityListing**](ForecastMetadataEntityListing.html) PostLongtermforecastsSearch (ForecastSearchRequest body)

Search forecasts



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostLongtermforecastsSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var body = new ForecastSearchRequest(); // ForecastSearchRequest | 

            try
            {
                // Search forecasts
                ForecastMetadataEntityListing result = apiInstance.PostLongtermforecastsSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PostLongtermforecastsSearch: " + e.Message );
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

[**ForecastMetadataEntityListing**](ForecastMetadataEntityListing.html)

<a name="putlongtermforecastsforecastidmodifications"></a>

## [**ForecastModification**](ForecastModification.html) PutLongtermforecastsForecastIdModifications (string forecastId, ForecastModification body)

Update a forecast modification



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutLongtermforecastsForecastIdModificationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new WorkforceManagementApi();
            var forecastId = forecastId_example;  // string | The forecast id
            var body = new ForecastModification(); // ForecastModification | The request body

            try
            {
                // Update a forecast modification
                ForecastModification result = apiInstance.PutLongtermforecastsForecastIdModifications(forecastId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkforceManagementApi.PutLongtermforecastsForecastIdModifications: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **forecastId** | **string**| The forecast id |  |
| **body** | [**ForecastModification**](ForecastModification.html)| The request body |  |
{: class="table table-striped"}

### Return type

[**ForecastModification**](ForecastModification.html)

