---
title: SuggestApi
---
## ININ.PureCloudApi.Api.SuggestApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**GetSearch**](SuggestApi.html#getsearch) | Search using the q64 value returned from a previous search. |
| [**GetSuggest**](SuggestApi.html#getsuggest) | Suggest resources using the q64 value returned from a previous suggest query. |
| [**PostSearch**](SuggestApi.html#postsearch) | Search resources. |
| [**PostSuggest**](SuggestApi.html#postsuggest) | Suggest resources. |
{: class="table table-striped"}

<a name="getsearch"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSearch (string q64, List<string> expand = null, bool? profile = null)

Search using the q64 value returned from a previous search.



Wraps GET /api/v2/search 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SuggestApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var profile = true;  // bool? | profile (optional)  (default to true)

            try
            {
                // Search using the q64 value returned from a previous search.
                JsonNodeSearchResponse result = apiInstance.GetSearch(q64, expand, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestApi.GetSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="getsuggest"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSuggest (string q64, List<string> expand = null, bool? profile = null)

Suggest resources using the q64 value returned from a previous suggest query.



Wraps GET /api/v2/search/suggest 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSuggestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SuggestApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var profile = true;  // bool? | profile (optional)  (default to true)

            try
            {
                // Suggest resources using the q64 value returned from a previous suggest query.
                JsonNodeSearchResponse result = apiInstance.GetSuggest(q64, expand, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestApi.GetSuggest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postsearch"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSearch (SearchRequest body, bool? profile = null)

Search resources.



Wraps POST /api/v2/search 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SuggestApi();
            var body = new SearchRequest(); // SearchRequest | Search request options
            var profile = true;  // bool? | profile (optional)  (default to true)

            try
            {
                // Search resources.
                JsonNodeSearchResponse result = apiInstance.PostSearch(body, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestApi.PostSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SearchRequest**](SearchRequest.html)| Search request options |  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postsuggest"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSuggest (SuggestSearchRequest body, bool? profile = null)

Suggest resources.



Wraps POST /api/v2/search/suggest 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostSuggestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SuggestApi();
            var body = new SuggestSearchRequest(); // SuggestSearchRequest | Search request options
            var profile = true;  // bool? | profile (optional)  (default to true)

            try
            {
                // Suggest resources.
                JsonNodeSearchResponse result = apiInstance.PostSuggest(body, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestApi.PostSuggest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SuggestSearchRequest**](SuggestSearchRequest.html)| Search request options |  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

