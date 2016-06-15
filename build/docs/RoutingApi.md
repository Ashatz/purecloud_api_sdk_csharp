---
title: RoutingApi
---
## ININ.PureCloudApi.Api.RoutingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteEmailDomainsDomainId**](RoutingApi.html#deleteemaildomainsdomainid) | **DELETE** /api/v2/routing/email/domains/{domainId} | Delete a domain |
| [**DeleteEmailDomainsDomainnameRoutesRouteId**](RoutingApi.html#deleteemaildomainsdomainnameroutesrouteid) | **DELETE** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Delete a route |
| [**DeleteQueuesQueueId**](RoutingApi.html#deletequeuesqueueid) | **DELETE** /api/v2/routing/queues/{queueId} | Delete a queue |
| [**DeleteQueuesQueueIdUsersMemberId**](RoutingApi.html#deletequeuesqueueidusersmemberid) | **DELETE** /api/v2/routing/queues/{queueId}/users/{memberId} | Delete queue member |
| [**DeleteQueuesQueueIdWrapupcodesCodeId**](RoutingApi.html#deletequeuesqueueidwrapupcodescodeid) | **DELETE** /api/v2/routing/queues/{queueId}/wrapupcodes/{codeId} | Delete a wrap-up code from a queue |
| [**DeleteSkillsSkillId**](RoutingApi.html#deleteskillsskillid) | **DELETE** /api/v2/routing/skills/{skillId} | Delete Routing Skill |
| [**DeleteUserIdRoutingskillsSkillId**](RoutingApi.html#deleteuseridroutingskillsskillid) | **DELETE** /api/v2/users/{userId}/routingskills/{skillId} | Remove routing skill from user |
| [**DeleteUtilization**](RoutingApi.html#deleteutilization) | **DELETE** /api/v2/routing/utilization | Delete utilization settings and revert to system defaults. |
| [**DeleteWrapupcodesCodeId**](RoutingApi.html#deletewrapupcodescodeid) | **DELETE** /api/v2/routing/wrapupcodes/{codeId} | Delete wrap-up code |
| [**GetEmailDomains**](RoutingApi.html#getemaildomains) | **GET** /api/v2/routing/email/domains | Get domains |
| [**GetEmailDomainsDomainnameRoutes**](RoutingApi.html#getemaildomainsdomainnameroutes) | **GET** /api/v2/routing/email/domains/{domainName}/routes | Get routes |
| [**GetEmailDomainsDomainnameRoutesRouteId**](RoutingApi.html#getemaildomainsdomainnameroutesrouteid) | **GET** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Get a route |
| [**GetEmailSetup**](RoutingApi.html#getemailsetup) | **GET** /api/v2/routing/email/setup | Get email setup |
| [**GetQueues**](RoutingApi.html#getqueues) | **GET** /api/v2/routing/queues | Get list of queues. |
| [**GetQueuesQueueId**](RoutingApi.html#getqueuesqueueid) | **GET** /api/v2/routing/queues/{queueId} | Get details about this queue. |
| [**GetQueuesQueueIdEstimatedwaittime**](RoutingApi.html#getqueuesqueueidestimatedwaittime) | **GET** /api/v2/routing/queues/{queueId}/estimatedwaittime | Get Estimated Wait Time |
| [**GetQueuesQueueIdUsers**](RoutingApi.html#getqueuesqueueidusers) | **GET** /api/v2/routing/queues/{queueId}/users | Get the members of this queue |
| [**GetQueuesQueueIdWrapupcodes**](RoutingApi.html#getqueuesqueueidwrapupcodes) | **GET** /api/v2/routing/queues/{queueId}/wrapupcodes | Get the wrap-up codes for a queue |
| [**GetSkills**](RoutingApi.html#getskills) | **GET** /api/v2/routing/skills | Get the list of routing skills. |
| [**GetSkillsSkillId**](RoutingApi.html#getskillsskillid) | **GET** /api/v2/routing/skills/{skillId} | Get Routing Skill |
| [**GetUserIdRoutingskills**](RoutingApi.html#getuseridroutingskills) | **GET** /api/v2/users/{userId}/routingskills | List routing skills for user |
| [**GetUtilization**](RoutingApi.html#getutilization) | **GET** /api/v2/routing/utilization | Get the utilization settings. |
| [**GetWrapupcodes**](RoutingApi.html#getwrapupcodes) | **GET** /api/v2/routing/wrapupcodes | Get list of wrapup codes. |
| [**GetWrapupcodesCodeId**](RoutingApi.html#getwrapupcodescodeid) | **GET** /api/v2/routing/wrapupcodes/{codeId} | Get details about this wrap-up code. |
| [**PatchQueuesQueueIdUsers**](RoutingApi.html#patchqueuesqueueidusers) | **PATCH** /api/v2/routing/queues/{queueId}/users | Join or unjoin a set of users for a queue |
| [**PatchQueuesQueueIdUsersMemberId**](RoutingApi.html#patchqueuesqueueidusersmemberid) | **PATCH** /api/v2/routing/queues/{queueId}/users/{memberId} | Update the ring number of joined status for a User in a Queue |
| [**PostEmailDomains**](RoutingApi.html#postemaildomains) | **POST** /api/v2/routing/email/domains | Create a domain |
| [**PostEmailDomainsDomainnameRoutes**](RoutingApi.html#postemaildomainsdomainnameroutes) | **POST** /api/v2/routing/email/domains/{domainName}/routes | Create a route |
| [**PostQueues**](RoutingApi.html#postqueues) | **POST** /api/v2/routing/queues | Create queue |
| [**PostQueuesObservationsQuery**](RoutingApi.html#postqueuesobservationsquery) | **POST** /api/v2/analytics/queues/observations/query | Query for queue observations |
| [**PostQueuesQueueIdUsers**](RoutingApi.html#postqueuesqueueidusers) | **POST** /api/v2/routing/queues/{queueId}/users | Bulk add or delete up to 100 queue members |
| [**PostQueuesQueueIdWrapupcodes**](RoutingApi.html#postqueuesqueueidwrapupcodes) | **POST** /api/v2/routing/queues/{queueId}/wrapupcodes | Add up to 100 wrap-up codes to a queue |
| [**PostSkills**](RoutingApi.html#postskills) | **POST** /api/v2/routing/skills | Create Skill |
| [**PostUserIdRoutingskills**](RoutingApi.html#postuseridroutingskills) | **POST** /api/v2/users/{userId}/routingskills | Add routing skill to user |
| [**PostWrapupcodes**](RoutingApi.html#postwrapupcodes) | **POST** /api/v2/routing/wrapupcodes | Create a wrap-up code |
| [**PutEmailDomainsDomainnameRoutesRouteId**](RoutingApi.html#putemaildomainsdomainnameroutesrouteid) | **PUT** /api/v2/routing/email/domains/{domainName}/routes/{routeId} | Update a route |
| [**PutQueuesQueueId**](RoutingApi.html#putqueuesqueueid) | **PUT** /api/v2/routing/queues/{queueId} | Update a queue |
| [**PutUserIdRoutingskillsSkillId**](RoutingApi.html#putuseridroutingskillsskillid) | **PUT** /api/v2/users/{userId}/routingskills/{skillId} | Update routing skill proficiency or state. |
| [**PutUtilization**](RoutingApi.html#pututilization) | **PUT** /api/v2/routing/utilization | Update the utilization settings. |
| [**PutWrapupcodesCodeId**](RoutingApi.html#putwrapupcodescodeid) | **PUT** /api/v2/routing/wrapupcodes/{codeId} | Update wrap-up code |
{: class="table table-striped"}

<a name="deleteemaildomainsdomainid"></a>

## string** DeleteEmailDomainsDomainId (string domainId)

Delete a domain



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteEmailDomainsDomainIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domainId = domainId_example;  // string | domain ID

            try
            {
                // Delete a domain
                string result = apiInstance.DeleteEmailDomainsDomainId(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteEmailDomainsDomainId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainId** | **string**| domain ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleteemaildomainsdomainnameroutesrouteid"></a>

## string** DeleteEmailDomainsDomainnameRoutesRouteId (string domainName, string routeId)

Delete a route



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteEmailDomainsDomainnameRoutesRouteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var routeId = routeId_example;  // string | route ID

            try
            {
                // Delete a route
                string result = apiInstance.DeleteEmailDomainsDomainnameRoutesRouteId(domainName, routeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteEmailDomainsDomainnameRoutesRouteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletequeuesqueueid"></a>

## string** DeleteQueuesQueueId (string queueId, bool? forceDelete = null)

Delete a queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteQueuesQueueIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var forceDelete = true;  // bool? |  (optional) 

            try
            {
                // Delete a queue
                string result = apiInstance.DeleteQueuesQueueId(queueId, forceDelete);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteQueuesQueueId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **forceDelete** | **bool?**|  | [optional]  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletequeuesqueueidusersmemberid"></a>

## string** DeleteQueuesQueueIdUsersMemberId (string queueId, string memberId)

Delete queue member



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteQueuesQueueIdUsersMemberIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID

            try
            {
                // Delete queue member
                string result = apiInstance.DeleteQueuesQueueIdUsersMemberId(queueId, memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteQueuesQueueIdUsersMemberId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletequeuesqueueidwrapupcodescodeid"></a>

## string** DeleteQueuesQueueIdWrapupcodesCodeId (string queueId, string codeId)

Delete a wrap-up code from a queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteQueuesQueueIdWrapupcodesCodeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var codeId = codeId_example;  // string | Code ID

            try
            {
                // Delete a wrap-up code from a queue
                string result = apiInstance.DeleteQueuesQueueIdWrapupcodesCodeId(queueId, codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteQueuesQueueIdWrapupcodesCodeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **codeId** | **string**| Code ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleteskillsskillid"></a>

## string** DeleteSkillsSkillId (string skillId)

Delete Routing Skill



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteSkillsSkillIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var skillId = skillId_example;  // string | Skill ID

            try
            {
                // Delete Routing Skill
                string result = apiInstance.DeleteSkillsSkillId(skillId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteSkillsSkillId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillId** | **string**| Skill ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleteuseridroutingskillsskillid"></a>

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

            var apiInstance = new RoutingApi();
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
                Debug.Print("Exception when calling RoutingApi.DeleteUserIdRoutingskillsSkillId: " + e.Message );
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

<a name="deleteutilization"></a>

## string** DeleteUtilization ()

Delete utilization settings and revert to system defaults.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteUtilizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();

            try
            {
                // Delete utilization settings and revert to system defaults.
                string result = apiInstance.DeleteUtilization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteUtilization: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**string**

<a name="deletewrapupcodescodeid"></a>

## string** DeleteWrapupcodesCodeId (string codeId)

Delete wrap-up code



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteWrapupcodesCodeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var codeId = codeId_example;  // string | Wrapup Code ID

            try
            {
                // Delete wrap-up code
                string result = apiInstance.DeleteWrapupcodesCodeId(codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.DeleteWrapupcodesCodeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getemaildomains"></a>

## [**InboundDomainEntityListing**](InboundDomainEntityListing.html) GetEmailDomains ()

Get domains



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailDomainsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();

            try
            {
                // Get domains
                InboundDomainEntityListing result = apiInstance.GetEmailDomains();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetEmailDomains: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**InboundDomainEntityListing**](InboundDomainEntityListing.html)

<a name="getemaildomainsdomainnameroutes"></a>

## [**InboundRouteEntityListing**](InboundRouteEntityListing.html) GetEmailDomainsDomainnameRoutes (string domainName)

Get routes



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailDomainsDomainnameRoutesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain

            try
            {
                // Get routes
                InboundRouteEntityListing result = apiInstance.GetEmailDomainsDomainnameRoutes(domainName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetEmailDomainsDomainnameRoutes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
{: class="table table-striped"}

### Return type

[**InboundRouteEntityListing**](InboundRouteEntityListing.html)

<a name="getemaildomainsdomainnameroutesrouteid"></a>

## [**InboundRoute**](InboundRoute.html) GetEmailDomainsDomainnameRoutesRouteId (string domainName, string routeId)

Get a route



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailDomainsDomainnameRoutesRouteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var routeId = routeId_example;  // string | route ID

            try
            {
                // Get a route
                InboundRoute result = apiInstance.GetEmailDomainsDomainnameRoutesRouteId(domainName, routeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetEmailDomainsDomainnameRoutesRouteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.html)

<a name="getemailsetup"></a>

## [**EmailSetup**](EmailSetup.html) GetEmailSetup ()

Get email setup



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailSetupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();

            try
            {
                // Get email setup
                EmailSetup result = apiInstance.GetEmailSetup();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetEmailSetup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EmailSetup**](EmailSetup.html)

<a name="getqueues"></a>

## [**QueueEntityListing**](QueueEntityListing.html) GetQueues (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)

Get list of queues.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetQueuesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var name = name_example;  // string | Name (optional) 
            var active = true;  // bool? | Active (optional) 

            try
            {
                // Get list of queues.
                QueueEntityListing result = apiInstance.GetQueues(pageSize, pageNumber, sortBy, name, active);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetQueues: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **name** | **string**| Name | [optional]  |
| **active** | **bool?**| Active | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueEntityListing**](QueueEntityListing.html)

<a name="getqueuesqueueid"></a>

## [**Queue**](Queue.html) GetQueuesQueueId (string queueId)

Get details about this queue.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetQueuesQueueIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID

            try
            {
                // Get details about this queue.
                Queue result = apiInstance.GetQueuesQueueId(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetQueuesQueueId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.html)

<a name="getqueuesqueueidestimatedwaittime"></a>

## [**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions.html) GetQueuesQueueIdEstimatedwaittime (string queueId, string conversationId = null)

Get Estimated Wait Time



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetQueuesQueueIdEstimatedwaittimeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | queueId
            var conversationId = conversationId_example;  // string | conversationId (optional) 

            try
            {
                // Get Estimated Wait Time
                EstimatedWaitTimePredictions result = apiInstance.GetQueuesQueueIdEstimatedwaittime(queueId, conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetQueuesQueueIdEstimatedwaittime: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| queueId |  |
| **conversationId** | **string**| conversationId | [optional]  |
{: class="table table-striped"}

### Return type

[**EstimatedWaitTimePredictions**](EstimatedWaitTimePredictions.html)

<a name="getqueuesqueueidusers"></a>

## [**QueueMember**](QueueMember.html) GetQueuesQueueIdUsers (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)

Get the members of this queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetQueuesQueueIdUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var expand = expand_example;  // string | expand (optional) 
            var directMembers = true;  // bool? | Only get users that are direct members of the queue (optional)  (default to false)

            try
            {
                // Get the members of this queue
                QueueMember result = apiInstance.GetQueuesQueueIdUsers(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetQueuesQueueIdUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **expand** | **string**| expand | [optional]  |
| **directMembers** | **bool?**| Only get users that are direct members of the queue | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**QueueMember**](QueueMember.html)

<a name="getqueuesqueueidwrapupcodes"></a>

## [**WrapupCode**](WrapupCode.html) GetQueuesQueueIdWrapupcodes (string queueId, string codeId)

Get the wrap-up codes for a queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetQueuesQueueIdWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var codeId = codeId_example;  // string | Code ID

            try
            {
                // Get the wrap-up codes for a queue
                WrapupCode result = apiInstance.GetQueuesQueueIdWrapupcodes(queueId, codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetQueuesQueueIdWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **codeId** | **string**| Code ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getskills"></a>

## [**SkillEntityListing**](SkillEntityListing.html) GetSkills (int? pageSize = null, int? pageNumber = null)

Get the list of routing skills.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSkillsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get the list of routing skills.
                SkillEntityListing result = apiInstance.GetSkills(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetSkills: " + e.Message );
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

[**SkillEntityListing**](SkillEntityListing.html)

<a name="getskillsskillid"></a>

## [**RoutingSkill**](RoutingSkill.html) GetSkillsSkillId (string skillId)

Get Routing Skill



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSkillsSkillIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var skillId = skillId_example;  // string | Skill ID

            try
            {
                // Get Routing Skill
                RoutingSkill result = apiInstance.GetSkillsSkillId(skillId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetSkillsSkillId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **skillId** | **string**| Skill ID |  |
{: class="table table-striped"}

### Return type

[**RoutingSkill**](RoutingSkill.html)

<a name="getuseridroutingskills"></a>

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

            var apiInstance = new RoutingApi();
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
                Debug.Print("Exception when calling RoutingApi.GetUserIdRoutingskills: " + e.Message );
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

<a name="getutilization"></a>

## [**Utilization**](Utilization.html) GetUtilization ()

Get the utilization settings.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUtilizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();

            try
            {
                // Get the utilization settings.
                Utilization result = apiInstance.GetUtilization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetUtilization: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Utilization**](Utilization.html)

<a name="getwrapupcodes"></a>

## [**WrapupCodeEntityListing**](WrapupCodeEntityListing.html) GetWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null)

Get list of wrapup codes.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)

            try
            {
                // Get list of wrapup codes.
                WrapupCodeEntityListing result = apiInstance.GetWrapupcodes(pageSize, pageNumber, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetWrapupcodes: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**WrapupCodeEntityListing**](WrapupCodeEntityListing.html)

<a name="getwrapupcodescodeid"></a>

## [**WrapupCode**](WrapupCode.html) GetWrapupcodesCodeId (string codeId)

Get details about this wrap-up code.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetWrapupcodesCodeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var codeId = codeId_example;  // string | Wrapup Code ID

            try
            {
                // Get details about this wrap-up code.
                WrapupCode result = apiInstance.GetWrapupcodesCodeId(codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetWrapupcodesCodeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="patchqueuesqueueidusers"></a>

## [**QueueMember**](QueueMember.html) PatchQueuesQueueIdUsers (string queueId, List<QueueMember> body = null)

Join or unjoin a set of users for a queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchQueuesQueueIdUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<QueueMember>(); // List<QueueMember> | Queue Members (optional) 

            try
            {
                // Join or unjoin a set of users for a queue
                QueueMember result = apiInstance.PatchQueuesQueueIdUsers(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchQueuesQueueIdUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<QueueMember>**](QueueMember.html)| Queue Members | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueMember**](QueueMember.html)

<a name="patchqueuesqueueidusersmemberid"></a>

## [**QueueMember**](QueueMember.html) PatchQueuesQueueIdUsersMemberId (string queueId, string memberId, QueueMember body = null)

Update the ring number of joined status for a User in a Queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchQueuesQueueIdUsersMemberIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member ID
            var body = new QueueMember(); // QueueMember | Queue Member (optional) 

            try
            {
                // Update the ring number of joined status for a User in a Queue
                QueueMember result = apiInstance.PatchQueuesQueueIdUsersMemberId(queueId, memberId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PatchQueuesQueueIdUsersMemberId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**QueueMember**](QueueMember.html)| Queue Member | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueMember**](QueueMember.html)

<a name="postemaildomains"></a>

## [**InboundDomain**](InboundDomain.html) PostEmailDomains (InboundDomain body = null)

Create a domain



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostEmailDomainsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var body = new InboundDomain(); // InboundDomain | Domain (optional) 

            try
            {
                // Create a domain
                InboundDomain result = apiInstance.PostEmailDomains(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostEmailDomains: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**InboundDomain**](InboundDomain.html)| Domain | [optional]  |
{: class="table table-striped"}

### Return type

[**InboundDomain**](InboundDomain.html)

<a name="postemaildomainsdomainnameroutes"></a>

## [**InboundRoute**](InboundRoute.html) PostEmailDomainsDomainnameRoutes (string domainName, InboundRoute body = null)

Create a route



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostEmailDomainsDomainnameRoutesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var body = new InboundRoute(); // InboundRoute | Route (optional) 

            try
            {
                // Create a route
                InboundRoute result = apiInstance.PostEmailDomainsDomainnameRoutes(domainName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostEmailDomainsDomainnameRoutes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **body** | [**InboundRoute**](InboundRoute.html)| Route | [optional]  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.html)

<a name="postqueues"></a>

## [**Queue**](Queue.html) PostQueues (Queue body = null)

Create queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostQueuesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var body = new Queue(); // Queue | Queue (optional) 

            try
            {
                // Create queue
                Queue result = apiInstance.PostQueues(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostQueues: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Queue**](Queue.html)| Queue | [optional]  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.html)

<a name="postqueuesobservationsquery"></a>

## [**ObservationQueryResponse**](ObservationQueryResponse.html) PostQueuesObservationsQuery (ObservationQuery body = null)

Query for queue observations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostQueuesObservationsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var body = new ObservationQuery(); // ObservationQuery | query (optional) 

            try
            {
                // Query for queue observations
                ObservationQueryResponse result = apiInstance.PostQueuesObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostQueuesObservationsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ObservationQuery**](ObservationQuery.html)| query | [optional]  |
{: class="table table-striped"}

### Return type

[**ObservationQueryResponse**](ObservationQueryResponse.html)

<a name="postqueuesqueueidusers"></a>

## [**QueueMember**](QueueMember.html) PostQueuesQueueIdUsers (string queueId, List<QueueMember> body = null, bool? delete = null)

Bulk add or delete up to 100 queue members



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostQueuesQueueIdUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new List<QueueMember>(); // List<QueueMember> | Queue Members (optional) 
            var delete = true;  // bool? | True to delete queue members (optional)  (default to false)

            try
            {
                // Bulk add or delete up to 100 queue members
                QueueMember result = apiInstance.PostQueuesQueueIdUsers(queueId, body, delete);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostQueuesQueueIdUsers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<QueueMember>**](QueueMember.html)| Queue Members | [optional]  |
| **delete** | **bool?**| True to delete queue members | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**QueueMember**](QueueMember.html)

<a name="postqueuesqueueidwrapupcodes"></a>

## [**WrapupCode**](WrapupCode.html) PostQueuesQueueIdWrapupcodes (string queueId, string codeId, List<WrapupCode> body = null)

Add up to 100 wrap-up codes to a queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostQueuesQueueIdWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var codeId = codeId_example;  // string | Code ID
            var body = new List<WrapupCode>(); // List<WrapupCode> |  (optional) 

            try
            {
                // Add up to 100 wrap-up codes to a queue
                WrapupCode result = apiInstance.PostQueuesQueueIdWrapupcodes(queueId, codeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostQueuesQueueIdWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **codeId** | **string**| Code ID |  |
| **body** | [**List<WrapupCode>**](WrapupCode.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="postskills"></a>

## [**RoutingSkill**](RoutingSkill.html) PostSkills (RoutingSkill body = null)

Create Skill



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostSkillsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var body = new RoutingSkill(); // RoutingSkill | Skill (optional) 

            try
            {
                // Create Skill
                RoutingSkill result = apiInstance.PostSkills(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostSkills: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingSkill**](RoutingSkill.html)| Skill | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingSkill**](RoutingSkill.html)

<a name="postuseridroutingskills"></a>

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

            var apiInstance = new RoutingApi();
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
                Debug.Print("Exception when calling RoutingApi.PostUserIdRoutingskills: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**UserRoutingSkill**](UserRoutingSkill.html)| Skill | [optional]  |
{: class="table table-striped"}

### Return type

[**UserRoutingSkill**](UserRoutingSkill.html)

<a name="postwrapupcodes"></a>

## [**CallableTimeSet**](CallableTimeSet.html) PostWrapupcodes (WrapupCode body = null)

Create a wrap-up code



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var body = new WrapupCode(); // WrapupCode | WrapupCode (optional) 

            try
            {
                // Create a wrap-up code
                CallableTimeSet result = apiInstance.PostWrapupcodes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PostWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WrapupCode**](WrapupCode.html)| WrapupCode | [optional]  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="putemaildomainsdomainnameroutesrouteid"></a>

## [**InboundRoute**](InboundRoute.html) PutEmailDomainsDomainnameRoutesRouteId (string domainName, string routeId, InboundRoute body = null)

Update a route



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutEmailDomainsDomainnameRoutesRouteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domainName = domainName_example;  // string | email domain
            var routeId = routeId_example;  // string | route ID
            var body = new InboundRoute(); // InboundRoute | Route (optional) 

            try
            {
                // Update a route
                InboundRoute result = apiInstance.PutEmailDomainsDomainnameRoutesRouteId(domainName, routeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutEmailDomainsDomainnameRoutesRouteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domainName** | **string**| email domain |  |
| **routeId** | **string**| route ID |  |
| **body** | [**InboundRoute**](InboundRoute.html)| Route | [optional]  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.html)

<a name="putqueuesqueueid"></a>

## [**Queue**](Queue.html) PutQueuesQueueId (string queueId, Queue body = null)

Update a queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutQueuesQueueIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var body = new Queue(); // Queue | Queue (optional) 

            try
            {
                // Update a queue
                Queue result = apiInstance.PutQueuesQueueId(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutQueuesQueueId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**Queue**](Queue.html)| Queue | [optional]  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.html)

<a name="putuseridroutingskillsskillid"></a>

## [**UserRoutingSkill**](UserRoutingSkill.html) PutUserIdRoutingskillsSkillId (string userId, string skillId, UserRoutingSkill body = null)

Update routing skill proficiency or state.



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

            var apiInstance = new RoutingApi();
            var userId = userId_example;  // string | User ID
            var skillId = skillId_example;  // string | 
            var body = new UserRoutingSkill(); // UserRoutingSkill | Skill (optional) 

            try
            {
                // Update routing skill proficiency or state.
                UserRoutingSkill result = apiInstance.PutUserIdRoutingskillsSkillId(userId, skillId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutUserIdRoutingskillsSkillId: " + e.Message );
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
| **body** | [**UserRoutingSkill**](UserRoutingSkill.html)| Skill | [optional]  |
{: class="table table-striped"}

### Return type

[**UserRoutingSkill**](UserRoutingSkill.html)

<a name="pututilization"></a>

## [**Utilization**](Utilization.html) PutUtilization (Utilization body = null)

Update the utilization settings.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUtilizationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var body = new Utilization(); // Utilization | utilization (optional) 

            try
            {
                // Update the utilization settings.
                Utilization result = apiInstance.PutUtilization(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutUtilization: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Utilization**](Utilization.html)| utilization | [optional]  |
{: class="table table-striped"}

### Return type

[**Utilization**](Utilization.html)

<a name="putwrapupcodescodeid"></a>

## [**WrapupCode**](WrapupCode.html) PutWrapupcodesCodeId (string codeId, WrapupCode body = null)

Update wrap-up code



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutWrapupcodesCodeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var codeId = codeId_example;  // string | Wrapup Code ID
            var body = new WrapupCode(); // WrapupCode | WrapupCode (optional) 

            try
            {
                // Update wrap-up code
                WrapupCode result = apiInstance.PutWrapupcodesCodeId(codeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.PutWrapupcodesCodeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
| **body** | [**WrapupCode**](WrapupCode.html)| WrapupCode | [optional]  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)
