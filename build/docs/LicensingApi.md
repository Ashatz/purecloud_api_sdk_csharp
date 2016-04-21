# ININ.PureCloudApi.Api.LicensingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**LicensingLicensesGet**](LicensingApi.md#licensinglicensesget) | **GET** /api/v1/licensing/licenses | Get Licenses required for a set of permissions. |
| [**LicensingOrgassignmentsGet**](LicensingApi.md#licensingorgassignmentsget) | **GET** /api/v1/licensing/orgassignments | Get org license assignments. |
| [**LicensingOrgassignmentsIdGet**](LicensingApi.md#licensingorgassignmentsidget) | **GET** /api/v1/licensing/orgassignments/{id} | Get org license assignment. |
| [**LicensingPermissionsGet**](LicensingApi.md#licensingpermissionsget) | **GET** /api/v1/licensing/permissions | Get Licenses required per permission. |
| [**LicensingUserassignmentsGet**](LicensingApi.md#licensinguserassignmentsget) | **GET** /api/v1/licensing/userassignments | Get user license assignments. |
| [**LicensingUserassignmentsIdGet**](LicensingApi.md#licensinguserassignmentsidget) | **GET** /api/v1/licensing/userassignments/{id} | Get user license assignment. |
{: class="table table-striped"}

<a name="LicensingLicensesGet"></a>
## [**List&lt;License&gt;**](License.html) LicensingLicensesGet (List<string> permission = null)

Get Licenses required for a set of permissions.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class LicensingLicensesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LicensingApi();
            var permission = new List<string>(); // List<string> | Permission (optional) 

            try
            {
                // Get Licenses required for a set of permissions.
                List&lt;License&gt; result = apiInstance.LicensingLicensesGet(permission);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensingApi.LicensingLicensesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **permission** | [**List<string>**](string.md)| Permission | [optional]  |
{: class="table table-striped"}

### Return type

[**List<License>**](License.md)

<a name="LicensingOrgassignmentsGet"></a>
## [**OrgLicenseAssignment**](OrgLicenseAssignment.html) LicensingOrgassignmentsGet ()

Get org license assignments.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class LicensingOrgassignmentsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LicensingApi();

            try
            {
                // Get org license assignments.
                OrgLicenseAssignment result = apiInstance.LicensingOrgassignmentsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensingApi.LicensingOrgassignmentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OrgLicenseAssignment**](OrgLicenseAssignment.md)

<a name="LicensingOrgassignmentsIdGet"></a>
## [**OrgLicenseAssignment**](OrgLicenseAssignment.html) LicensingOrgassignmentsIdGet (string id)

Get org license assignment.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class LicensingOrgassignmentsIdGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LicensingApi();
            var id = id_example;  // string | ID

            try
            {
                // Get org license assignment.
                OrgLicenseAssignment result = apiInstance.LicensingOrgassignmentsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensingApi.LicensingOrgassignmentsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| ID |  |
{: class="table table-striped"}

### Return type

[**OrgLicenseAssignment**](OrgLicenseAssignment.md)

<a name="LicensingPermissionsGet"></a>
## [**List&lt;LicensesByPermission&gt;**](LicensesByPermission.html) LicensingPermissionsGet (List<string> id = null)

Get Licenses required per permission.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class LicensingPermissionsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LicensingApi();
            var id = new List<string>(); // List<string> | ID (optional) 

            try
            {
                // Get Licenses required per permission.
                List&lt;LicensesByPermission&gt; result = apiInstance.LicensingPermissionsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensingApi.LicensingPermissionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.md)| ID | [optional]  |
{: class="table table-striped"}

### Return type

[**List<LicensesByPermission>**](LicensesByPermission.md)

<a name="LicensingUserassignmentsGet"></a>
## [**UserLicenseAssignment**](UserLicenseAssignment.html) LicensingUserassignmentsGet ()

Get user license assignments.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class LicensingUserassignmentsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LicensingApi();

            try
            {
                // Get user license assignments.
                UserLicenseAssignment result = apiInstance.LicensingUserassignmentsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensingApi.LicensingUserassignmentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**UserLicenseAssignment**](UserLicenseAssignment.md)

<a name="LicensingUserassignmentsIdGet"></a>
## [**UserLicenseAssignment**](UserLicenseAssignment.html) LicensingUserassignmentsIdGet (string id)

Get user license assignment.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class LicensingUserassignmentsIdGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new LicensingApi();
            var id = id_example;  // string | ID

            try
            {
                // Get user license assignment.
                UserLicenseAssignment result = apiInstance.LicensingUserassignmentsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensingApi.LicensingUserassignmentsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| ID |  |
{: class="table table-striped"}

### Return type

[**UserLicenseAssignment**](UserLicenseAssignment.md)

