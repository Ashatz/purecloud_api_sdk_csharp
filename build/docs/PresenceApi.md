# ININ.PureCloudApi.Api.PresenceApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PresencedefinitionsGet**](PresenceApi.md#presencedefinitionsget) | **GET** /api/v1/presencedefinitions | Get an Organization&#39;s list of Presences |
| [**PresencedefinitionsPost**](PresenceApi.md#presencedefinitionspost) | **POST** /api/v1/presencedefinitions | Create an OrganizationPresence |
| [**PresencedefinitionsPresenceidDelete**](PresenceApi.md#presencedefinitionspresenceiddelete) | **DELETE** /api/v1/presencedefinitions/{presenceId} | Delete an OrganizationPresence |
| [**PresencedefinitionsPresenceidGet**](PresenceApi.md#presencedefinitionspresenceidget) | **GET** /api/v1/presencedefinitions/{presenceId} | Get an OrganizationPresence |
| [**PresencedefinitionsPresenceidPut**](PresenceApi.md#presencedefinitionspresenceidput) | **PUT** /api/v1/presencedefinitions/{presenceId} | Update an OrganizationPresence |
| [**UsersUseridPresencesGet**](PresenceApi.md#usersuseridpresencesget) | **GET** /api/v1/users/{userId}/presences | Get an User&#39;s list of Presences |
| [**UsersUseridPresencesSourceGet**](PresenceApi.md#usersuseridpresencessourceget) | **GET** /api/v1/users/{userId}/presences/{source} | Get a UserPresence |
| [**UsersUseridPresencesSourcePatch**](PresenceApi.md#usersuseridpresencessourcepatch) | **PATCH** /api/v1/users/{userId}/presences/{source} | Patch a UserPresence |
| [**UsersUseridPresencesSourcePut**](PresenceApi.md#usersuseridpresencessourceput) | **PUT** /api/v1/users/{userId}/presences/{source} | Update a UserPresence |
| [**UsersUseridPrimarypresenceGet**](PresenceApi.md#usersuseridprimarypresenceget) | **GET** /api/v1/users/{userId}/primarypresence | Get a user&#39;s Primary UserPresence |
{: class="table table-striped"}

<a name="PresencedefinitionsGet"></a>
## [**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing.html) PresencedefinitionsGet (int? pageNumber = null, int? pageSize = null)

Get an Organization's list of Presences



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PresencedefinitionsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            {
                // Get an Organization's list of Presences
                OrganizationPresenceEntityListing result = apiInstance.PresencedefinitionsGet(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PresencedefinitionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**OrganizationPresenceEntityListing**](OrganizationPresenceEntityListing.md)

<a name="PresencedefinitionsPost"></a>
## [**OrganizationPresence**](OrganizationPresence.html) PresencedefinitionsPost (OrganizationPresence body)

Create an OrganizationPresence



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PresencedefinitionsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var body = new OrganizationPresence(); // OrganizationPresence | The OrganizationPresence to create

            try
            {
                // Create an OrganizationPresence
                OrganizationPresence result = apiInstance.PresencedefinitionsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PresencedefinitionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OrganizationPresence**](OrganizationPresence.md)| The OrganizationPresence to create |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.md)

<a name="PresencedefinitionsPresenceidDelete"></a>
## [**OrganizationPresence**](OrganizationPresence.html) PresencedefinitionsPresenceidDelete (string presenceId)

Delete an OrganizationPresence



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PresencedefinitionsPresenceidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var presenceId = presenceId_example;  // string | Organization Presence ID

            try
            {
                // Delete an OrganizationPresence
                OrganizationPresence result = apiInstance.PresencedefinitionsPresenceidDelete(presenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PresencedefinitionsPresenceidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.md)

<a name="PresencedefinitionsPresenceidGet"></a>
## [**OrganizationPresence**](OrganizationPresence.html) PresencedefinitionsPresenceidGet (string presenceId)

Get an OrganizationPresence



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PresencedefinitionsPresenceidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var presenceId = presenceId_example;  // string | Organization Presence ID

            try
            {
                // Get an OrganizationPresence
                OrganizationPresence result = apiInstance.PresencedefinitionsPresenceidGet(presenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PresencedefinitionsPresenceidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.md)

<a name="PresencedefinitionsPresenceidPut"></a>
## [**OrganizationPresence**](OrganizationPresence.html) PresencedefinitionsPresenceidPut (string presenceId, OrganizationPresence body)

Update an OrganizationPresence



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PresencedefinitionsPresenceidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var presenceId = presenceId_example;  // string | Organization Presence ID
            var body = new OrganizationPresence(); // OrganizationPresence | The OrganizationPresence to update

            try
            {
                // Update an OrganizationPresence
                OrganizationPresence result = apiInstance.PresencedefinitionsPresenceidPut(presenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.PresencedefinitionsPresenceidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **presenceId** | **string**| Organization Presence ID |  |
| **body** | [**OrganizationPresence**](OrganizationPresence.md)| The OrganizationPresence to update |  |
{: class="table table-striped"}

### Return type

[**OrganizationPresence**](OrganizationPresence.md)

<a name="UsersUseridPresencesGet"></a>
## [**UserPresenceEntityListing**](UserPresenceEntityListing.html) UsersUseridPresencesGet (string userId, int? pageNumber = null, int? pageSize = null)

Get an User's list of Presences



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridPresencesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | User ID
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            {
                // Get an User's list of Presences
                UserPresenceEntityListing result = apiInstance.UsersUseridPresencesGet(userId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.UsersUseridPresencesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**UserPresenceEntityListing**](UserPresenceEntityListing.md)

<a name="UsersUseridPresencesSourceGet"></a>
## [**UserPresence**](UserPresence.html) UsersUseridPresencesSourceGet (string userId, string source)

Get a UserPresence



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridPresencesSourceGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | User ID
            var source = source_example;  // string | Source

            try
            {
                // Get a UserPresence
                UserPresence result = apiInstance.UsersUseridPresencesSourceGet(userId, source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.UsersUseridPresencesSourceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **source** | **string**| Source |  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.md)

<a name="UsersUseridPresencesSourcePatch"></a>
## [**UserPresence**](UserPresence.html) UsersUseridPresencesSourcePatch (string userId, string source, UserPresence body)

Patch a UserPresence



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridPresencesSourcePatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | User ID
            var source = source_example;  // string | Source
            var body = new UserPresence(); // UserPresence | The patched UserPresence

            try
            {
                // Patch a UserPresence
                UserPresence result = apiInstance.UsersUseridPresencesSourcePatch(userId, source, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.UsersUseridPresencesSourcePatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **source** | **string**| Source |  |
| **body** | [**UserPresence**](UserPresence.md)| The patched UserPresence |  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.md)

<a name="UsersUseridPresencesSourcePut"></a>
## [**UserPresence**](UserPresence.html) UsersUseridPresencesSourcePut (string userId, string source, UserPresence body)

Update a UserPresence



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridPresencesSourcePutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | User ID
            var source = source_example;  // string | Source
            var body = new UserPresence(); // UserPresence | The updated UserPresence

            try
            {
                // Update a UserPresence
                UserPresence result = apiInstance.UsersUseridPresencesSourcePut(userId, source, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.UsersUseridPresencesSourcePut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **source** | **string**| Source |  |
| **body** | [**UserPresence**](UserPresence.md)| The updated UserPresence |  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.md)

<a name="UsersUseridPrimarypresenceGet"></a>
## [**UserPresence**](UserPresence.html) UsersUseridPrimarypresenceGet (string userId)

Get a user's Primary UserPresence



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridPrimarypresenceGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PresenceApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Get a user's Primary UserPresence
                UserPresence result = apiInstance.UsersUseridPrimarypresenceGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PresenceApi.UsersUseridPrimarypresenceGet: " + e.Message );
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

[**UserPresence**](UserPresence.md)

