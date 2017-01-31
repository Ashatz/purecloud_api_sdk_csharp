---
title: GeolocationApi
---
## ININ.PureCloudApi.Api.GeolocationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**GetSettings**](GeolocationApi.html#getsettings) | Get a organization&#39;s GeolocationSettings |
| [**GetUserIdGeolocationsClientId**](GeolocationApi.html#getuseridgeolocationsclientid) | Get a user&#39;s Geolocation |
| [**PatchSettings**](GeolocationApi.html#patchsettings) | Patch a organization&#39;s GeolocationSettings |
| [**PatchUserIdGeolocationsClientId**](GeolocationApi.html#patchuseridgeolocationsclientid) | Patch a user&#39;s Geolocation |
{: class="table table-striped"}

<a name="getsettings"></a>

## [**GeolocationSettings**](GeolocationSettings.html) GetSettings ()

Get a organization's GeolocationSettings



Wraps GET /api/v2/geolocations/settings 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GeolocationApi();

            try
            {
                // Get a organization's GeolocationSettings
                GeolocationSettings result = apiInstance.GetSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeolocationApi.GetSettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**GeolocationSettings**](GeolocationSettings.html)

<a name="getuseridgeolocationsclientid"></a>

## [**Geolocation**](Geolocation.html) GetUserIdGeolocationsClientId (string userId, string clientId)

Get a user's Geolocation



Wraps GET /api/v2/users/{userId}/geolocations/{clientId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdGeolocationsClientIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GeolocationApi();
            var userId = userId_example;  // string | user Id
            var clientId = clientId_example;  // string | client Id

            try
            {
                // Get a user's Geolocation
                Geolocation result = apiInstance.GetUserIdGeolocationsClientId(userId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeolocationApi.GetUserIdGeolocationsClientId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.html)

<a name="patchsettings"></a>

## [**GeolocationSettings**](GeolocationSettings.html) PatchSettings (GeolocationSettings body)

Patch a organization's GeolocationSettings



Wraps PATCH /api/v2/geolocations/settings 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GeolocationApi();
            var body = new GeolocationSettings(); // GeolocationSettings | Geolocation settings

            try
            {
                // Patch a organization's GeolocationSettings
                GeolocationSettings result = apiInstance.PatchSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeolocationApi.PatchSettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GeolocationSettings**](GeolocationSettings.html)| Geolocation settings |  |
{: class="table table-striped"}

### Return type

[**GeolocationSettings**](GeolocationSettings.html)

<a name="patchuseridgeolocationsclientid"></a>

## [**Geolocation**](Geolocation.html) PatchUserIdGeolocationsClientId (string userId, string clientId, Geolocation body)

Patch a user's Geolocation

The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.

Wraps PATCH /api/v2/users/{userId}/geolocations/{clientId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserIdGeolocationsClientIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GeolocationApi();
            var userId = userId_example;  // string | user Id
            var clientId = clientId_example;  // string | client Id
            var body = new Geolocation(); // Geolocation | Geolocation

            try
            {
                // Patch a user's Geolocation
                Geolocation result = apiInstance.PatchUserIdGeolocationsClientId(userId, clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeolocationApi.PatchUserIdGeolocationsClientId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
| **body** | [**Geolocation**](Geolocation.html)| Geolocation |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.html)

