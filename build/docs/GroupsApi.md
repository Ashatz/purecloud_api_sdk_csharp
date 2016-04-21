# ININ.PureCloudApi.Api.GroupsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GroupsGet**](GroupsApi.md#groupsget) | **GET** /api/v1/groups | Get a group list |
| [**GroupsGroupidGet**](GroupsApi.md#groupsgroupidget) | **GET** /api/v1/groups/{groupId} | Get group |
| [**GroupsGroupidMembersGet**](GroupsApi.md#groupsgroupidmembersget) | **GET** /api/v1/groups/{groupId}/members | Get group members |
{: class="table table-striped"}

<a name="GroupsGet"></a>
## [**GroupEntityListing**](GroupEntityListing.html) GroupsGet (int? pageSize = null, int? pageNumber = null, string name = null)

Get a group list



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GroupsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 

            try
            {
                // Get a group list
                GroupEntityListing result = apiInstance.GroupsGet(pageSize, pageNumber, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsGet: " + e.Message );
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
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupEntityListing**](GroupEntityListing.md)

<a name="GroupsGroupidGet"></a>
## [**Group**](Group.html) GroupsGroupidGet (string groupId)

Get group



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GroupsGroupidGetExample
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
                Group result = apiInstance.GroupsGroupidGet(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsGroupidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

[**Group**](Group.md)

<a name="GroupsGroupidMembersGet"></a>
## [**UserEntityListing**](UserEntityListing.html) GroupsGroupidMembersGet (string groupId, int? pageSize = null, int? pageNumber = null)

Get group members



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GroupsGroupidMembersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | Group ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get group members
                UserEntityListing result = apiInstance.GroupsGroupidMembersGet(groupId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsGroupidMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.md)

