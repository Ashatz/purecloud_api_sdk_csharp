# ININ.PureCloudApi.Api.TokensApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**TokensMeDelete**](TokensApi.md#tokensmedelete) | **DELETE** /api/v1/tokens/me | Delete  auth token used to make the request. |
{: class="table table-striped"}

<a name="TokensMeDelete"></a>
## string** TokensMeDelete ()

Delete  auth token used to make the request.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TokensMeDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TokensApi();

            try
            {
                // Delete  auth token used to make the request.
                string result = apiInstance.TokensMeDelete();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokensApi.TokensMeDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**string**

