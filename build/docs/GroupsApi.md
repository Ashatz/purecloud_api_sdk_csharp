---
title: GroupsApi
---
## ININ.PureCloudApi.Api.GroupsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**DeleteGroupId**](GroupsApi.html#deletegroupid) | Delete group |
| [**DeleteGroupIdMembers**](GroupsApi.html#deletegroupidmembers) | Remove members |
| [**GetFieldconfig**](GroupsApi.html#getfieldconfig) | Fetch field config for an entity type |
| [**GetGroupId**](GroupsApi.html#getgroupid) | Get group |
| [**GetGroupIdMembers**](GroupsApi.html#getgroupidmembers) | Get group members |
| [**GetGroups**](GroupsApi.html#getgroups) | Get a group list |
| [**GetSearch**](GroupsApi.html#getsearch) | Search groups using the q64 value returned from a previous search |
| [**PostGroupIdMembers**](GroupsApi.html#postgroupidmembers) | Add members |
| [**PostGroups**](GroupsApi.html#postgroups) | Create a group |
| [**PostSearch**](GroupsApi.html#postsearch) | Search groups |
| [**PutGroupId**](GroupsApi.html#putgroupid) | Update group |
{: class="table table-striped"}

<a name="deletegroupid"></a>

## **string** DeleteGroupId (string groupId)

Delete group



Wraps DELETE /api/v2/groups/{groupId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteGroupIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            {
                // Delete group
                string result = apiInstance.DeleteGroupId(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupId: " + e.Message );
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

**string**

<a name="deletegroupidmembers"></a>

## [**Empty**](Empty.html) DeleteGroupIdMembers (string groupId, string ids)

Remove members



Wraps DELETE /api/v2/groups/{groupId}/members 

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
                Empty result = apiInstance.DeleteGroupIdMembers(groupId, ids);
                Debug.WriteLine(result);
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

[**Empty**](Empty.html)

<a name="getfieldconfig"></a>

## [**FieldConfig**](FieldConfig.html) GetFieldconfig (string type)

Fetch field config for an entity type



Wraps GET /api/v2/fieldconfig 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetFieldconfigExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var type = type_example;  // string | Field type

            try
            {
                // Fetch field config for an entity type
                FieldConfig result = apiInstance.GetFieldconfig(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetFieldconfig: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| Field type |  |
{: class="table table-striped"}

### Return type

[**FieldConfig**](FieldConfig.html)

<a name="getgroupid"></a>

## [**Group**](Group.html) GetGroupId (string groupId)

Get group



Wraps GET /api/v2/groups/{groupId} 

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

## [**UserEntityListing**](UserEntityListing.html) GetGroupIdMembers (string groupId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)

Get group members



Wraps GET /api/v2/groups/{groupId}/members 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get group members
                UserEntityListing result = apiInstance.GetGroupIdMembers(groupId, pageSize, pageNumber, sortOrder, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getgroups"></a>

## [**GroupEntityListing**](GroupEntityListing.html) GetGroups (int? pageSize = null, int? pageNumber = null, string sortOrder = null)

Get a group list



Wraps GET /api/v2/groups 

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

            var apiInstance = new GroupsApi();
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
                Debug.Print("Exception when calling GroupsApi.GetSearch: " + e.Message );
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

<a name="postgroupidmembers"></a>

## [**Empty**](Empty.html) PostGroupIdMembers (string groupId, GroupMembersUpdate body)

Add members



Wraps POST /api/v2/groups/{groupId}/members 

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
                Empty result = apiInstance.PostGroupIdMembers(groupId, body);
                Debug.WriteLine(result);
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

[**Empty**](Empty.html)

<a name="postgroups"></a>

## [**Group**](Group.html) PostGroups (Group body)

Create a group



Wraps POST /api/v2/groups 

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

            var apiInstance = new GroupsApi();
            var body = new GroupSearchRequest(); // GroupSearchRequest | Search request options

            try
            {
                // Search groups
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

<a name="putgroupid"></a>

## [**Group**](Group.html) PutGroupId (string groupId, GroupUpdate body = null)

Update group



Wraps PUT /api/v2/groups/{groupId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutGroupIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new GroupUpdate(); // GroupUpdate | Group (optional) 

            try
            {
                // Update group
                Group result = apiInstance.PutGroupId(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**GroupUpdate**](GroupUpdate.html)| Group | [optional]  |
{: class="table table-striped"}

### Return type

[**Group**](Group.html)

