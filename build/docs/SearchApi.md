# ININ.PureCloudApi.Api.SearchApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetSearch**](SearchApi.md#getsearch) | **GET** /api/v2/groups/search | Search using q64 |
| [**GetSearch_0**](SearchApi.md#getsearch_0) | **GET** /api/v2/search | Search using q64 |
| [**GetSearch_1**](SearchApi.md#getsearch_1) | **GET** /api/v2/users/search | Search using q64 |
| [**PostSearch**](SearchApi.md#postsearch) | **POST** /api/v2/groups/search | Search |
| [**PostSearch_0**](SearchApi.md#postsearch_0) | **POST** /api/v2/search | Search |
| [**PostSearch_1**](SearchApi.md#postsearch_1) | **POST** /api/v2/users/search | Search |
{: class="table table-striped"}

<a name="GetSearch"></a>
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
| **expand** | [**List<string>**](string.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.md)

<a name="GetSearch_0"></a>
## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSearch_0 (string q64 = null, List<string> expand = null)

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
                JsonNodeSearchResponse result = apiInstance.GetSearch_0(q64, expand);
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
| **expand** | [**List<string>**](string.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.md)

<a name="GetSearch_1"></a>
## [**UsersSearchResponse**](UsersSearchResponse.html) GetSearch_1 (string q64 = null, List<string> expand = null)

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

            try
            {
                // Search using q64
                UsersSearchResponse result = apiInstance.GetSearch_1(q64, expand);
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
| **expand** | [**List<string>**](string.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.md)

<a name="PostSearch"></a>
## [**GroupsSearchResponse**](GroupsSearchResponse.html) PostSearch (SearchRequest body = null)

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
            var body = new SearchRequest(); // SearchRequest | Search request options (optional) 

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
| **body** | [**SearchRequest**](SearchRequest.md)| Search request options | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.md)

<a name="PostSearch_0"></a>
## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSearch_0 (SearchRequest body = null)

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
            var body = new SearchRequest(); // SearchRequest | Search request options (optional) 

            try
            {
                // Search
                JsonNodeSearchResponse result = apiInstance.PostSearch_0(body);
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
| **body** | [**SearchRequest**](SearchRequest.md)| Search request options | [optional]  |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.md)

<a name="PostSearch_1"></a>
## [**UsersSearchResponse**](UsersSearchResponse.html) PostSearch_1 (SearchRequest body = null)

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

            try
            {
                // Search
                UsersSearchResponse result = apiInstance.PostSearch_1(body);
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
| **body** | [**SearchRequest**](SearchRequest.md)| Search request options | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.md)

