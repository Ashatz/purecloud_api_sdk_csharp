---
title: AttributesApi
---
## ININ.PureCloudApi.Api.AttributesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAttributeId**](AttributesApi.html#deleteattributeid) | **DELETE** /api/v2/attributes/{attributeId} | Delete an existing Attribute. |
| [**Get**](AttributesApi.html#get) | **GET** /api/v2/attributes | Gets a list of existing attributes. |
| [**GetAttributeId**](AttributesApi.html#getattributeid) | **GET** /api/v2/attributes/{attributeId} | Get details about an existing attribute. |
| [**Post**](AttributesApi.html#post) | **POST** /api/v2/attributes | Create an attribute. |
| [**PostQuery**](AttributesApi.html#postquery) | **POST** /api/v2/attributes/query | Query attributes |
| [**PutAttributeId**](AttributesApi.html#putattributeid) | **PUT** /api/v2/attributes/{attributeId} | Update an existing attribute. |
{: class="table table-striped"}

<a name="deleteattributeid"></a>

## void DeleteAttributeId (string attributeId)

Delete an existing Attribute.

This will remove attribute.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteAttributeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AttributesApi();
            var attributeId = attributeId_example;  // string | Attribute ID

            try
            {
                // Delete an existing Attribute.
                apiInstance.DeleteAttributeId(attributeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.DeleteAttributeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attributeId** | **string**| Attribute ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="get"></a>

## [**AttributeEntityListing**](AttributeEntityListing.html) Get (int? pageNumber = null, int? pageSize = null)

Gets a list of existing attributes.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AttributesApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            {
                // Gets a list of existing attributes.
                AttributeEntityListing result = apiInstance.Get(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.Get: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**AttributeEntityListing**](AttributeEntityListing.html)

<a name="getattributeid"></a>

## [**ININ.PureCloudApi.Model.Attribute**](Attribute.html) GetAttributeId (string attributeId)

Get details about an existing attribute.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetAttributeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AttributesApi();
            var attributeId = attributeId_example;  // string | Attribute ID

            try
            {
                // Get details about an existing attribute.
                ININ.PureCloudApi.Model.Attribute result = apiInstance.GetAttributeId(attributeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.GetAttributeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attributeId** | **string**| Attribute ID |  |
{: class="table table-striped"}

### Return type

[**ININ.PureCloudApi.Model.Attribute**](Attribute.html)

<a name="post"></a>

## [**ININ.PureCloudApi.Model.Attribute**](Attribute.html) Post (ININ.PureCloudApi.Model.Attribute body)

Create an attribute.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AttributesApi();
            var body = new ININ.PureCloudApi.Model.Attribute(); // ININ.PureCloudApi.Model.Attribute | Attribute

            try
            {
                // Create an attribute.
                ININ.PureCloudApi.Model.Attribute result = apiInstance.Post(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.Post: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ININ.PureCloudApi.Model.Attribute**](ININ.PureCloudApi.Model.Attribute.html)| Attribute |  |
{: class="table table-striped"}

### Return type

[**ININ.PureCloudApi.Model.Attribute**](Attribute.html)

<a name="postquery"></a>

## [**AttributeEntityListing**](AttributeEntityListing.html) PostQuery (AttributeQueryRequest body)

Query attributes



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AttributesApi();
            var body = new AttributeQueryRequest(); // AttributeQueryRequest | query

            try
            {
                // Query attributes
                AttributeEntityListing result = apiInstance.PostQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.PostQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AttributeQueryRequest**](AttributeQueryRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**AttributeEntityListing**](AttributeEntityListing.html)

<a name="putattributeid"></a>

## [**ININ.PureCloudApi.Model.Attribute**](Attribute.html) PutAttributeId (string attributeId, ININ.PureCloudApi.Model.Attribute body)

Update an existing attribute.

Fields that can be updated: name, description. The most recent version is required for updates.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutAttributeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AttributesApi();
            var attributeId = attributeId_example;  // string | Attribute ID
            var body = new ININ.PureCloudApi.Model.Attribute(); // ININ.PureCloudApi.Model.Attribute | Attribute

            try
            {
                // Update an existing attribute.
                ININ.PureCloudApi.Model.Attribute result = apiInstance.PutAttributeId(attributeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.PutAttributeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **attributeId** | **string**| Attribute ID |  |
| **body** | [**ININ.PureCloudApi.Model.Attribute**](ININ.PureCloudApi.Model.Attribute.html)| Attribute |  |
{: class="table table-striped"}

### Return type

[**ININ.PureCloudApi.Model.Attribute**](Attribute.html)

