# ININ.PureCloudApi.Api.LanguagesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**LanguagesGet**](LanguagesApi.md#languagesget) | **GET** /api/v1/languages | Get the list of supported languages. |
| [**LanguagesLanguageidGet**](LanguagesApi.md#languageslanguageidget) | **GET** /api/v1/languages/{languageId} | Get language |
{: class="table table-striped"}

<a name="LanguagesGet"></a>
## [**LanguageEntityListing**](LanguageEntityListing.html) LanguagesGet (int? pageSize = null, int? pageNumber = null)

Get the list of supported languages.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class LanguagesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LanguagesApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get the list of supported languages.
                LanguageEntityListing result = apiInstance.LanguagesGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.LanguagesGet: " + e.Message );
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

[**LanguageEntityListing**](LanguageEntityListing.md)

<a name="LanguagesLanguageidGet"></a>
## [**Language**](Language.html) LanguagesLanguageidGet (string languageId)

Get language



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class LanguagesLanguageidGetExample
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
                Language result = apiInstance.LanguagesLanguageidGet(languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguagesApi.LanguagesLanguageidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **languageId** | **string**| Language ID |  |
{: class="table table-striped"}

### Return type

[**Language**](Language.md)

