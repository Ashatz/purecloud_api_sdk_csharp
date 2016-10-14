---
title: LanguagesApi
---
## ININ.PureCloudApi.Api.LanguagesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteLanguageId**](LanguagesApi.html#deletelanguageid) | **DELETE** /api/v2/languages/{languageId} | Delete Language |
| [**GetLanguageId**](LanguagesApi.html#getlanguageid) | **GET** /api/v2/languages/{languageId} | Get language |
| [**GetLanguages**](LanguagesApi.html#getlanguages) | **GET** /api/v2/languages | Get the list of supported languages. |
| [**PostLanguages**](LanguagesApi.html#postlanguages) | **POST** /api/v2/languages | Create Language |
| [**PutLanguageId**](LanguagesApi.html#putlanguageid) | **PUT** /api/v2/languages/{languageId} | Update Language |
{: class="table table-striped"}

<a name="deletelanguageid"></a>

## void DeleteLanguageId (string languageId)

Delete Language



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteLanguageIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();
            var languageId = languageId_example;  // string | Language ID

            try
            {
                // Delete Language
                apiInstance.DeleteLanguageId(languageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.DeleteLanguageId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **languageId** | **string**| Language ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getlanguageid"></a>

## [**Language**](Language.html) GetLanguageId (string languageId)

Get language



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLanguageIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();
            var languageId = languageId_example;  // string | Language ID

            try
            {
                // Get language
                Language result = apiInstance.GetLanguageId(languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetLanguageId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **languageId** | **string**| Language ID |  |
{: class="table table-striped"}

### Return type

[**Language**](Language.html)

<a name="getlanguages"></a>

## [**LanguageEntityListing**](LanguageEntityListing.html) GetLanguages (int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null)

Get the list of supported languages.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLanguagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var name = name_example;  // string | Name (optional) 

            try
            {
                // Get the list of supported languages.
                LanguageEntityListing result = apiInstance.GetLanguages(pageSize, pageNumber, sortOrder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetLanguages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC] |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**LanguageEntityListing**](LanguageEntityListing.html)

<a name="postlanguages"></a>

## [**Language**](Language.html) PostLanguages (Language body)

Create Language



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostLanguagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();
            var body = new Language(); // Language | Language

            try
            {
                // Create Language
                Language result = apiInstance.PostLanguages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.PostLanguages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Language**](Language.html)| Language |  |
{: class="table table-striped"}

### Return type

[**Language**](Language.html)

<a name="putlanguageid"></a>

## [**Language**](Language.html) PutLanguageId (string languageId, Language body)

Update Language



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutLanguageIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();
            var languageId = languageId_example;  // string | Language ID
            var body = new Language(); // Language | Language

            try
            {
                // Update Language
                Language result = apiInstance.PutLanguageId(languageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.PutLanguageId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **languageId** | **string**| Language ID |  |
| **body** | [**Language**](Language.html)| Language |  |
{: class="table table-striped"}

### Return type

[**Language**](Language.html)

