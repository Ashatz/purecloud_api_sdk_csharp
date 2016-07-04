---
title: AuthorizationApi
---
## ININ.PureCloudApi.Api.AuthorizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteRolesRoleId**](AuthorizationApi.html#deleterolesroleid) | **DELETE** /api/v2/authorization/roles/{roleId} | Delete an organization role. |
| [**DeleteUserIdRoles**](AuthorizationApi.html#deleteuseridroles) | **DELETE** /api/v2/users/{userId}/roles | Removes all the roles from the user. |
| [**GetPermissions**](AuthorizationApi.html#getpermissions) | **GET** /api/v2/authorization/permissions | Get all permissions. |
| [**GetProducts**](AuthorizationApi.html#getproducts) | **GET** /api/v2/authorization/products | Get the list of enabled products |
| [**GetRoles**](AuthorizationApi.html#getroles) | **GET** /api/v2/authorization/roles | Retrieve a list of all roles defined for the organization |
| [**GetRolesLeftroleIdComparedefaultRightroleId**](AuthorizationApi.html#getrolesleftroleidcomparedefaultrightroleid) | **GET** /api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId} | Get an org role to default role comparison comparison |
| [**GetRolesRoleId**](AuthorizationApi.html#getrolesroleid) | **GET** /api/v2/authorization/roles/{roleId} | Get a single organization role. |
| [**GetUserIdRoles**](AuthorizationApi.html#getuseridroles) | **GET** /api/v2/users/{userId}/roles | Returns a listing of roles and permissions for a user. |
| [**PatchRolesRoleId**](AuthorizationApi.html#patchrolesroleid) | **PATCH** /api/v2/authorization/roles/{roleId} | Patch Organization Role for needsUpdate Field |
| [**PostRoles**](AuthorizationApi.html#postroles) | **POST** /api/v2/authorization/roles | Create an organization role. |
| [**PostRolesDefault**](AuthorizationApi.html#postrolesdefault) | **POST** /api/v2/authorization/roles/default | Restores all default roles |
| [**PostRolesLeftroleIdComparedefaultRightroleId**](AuthorizationApi.html#postrolesleftroleidcomparedefaultrightroleid) | **POST** /api/v2/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId} | Get an unsaved org role to default role comparison |
| [**PutRolesDefault**](AuthorizationApi.html#putrolesdefault) | **PUT** /api/v2/authorization/roles/default | Restore specified default roles |
| [**PutRolesRoleId**](AuthorizationApi.html#putrolesroleid) | **PUT** /api/v2/authorization/roles/{roleId} | Update an organization role. |
| [**PutRolesRoleIdUsersAdd**](AuthorizationApi.html#putrolesroleidusersadd) | **PUT** /api/v2/authorization/roles/{roleId}/users/add | Sets the users for the role |
| [**PutRolesRoleIdUsersRemove**](AuthorizationApi.html#putrolesroleidusersremove) | **PUT** /api/v2/authorization/roles/{roleId}/users/remove | Removes the users from the role |
| [**PutUserIdRoles**](AuthorizationApi.html#putuseridroles) | **PUT** /api/v2/users/{userId}/roles | Sets the user&#39;s roles |
{: class="table table-striped"}

<a name="deleterolesroleid"></a>

## void DeleteRolesRoleId (string roleId)

Delete an organization role.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteRolesRoleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID

            try
            {
                // Delete an organization role.
                apiInstance.DeleteRolesRoleId(roleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.DeleteRolesRoleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteuseridroles"></a>

## void DeleteUserIdRoles (string userId)

Removes all the roles from the user.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteUserIdRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Removes all the roles from the user.
                apiInstance.DeleteUserIdRoles(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.DeleteUserIdRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getpermissions"></a>

## [**PermissionCollectionEntityListing**](PermissionCollectionEntityListing.html) GetPermissions (int? pageSize = null, int? pageNumber = null)

Get all permissions.

Retrieve a list of all permission defined in the system.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPermissionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get all permissions.
                PermissionCollectionEntityListing result = apiInstance.GetPermissions(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetPermissions: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**PermissionCollectionEntityListing**](PermissionCollectionEntityListing.html)

<a name="getproducts"></a>

## [**OrganizationProductEntityListing**](OrganizationProductEntityListing.html) GetProducts ()

Get the list of enabled products

Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProductsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();

            try
            {
                // Get the list of enabled products
                OrganizationProductEntityListing result = apiInstance.GetProducts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetProducts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OrganizationProductEntityListing**](OrganizationProductEntityListing.html)

<a name="getroles"></a>

## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) GetRoles (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, List<string> permission = null, bool? userCount = null)

Retrieve a list of all roles defined for the organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var permission = new List<string>(); // List<string> |  (optional) 
            var userCount = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Retrieve a list of all roles defined for the organization
                OrganizationRoleEntityListing result = apiInstance.GetRoles(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, permission, userCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **permission** | [**List<string>**](string.html)|  | [optional]  |
| **userCount** | **bool?**|  | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html)

<a name="getrolesleftroleidcomparedefaultrightroleid"></a>

## [**DomainOrgRoleDifference**](DomainOrgRoleDifference.html) GetRolesLeftroleIdComparedefaultRightroleId (string leftRoleId, string rightRoleId)

Get an org role to default role comparison comparison

Compares any organization role to a default role id and show differences

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRolesLeftroleIdComparedefaultRightroleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var leftRoleId = leftRoleId_example;  // string | Left Role ID
            var rightRoleId = rightRoleId_example;  // string | Right Role id

            try
            {
                // Get an org role to default role comparison comparison
                DomainOrgRoleDifference result = apiInstance.GetRolesLeftroleIdComparedefaultRightroleId(leftRoleId, rightRoleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetRolesLeftroleIdComparedefaultRightroleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **leftRoleId** | **string**| Left Role ID |  |
| **rightRoleId** | **string**| Right Role id |  |
{: class="table table-striped"}

### Return type

[**DomainOrgRoleDifference**](DomainOrgRoleDifference.html)

<a name="getrolesroleid"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) GetRolesRoleId (string roleId)

Get a single organization role.

Get the organization role specified by its ID.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRolesRoleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID

            try
            {
                // Get a single organization role.
                DomainOrganizationRole result = apiInstance.GetRolesRoleId(roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetRolesRoleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="getuseridroles"></a>

## [**UserAuthorization**](UserAuthorization.html) GetUserIdRoles (string userId)

Returns a listing of roles and permissions for a user.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Returns a listing of roles and permissions for a user.
                UserAuthorization result = apiInstance.GetUserIdRoles(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.GetUserIdRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="patchrolesroleid"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) PatchRolesRoleId (string roleId, DomainOrganizationRole body)

Patch Organization Role for needsUpdate Field

Patch Organization Role for needsUpdate Field

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchRolesRoleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = new DomainOrganizationRole(); // DomainOrganizationRole | Organization role

            try
            {
                // Patch Organization Role for needsUpdate Field
                DomainOrganizationRole result = apiInstance.PatchRolesRoleId(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PatchRolesRoleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.html)| Organization role |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="postroles"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) PostRoles (DomainOrganizationRole body)

Create an organization role.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var body = new DomainOrganizationRole(); // DomainOrganizationRole | Organization role

            try
            {
                // Create an organization role.
                DomainOrganizationRole result = apiInstance.PostRoles(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.html)| Organization role |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="postrolesdefault"></a>

## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) PostRolesDefault (bool? force = null)

Restores all default roles

This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostRolesDefaultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var force = true;  // bool? | Restore default roles (optional)  (default to false)

            try
            {
                // Restores all default roles
                OrganizationRoleEntityListing result = apiInstance.PostRolesDefault(force);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostRolesDefault: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **force** | **bool?**| Restore default roles | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html)

<a name="postrolesleftroleidcomparedefaultrightroleid"></a>

## [**DomainOrgRoleDifference**](DomainOrgRoleDifference.html) PostRolesLeftroleIdComparedefaultRightroleId (string leftRoleId, string rightRoleId, DomainOrganizationRole body)

Get an unsaved org role to default role comparison

Allows users to compare their existing roles in an unsaved state to its default role

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostRolesLeftroleIdComparedefaultRightroleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var leftRoleId = leftRoleId_example;  // string | Left Role ID
            var rightRoleId = rightRoleId_example;  // string | Right Role id
            var body = new DomainOrganizationRole(); // DomainOrganizationRole | Organization role

            try
            {
                // Get an unsaved org role to default role comparison
                DomainOrgRoleDifference result = apiInstance.PostRolesLeftroleIdComparedefaultRightroleId(leftRoleId, rightRoleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PostRolesLeftroleIdComparedefaultRightroleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **leftRoleId** | **string**| Left Role ID |  |
| **rightRoleId** | **string**| Right Role id |  |
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.html)| Organization role |  |
{: class="table table-striped"}

### Return type

[**DomainOrgRoleDifference**](DomainOrgRoleDifference.html)

<a name="putrolesdefault"></a>

## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) PutRolesDefault (List<DomainOrganizationRole> body)

Restore specified default roles



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRolesDefaultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var body = new List<DomainOrganizationRole>(); // List<DomainOrganizationRole> | Organization roles list

            try
            {
                // Restore specified default roles
                OrganizationRoleEntityListing result = apiInstance.PutRolesDefault(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutRolesDefault: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<DomainOrganizationRole>**](DomainOrganizationRole.html)| Organization roles list |  |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html)

<a name="putrolesroleid"></a>

## [**DomainOrganizationRole**](DomainOrganizationRole.html) PutRolesRoleId (string roleId, DomainOrganizationRole body)

Update an organization role.

Update

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRolesRoleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = new DomainOrganizationRole(); // DomainOrganizationRole | Organization role

            try
            {
                // Update an organization role.
                DomainOrganizationRole result = apiInstance.PutRolesRoleId(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutRolesRoleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.html)| Organization role |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.html)

<a name="putrolesroleidusersadd"></a>

## List&lt;string&gt;** PutRolesRoleIdUsersAdd (string roleId, List<string> body)

Sets the users for the role



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRolesRoleIdUsersAddExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = ;  // List<string> | List of user IDs

            try
            {
                // Sets the users for the role
                List&lt;string&gt; result = apiInstance.PutRolesRoleIdUsersAdd(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutRolesRoleIdUsersAdd: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | **List<string>**| List of user IDs |  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="putrolesroleidusersremove"></a>

## List&lt;string&gt;** PutRolesRoleIdUsersRemove (string roleId, List<string> body)

Removes the users from the role



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRolesRoleIdUsersRemoveExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = ;  // List<string> | List of user IDs

            try
            {
                // Removes the users from the role
                List&lt;string&gt; result = apiInstance.PutRolesRoleIdUsersRemove(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutRolesRoleIdUsersRemove: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | **List<string>**| List of user IDs |  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="putuseridroles"></a>

## [**UserAuthorization**](UserAuthorization.html) PutUserIdRoles (string userId, List<string> body)

Sets the user's roles



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserIdRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var userId = userId_example;  // string | User ID
            var body = ;  // List<string> | List of roles

            try
            {
                // Sets the user's roles
                UserAuthorization result = apiInstance.PutUserIdRoles(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.PutUserIdRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | **List<string>**| List of roles |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

