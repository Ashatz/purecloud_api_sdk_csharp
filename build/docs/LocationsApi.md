# ININ.PureCloudApi.Api.LocationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetLocationId**](LocationsApi.md#getlocationid) | **GET** /api/v2/locations/{locationId} | Get Location by ID. |
| [**GetLocations**](LocationsApi.md#getlocations) | **GET** /api/v2/locations | Get the list of locations. |
{: class="table table-striped"}

<a name="GetLocationId"></a>
## [**Location**](Location.html) GetLocationId (string locationId)

Get Location by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLocationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LocationsApi();
            var locationId = locationId_example;  // string | Location ID

            try
            {
                // Get Location by ID.
                Location result = apiInstance.GetLocationId(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **locationId** | **string**| Location ID |  |
{: class="table table-striped"}

### Return type

[**Location**](Location.md)

<a name="GetLocations"></a>
## [**LocationEntityListing**](LocationEntityListing.html) GetLocations (string state = null, string name = null, int? pageSize = null, int? pageNumber = null)

Get the list of locations.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLocationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LocationsApi();
            var state = state_example;  // string | Location state (optional)  (default to ACTIVE)
            var name = name_example;  // string | Location name (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get the list of locations.
                LocationEntityListing result = apiInstance.GetLocations(state, name, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **state** | **string**| Location state | [optional] [default to ACTIVE] |
| **name** | **string**| Location name | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**LocationEntityListing**](LocationEntityListing.md)

