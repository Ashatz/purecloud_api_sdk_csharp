---
title: OrganizationApi
---
## ININ.PureCloudApi.Api.OrganizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**GetFieldconfig**](OrganizationApi.html#getfieldconfig) | Fetch field config for an entity type |
| [**GetMe**](OrganizationApi.html#getme) | Get organization. |
| [**PatchFeatures**](OrganizationApi.html#patchfeatures) | Update organization |
{: class="table table-striped"}

<a name="getfieldconfig"></a>

## [**FieldConfig**](FieldConfig.html) GetFieldconfig (string type)

Fetch field config for an entity type



Wraps GET /api/v2/fieldconfig 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetFieldconfigExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OrganizationApi();
            var type = type_example;  // string | Field type

            try
            {
                // Fetch field config for an entity type
                FieldConfig result = apiInstance.GetFieldconfig(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetFieldconfig: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| Field type |  |
{: class="table table-striped"}

### Return type

[**FieldConfig**](FieldConfig.html)

<a name="getme"></a>

## [**Organization**](Organization.html) GetMe ()

Get organization.



Wraps GET /api/v2/organizations/me 

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

<a name="patchfeatures"></a>

## **Dictionary&lt;string, string&gt;** PatchFeatures (EntryFeatureBoolean body = null)

Update organization



Wraps PATCH /api/v2/organizations/features 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchFeaturesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OrganizationApi();
            var body = new EntryFeatureBoolean(); // EntryFeatureBoolean | Feature to update. (optional) 

            try
            {
                // Update organization
                Dictionary&lt;string, string&gt; result = apiInstance.PatchFeatures(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PatchFeatures: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EntryFeatureBoolean**](EntryFeatureBoolean.html)| Feature to update. | [optional]  |
{: class="table table-striped"}

### Return type

**Dictionary<string, string>**

