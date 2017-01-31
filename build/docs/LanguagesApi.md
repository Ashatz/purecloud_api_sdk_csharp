---
title: LanguagesApi
---
## ININ.PureCloudApi.Api.LanguagesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**DeleteLanguageId**](LanguagesApi.html#deletelanguageid) | Delete Language (Deprecated) |
| [**DeleteLanguagesLanguageId**](LanguagesApi.html#deletelanguageslanguageid) | Delete Language |
| [**GetLanguageId**](LanguagesApi.html#getlanguageid) | Get language (Deprecated) |
| [**GetLanguages**](LanguagesApi.html#getlanguages) | Get the list of supported languages. (Deprecated) |
| [**GetLanguagesLanguageId**](LanguagesApi.html#getlanguageslanguageid) | Get language |
| [**GetTranslations**](LanguagesApi.html#gettranslations) | Get all available languages for translation |
| [**GetTranslationsBuiltin**](LanguagesApi.html#gettranslationsbuiltin) | Get the builtin translation for a language |
| [**GetTranslationsOrganization**](LanguagesApi.html#gettranslationsorganization) | Get effective translation for an organization by language |
| [**GetTranslationsUsersUserId**](LanguagesApi.html#gettranslationsusersuserid) | Get effective language translation for a user |
| [**PostLanguages**](LanguagesApi.html#postlanguages) | Create Language (Deprecated) |
{: class="table table-striped"}

<a name="deletelanguageid"></a>

## void DeleteLanguageId (string languageId)

Delete Language (Deprecated)

This endpoint is deprecated. It has been moved to /routing/languages/{languageId}

Wraps DELETE /api/v2/languages/{languageId} 

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
                // Delete Language (Deprecated)
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

<a name="deletelanguageslanguageid"></a>

## void DeleteLanguagesLanguageId (string languageId)

Delete Language



Wraps DELETE /api/v2/routing/languages/{languageId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteLanguagesLanguageIdExample
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
                apiInstance.DeleteLanguagesLanguageId(languageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.DeleteLanguagesLanguageId: " + e.Message );
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

Get language (Deprecated)

This endpoint is deprecated. It has been moved to /routing/languages/{languageId}

Wraps GET /api/v2/languages/{languageId} 

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
                // Get language (Deprecated)
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

Get the list of supported languages. (Deprecated)

This endpoint is deprecated. It has been moved to /routing/languages

Wraps GET /api/v2/languages 

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
                // Get the list of supported languages. (Deprecated)
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

<a name="getlanguageslanguageid"></a>

## [**Language**](Language.html) GetLanguagesLanguageId (string languageId)

Get language



Wraps GET /api/v2/routing/languages/{languageId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLanguagesLanguageIdExample
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
                Language result = apiInstance.GetLanguagesLanguageId(languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetLanguagesLanguageId: " + e.Message );
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

<a name="gettranslations"></a>

## [**AvailableTranslations**](AvailableTranslations.html) GetTranslations ()

Get all available languages for translation



Wraps GET /api/v2/languages/translations 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetTranslationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();

            try
            {
                // Get all available languages for translation
                AvailableTranslations result = apiInstance.GetTranslations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetTranslations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**AvailableTranslations**](AvailableTranslations.html)

<a name="gettranslationsbuiltin"></a>

## **Dictionary&lt;string, Object&gt;** GetTranslationsBuiltin (string language)

Get the builtin translation for a language



Wraps GET /api/v2/languages/translations/builtin 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetTranslationsBuiltinExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();
            var language = language_example;  // string | The language of the builtin translation to retrieve

            try
            {
                // Get the builtin translation for a language
                Dictionary&lt;string, Object&gt; result = apiInstance.GetTranslationsBuiltin(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetTranslationsBuiltin: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **language** | **string**| The language of the builtin translation to retrieve |  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="gettranslationsorganization"></a>

## **Dictionary&lt;string, Object&gt;** GetTranslationsOrganization (string language)

Get effective translation for an organization by language



Wraps GET /api/v2/languages/translations/organization 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetTranslationsOrganizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();
            var language = language_example;  // string | The language of the translation to retrieve for the organization

            try
            {
                // Get effective translation for an organization by language
                Dictionary&lt;string, Object&gt; result = apiInstance.GetTranslationsOrganization(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetTranslationsOrganization: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **language** | **string**| The language of the translation to retrieve for the organization |  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="gettranslationsusersuserid"></a>

## **Dictionary&lt;string, Object&gt;** GetTranslationsUsersUserId (string userId)

Get effective language translation for a user



Wraps GET /api/v2/languages/translations/users/{userId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetTranslationsUsersUserIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();
            var userId = userId_example;  // string | The user id

            try
            {
                // Get effective language translation for a user
                Dictionary&lt;string, Object&gt; result = apiInstance.GetTranslationsUsersUserId(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.GetTranslationsUsersUserId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| The user id |  |
{: class="table table-striped"}

### Return type

**Dictionary<string, Object>**

<a name="postlanguages"></a>

## [**Language**](Language.html) PostLanguages (Language body)

Create Language (Deprecated)

This endpoint is deprecated. It has been moved to /routing/languages

Wraps POST /api/v2/languages 

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
                // Create Language (Deprecated)
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

