---
title: SearchApi
---
## ININ.PureCloudApi.Api.SearchApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetSearch**](SearchApi.html#getsearch) | **GET** /api/v2/groups/search | Search using q64 |
| [**GetSearch_0**](SearchApi.html#getsearch_0) | **GET** /api/v2/locations/search | Search using q64 |
| [**GetSearch_1**](SearchApi.html#getsearch_1) | **GET** /api/v2/search | Search using q64 |
| [**GetSearch_2**](SearchApi.html#getsearch_2) | **GET** /api/v2/users/search | Search using q64 |
| [**GetSuggest**](SearchApi.html#getsuggest) | **GET** /api/v2/search/suggest | Suggest using q64 |
| [**PostSearch**](SearchApi.html#postsearch) | **POST** /api/v2/groups/search | Search |
| [**PostSearch_0**](SearchApi.html#postsearch_0) | **POST** /api/v2/locations/search | Search |
| [**PostSearch_1**](SearchApi.html#postsearch_1) | **POST** /api/v2/search | Search |
| [**PostSearch_2**](SearchApi.html#postsearch_2) | **POST** /api/v2/users/search | Search |
| [**PostSuggest**](SearchApi.html#postsuggest) | **POST** /api/v2/search/suggest | Suggest |
{: class="table table-striped"}

<a name="getsearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) GetSearch (string q64 = null, List<string> expand = null)

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

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string |  (optional) 
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Search using q64
                GroupsSearchResponse result = apiInstance.GetSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**|  | [optional]  |
| **expand** | [**List<string>**](string.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="getsearch_0"></a>

## [**LocationsSearchResponse**](LocationsSearchResponse.html) GetSearch_0 (string q64 = null, List<string> expand = null)

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
    public class GetSearch_0Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string |  (optional) 
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Search using q64
                LocationsSearchResponse result = apiInstance.GetSearch_0(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetSearch_0: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**|  | [optional]  |
| **expand** | [**List<string>**](string.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse.html)

<a name="getsearch_1"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSearch_1 (string q64 = null, List<string> expand = null, bool? profile = null)

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
    public class GetSearch_1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string |  (optional) 
            var expand = new List<string>(); // List<string> |  (optional) 
            var profile = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Search using q64
                JsonNodeSearchResponse result = apiInstance.GetSearch_1(q64, expand, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetSearch_1: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**|  | [optional]  |
| **expand** | [**List<string>**](string.html)|  | [optional]  |
| **profile** | **bool?**|  | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="getsearch_2"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) GetSearch_2 (string q64 = null, List<string> expand = null)

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
    public class GetSearch_2Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string |  (optional) 
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Search using q64
                UsersSearchResponse result = apiInstance.GetSearch_2(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetSearch_2: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**|  | [optional]  |
| **expand** | [**List<string>**](string.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="getsuggest"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSuggest (string q64 = null, bool? profile = null)

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

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string |  (optional) 
            var profile = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Suggest using q64
                JsonNodeSearchResponse result = apiInstance.GetSuggest(q64, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetSuggest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**|  | [optional]  |
| **profile** | **bool?**|  | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postsearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) PostSearch (GroupSearchRequest body = null)

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

            var apiInstance = new SearchApi();
            var body = new GroupSearchRequest(); // GroupSearchRequest | Search request options (optional) 

            try
            {
                // Search
                GroupsSearchResponse result = apiInstance.PostSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GroupSearchRequest**](GroupSearchRequest.html)| Search request options | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="postsearch_0"></a>

## [**LocationsSearchResponse**](LocationsSearchResponse.html) PostSearch_0 (LocationSearchRequest body = null)

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
    public class PostSearch_0Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var body = new LocationSearchRequest(); // LocationSearchRequest | Search request options (optional) 

            try
            {
                // Search
                LocationsSearchResponse result = apiInstance.PostSearch_0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostSearch_0: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LocationSearchRequest**](LocationSearchRequest.html)| Search request options | [optional]  |
{: class="table table-striped"}

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse.html)

<a name="postsearch_1"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSearch_1 (SearchRequest body = null, bool? profile = null)

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
    public class PostSearch_1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var body = new SearchRequest(); // SearchRequest | Search request options (optional) 
            var profile = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Search
                JsonNodeSearchResponse result = apiInstance.PostSearch_1(body, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostSearch_1: " + e.Message );
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

<a name="postsearch_2"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostSearch_2 (UserSearchRequest body = null)

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
    public class PostSearch_2Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options (optional) 

            try
            {
                // Search
                UsersSearchResponse result = apiInstance.PostSearch_2(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostSearch_2: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserSearchRequest**](UserSearchRequest.html)| Search request options | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

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

            var apiInstance = new SearchApi();
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
                Debug.Print("Exception when calling SearchApi.PostSuggest: " + e.Message );
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

