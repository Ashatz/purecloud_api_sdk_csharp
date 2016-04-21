# ININ.PureCloudApi.Api.AuthorizationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**AuthorizationLicensesGet**](AuthorizationApi.md#authorizationlicensesget) | **GET** /api/v1/authorization/licenses | Retrieve a list of all licenses defined in the system |
| [**AuthorizationPermissionsGet**](AuthorizationApi.md#authorizationpermissionsget) | **GET** /api/v1/authorization/permissions | Get all permissions. |
| [**AuthorizationProductsGet**](AuthorizationApi.md#authorizationproductsget) | **GET** /api/v1/authorization/products | Get the list of enabled products |
| [**AuthorizationRolesDefaultPost**](AuthorizationApi.md#authorizationrolesdefaultpost) | **POST** /api/v1/authorization/roles/default | Restores all default roles |
| [**AuthorizationRolesDefaultPut**](AuthorizationApi.md#authorizationrolesdefaultput) | **PUT** /api/v1/authorization/roles/default | Restore specified default roles |
| [**AuthorizationRolesGet**](AuthorizationApi.md#authorizationrolesget) | **GET** /api/v1/authorization/roles | Retrieve a list of all roles defined for the organization |
| [**AuthorizationRolesLeftroleidComparedefaultRightroleidGet**](AuthorizationApi.md#authorizationrolesleftroleidcomparedefaultrightroleidget) | **GET** /api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId} | Get an org role to default role comparison comparison |
| [**AuthorizationRolesLeftroleidComparedefaultRightroleidPost**](AuthorizationApi.md#authorizationrolesleftroleidcomparedefaultrightroleidpost) | **POST** /api/v1/authorization/roles/{leftRoleId}/comparedefault/{rightRoleId} |  Get an unsaved org role to default role comparison |
| [**AuthorizationRolesPost**](AuthorizationApi.md#authorizationrolespost) | **POST** /api/v1/authorization/roles | Create an organization role. |
| [**AuthorizationRolesRoleidDelete**](AuthorizationApi.md#authorizationrolesroleiddelete) | **DELETE** /api/v1/authorization/roles/{roleId} | Delete an organization role. |
| [**AuthorizationRolesRoleidGet**](AuthorizationApi.md#authorizationrolesroleidget) | **GET** /api/v1/authorization/roles/{roleId} | Get a single organization role. |
| [**AuthorizationRolesRoleidPatch**](AuthorizationApi.md#authorizationrolesroleidpatch) | **PATCH** /api/v1/authorization/roles/{roleId} | Patch Organization Role for needsUpdate Field |
| [**AuthorizationRolesRoleidPut**](AuthorizationApi.md#authorizationrolesroleidput) | **PUT** /api/v1/authorization/roles/{roleId} | Update an organization role. |
| [**AuthorizationRolesRoleidUsersAddPut**](AuthorizationApi.md#authorizationrolesroleidusersaddput) | **PUT** /api/v1/authorization/roles/{roleId}/users/add | Sets the users for the role |
| [**AuthorizationRolesRoleidUsersRemovePut**](AuthorizationApi.md#authorizationrolesroleidusersremoveput) | **PUT** /api/v1/authorization/roles/{roleId}/users/remove | Removes the users from the role |
| [**AuthorizationUsersUseridRolesDelete**](AuthorizationApi.md#authorizationusersuseridrolesdelete) | **DELETE** /api/v1/authorization/users/{userId}/roles | Removes all the roles from the user. |
| [**AuthorizationUsersUseridRolesGet**](AuthorizationApi.md#authorizationusersuseridrolesget) | **GET** /api/v1/authorization/users/{userId}/roles | Get the list of roles for a user. |
| [**AuthorizationUsersUseridRolesPut**](AuthorizationApi.md#authorizationusersuseridrolesput) | **PUT** /api/v1/authorization/users/{userId}/roles | Sets the user&#39;s roles |
{: class="table table-striped"}

<a name="AuthorizationLicensesGet"></a>
## [**DomainLicenseEntityListing**](DomainLicenseEntityListing.html) AuthorizationLicensesGet (int? pageSize = null, int? pageNumber = null)

Retrieve a list of all licenses defined in the system



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationLicensesGetExample
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
                // Retrieve a list of all licenses defined in the system
                DomainLicenseEntityListing result = apiInstance.AuthorizationLicensesGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationLicensesGet: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**DomainLicenseEntityListing**](DomainLicenseEntityListing.md)

<a name="AuthorizationPermissionsGet"></a>
## [**PermissionCollectionEntityListing**](PermissionCollectionEntityListing.html) AuthorizationPermissionsGet (int? pageSize = null, int? pageNumber = null)

Get all permissions.

Retrieve a list of all permission defined in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationPermissionsGetExample
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
                PermissionCollectionEntityListing result = apiInstance.AuthorizationPermissionsGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationPermissionsGet: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**PermissionCollectionEntityListing**](PermissionCollectionEntityListing.md)

<a name="AuthorizationProductsGet"></a>
## [**OrganizationProductEntityListing**](OrganizationProductEntityListing.html) AuthorizationProductsGet ()

Get the list of enabled products

Gets the list of enabled products. Some example product names are: collaborateFree, collaboratePro, communicate, and engage.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationProductsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();

            try
            {
                // Get the list of enabled products
                OrganizationProductEntityListing result = apiInstance.AuthorizationProductsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationProductsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OrganizationProductEntityListing**](OrganizationProductEntityListing.md)

<a name="AuthorizationRolesDefaultPost"></a>
## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) AuthorizationRolesDefaultPost (bool? force = null)

Restores all default roles

This endpoint serves several purposes. 1. It provides the org with default roles. This is important for default roles that will be added after go-live (they can retroactively add the new default-role). Note: When not using a query param of force=true, it only adds the default roles not configured for the org; it does not overwrite roles. 2. Using the query param force=true, you can restore all default roles. Note: This does not have an effect on custom roles.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesDefaultPostExample
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
                OrganizationRoleEntityListing result = apiInstance.AuthorizationRolesDefaultPost(force);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesDefaultPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **force** | **bool?**| Restore default roles | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.md)

<a name="AuthorizationRolesDefaultPut"></a>
## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) AuthorizationRolesDefaultPut (List<DomainOrganizationRole> body = null)

Restore specified default roles



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesDefaultPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var body = new List<DomainOrganizationRole>(); // List<DomainOrganizationRole> |  (optional) 

            try
            {
                // Restore specified default roles
                OrganizationRoleEntityListing result = apiInstance.AuthorizationRolesDefaultPut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesDefaultPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<DomainOrganizationRole>**](DomainOrganizationRole.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.md)

<a name="AuthorizationRolesGet"></a>
## [**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.html) AuthorizationRolesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, List<string> permission = null, bool? userCount = null)

Retrieve a list of all roles defined for the organization



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesGetExample
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
            var permission = new List<string>(); // List<string> |  (optional) 
            var userCount = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Retrieve a list of all roles defined for the organization
                OrganizationRoleEntityListing result = apiInstance.AuthorizationRolesGet(pageSize, pageNumber, sortBy, expand, permission, userCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **permission** | [**List<string>**](string.md)|  | [optional]  |
| **userCount** | **bool?**|  | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**OrganizationRoleEntityListing**](OrganizationRoleEntityListing.md)

<a name="AuthorizationRolesLeftroleidComparedefaultRightroleidGet"></a>
## [**DomainOrgRoleDifference**](DomainOrgRoleDifference.html) AuthorizationRolesLeftroleidComparedefaultRightroleidGet (string leftRoleId, string rightRoleId)

Get an org role to default role comparison comparison

Compares any organization role to a default role id and show differences

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesLeftroleidComparedefaultRightroleidGetExample
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
                DomainOrgRoleDifference result = apiInstance.AuthorizationRolesLeftroleidComparedefaultRightroleidGet(leftRoleId, rightRoleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesLeftroleidComparedefaultRightroleidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **leftRoleId** | **string**| Left Role ID |  |
| **rightRoleId** | **string**| Right Role id |  |
{: class="table table-striped"}

### Return type

[**DomainOrgRoleDifference**](DomainOrgRoleDifference.md)

<a name="AuthorizationRolesLeftroleidComparedefaultRightroleidPost"></a>
## [**DomainOrgRoleDifference**](DomainOrgRoleDifference.html) AuthorizationRolesLeftroleidComparedefaultRightroleidPost (string leftRoleId, string rightRoleId, DomainOrganizationRole body = null)

 Get an unsaved org role to default role comparison

Allows users to compare their existing roles in an unsaved state to its default role

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesLeftroleidComparedefaultRightroleidPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var leftRoleId = leftRoleId_example;  // string | Left Role ID
            var rightRoleId = rightRoleId_example;  // string | Right Role id
            var body = new DomainOrganizationRole(); // DomainOrganizationRole |  (optional) 

            try
            {
                //  Get an unsaved org role to default role comparison
                DomainOrgRoleDifference result = apiInstance.AuthorizationRolesLeftroleidComparedefaultRightroleidPost(leftRoleId, rightRoleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesLeftroleidComparedefaultRightroleidPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **leftRoleId** | **string**| Left Role ID |  |
| **rightRoleId** | **string**| Right Role id |  |
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainOrgRoleDifference**](DomainOrgRoleDifference.md)

<a name="AuthorizationRolesPost"></a>
## [**DomainOrganizationRole**](DomainOrganizationRole.html) AuthorizationRolesPost (DomainOrganizationRole body = null)

Create an organization role.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var body = new DomainOrganizationRole(); // DomainOrganizationRole |  (optional) 

            try
            {
                // Create an organization role.
                DomainOrganizationRole result = apiInstance.AuthorizationRolesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.md)

<a name="AuthorizationRolesRoleidDelete"></a>
## void AuthorizationRolesRoleidDelete (string roleId)

Delete an organization role.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesRoleidDeleteExample
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
                apiInstance.AuthorizationRolesRoleidDelete(roleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesRoleidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="AuthorizationRolesRoleidGet"></a>
## [**DomainOrganizationRole**](DomainOrganizationRole.html) AuthorizationRolesRoleidGet (string roleId)

Get a single organization role.

Get the organization role specified by its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesRoleidGetExample
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
                DomainOrganizationRole result = apiInstance.AuthorizationRolesRoleidGet(roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesRoleidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.md)

<a name="AuthorizationRolesRoleidPatch"></a>
## [**DomainOrganizationRole**](DomainOrganizationRole.html) AuthorizationRolesRoleidPatch (string roleId, DomainOrganizationRole body = null)

Patch Organization Role for needsUpdate Field

Patch Organization Role for needsUpdate Field

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesRoleidPatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = new DomainOrganizationRole(); // DomainOrganizationRole |  (optional) 

            try
            {
                // Patch Organization Role for needsUpdate Field
                DomainOrganizationRole result = apiInstance.AuthorizationRolesRoleidPatch(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesRoleidPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.md)

<a name="AuthorizationRolesRoleidPut"></a>
## [**DomainOrganizationRole**](DomainOrganizationRole.html) AuthorizationRolesRoleidPut (string roleId, DomainOrganizationRole body = null)

Update an organization role.

Update

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesRoleidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = new DomainOrganizationRole(); // DomainOrganizationRole |  (optional) 

            try
            {
                // Update an organization role.
                DomainOrganizationRole result = apiInstance.AuthorizationRolesRoleidPut(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesRoleidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | [**DomainOrganizationRole**](DomainOrganizationRole.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainOrganizationRole**](DomainOrganizationRole.md)

<a name="AuthorizationRolesRoleidUsersAddPut"></a>
## List&lt;string&gt;** AuthorizationRolesRoleidUsersAddPut (string roleId, List<string> body = null)

Sets the users for the role



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesRoleidUsersAddPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = ;  // List<string> |  (optional) 

            try
            {
                // Sets the users for the role
                List&lt;string&gt; result = apiInstance.AuthorizationRolesRoleidUsersAddPut(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesRoleidUsersAddPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | **List<string>**|  | [optional]  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="AuthorizationRolesRoleidUsersRemovePut"></a>
## List&lt;string&gt;** AuthorizationRolesRoleidUsersRemovePut (string roleId, List<string> body = null)

Removes the users from the role



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationRolesRoleidUsersRemovePutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var roleId = roleId_example;  // string | Role ID
            var body = ;  // List<string> |  (optional) 

            try
            {
                // Removes the users from the role
                List&lt;string&gt; result = apiInstance.AuthorizationRolesRoleidUsersRemovePut(roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationRolesRoleidUsersRemovePut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **roleId** | **string**| Role ID |  |
| **body** | **List<string>**|  | [optional]  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="AuthorizationUsersUseridRolesDelete"></a>
## void AuthorizationUsersUseridRolesDelete (string userId)

Removes all the roles from the user.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationUsersUseridRolesDeleteExample
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
                apiInstance.AuthorizationUsersUseridRolesDelete(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationUsersUseridRolesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="AuthorizationUsersUseridRolesGet"></a>
## [**UserAuthorization**](UserAuthorization.html) AuthorizationUsersUseridRolesGet (string userId)

Get the list of roles for a user.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationUsersUseridRolesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Get the list of roles for a user.
                UserAuthorization result = apiInstance.AuthorizationUsersUseridRolesGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationUsersUseridRolesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.md)

<a name="AuthorizationUsersUseridRolesPut"></a>
## List&lt;string&gt;** AuthorizationUsersUseridRolesPut (string userId, List<string> body = null)

Sets the user's roles



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AuthorizationUsersUseridRolesPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AuthorizationApi();
            var userId = userId_example;  // string | User ID
            var body = ;  // List<string> |  (optional) 

            try
            {
                // Sets the user's roles
                List&lt;string&gt; result = apiInstance.AuthorizationUsersUseridRolesPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizationUsersUseridRolesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | **List<string>**|  | [optional]  |
{: class="table table-striped"}

### Return type

**List<string>**

