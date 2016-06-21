---
title: SuggestApi
---
## ININ.PureCloudApi.Api.SuggestApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetSearch**](SuggestApi.html#getsearch) | **GET** /api/v2/search | Search using q64 |
| [**GetSuggest**](SuggestApi.html#getsuggest) | **GET** /api/v2/search/suggest | Suggest using q64 |
| [**PostSearch**](SuggestApi.html#postsearch) | **POST** /api/v2/search | Search |
| [**PostSuggest**](SuggestApi.html#postsuggest) | **POST** /api/v2/search/suggest | Suggest |
{: class="table table-striped"}

<a name="getsearch"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSearch (string q64, List<string> expand = null, bool? profile = null)

Search using q64



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
            var q64 = q64_example;  // string | 
            var expand = new List<string>(); // List<string> |  (optional) 
            var profile = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Search using q64
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
| **q64** | **string**|  |  |
| **expand** | [**List<string>**](string.html)|  | [optional]  |
| **profile** | **bool?**|  | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="getsuggest"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSuggest (string q64, bool? profile = null)

Suggest using q64



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
            var q64 = q64_example;  // string | 
            var profile = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Suggest using q64
                JsonNodeSearchResponse result = apiInstance.GetSuggest(q64, profile);
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
| **q64** | **string**|  |  |
| **profile** | **bool?**|  | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postsearch"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSearch (SearchRequest body = null, bool? profile = null)

Search



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
            var body = new SearchRequest(); // SearchRequest | Search request options (optional) 
            var profile = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Search
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
| **body** | [**SearchRequest**](SearchRequest.html)| Search request options | [optional]  |
| **profile** | **bool?**|  | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postsuggest"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSuggest (SuggestSearchRequest body = null, bool? profile = null)

Suggest



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
            var body = new SuggestSearchRequest(); // SuggestSearchRequest | Search request options (optional) 
            var profile = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Suggest
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
| **body** | [**SuggestSearchRequest**](SuggestSearchRequest.html)| Search request options | [optional]  |
| **profile** | **bool?**|  | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

