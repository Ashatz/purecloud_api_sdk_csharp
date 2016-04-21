# ININ.PureCloudApi.Api.SearchApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**SearchChatsPost**](SearchApi.md#searchchatspost) | **POST** /api/v1/search/chats | Search chat history |
{: class="table table-striped"}

<a name="SearchChatsPost"></a>
## [**ChatSearchListing**](ChatSearchListing.html) SearchChatsPost (ChatSearchRequest body = null)

Search chat history



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SearchChatsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SearchApi();
            var body = new ChatSearchRequest(); // ChatSearchRequest | Search request options (optional) 

            try
            {
                // Search chat history
                ChatSearchListing result = apiInstance.SearchChatsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchChatsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ChatSearchRequest**](ChatSearchRequest.md)| Search request options | [optional]  |
{: class="table table-striped"}

### Return type

[**ChatSearchListing**](ChatSearchListing.md)

