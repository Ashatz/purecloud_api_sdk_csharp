# ININ.PureCloudApi.Api.UsersApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteUserId**](UsersApi.md#deleteuserid) | **DELETE** /api/v2/users/{userId} | Delete user |
| [**DeleteUserIdRoles**](UsersApi.md#deleteuseridroles) | **DELETE** /api/v2/users/{userId}/roles | Removes all the roles from the user. |
| [**DeleteUserIdRoutingskillsSkillId**](UsersApi.md#deleteuseridroutingskillsskillid) | **DELETE** /api/v2/users/{userId}/routingskills/{skillId} | Remove routing skill from user |
| [**DeleteUserIdStationAssociatedstation**](UsersApi.md#deleteuseridstationassociatedstation) | **DELETE** /api/v2/users/{userId}/station/associatedstation | Clear associated station |
| [**DeleteUserIdStationDefaultstation**](UsersApi.md#deleteuseridstationdefaultstation) | **DELETE** /api/v2/users/{userId}/station/defaultstation | Clear default station |
| [**GetMe**](UsersApi.md#getme) | **GET** /api/v2/users/me | Get user. |
| [**GetSearch**](UsersApi.md#getsearch) | **GET** /api/v2/users/search | Search using q64 |
| [**GetUserId**](UsersApi.md#getuserid) | **GET** /api/v2/users/{userId} | Get user |
| [**GetUserIdCallforwarding**](UsersApi.md#getuseridcallforwarding) | **GET** /api/v2/users/{userId}/callforwarding | Get a user&#39;s CallForwarding |
| [**GetUserIdGeolocationsClientId**](UsersApi.md#getuseridgeolocationsclientid) | **GET** /api/v2/users/{userId}/geolocations/{clientId} | Get a user&#39;s Geolocation |
| [**GetUserIdOutofoffice**](UsersApi.md#getuseridoutofoffice) | **GET** /api/v2/users/{userId}/outofoffice | Get a OutOfOffice |
| [**GetUserIdPresencesSource**](UsersApi.md#getuseridpresencessource) | **GET** /api/v2/users/{userId}/presences/{source} | Get a user&#39;s Presence |
| [**GetUserIdQueues**](UsersApi.md#getuseridqueues) | **GET** /api/v2/users/{userId}/queues | Get queues for user |
| [**GetUserIdRoles**](UsersApi.md#getuseridroles) | **GET** /api/v2/users/{userId}/roles | Returns a listing of roles and permissions for a user. |
| [**GetUserIdRoutingskills**](UsersApi.md#getuseridroutingskills) | **GET** /api/v2/users/{userId}/routingskills | List routing skills for user |
| [**GetUserIdRoutingstatus**](UsersApi.md#getuseridroutingstatus) | **GET** /api/v2/users/{userId}/routingstatus | Fetch the routing status of a user |
| [**GetUserIdStation**](UsersApi.md#getuseridstation) | **GET** /api/v2/users/{userId}/station | Get station information for user |
| [**GetUsers**](UsersApi.md#getusers) | **GET** /api/v2/users | Get the list of available users. |
| [**PatchUserId**](UsersApi.md#patchuserid) | **PATCH** /api/v2/users/{userId} | Update user |
| [**PatchUserIdCallforwarding**](UsersApi.md#patchuseridcallforwarding) | **PATCH** /api/v2/users/{userId}/callforwarding | Patch a user&#39;s CallForwarding |
| [**PatchUserIdGeolocationsClientId**](UsersApi.md#patchuseridgeolocationsclientid) | **PATCH** /api/v2/users/{userId}/geolocations/{clientId} | Patch a user&#39;s Geolocation |
| [**PatchUserIdPresencesSource**](UsersApi.md#patchuseridpresencessource) | **PATCH** /api/v2/users/{userId}/presences/{source} | Patch a user&#39;s Presence |
| [**PatchUserIdQueues**](UsersApi.md#patchuseridqueues) | **PATCH** /api/v2/users/{userId}/queues | Join or unjoin a set of queues for a user |
| [**PatchUserIdQueuesQueueId**](UsersApi.md#patchuseridqueuesqueueid) | **PATCH** /api/v2/users/{userId}/queues/{queueId} | Join or unjoin a queue for a user |
| [**PostSearch**](UsersApi.md#postsearch) | **POST** /api/v2/users/search | Search |
| [**PostUserIdRoutingskills**](UsersApi.md#postuseridroutingskills) | **POST** /api/v2/users/{userId}/routingskills | Add routing skill to user |
| [**PostUsers**](UsersApi.md#postusers) | **POST** /api/v2/users | Create user |
| [**PostUsersAggregatesQuery**](UsersApi.md#postusersaggregatesquery) | **POST** /api/v2/analytics/users/aggregates/query | Query for user aggregates |
| [**PostUsersObservationsQuery**](UsersApi.md#postusersobservationsquery) | **POST** /api/v2/analytics/users/observations/query | Query for user observations |
| [**PutUserIdCallforwarding**](UsersApi.md#putuseridcallforwarding) | **PUT** /api/v2/users/{userId}/callforwarding | Update a user&#39;s CallForwarding |
| [**PutUserIdOutofoffice**](UsersApi.md#putuseridoutofoffice) | **PUT** /api/v2/users/{userId}/outofoffice | Update an OutOfOffice |
| [**PutUserIdRoles**](UsersApi.md#putuseridroles) | **PUT** /api/v2/users/{userId}/roles | Sets the user&#39;s roles |
| [**PutUserIdRoutingstatus**](UsersApi.md#putuseridroutingstatus) | **PUT** /api/v2/users/{userId}/routingstatus | Update the routing status of a user |
| [**PutUserIdStationAssociatedstationStationId**](UsersApi.md#putuseridstationassociatedstationstationid) | **PUT** /api/v2/users/{userId}/station/associatedstation/{stationId} | Set associated station |
| [**PutUserIdStationDefaultstationStationId**](UsersApi.md#putuseridstationdefaultstationstationid) | **PUT** /api/v2/users/{userId}/station/defaultstation/{stationId} | Set default station |
{: class="table table-striped"}

<a name="DeleteUserId"></a>
## string** DeleteUserId (string userId)

Delete user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteUserIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Delete user
                string result = apiInstance.DeleteUserId(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserId: " + e.Message );
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

**string**

<a name="DeleteUserIdRoles"></a>
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

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Removes all the roles from the user.
                apiInstance.DeleteUserIdRoles(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserIdRoles: " + e.Message );
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

<a name="DeleteUserIdRoutingskillsSkillId"></a>
## string** DeleteUserIdRoutingskillsSkillId (string userId, string skillId)

Remove routing skill from user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteUserIdRoutingskillsSkillIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var skillId = skillId_example;  // string | 

            try
            {
                // Remove routing skill from user
                string result = apiInstance.DeleteUserIdRoutingskillsSkillId(userId, skillId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserIdRoutingskillsSkillId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **skillId** | **string**|  |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteUserIdStationAssociatedstation"></a>
## void DeleteUserIdStationAssociatedstation (string userId)

Clear associated station



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteUserIdStationAssociatedstationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Clear associated station
                apiInstance.DeleteUserIdStationAssociatedstation(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserIdStationAssociatedstation: " + e.Message );
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

<a name="DeleteUserIdStationDefaultstation"></a>
## void DeleteUserIdStationDefaultstation (string userId)

Clear default station



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteUserIdStationDefaultstationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Clear default station
                apiInstance.DeleteUserIdStationDefaultstation(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserIdStationDefaultstation: " + e.Message );
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

<a name="GetMe"></a>
## [**UserMe**](UserMe.html) GetMe (List<string> expand = null)

Get user.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMeExample
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
                UserMe result = apiInstance.GetMe(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetMe: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.md)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserMe**](UserMe.md)

<a name="GetSearch"></a>
## [**UsersSearchResponse**](UsersSearchResponse.html) GetSearch (string q64 = null, List<string> expand = null)

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

            var apiInstance = new UsersApi();
            var q64 = q64_example;  // string |  (optional) 
            var expand = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Search using q64
                UsersSearchResponse result = apiInstance.GetSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**|  | [optional]  |
| **expand** | [**List<string>**](string.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.md)

<a name="GetUserId"></a>
## [**User**](User.html) GetUserId (string userId, List<string> expand = null)

Get user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdExample
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
                // Get user
                User result = apiInstance.GetUserId(userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **expand** | [**List<string>**](string.md)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**User**](User.md)

<a name="GetUserIdCallforwarding"></a>
## [**CallForwarding**](CallForwarding.html) GetUserIdCallforwarding (string userId)

Get a user's CallForwarding



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdCallforwardingExample
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
                CallForwarding result = apiInstance.GetUserIdCallforwarding(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdCallforwarding: " + e.Message );
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

[**CallForwarding**](CallForwarding.md)

<a name="GetUserIdGeolocationsClientId"></a>
## [**Geolocation**](Geolocation.html) GetUserIdGeolocationsClientId (string userId, string clientId)

Get a user's Geolocation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdGeolocationsClientIdExample
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
                Geolocation result = apiInstance.GetUserIdGeolocationsClientId(userId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdGeolocationsClientId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.md)

<a name="GetUserIdOutofoffice"></a>
## [**OutOfOffice**](OutOfOffice.html) GetUserIdOutofoffice (string userId)

Get a OutOfOffice



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdOutofofficeExample
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
                OutOfOffice result = apiInstance.GetUserIdOutofoffice(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdOutofoffice: " + e.Message );
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

[**OutOfOffice**](OutOfOffice.md)

<a name="GetUserIdPresencesSource"></a>
## [**UserPresence**](UserPresence.html) GetUserIdPresencesSource (string userId, string source)

Get a user's Presence



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdPresencesSourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | user Id
            var source = source_example;  // string | source

            try
            {
                // Get a user's Presence
                UserPresence result = apiInstance.GetUserIdPresencesSource(userId, source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdPresencesSource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **source** | **string**| source |  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.md)

<a name="GetUserIdQueues"></a>
## [**UserQueueEntityListing**](UserQueueEntityListing.html) GetUserIdQueues (string userId, int? pageSize = null, int? pageNumber = null)

Get queues for user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdQueuesExample
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
                UserQueueEntityListing result = apiInstance.GetUserIdQueues(userId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdQueues: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing.md)

<a name="GetUserIdRoles"></a>
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

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Returns a listing of roles and permissions for a user.
                UserAuthorization result = apiInstance.GetUserIdRoles(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdRoles: " + e.Message );
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

[**UserAuthorization**](UserAuthorization.md)

<a name="GetUserIdRoutingskills"></a>
## [**UserSkillEntityListing**](UserSkillEntityListing.html) GetUserIdRoutingskills (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)

List routing skills for user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdRoutingskillsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)

            try
            {
                // List routing skills for user
                UserSkillEntityListing result = apiInstance.GetUserIdRoutingskills(userId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdRoutingskills: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC] |
{: class="table table-striped"}

### Return type

[**UserSkillEntityListing**](UserSkillEntityListing.md)

<a name="GetUserIdRoutingstatus"></a>
## [**RoutingStatus**](RoutingStatus.html) GetUserIdRoutingstatus (string userId)

Fetch the routing status of a user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdRoutingstatusExample
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
                RoutingStatus result = apiInstance.GetUserIdRoutingstatus(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdRoutingstatus: " + e.Message );
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

[**RoutingStatus**](RoutingStatus.md)

<a name="GetUserIdStation"></a>
## [**UserStations**](UserStations.html) GetUserIdStation (string userId)

Get station information for user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdStationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Get station information for user
                UserStations result = apiInstance.GetUserIdStation(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdStation: " + e.Message );
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

[**UserStations**](UserStations.md)

<a name="GetUsers"></a>
## [**UsersEntityListing**](UsersEntityListing.html) GetUsers (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null)

Get the list of available users.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var id = new List<string>(); // List<string> | The list of user ids to get. Paging is ignored if ids are specified (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get the list of available users.
                UsersEntityListing result = apiInstance.GetUsers(pageSize, pageNumber, id, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message );
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
| **id** | [**List<string>**](string.md)| The list of user ids to get. Paging is ignored if ids are specified | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC] |
| **expand** | [**List<string>**](string.md)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersEntityListing**](UsersEntityListing.md)

<a name="PatchUserId"></a>
## [**User**](User.html) PatchUserId (string userId, User body = null)

Update user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new User(); // User |  (optional) 

            try
            {
                // Update user
                User result = apiInstance.PatchUserId(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**User**](User.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**User**](User.md)

<a name="PatchUserIdCallforwarding"></a>
## [**CallForwarding**](CallForwarding.html) PatchUserIdCallforwarding (string userId, CallForwarding body = null)

Patch a user's CallForwarding



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserIdCallforwardingExample
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
                CallForwarding result = apiInstance.PatchUserIdCallforwarding(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserIdCallforwarding: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**CallForwarding**](CallForwarding.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**CallForwarding**](CallForwarding.md)

<a name="PatchUserIdGeolocationsClientId"></a>
## [**Geolocation**](Geolocation.html) PatchUserIdGeolocationsClientId (string userId, string clientId, Geolocation body = null)

Patch a user's Geolocation

The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserIdGeolocationsClientIdExample
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
                Geolocation result = apiInstance.PatchUserIdGeolocationsClientId(userId, clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserIdGeolocationsClientId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **clientId** | **string**| client Id |  |
| **body** | [**Geolocation**](Geolocation.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.md)

<a name="PatchUserIdPresencesSource"></a>
## [**UserPresence**](UserPresence.html) PatchUserIdPresencesSource (string userId, string source, UserPresence body = null)

Patch a user's Presence

The presence object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the 'source' defined in the path as the user's primary presence source. Option 2: Provide the presenceDefinition value. Option 3: Provide the message value.  Option 1 can be combined with Option2 and/or Option 3.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserIdPresencesSourceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | user Id
            var source = source_example;  // string | source
            var body = new UserPresence(); // UserPresence |  (optional) 

            try
            {
                // Patch a user's Presence
                UserPresence result = apiInstance.PatchUserIdPresencesSource(userId, source, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserIdPresencesSource: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| user Id |  |
| **source** | **string**| source |  |
| **body** | [**UserPresence**](UserPresence.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**UserPresence**](UserPresence.md)

<a name="PatchUserIdQueues"></a>
## [**UserQueue**](UserQueue.html) PatchUserIdQueues (string userId, List<UserQueue> body = null)

Join or unjoin a set of queues for a user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserIdQueuesExample
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
                UserQueue result = apiInstance.PatchUserIdQueues(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserIdQueues: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**List<UserQueue>**](UserQueue.md)| User Queues | [optional]  |
{: class="table table-striped"}

### Return type

[**UserQueue**](UserQueue.md)

<a name="PatchUserIdQueuesQueueId"></a>
## [**UserQueue**](UserQueue.html) PatchUserIdQueuesQueueId (string queueId, string userId, UserQueue body = null)

Join or unjoin a queue for a user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserIdQueuesQueueIdExample
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
                UserQueue result = apiInstance.PatchUserIdQueuesQueueId(queueId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserIdQueuesQueueId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **userId** | **string**| User ID |  |
| **body** | [**UserQueue**](UserQueue.md)| Queue Member | [optional]  |
{: class="table table-striped"}

### Return type

[**UserQueue**](UserQueue.md)

<a name="PostSearch"></a>
## [**UsersSearchResponse**](UsersSearchResponse.html) PostSearch (SearchRequest body = null)

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

            var apiInstance = new UsersApi();
            var body = new SearchRequest(); // SearchRequest | Search request options (optional) 

            try
            {
                // Search
                UsersSearchResponse result = apiInstance.PostSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SearchRequest**](SearchRequest.md)| Search request options | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.md)

<a name="PostUserIdRoutingskills"></a>
## [**UserRoutingSkill**](UserRoutingSkill.html) PostUserIdRoutingskills (string userId, UserRoutingSkill body = null)

Add routing skill to user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostUserIdRoutingskillsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = new UserRoutingSkill(); // UserRoutingSkill | Skill (optional) 

            try
            {
                // Add routing skill to user
                UserRoutingSkill result = apiInstance.PostUserIdRoutingskills(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUserIdRoutingskills: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UserRoutingSkill**](UserRoutingSkill.md)| Skill | [optional]  |
{: class="table table-striped"}

### Return type

[**UserRoutingSkill**](UserRoutingSkill.md)

<a name="PostUsers"></a>
## [**User**](User.html) PostUsers (CreateUser body = null)

Create user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var body = new CreateUser(); // CreateUser | User (optional) 

            try
            {
                // Create user
                User result = apiInstance.PostUsers(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateUser**](CreateUser.md)| User | [optional]  |
{: class="table table-striped"}

### Return type

[**User**](User.md)

<a name="PostUsersAggregatesQuery"></a>
## [**PresenceQueryResponse**](PresenceQueryResponse.html) PostUsersAggregatesQuery (AggregationQuery body = null)

Query for user aggregates



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostUsersAggregatesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var body = new AggregationQuery(); // AggregationQuery | query (optional) 

            try
            {
                // Query for user aggregates
                PresenceQueryResponse result = apiInstance.PostUsersAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.md)| query | [optional]  |
{: class="table table-striped"}

### Return type

[**PresenceQueryResponse**](PresenceQueryResponse.md)

<a name="PostUsersObservationsQuery"></a>
## [**ObservationQueryResponse**](ObservationQueryResponse.html) PostUsersObservationsQuery (ObservationQuery body = null)

Query for user observations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostUsersObservationsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var body = new ObservationQuery(); // ObservationQuery | query (optional) 

            try
            {
                // Query for user observations
                ObservationQueryResponse result = apiInstance.PostUsersObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersObservationsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ObservationQuery**](ObservationQuery.md)| query | [optional]  |
{: class="table table-striped"}

### Return type

[**ObservationQueryResponse**](ObservationQueryResponse.md)

<a name="PutUserIdCallforwarding"></a>
## [**CallForwarding**](CallForwarding.html) PutUserIdCallforwarding (string userId, CallForwarding body = null)

Update a user's CallForwarding



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserIdCallforwardingExample
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
                CallForwarding result = apiInstance.PutUserIdCallforwarding(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserIdCallforwarding: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**CallForwarding**](CallForwarding.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**CallForwarding**](CallForwarding.md)

<a name="PutUserIdOutofoffice"></a>
## [**OutOfOffice**](OutOfOffice.html) PutUserIdOutofoffice (string userId, OutOfOffice body)

Update an OutOfOffice



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserIdOutofofficeExample
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
                OutOfOffice result = apiInstance.PutUserIdOutofoffice(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserIdOutofoffice: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**OutOfOffice**](OutOfOffice.md)| The updated UserPresence |  |
{: class="table table-striped"}

### Return type

[**OutOfOffice**](OutOfOffice.md)

<a name="PutUserIdRoles"></a>
## [**UserAuthorization**](UserAuthorization.html) PutUserIdRoles (string userId, List<string> body = null)

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

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = ;  // List<string> |  (optional) 

            try
            {
                // Sets the user's roles
                UserAuthorization result = apiInstance.PutUserIdRoles(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserIdRoles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | **List<string>**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.md)

<a name="PutUserIdRoutingstatus"></a>
## [**RoutingStatus**](RoutingStatus.html) PutUserIdRoutingstatus (string userId, RoutingStatus body = null)

Update the routing status of a user



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserIdRoutingstatusExample
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
                RoutingStatus result = apiInstance.PutUserIdRoutingstatus(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserIdRoutingstatus: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**RoutingStatus**](RoutingStatus.md)| Routing Status | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingStatus**](RoutingStatus.md)

<a name="PutUserIdStationAssociatedstationStationId"></a>
## void PutUserIdStationAssociatedstationStationId (string userId, string stationId)

Set associated station



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserIdStationAssociatedstationStationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var stationId = stationId_example;  // string | 

            try
            {
                // Set associated station
                apiInstance.PutUserIdStationAssociatedstationStationId(userId, stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserIdStationAssociatedstationStationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **stationId** | **string**|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PutUserIdStationDefaultstationStationId"></a>
## void PutUserIdStationDefaultstationStationId (string userId, string stationId)

Set default station



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserIdStationDefaultstationStationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var stationId = stationId_example;  // string | 

            try
            {
                // Set default station
                apiInstance.PutUserIdStationDefaultstationStationId(userId, stationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserIdStationDefaultstationStationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **stationId** | **string**|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

