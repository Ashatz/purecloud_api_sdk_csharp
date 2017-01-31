---
title: SearchApi
---
## ININ.PureCloudApi.Api.SearchApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**GetSearch**](SearchApi.html#getsearch) | Search groups using the q64 value returned from a previous search |
| [**GetSearch_0**](SearchApi.html#getsearch_0) | Search locations using the q64 value returned from a previous search |
| [**GetSearch_1**](SearchApi.html#getsearch_1) | Search using the q64 value returned from a previous search. |
| [**GetSearch_2**](SearchApi.html#getsearch_2) | Search users using the q64 value returned from a previous search |
| [**GetSearch_3**](SearchApi.html#getsearch_3) | Search voicemails using the q64 value returned from a previous search |
| [**GetSuggest**](SearchApi.html#getsuggest) | Suggest resources using the q64 value returned from a previous suggest query. |
| [**PostSearch**](SearchApi.html#postsearch) | Search groups |
| [**PostSearch_0**](SearchApi.html#postsearch_0) | Search locations |
| [**PostSearch_1**](SearchApi.html#postsearch_1) | Search resources. |
| [**PostSearch_2**](SearchApi.html#postsearch_2) | Search users |
| [**PostSearch_3**](SearchApi.html#postsearch_3) | Search voicemails |
| [**PostSuggest**](SearchApi.html#postsuggest) | Suggest resources. |
{: class="table table-striped"}

<a name="getsearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) GetSearch (string q64, List<string> expand = null)

Search groups using the q64 value returned from a previous search



Wraps GET /api/v2/groups/search 

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
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            {
                // Search groups using the q64 value returned from a previous search
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
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="getsearch_0"></a>

## [**LocationsSearchResponse**](LocationsSearchResponse.html) GetSearch_0 (string q64, List<string> expand = null)

Search locations using the q64 value returned from a previous search



Wraps GET /api/v2/locations/search 

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
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            {
                // Search locations using the q64 value returned from a previous search
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
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse.html)

<a name="getsearch_1"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) GetSearch_1 (string q64, List<string> expand = null, bool? profile = null)

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
    public class GetSearch_1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 
            var profile = true;  // bool? | profile (optional)  (default to true)

            try
            {
                // Search using the q64 value returned from a previous search.
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
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="getsearch_2"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) GetSearch_2 (string q64, List<string> expand = null)

Search users using the q64 value returned from a previous search



Wraps GET /api/v2/users/search 

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
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            {
                // Search users using the q64 value returned from a previous search
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
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="getsearch_3"></a>

## [**VoicemailsSearchResponse**](VoicemailsSearchResponse.html) GetSearch_3 (string q64, List<string> expand = null)

Search voicemails using the q64 value returned from a previous search



Wraps GET /api/v2/voicemail/search 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSearch_3Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            {
                // Search voicemails using the q64 value returned from a previous search
                VoicemailsSearchResponse result = apiInstance.GetSearch_3(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetSearch_3: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse.html)

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

            var apiInstance = new SearchApi();
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
                Debug.Print("Exception when calling SearchApi.GetSuggest: " + e.Message );
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

## [**GroupsSearchResponse**](GroupsSearchResponse.html) PostSearch (GroupSearchRequest body)

Search groups



Wraps POST /api/v2/groups/search 

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
            var body = new GroupSearchRequest(); // GroupSearchRequest | Search request options

            try
            {
                // Search groups
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
| **body** | [**GroupSearchRequest**](GroupSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="postsearch_0"></a>

## [**LocationsSearchResponse**](LocationsSearchResponse.html) PostSearch_0 (LocationSearchRequest body)

Search locations



Wraps POST /api/v2/locations/search 

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
            var body = new LocationSearchRequest(); // LocationSearchRequest | Search request options

            try
            {
                // Search locations
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
| **body** | [**LocationSearchRequest**](LocationSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**LocationsSearchResponse**](LocationsSearchResponse.html)

<a name="postsearch_1"></a>

## [**JsonNodeSearchResponse**](JsonNodeSearchResponse.html) PostSearch_1 (SearchRequest body, bool? profile = null)

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
    public class PostSearch_1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var body = new SearchRequest(); // SearchRequest | Search request options
            var profile = true;  // bool? | profile (optional)  (default to true)

            try
            {
                // Search resources.
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
| **body** | [**SearchRequest**](SearchRequest.html)| Search request options |  |
| **profile** | **bool?**| profile | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**JsonNodeSearchResponse**](JsonNodeSearchResponse.html)

<a name="postsearch_2"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostSearch_2 (UserSearchRequest body)

Search users



Wraps POST /api/v2/users/search 

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
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            {
                // Search users
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
| **body** | [**UserSearchRequest**](UserSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="postsearch_3"></a>

## [**VoicemailsSearchResponse**](VoicemailsSearchResponse.html) PostSearch_3 (VoicemailSearchRequest body)

Search voicemails



Wraps POST /api/v2/voicemail/search 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostSearch_3Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var body = new VoicemailSearchRequest(); // VoicemailSearchRequest | Search request options

            try
            {
                // Search voicemails
                VoicemailsSearchResponse result = apiInstance.PostSearch_3(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PostSearch_3: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**VoicemailSearchRequest**](VoicemailSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse.html)

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

            var apiInstance = new SearchApi();
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
                Debug.Print("Exception when calling SearchApi.PostSuggest: " + e.Message );
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

