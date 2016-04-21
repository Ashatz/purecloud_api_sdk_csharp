# ININ.PureCloudApi.Api.StationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteIdAssociateduser**](StationsApi.md#deleteidassociateduser) | **DELETE** /api/v2/stations/{id}/associateduser | Unassigns the user assigned to this station |
| [**GetId**](StationsApi.md#getid) | **GET** /api/v2/stations/{id} | Get station. |
| [**GetStations**](StationsApi.md#getstations) | **GET** /api/v2/stations | Get the list of available stations. |
{: class="table table-striped"}

<a name="DeleteIdAssociateduser"></a>
## string** DeleteIdAssociateduser (string id)

Unassigns the user assigned to this station



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteIdAssociateduserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new StationsApi();
            var id = id_example;  // string | Station ID

            try
            {
                // Unassigns the user assigned to this station
                string result = apiInstance.DeleteIdAssociateduser(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.DeleteIdAssociateduser: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Station ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="GetId"></a>
## [**Station**](Station.html) GetId (string id)

Get station.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new StationsApi();
            var id = id_example;  // string | Station ID

            try
            {
                // Get station.
                Station result = apiInstance.GetId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Station ID |  |
{: class="table table-striped"}

### Return type

[**Station**](Station.md)

<a name="GetStations"></a>
## [**StationEntityListing**](StationEntityListing.html) GetStations (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)

Get the list of available stations.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetStationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new StationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var name = name_example;  // string | Name (optional) 

            try
            {
                // Get the list of available stations.
                StationEntityListing result = apiInstance.GetStations(pageSize, pageNumber, sortBy, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetStations: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**StationEntityListing**](StationEntityListing.md)

