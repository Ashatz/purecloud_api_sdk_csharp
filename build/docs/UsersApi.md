---
title: UsersApi
---
## ININ.PureCloudApi.Api.UsersApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**DeleteUserId**](UsersApi.html#deleteuserid) | Delete user |
| [**DeleteUserIdRoles**](UsersApi.html#deleteuseridroles) | Removes all the roles from the user. |
| [**DeleteUserIdRoutingskillsSkillId**](UsersApi.html#deleteuseridroutingskillsskillid) | Remove routing skill from user |
| [**DeleteUserIdStationAssociatedstation**](UsersApi.html#deleteuseridstationassociatedstation) | Clear associated station |
| [**DeleteUserIdStationDefaultstation**](UsersApi.html#deleteuseridstationdefaultstation) | Clear default station |
| [**GetFieldconfig**](UsersApi.html#getfieldconfig) | Fetch field config for an entity type |
| [**GetMe**](UsersApi.html#getme) | Get current user details. |
| [**GetSearch**](UsersApi.html#getsearch) | Search users using the q64 value returned from a previous search |
| [**GetUserId**](UsersApi.html#getuserid) | Get user. |
| [**GetUserIdAdjacents**](UsersApi.html#getuseridadjacents) | Get adjacents |
| [**GetUserIdCallforwarding**](UsersApi.html#getuseridcallforwarding) | Get a user&#39;s CallForwarding |
| [**GetUserIdDirectreports**](UsersApi.html#getuseriddirectreports) | Get direct reports |
| [**GetUserIdFavorites**](UsersApi.html#getuseridfavorites) | Get favorites |
| [**GetUserIdGeolocationsClientId**](UsersApi.html#getuseridgeolocationsclientid) | Get a user&#39;s Geolocation |
| [**GetUserIdOutofoffice**](UsersApi.html#getuseridoutofoffice) | Get a OutOfOffice |
| [**GetUserIdProfileskills**](UsersApi.html#getuseridprofileskills) | List profile skills for a user |
| [**GetUserIdQueues**](UsersApi.html#getuseridqueues) | Get queues for user |
| [**GetUserIdRoles**](UsersApi.html#getuseridroles) | Returns a listing of roles and permissions for a user. |
| [**GetUserIdRoutingskills**](UsersApi.html#getuseridroutingskills) | List routing skills for user |
| [**GetUserIdRoutingstatus**](UsersApi.html#getuseridroutingstatus) | Fetch the routing status of a user |
| [**GetUserIdStation**](UsersApi.html#getuseridstation) | Get station information for user |
| [**GetUserIdSuperiors**](UsersApi.html#getuseridsuperiors) | Get superiors |
| [**GetUsers**](UsersApi.html#getusers) | Get the list of available users. |
| [**PatchUserId**](UsersApi.html#patchuserid) | Update user |
| [**PatchUserIdCallforwarding**](UsersApi.html#patchuseridcallforwarding) | Patch a user&#39;s CallForwarding |
| [**PatchUserIdGeolocationsClientId**](UsersApi.html#patchuseridgeolocationsclientid) | Patch a user&#39;s Geolocation |
| [**PatchUserIdQueues**](UsersApi.html#patchuseridqueues) | Join or unjoin a set of queues for a user |
| [**PatchUserIdQueuesQueueId**](UsersApi.html#patchuseridqueuesqueueid) | Join or unjoin a queue for a user |
| [**PostSearch**](UsersApi.html#postsearch) | Search users |
| [**PostUserIdRoutingskills**](UsersApi.html#postuseridroutingskills) | Add routing skill to user |
| [**PostUsers**](UsersApi.html#postusers) | Create user |
| [**PostUsersAggregatesQuery**](UsersApi.html#postusersaggregatesquery) | Query for user aggregates |
| [**PostUsersDetailsQuery**](UsersApi.html#postusersdetailsquery) | Query for user details |
| [**PostUsersObservationsQuery**](UsersApi.html#postusersobservationsquery) | Query for user observations |
| [**PutUserIdCallforwarding**](UsersApi.html#putuseridcallforwarding) | Update a user&#39;s CallForwarding |
| [**PutUserIdOutofoffice**](UsersApi.html#putuseridoutofoffice) | Update an OutOfOffice |
| [**PutUserIdProfileskills**](UsersApi.html#putuseridprofileskills) | Update profile skills for a user |
| [**PutUserIdRoles**](UsersApi.html#putuseridroles) | Sets the user&#39;s roles |
| [**PutUserIdRoutingskillsSkillId**](UsersApi.html#putuseridroutingskillsskillid) | Update routing skill proficiency or state. |
| [**PutUserIdRoutingstatus**](UsersApi.html#putuseridroutingstatus) | Update the routing status of a user |
| [**PutUserIdStationAssociatedstationStationId**](UsersApi.html#putuseridstationassociatedstationstationid) | Set associated station |
| [**PutUserIdStationDefaultstationStationId**](UsersApi.html#putuseridstationdefaultstationstationid) | Set default station |
{: class="table table-striped"}

<a name="deleteuserid"></a>

## **string** DeleteUserId (string userId)

Delete user



Wraps DELETE /api/v2/users/{userId} 

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

<a name="deleteuseridroles"></a>

## void DeleteUserIdRoles (string userId)

Removes all the roles from the user.



Wraps DELETE /api/v2/users/{userId}/roles 

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

<a name="deleteuseridroutingskillsskillid"></a>

## **string** DeleteUserIdRoutingskillsSkillId (string userId, string skillId)

Remove routing skill from user



Wraps DELETE /api/v2/users/{userId}/routingskills/{skillId} 

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
            var skillId = skillId_example;  // string | skillId

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
| **skillId** | **string**| skillId |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleteuseridstationassociatedstation"></a>

## void DeleteUserIdStationAssociatedstation (string userId)

Clear associated station



Wraps DELETE /api/v2/users/{userId}/station/associatedstation 

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

<a name="deleteuseridstationdefaultstation"></a>

## void DeleteUserIdStationDefaultstation (string userId)

Clear default station



Wraps DELETE /api/v2/users/{userId}/station/defaultstation 

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

            var apiInstance = new UsersApi();
            var type = type_example;  // string | Field type

            try
            {
                // Fetch field config for an entity type
                FieldConfig result = apiInstance.GetFieldconfig(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetFieldconfig: " + e.Message );
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

<a name="getme"></a>

## [**UserMe**](UserMe.html) GetMe (List<string> expand = null)

Get current user details.

This request is not valid when using the Client Credentials OAuth grant.

Wraps GET /api/v2/users/me 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand. (optional) 

            try
            {
                // Get current user details.
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand. | [optional]  |
{: class="table table-striped"}

### Return type

[**UserMe**](UserMe.html)

<a name="getsearch"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) GetSearch (string q64, List<string> expand = null)

Search users using the q64 value returned from a previous search



Wraps GET /api/v2/users/search 

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
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            {
                // Search users using the q64 value returned from a previous search
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
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="getuserid"></a>

## [**User**](User.html) GetUserId (string userId, List<string> expand = null)

Get user.



Wraps GET /api/v2/users/{userId} 

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
                // Get user.
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**User**](User.html)

<a name="getuseridadjacents"></a>

## [**Adjacents**](Adjacents.html) GetUserIdAdjacents (string userId, List<string> expand = null)

Get adjacents



Wraps GET /api/v2/users/{userId}/adjacents 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdAdjacentsExample
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
                // Get adjacents
                Adjacents result = apiInstance.GetUserIdAdjacents(userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdAdjacents: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**Adjacents**](Adjacents.html)

<a name="getuseridcallforwarding"></a>

## [**CallForwarding**](CallForwarding.html) GetUserIdCallforwarding (string userId)

Get a user's CallForwarding



Wraps GET /api/v2/users/{userId}/callforwarding 

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

[**CallForwarding**](CallForwarding.html)

<a name="getuseriddirectreports"></a>

## [**List&lt;User&gt;**](User.html) GetUserIdDirectreports (string userId, List<string> expand = null)

Get direct reports



Wraps GET /api/v2/users/{userId}/directreports 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdDirectreportsExample
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
                // Get direct reports
                List&lt;User&gt; result = apiInstance.GetUserIdDirectreports(userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdDirectreports: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**List<User>**](User.html)

<a name="getuseridfavorites"></a>

## [**UserEntityListing**](UserEntityListing.html) GetUserIdFavorites (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, List<string> expand = null)

Get favorites



Wraps GET /api/v2/users/{userId}/favorites 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdFavoritesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get favorites
                UserEntityListing result = apiInstance.GetUserIdFavorites(userId, pageSize, pageNumber, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdFavorites: " + e.Message );
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
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="getuseridgeolocationsclientid"></a>

## [**Geolocation**](Geolocation.html) GetUserIdGeolocationsClientId (string userId, string clientId)

Get a user's Geolocation



Wraps GET /api/v2/users/{userId}/geolocations/{clientId} 

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

[**Geolocation**](Geolocation.html)

<a name="getuseridoutofoffice"></a>

## [**OutOfOffice**](OutOfOffice.html) GetUserIdOutofoffice (string userId)

Get a OutOfOffice



Wraps GET /api/v2/users/{userId}/outofoffice 

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

[**OutOfOffice**](OutOfOffice.html)

<a name="getuseridprofileskills"></a>

## **List&lt;string&gt;** GetUserIdProfileskills (string userId)

List profile skills for a user



Wraps GET /api/v2/users/{userId}/profileskills 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdProfileskillsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // List profile skills for a user
                List&lt;string&gt; result = apiInstance.GetUserIdProfileskills(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdProfileskills: " + e.Message );
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

**List<string>**

<a name="getuseridqueues"></a>

## [**UserQueueEntityListing**](UserQueueEntityListing.html) GetUserIdQueues (string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null)

Get queues for user



Wraps GET /api/v2/users/{userId}/queues 

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
            var joined = true;  // bool? | Is joined to the queue (optional)  (default to true)

            try
            {
                // Get queues for user
                UserQueueEntityListing result = apiInstance.GetUserIdQueues(userId, pageSize, pageNumber, joined);
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
| **joined** | **bool?**| Is joined to the queue | [optional] [default to true] |
{: class="table table-striped"}

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing.html)

<a name="getuseridroles"></a>

## [**UserAuthorization**](UserAuthorization.html) GetUserIdRoles (string userId)

Returns a listing of roles and permissions for a user.



Wraps GET /api/v2/users/{userId}/roles 

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

[**UserAuthorization**](UserAuthorization.html)

<a name="getuseridroutingskills"></a>

## [**UserSkillEntityListing**](UserSkillEntityListing.html) GetUserIdRoutingskills (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)

List routing skills for user



Wraps GET /api/v2/users/{userId}/routingskills 

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

[**UserSkillEntityListing**](UserSkillEntityListing.html)

<a name="getuseridroutingstatus"></a>

## [**RoutingStatus**](RoutingStatus.html) GetUserIdRoutingstatus (string userId)

Fetch the routing status of a user



Wraps GET /api/v2/users/{userId}/routingstatus 

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

[**RoutingStatus**](RoutingStatus.html)

<a name="getuseridstation"></a>

## [**UserStations**](UserStations.html) GetUserIdStation (string userId)

Get station information for user



Wraps GET /api/v2/users/{userId}/station 

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

[**UserStations**](UserStations.html)

<a name="getuseridsuperiors"></a>

## [**List&lt;User&gt;**](User.html) GetUserIdSuperiors (string userId, List<string> expand = null)

Get superiors



Wraps GET /api/v2/users/{userId}/superiors 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserIdSuperiorsExample
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
                // Get superiors
                List&lt;User&gt; result = apiInstance.GetUserIdSuperiors(userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserIdSuperiors: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**List<User>**](User.html)

<a name="getusers"></a>

## [**UserEntityListing**](UserEntityListing.html) GetUsers (int? pageSize = null, int? pageNumber = null, List<string> id = null, string sortOrder = null, List<string> expand = null)

Get the list of available users.



Wraps GET /api/v2/users 

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
            var id = new List<string>(); // List<string> | id (optional) 
            var sortOrder = sortOrder_example;  // string | Ascending or descending sort order (optional)  (default to ASC)
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get the list of available users.
                UserEntityListing result = apiInstance.GetUsers(pageSize, pageNumber, id, sortOrder, expand);
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
| **id** | [**List<string>**](string.html)| id | [optional]  |
| **sortOrder** | **string**| Ascending or descending sort order | [optional] [default to ASC] |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserEntityListing**](UserEntityListing.html)

<a name="patchuserid"></a>

## [**User**](User.html) PatchUserId (string userId, User body)

Update user



Wraps PATCH /api/v2/users/{userId} 

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
            var body = new User(); // User | User

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
| **body** | [**User**](User.html)| User |  |
{: class="table table-striped"}

### Return type

[**User**](User.html)

<a name="patchuseridcallforwarding"></a>

## [**CallForwarding**](CallForwarding.html) PatchUserIdCallforwarding (string userId, CallForwarding body)

Patch a user's CallForwarding



Wraps PATCH /api/v2/users/{userId}/callforwarding 

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
            var body = new CallForwarding(); // CallForwarding | Call forwarding

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
| **body** | [**CallForwarding**](CallForwarding.html)| Call forwarding |  |
{: class="table table-striped"}

### Return type

[**CallForwarding**](CallForwarding.html)

<a name="patchuseridgeolocationsclientid"></a>

## [**Geolocation**](Geolocation.html) PatchUserIdGeolocationsClientId (string userId, string clientId, Geolocation body)

Patch a user's Geolocation

The geolocation object can be patched one of three ways. Option 1: Set the 'primary' property to true. This will set the client as the user's primary geolocation source.  Option 2: Provide the 'latitude' and 'longitude' values.  This will enqueue an asynchronous update of the 'city', 'region', and 'country', generating a notification. A subsequent GET operation will include the new values for 'city', 'region' and 'country'.  Option 3:  Provide the 'city', 'region', 'country' values.  Option 1 can be combined with Option 2 or Option 3.  For example, update the client as primary and provide latitude and longitude values.

Wraps PATCH /api/v2/users/{userId}/geolocations/{clientId} 

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
            var body = new Geolocation(); // Geolocation | Geolocation

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
| **body** | [**Geolocation**](Geolocation.html)| Geolocation |  |
{: class="table table-striped"}

### Return type

[**Geolocation**](Geolocation.html)

<a name="patchuseridqueues"></a>

## [**UserQueueEntityListing**](UserQueueEntityListing.html) PatchUserIdQueues (string userId, List<UserQueue> body)

Join or unjoin a set of queues for a user



Wraps PATCH /api/v2/users/{userId}/queues 

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
            var body = new List<UserQueue>(); // List<UserQueue> | User Queues

            try
            {
                // Join or unjoin a set of queues for a user
                UserQueueEntityListing result = apiInstance.PatchUserIdQueues(userId, body);
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
| **body** | [**List<UserQueue>**](UserQueue.html)| User Queues |  |
{: class="table table-striped"}

### Return type

[**UserQueueEntityListing**](UserQueueEntityListing.html)

<a name="patchuseridqueuesqueueid"></a>

## [**UserQueue**](UserQueue.html) PatchUserIdQueuesQueueId (string queueId, string userId, UserQueue body)

Join or unjoin a queue for a user



Wraps PATCH /api/v2/users/{userId}/queues/{queueId} 

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
            var body = new UserQueue(); // UserQueue | Queue Member

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
| **body** | [**UserQueue**](UserQueue.html)| Queue Member |  |
{: class="table table-striped"}

### Return type

[**UserQueue**](UserQueue.html)

<a name="postsearch"></a>

## [**UsersSearchResponse**](UsersSearchResponse.html) PostSearch (UserSearchRequest body)

Search users



Wraps POST /api/v2/users/search 

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
            var body = new UserSearchRequest(); // UserSearchRequest | Search request options

            try
            {
                // Search users
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
| **body** | [**UserSearchRequest**](UserSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**UsersSearchResponse**](UsersSearchResponse.html)

<a name="postuseridroutingskills"></a>

## [**UserRoutingSkill**](UserRoutingSkill.html) PostUserIdRoutingskills (string userId, UserRoutingSkillPost body)

Add routing skill to user



Wraps POST /api/v2/users/{userId}/routingskills 

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
            var body = new UserRoutingSkillPost(); // UserRoutingSkillPost | Skill

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
| **body** | [**UserRoutingSkillPost**](UserRoutingSkillPost.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**UserRoutingSkill**](UserRoutingSkill.html)

<a name="postusers"></a>

## [**User**](User.html) PostUsers (CreateUser body)

Create user



Wraps POST /api/v2/users 

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
            var body = new CreateUser(); // CreateUser | User

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
| **body** | [**CreateUser**](CreateUser.html)| User |  |
{: class="table table-striped"}

### Return type

[**User**](User.html)

<a name="postusersaggregatesquery"></a>

## [**PresenceQueryResponse**](PresenceQueryResponse.html) PostUsersAggregatesQuery (AggregationQuery body)

Query for user aggregates



Wraps POST /api/v2/analytics/users/aggregates/query 

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
            var body = new AggregationQuery(); // AggregationQuery | query

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
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**PresenceQueryResponse**](PresenceQueryResponse.html)

<a name="postusersdetailsquery"></a>

## [**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse.html) PostUsersDetailsQuery (UserDetailsQuery body)

Query for user details



Wraps POST /api/v2/analytics/users/details/query 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostUsersDetailsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var body = new UserDetailsQuery(); // UserDetailsQuery | query

            try
            {
                // Query for user details
                AnalyticsUserDetailsQueryResponse result = apiInstance.PostUsersDetailsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersDetailsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserDetailsQuery**](UserDetailsQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsUserDetailsQueryResponse**](AnalyticsUserDetailsQueryResponse.html)

<a name="postusersobservationsquery"></a>

## [**ObservationQueryResponse**](ObservationQueryResponse.html) PostUsersObservationsQuery (ObservationQuery body)

Query for user observations



Wraps POST /api/v2/analytics/users/observations/query 

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
            var body = new ObservationQuery(); // ObservationQuery | query

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
| **body** | [**ObservationQuery**](ObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**ObservationQueryResponse**](ObservationQueryResponse.html)

<a name="putuseridcallforwarding"></a>

## [**CallForwarding**](CallForwarding.html) PutUserIdCallforwarding (string userId, CallForwarding body)

Update a user's CallForwarding



Wraps PUT /api/v2/users/{userId}/callforwarding 

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
            var body = new CallForwarding(); // CallForwarding | Call forwarding

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
| **body** | [**CallForwarding**](CallForwarding.html)| Call forwarding |  |
{: class="table table-striped"}

### Return type

[**CallForwarding**](CallForwarding.html)

<a name="putuseridoutofoffice"></a>

## [**OutOfOffice**](OutOfOffice.html) PutUserIdOutofoffice (string userId, OutOfOffice body)

Update an OutOfOffice



Wraps PUT /api/v2/users/{userId}/outofoffice 

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
| **body** | [**OutOfOffice**](OutOfOffice.html)| The updated UserPresence |  |
{: class="table table-striped"}

### Return type

[**OutOfOffice**](OutOfOffice.html)

<a name="putuseridprofileskills"></a>

## **List&lt;string&gt;** PutUserIdProfileskills (string userId, List<string> body = null)

Update profile skills for a user



Wraps PUT /api/v2/users/{userId}/profileskills 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserIdProfileskillsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var body = ;  // List<string> | Skills (optional) 

            try
            {
                // Update profile skills for a user
                List&lt;string&gt; result = apiInstance.PutUserIdProfileskills(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserIdProfileskills: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | **List<string>**| Skills | [optional]  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="putuseridroles"></a>

## [**UserAuthorization**](UserAuthorization.html) PutUserIdRoles (string userId, List<string> body)

Sets the user's roles



Wraps PUT /api/v2/users/{userId}/roles 

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
            var body = ;  // List<string> | List of roles

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
| **body** | **List<string>**| List of roles |  |
{: class="table table-striped"}

### Return type

[**UserAuthorization**](UserAuthorization.html)

<a name="putuseridroutingskillsskillid"></a>

## [**UserRoutingSkill**](UserRoutingSkill.html) PutUserIdRoutingskillsSkillId (string userId, string skillId, UserRoutingSkill body)

Update routing skill proficiency or state.



Wraps PUT /api/v2/users/{userId}/routingskills/{skillId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserIdRoutingskillsSkillIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User ID
            var skillId = skillId_example;  // string | skillId
            var body = new UserRoutingSkill(); // UserRoutingSkill | Skill

            try
            {
                // Update routing skill proficiency or state.
                UserRoutingSkill result = apiInstance.PutUserIdRoutingskillsSkillId(userId, skillId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserIdRoutingskillsSkillId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **skillId** | **string**| skillId |  |
| **body** | [**UserRoutingSkill**](UserRoutingSkill.html)| Skill |  |
{: class="table table-striped"}

### Return type

[**UserRoutingSkill**](UserRoutingSkill.html)

<a name="putuseridroutingstatus"></a>

## [**RoutingStatus**](RoutingStatus.html) PutUserIdRoutingstatus (string userId, RoutingStatus body)

Update the routing status of a user



Wraps PUT /api/v2/users/{userId}/routingstatus 

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
            var body = new RoutingStatus(); // RoutingStatus | Routing Status

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
| **body** | [**RoutingStatus**](RoutingStatus.html)| Routing Status |  |
{: class="table table-striped"}

### Return type

[**RoutingStatus**](RoutingStatus.html)

<a name="putuseridstationassociatedstationstationid"></a>

## void PutUserIdStationAssociatedstationStationId (string userId, string stationId)

Set associated station



Wraps PUT /api/v2/users/{userId}/station/associatedstation/{stationId} 

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
            var stationId = stationId_example;  // string | stationId

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
| **stationId** | **string**| stationId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putuseridstationdefaultstationstationid"></a>

## void PutUserIdStationDefaultstationStationId (string userId, string stationId)

Set default station



Wraps PUT /api/v2/users/{userId}/station/defaultstation/{stationId} 

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
            var stationId = stationId_example;  // string | stationId

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
| **stationId** | **string**| stationId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

