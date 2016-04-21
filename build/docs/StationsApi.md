# ININ.PureCloudApi.Api.StationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**StationsGet**](StationsApi.md#stationsget) | **GET** /api/v1/stations | Get the list of available stations. |
| [**StationsIdAssociateduserDelete**](StationsApi.md#stationsidassociateduserdelete) | **DELETE** /api/v1/stations/{id}/associateduser | Unassigns the user assigned to this station |
| [**StationsIdGet**](StationsApi.md#stationsidget) | **GET** /api/v1/stations/{id} | Get station. |
{: class="table table-striped"}

<a name="StationsGet"></a>
## [**StationEntityListing**](StationEntityListing.html) StationsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)

Get the list of available stations.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class StationsGetExample
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
                StationEntityListing result = apiInstance.StationsGet(pageSize, pageNumber, sortBy, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.StationsGet: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**StationEntityListing**](StationEntityListing.md)

<a name="StationsIdAssociateduserDelete"></a>
## string** StationsIdAssociateduserDelete (string id)

Unassigns the user assigned to this station



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class StationsIdAssociateduserDeleteExample
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
                string result = apiInstance.StationsIdAssociateduserDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.StationsIdAssociateduserDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Station ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="StationsIdGet"></a>
## [**UserStationResource**](UserStationResource.html) StationsIdGet (string id)

Get station.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class StationsIdGetExample
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
                UserStationResource result = apiInstance.StationsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.StationsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| Station ID |  |
{: class="table table-striped"}

### Return type

[**UserStationResource**](UserStationResource.md)

