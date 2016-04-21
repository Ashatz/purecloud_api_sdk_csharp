# ININ.PureCloudApi.Api.OrganizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteMe**](OrganizationApi.md#deleteme) | **DELETE** /api/v2/organizations/me | Delete the organization. |
| [**GetMe**](OrganizationApi.md#getme) | **GET** /api/v2/organizations/me | Get organization. |
| [**PutMe**](OrganizationApi.md#putme) | **PUT** /api/v2/organizations/me | Update organization. |
{: class="table table-striped"}

<a name="DeleteMe"></a>
## string** DeleteMe ()

Delete the organization.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteMeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OrganizationApi();

            try
            {
                // Delete the organization.
                string result = apiInstance.DeleteMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.DeleteMe: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**string**

<a name="GetMe"></a>
## [**Organization**](Organization.html) GetMe ()

Get organization.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OrganizationApi();

            try
            {
                // Get organization.
                Organization result = apiInstance.GetMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetMe: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="PutMe"></a>
## [**Organization**](Organization.html) PutMe (Organization body = null)

Update organization.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutMeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OrganizationApi();
            var body = new Organization(); // Organization | Organization (optional) 

            try
            {
                // Update organization.
                Organization result = apiInstance.PutMe(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PutMe: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Organization**](Organization.md)| Organization | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

