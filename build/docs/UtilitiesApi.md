# ININ.PureCloudApi.Api.UtilitiesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**CertificateDetailsPost**](UtilitiesApi.md#certificatedetailspost) | **POST** /api/v1/certificate/details | Returns the information about an X509 PEM encoded certificate or certificate chain. |
| [**ConfigurationAddressvalidationPost**](UtilitiesApi.md#configurationaddressvalidationpost) | **POST** /api/v1/configuration/addressvalidation | Validates a street address |
| [**DateGet**](UtilitiesApi.md#dateget) | **GET** /api/v1/date | Get the current system date/time |
| [**TimezonesGet**](UtilitiesApi.md#timezonesget) | **GET** /api/v1/timezones | Get time zones list |
{: class="table table-striped"}

<a name="CertificateDetailsPost"></a>
## [**ParsedCertificate**](ParsedCertificate.html) CertificateDetailsPost (Certificate body = null)

Returns the information about an X509 PEM encoded certificate or certificate chain.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class CertificateDetailsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UtilitiesApi();
            var body = new Certificate(); // Certificate |  (optional) 

            try
            {
                // Returns the information about an X509 PEM encoded certificate or certificate chain.
                ParsedCertificate result = apiInstance.CertificateDetailsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.CertificateDetailsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Certificate**](Certificate.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ParsedCertificate**](ParsedCertificate.md)

<a name="ConfigurationAddressvalidationPost"></a>
## [**ValidateAddressResponse**](ValidateAddressResponse.html) ConfigurationAddressvalidationPost (ValidateAddressRequest body = null)

Validates a street address



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationAddressvalidationPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UtilitiesApi();
            var body = new ValidateAddressRequest(); // ValidateAddressRequest |  (optional) 

            try
            {
                // Validates a street address
                ValidateAddressResponse result = apiInstance.ConfigurationAddressvalidationPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.ConfigurationAddressvalidationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ValidateAddressRequest**](ValidateAddressRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ValidateAddressResponse**](ValidateAddressResponse.md)

<a name="DateGet"></a>
## [**ServerDate**](ServerDate.html) DateGet ()

Get the current system date/time



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DateGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UtilitiesApi();

            try
            {
                // Get the current system date/time
                ServerDate result = apiInstance.DateGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.DateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ServerDate**](ServerDate.md)

<a name="TimezonesGet"></a>
## [**TimeZoneEntityListing**](TimeZoneEntityListing.html) TimezonesGet (int? pageSize = null, int? pageNumber = null)

Get time zones list



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TimezonesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UtilitiesApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get time zones list
                TimeZoneEntityListing result = apiInstance.TimezonesGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.TimezonesGet: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**TimeZoneEntityListing**](TimeZoneEntityListing.md)

