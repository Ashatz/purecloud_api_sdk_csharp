---
title: ObjectsApi
---
## ININ.PureCloudApi.Api.ObjectsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetObjectsObjectId**](ObjectsApi.html#getobjectsobjectid) | **GET** /api/v2/authorization/objects/{objectId} | Returns a permission-protected object, showing the permission contexts it belongs to. |
{: class="table table-striped"}

<a name="getobjectsobjectid"></a>

## [**AuthzObject**](AuthzObject.html) GetObjectsObjectId (string objectId)

Returns a permission-protected object, showing the permission contexts it belongs to.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetObjectsObjectIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ObjectsApi();
            var objectId = objectId_example;  // string | Object ID

            try
            {
                // Returns a permission-protected object, showing the permission contexts it belongs to.
                AuthzObject result = apiInstance.GetObjectsObjectId(objectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectsApi.GetObjectsObjectId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **objectId** | **string**| Object ID |  |
{: class="table table-striped"}

### Return type

[**AuthzObject**](AuthzObject.html)

