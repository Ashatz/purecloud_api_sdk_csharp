---
title: GroupsApi
---
## ININ.PureCloudApi.Api.GroupsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteGroupIdMembers**](GroupsApi.html#deletegroupidmembers) | **DELETE** /api/v2/groups/{groupId}/members | Remove members |
| [**GetGroupId**](GroupsApi.html#getgroupid) | **GET** /api/v2/groups/{groupId} | Get group |
| [**GetGroupIdMembers**](GroupsApi.html#getgroupidmembers) | **GET** /api/v2/groups/{groupId}/members | Get group members |
| [**GetGroups**](GroupsApi.html#getgroups) | **GET** /api/v2/groups | Get a group list |
| [**GetSearch**](GroupsApi.html#getsearch) | **GET** /api/v2/groups/search | Search using q64 |
| [**PostGroupIdMembers**](GroupsApi.html#postgroupidmembers) | **POST** /api/v2/groups/{groupId}/members | Add members |
| [**PostGroups**](GroupsApi.html#postgroups) | **POST** /api/v2/groups | Create a group |
| [**PostSearch**](GroupsApi.html#postsearch) | **POST** /api/v2/groups/search | Search |
{: class="table table-striped"}

<a name="deletegroupidmembers"></a>

## void DeleteGroupIdMembers (string groupId, string ids)

Remove members



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteGroupIdMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var ids = ids_example;  // string | Comma separated list of userIds to remove

            try
            {
                // Remove members
                apiInstance.DeleteGroupIdMembers(groupId, ids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupIdMembers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **ids** | **string**| Comma separated list of userIds to remove |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getgroupid"></a>

## [**Group**](Group.html) GetGroupId (string groupId)

Get group



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGroupIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            {
                // Get group
                Group result = apiInstance.GetGroupId(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

[**Group**](Group.html)

<a name="getgroupidmembers"></a>

## [**UserEntityListing**](UserEntityListing.html) GetGroupIdMembers (string groupId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)

Get group members



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGroupIdMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            {
                // Get group members
                UserEntityListing result = apiInstance.GetGroupIdMembers(groupId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupIdMembers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC] |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getgroups"></a>

## [**GroupEntityListing**](GroupEntityListing.html) GetGroups (int? pageSize = null, int? pageNumber = null, string sortOrder = null)

Get a group list



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            {
                // Get a group list
                GroupEntityListing result = apiInstance.GetGroups(pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**GroupEntityListing**](GroupEntityListing.html)

<a name="getsearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) GetSearch (string q64, List<string> expand = null)

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

            var apiInstance = new GroupsApi();
            var q64 = q64_example;  // string | 
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Search using q64
                GroupsSearchResponse result = apiInstance.GetSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetSearch: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**GroupsSearchResponse**](GroupsSearchResponse.html)

<a name="postgroupidmembers"></a>

## void PostGroupIdMembers (string groupId, GroupMembersUpdate body)

Add members



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostGroupIdMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new GroupMembersUpdate(); // GroupMembersUpdate | Add members

            try
            {
                // Add members
                apiInstance.PostGroupIdMembers(groupId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroupIdMembers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**GroupMembersUpdate**](GroupMembersUpdate.html)| Add members |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postgroups"></a>

## [**Group**](Group.html) PostGroups (Group body)

Create a group



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostGroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var body = new Group(); // Group | Group

            try
            {
                // Create a group
                Group result = apiInstance.PostGroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroups: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Group**](Group.html)| Group |  |
{: class="table table-striped"}

### Return type

[**Group**](Group.html)

<a name="postsearch"></a>

## [**GroupsSearchResponse**](GroupsSearchResponse.html) PostSearch (GroupSearchRequest body)

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

            var apiInstance = new GroupsApi();
            var body = new GroupSearchRequest(); // GroupSearchRequest | Search request options

            try
            {
                // Search
                GroupsSearchResponse result = apiInstance.PostSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostSearch: " + e.Message );
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

