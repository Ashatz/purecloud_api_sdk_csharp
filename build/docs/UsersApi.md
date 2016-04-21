# ININ.PureCloudApi.Api.UsersApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**UsersGet**](UsersApi.md#usersget) | **GET** /api/v1/users | Get the list of available users. |
| [**UsersMeGet**](UsersApi.md#usersmeget) | **GET** /api/v1/users/me | Get user. |
| [**UsersPost**](UsersApi.md#userspost) | **POST** /api/v1/users | Create a configuration service user. |
| [**UsersUseridCallforwardingGet**](UsersApi.md#usersuseridcallforwardingget) | **GET** /api/v1/users/{userId}/callforwarding | Get a user&#39;s CallForwarding |
| [**UsersUseridCallforwardingPatch**](UsersApi.md#usersuseridcallforwardingpatch) | **PATCH** /api/v1/users/{userId}/callforwarding | Patch a user&#39;s CallForwarding |
| [**UsersUseridCallforwardingPut**](UsersApi.md#usersuseridcallforwardingput) | **PUT** /api/v1/users/{userId}/callforwarding | Update a user&#39;s CallForwarding |
| [**UsersUseridGeolocationsClientidGet**](UsersApi.md#usersuseridgeolocationsclientidget) | **GET** /api/v1/users/{userId}/geolocations/{clientId} | Get a user&#39;s Geolocation |
| [**UsersUseridGeolocationsClientidPatch**](UsersApi.md#usersuseridgeolocationsclientidpatch) | **PATCH** /api/v1/users/{userId}/geolocations/{clientId} | Patch a user&#39;s Geolocation |
| [**UsersUseridGet**](UsersApi.md#usersuseridget) | **GET** /api/v1/users/{userId} | Get user. |
| [**UsersUseridOutofofficeGet**](UsersApi.md#usersuseridoutofofficeget) | **GET** /api/v1/users/{userId}/outofoffice | Get a OutOfOffice |
| [**UsersUseridOutofofficePut**](UsersApi.md#usersuseridoutofofficeput) | **PUT** /api/v1/users/{userId}/outofoffice | Update an OutOfOffice |
| [**UsersUseridPrimarypresencesourceGet**](UsersApi.md#usersuseridprimarypresencesourceget) | **GET** /api/v1/users/{userId}/primarypresencesource | Get a user&#39;s PrimaryUserPresenceSource |
| [**UsersUseridPrimarypresencesourcePut**](UsersApi.md#usersuseridprimarypresencesourceput) | **PUT** /api/v1/users/{userId}/primarypresencesource | Update a user&#39;s PrimaryUserPresenceSource |
| [**UsersUseridPut**](UsersApi.md#usersuseridput) | **PUT** /api/v1/users/{userId} | Set user station |
| [**UsersUseridQueuesGet**](UsersApi.md#usersuseridqueuesget) | **GET** /api/v1/users/{userId}/queues | Get queues for user |
| [**UsersUseridQueuesPatch**](UsersApi.md#usersuseridqueuespatch) | **PATCH** /api/v1/users/{userId}/queues | Join or unjoin a set of queues for a user |
| [**UsersUseridQueuesQueueidPatch**](UsersApi.md#usersuseridqueuesqueueidpatch) | **PATCH** /api/v1/users/{userId}/queues/{queueId} | Join or unjoin a queue for a user |
| [**UsersUseridRolesGet**](UsersApi.md#usersuseridrolesget) | **GET** /api/v1/users/{userId}/roles | List roles for user |
| [**UsersUseridRoutingstatusGet**](UsersApi.md#usersuseridroutingstatusget) | **GET** /api/v1/users/{userId}/routingstatus | Fetch the routing status of a user |
| [**UsersUseridRoutingstatusPut**](UsersApi.md#usersuseridroutingstatusput) | **PUT** /api/v1/users/{userId}/routingstatus | Update the routing status of a user |
| [**UsersUseridSkillsGet**](UsersApi.md#usersuseridskillsget) | **GET** /api/v1/users/{userId}/skills | List skills for user |
{: class="table table-striped"}

<a name="UsersGet"></a>
## [**UsersEntityListing**](UsersEntityListing.html) UsersGet (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortBy = null, string role = null, string name = null, string username = null, List<string> skill = null, List<string> expand = null)

Get the list of available users.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var role = role_example;  // string | Role (optional) 
            var name = name_example;  // string | Name (optional) 
            var username = username_example;  // string | Username (optional) 
            var skill = new List<string>(); // List<string> | Skill (optional) 
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get the list of available users.
                UsersEntityListing result = apiInstance.UsersGet(pageSize, pageNumber, id, sortBy, role, name, username, skill, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGet: " + e.Message );
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
| **id** | [**List<string>**](string.md)| id | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **role** | **string**| Role | [optional]  |
| **name** | **string**| Name | [optional]  |
| **username** | **string**| Username | [optional]  |
| **skill** | [**List<string>**](string.md)| Skill | [optional]  |
| **expand** | [**List<string>**](string.md)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersEntityListing**](UsersEntityListing.md)

<a name="UsersMeGet"></a>
## [**User**](User.html) UsersMeGet (List<string> expand = null)

Get user.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersMeGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get user.
                User result = apiInstance.UsersMeGet(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.md)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**User**](User.md)

<a name="UsersPost"></a>
## [**User**](User.html) UsersPost (User body = null)

Create a configuration service user.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var body = new User(); // User | User (optional) 

            try
            {
                // Create a configuration service user.
                User result = apiInstance.UsersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**User**](User.md)| User | [optional]  |
{: class="table table-striped"}

### Return type

[**User**](User.md)

<a name="UsersUseridCallforwardingGet"></a>
## [**CallForwarding**](CallForwarding.html) UsersUseridCallforwardingGet (string userId)

Get a user's CallForwarding



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridCallforwardingGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Get a user's CallForwarding
                CallForwarding result = apiInstance.UsersUseridCallforwardingGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridCallforwardingGet: " + e.Message );
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

[**CallForwarding**](CallForwarding.md)

<a name="UsersUseridCallforwardingPatch"></a>
## [**CallForwarding**](CallForwarding.html) UsersUseridCallforwardingPatch (string userId, CallForwarding body = null)

Patch a user's CallForwarding



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridCallforwardingPatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new CallForwarding(); // CallForwarding |  (optional) 

            try
            {
                // Patch a user's CallForwarding
                CallForwarding result = apiInstance.UsersUseridCallforwardingPatch(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridCallforwardingPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**CallForwarding**](CallForwarding.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**CallForwarding**](CallForwarding.md)

<a name="UsersUseridCallforwardingPut"></a>
## [**CallForwarding**](CallForwarding.html) UsersUseridCallforwardingPut (string userId, CallForwarding body = null)

Update a user's CallForwarding



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridCallforwardingPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new CallForwarding(); // CallForwarding |  (optional) 

            try
            {
                // Update a user's CallForwarding
                CallForwarding result = apiInstance.UsersUseridCallforwardingPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridCallforwardingPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**CallForwarding**](CallForwarding.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**CallForwarding**](CallForwarding.md)

<a name="UsersUseridGeolocationsClientidGet"></a>
## [**Geolocation**](Geolocation.html) UsersUseridGeolocationsClientidGet (string userId, string clientId)

Get a user's Geolocation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridGeolocationsClientidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | user Id
            var clientId = clientId_example;  // string | client Id

            try
            {
                // Get a user's Geolocation
                Geolocation result = apiInstance.UsersUseridGeolocationsClientidGet(userId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridGeolocationsClientidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.md)

<a name="UsersUseridGeolocationsClientidPatch"></a>
## [**Geolocation**](Geolocation.html) UsersUseridGeolocationsClientidPatch (string userId, string clientId, Geolocation body = null)

Patch a user's Geolocation

The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridGeolocationsClientidPatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | user Id
            var clientId = clientId_example;  // string | client Id
            var body = new Geolocation(); // Geolocation |  (optional) 

            try
            {
                // Patch a user's Geolocation
                Geolocation result = apiInstance.UsersUseridGeolocationsClientidPatch(userId, clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridGeolocationsClientidPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
| **body** | [**Geolocation**](Geolocation.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.md)

<a name="UsersUseridGet"></a>
## [**User**](User.html) UsersUseridGet (string userId, List<string> expand = null)

Get user.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get user.
                User result = apiInstance.UsersUseridGet(userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **expand** | [**List<string>**](string.md)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**User**](User.md)

<a name="UsersUseridOutofofficeGet"></a>
## [**OutOfOffice**](OutOfOffice.html) UsersUseridOutofofficeGet (string userId)

Get a OutOfOffice



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridOutofofficeGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Get a OutOfOffice
                OutOfOffice result = apiInstance.UsersUseridOutofofficeGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridOutofofficeGet: " + e.Message );
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

[**OutOfOffice**](OutOfOffice.md)

<a name="UsersUseridOutofofficePut"></a>
## [**OutOfOffice**](OutOfOffice.html) UsersUseridOutofofficePut (string userId, OutOfOffice body)

Update an OutOfOffice



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridOutofofficePutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new OutOfOffice(); // OutOfOffice | The updated UserPresence

            try
            {
                // Update an OutOfOffice
                OutOfOffice result = apiInstance.UsersUseridOutofofficePut(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridOutofofficePut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**OutOfOffice**](OutOfOffice.md)| The updated UserPresence |  |
{: class="table table-striped"}

### Return type

[**OutOfOffice**](OutOfOffice.md)

<a name="UsersUseridPrimarypresencesourceGet"></a>
## [**PrimaryUserPresenceSource**](PrimaryUserPresenceSource.html) UsersUseridPrimarypresencesourceGet (string userId)

Get a user's PrimaryUserPresenceSource



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridPrimarypresencesourceGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Get a user's PrimaryUserPresenceSource
                PrimaryUserPresenceSource result = apiInstance.UsersUseridPrimarypresencesourceGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridPrimarypresencesourceGet: " + e.Message );
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

[**PrimaryUserPresenceSource**](PrimaryUserPresenceSource.md)

<a name="UsersUseridPrimarypresencesourcePut"></a>
## [**PrimaryUserPresenceSource**](PrimaryUserPresenceSource.html) UsersUseridPrimarypresencesourcePut (string userId, PrimaryUserPresenceSource body = null)

Update a user's PrimaryUserPresenceSource



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridPrimarypresencesourcePutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new PrimaryUserPresenceSource(); // PrimaryUserPresenceSource |  (optional) 

            try
            {
                // Update a user's PrimaryUserPresenceSource
                PrimaryUserPresenceSource result = apiInstance.UsersUseridPrimarypresencesourcePut(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridPrimarypresencesourcePut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**PrimaryUserPresenceSource**](PrimaryUserPresenceSource.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**PrimaryUserPresenceSource**](PrimaryUserPresenceSource.md)

<a name="UsersUseridPut"></a>
## [**User**](User.html) UsersUseridPut (string userId, User body)

Set user station



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new User(); // User | stationUri

            try
            {
                // Set user station
                User result = apiInstance.UsersUseridPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**User**](User.md)| stationUri |  |
{: class="table table-striped"}

### Return type

[**User**](User.md)

<a name="UsersUseridQueuesGet"></a>
## [**UserQueueEntityListing**](UserQueueEntityListing.html) UsersUseridQueuesGet (string userId, int? pageSize = null, int? pageNumber = null)

Get queues for user



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridQueuesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get queues for user
                UserQueueEntityListing result = apiInstance.UsersUseridQueuesGet(userId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridQueuesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing.md)

<a name="UsersUseridQueuesPatch"></a>
## [**UserQueue**](UserQueue.html) UsersUseridQueuesPatch (string userId, List<UserQueue> body = null)

Join or unjoin a set of queues for a user



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridQueuesPatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new List<UserQueue>(); // List<UserQueue> | User Queues (optional) 

            try
            {
                // Join or unjoin a set of queues for a user
                UserQueue result = apiInstance.UsersUseridQueuesPatch(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridQueuesPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserQueue>**](UserQueue.md)| User Queues | [optional]  |
{: class="table table-striped"}

### Return type

[**UserQueue**](UserQueue.md)

<a name="UsersUseridQueuesQueueidPatch"></a>
## [**UserQueue**](UserQueue.html) UsersUseridQueuesQueueidPatch (string queueId, string userId, UserQueue body = null)

Join or unjoin a queue for a user



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridQueuesQueueidPatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var queueId = queueId_example;  // string | Queue ID
            var userId = userId_example;  // string | User ID
            var body = new UserQueue(); // UserQueue | Queue Member (optional) 

            try
            {
                // Join or unjoin a queue for a user
                UserQueue result = apiInstance.UsersUseridQueuesQueueidPatch(queueId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridQueuesQueueidPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **userId** | **string**| User ID |  |
| **body** | [**UserQueue**](UserQueue.md)| Queue Member | [optional]  |
{: class="table table-striped"}

### Return type

[**UserQueue**](UserQueue.md)

<a name="UsersUseridRolesGet"></a>
## [**List&lt;DomainOrganizationRole&gt;**](DomainOrganizationRole.html) UsersUseridRolesGet (string userId)

List roles for user



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridRolesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // List roles for user
                List&lt;DomainOrganizationRole&gt; result = apiInstance.UsersUseridRolesGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridRolesGet: " + e.Message );
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

[**List<DomainOrganizationRole>**](DomainOrganizationRole.md)

<a name="UsersUseridRoutingstatusGet"></a>
## [**RoutingStatus**](RoutingStatus.html) UsersUseridRoutingstatusGet (string userId)

Fetch the routing status of a user



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridRoutingstatusGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Fetch the routing status of a user
                RoutingStatus result = apiInstance.UsersUseridRoutingstatusGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridRoutingstatusGet: " + e.Message );
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

[**RoutingStatus**](RoutingStatus.md)

<a name="UsersUseridRoutingstatusPut"></a>
## [**RoutingStatus**](RoutingStatus.html) UsersUseridRoutingstatusPut (string userId, RoutingStatus body = null)

Update the routing status of a user



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridRoutingstatusPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new RoutingStatus(); // RoutingStatus | Routing Status (optional) 

            try
            {
                // Update the routing status of a user
                RoutingStatus result = apiInstance.UsersUseridRoutingstatusPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridRoutingstatusPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**RoutingStatus**](RoutingStatus.md)| Routing Status | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingStatus**](RoutingStatus.md)

<a name="UsersUseridSkillsGet"></a>
## [**UserSkillEntityListing**](UserSkillEntityListing.html) UsersUseridSkillsGet (string userId)

List skills for user



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridSkillsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // List skills for user
                UserSkillEntityListing result = apiInstance.UsersUseridSkillsGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUseridSkillsGet: " + e.Message );
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

[**UserSkillEntityListing**](UserSkillEntityListing.md)

