---
title: AttributesApi
---
## ININ.PureCloudApi.Api.AttributesApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteAttribute**](AttributesApi.html#deleteattribute) | **DELETE** /api/v2/attributes/{attributeId} | Delete an existing Attribute. |
| [**GetAttribute**](AttributesApi.html#getattribute) | **GET** /api/v2/attributes/{attributeId} | Get details about an existing attribute. |
| [**GetAttributes**](AttributesApi.html#getattributes) | **GET** /api/v2/attributes | Gets a list of existing attributes. |
| [**PostAttributes**](AttributesApi.html#postattributes) | **POST** /api/v2/attributes | Create an attribute. |
| [**PostQuery**](AttributesApi.html#postquery) | **POST** /api/v2/attributes/query | Query attributes |
| [**PutAttribute**](AttributesApi.html#putattribute) | **PUT** /api/v2/attributes/{attributeId} | Update an existing attribute. |
{: class="table table-striped"}

<a name="deleteattribute"></a>

## void DeleteAttribute (string attributeId)

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
    public class DeleteAttributeExample
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
                apiInstance.DeleteAttribute(attributeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.DeleteAttribute: " + e.Message );
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

<a name="getattribute"></a>

## [**ININ.PureCloudApi.Model.Attribute**](Attribute.html) GetAttribute (string attributeId)

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
    public class GetAttributeExample
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
                ININ.PureCloudApi.Model.Attribute result = apiInstance.GetAttribute(attributeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.GetAttribute: " + e.Message );
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

<a name="getattributes"></a>

## [**AttributeEntityListing**](AttributeEntityListing.html) GetAttributes (int? pageNumber = null, int? pageSize = null)

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
    public class GetAttributesExample
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
                AttributeEntityListing result = apiInstance.GetAttributes(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.GetAttributes: " + e.Message );
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

<a name="postattributes"></a>

## [**ININ.PureCloudApi.Model.Attribute**](Attribute.html) PostAttributes (ININ.PureCloudApi.Model.Attribute body)

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
    public class PostAttributesExample
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
                ININ.PureCloudApi.Model.Attribute result = apiInstance.PostAttributes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.PostAttributes: " + e.Message );
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

<a name="putattribute"></a>

## [**ININ.PureCloudApi.Model.Attribute**](Attribute.html) PutAttribute (string attributeId, ININ.PureCloudApi.Model.Attribute body)

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
    public class PutAttributeExample
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
                ININ.PureCloudApi.Model.Attribute result = apiInstance.PutAttribute(attributeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttributesApi.PutAttribute: " + e.Message );
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

