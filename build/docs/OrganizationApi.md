---
title: OrganizationApi
---
## ININ.PureCloudApi.Api.OrganizationApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetMe**](OrganizationApi.html#getme) | **GET** /api/v2/organizations/me | Get organization. |
{: class="table table-striped"}

<a name="getme"></a>

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

[**Organization**](Organization.html)

