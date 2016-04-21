# ININ.PureCloudApi.Api.RoutingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**RoutingEmailDomainsDomainRoutesGet**](RoutingApi.md#routingemaildomainsdomainroutesget) | **GET** /api/v1/routing/email/domains/{domain}/routes | Get routes |
| [**RoutingEmailDomainsDomainRoutesIdDelete**](RoutingApi.md#routingemaildomainsdomainroutesiddelete) | **DELETE** /api/v1/routing/email/domains/{domain}/routes/{id} | Delete a route |
| [**RoutingEmailDomainsDomainRoutesIdGet**](RoutingApi.md#routingemaildomainsdomainroutesidget) | **GET** /api/v1/routing/email/domains/{domain}/routes/{id} | Get a route |
| [**RoutingEmailDomainsDomainRoutesIdPut**](RoutingApi.md#routingemaildomainsdomainroutesidput) | **PUT** /api/v1/routing/email/domains/{domain}/routes/{id} | Update a route |
| [**RoutingEmailDomainsDomainRoutesPost**](RoutingApi.md#routingemaildomainsdomainroutespost) | **POST** /api/v1/routing/email/domains/{domain}/routes | Create a route |
| [**RoutingEmailDomainsGet**](RoutingApi.md#routingemaildomainsget) | **GET** /api/v1/routing/email/domains | Get domains |
| [**RoutingEmailDomainsIdDelete**](RoutingApi.md#routingemaildomainsiddelete) | **DELETE** /api/v1/routing/email/domains/{id} | Delete a domain |
| [**RoutingEmailDomainsPost**](RoutingApi.md#routingemaildomainspost) | **POST** /api/v1/routing/email/domains | Create a domain |
| [**RoutingEmailSetupGet**](RoutingApi.md#routingemailsetupget) | **GET** /api/v1/routing/email/setup | Get email setup |
| [**RoutingQueuesGet**](RoutingApi.md#routingqueuesget) | **GET** /api/v1/routing/queues | Get list of queues. |
| [**RoutingQueuesPost**](RoutingApi.md#routingqueuespost) | **POST** /api/v1/routing/queues | Create queue |
| [**RoutingQueuesQueueidDelete**](RoutingApi.md#routingqueuesqueueiddelete) | **DELETE** /api/v1/routing/queues/{queueId} | Delete a queue |
| [**RoutingQueuesQueueidGet**](RoutingApi.md#routingqueuesqueueidget) | **GET** /api/v1/routing/queues/{queueId} | Get details about this queue. |
| [**RoutingQueuesQueueidMembersGet**](RoutingApi.md#routingqueuesqueueidmembersget) | **GET** /api/v1/routing/queues/{queueId}/members | Get members in a queue |
| [**RoutingQueuesQueueidMembersMemberidPut**](RoutingApi.md#routingqueuesqueueidmembersmemberidput) | **PUT** /api/v1/routing/queues/{queueId}/members/{memberId} | Join or unjoin a user to the queue. |
| [**RoutingQueuesQueueidPut**](RoutingApi.md#routingqueuesqueueidput) | **PUT** /api/v1/routing/queues/{queueId} | Update a queue |
| [**RoutingQueuesQueueidUsersGet**](RoutingApi.md#routingqueuesqueueidusersget) | **GET** /api/v1/routing/queues/{queueId}/users | Get the members of this queue |
| [**RoutingQueuesQueueidUsersMemberidDelete**](RoutingApi.md#routingqueuesqueueidusersmemberiddelete) | **DELETE** /api/v1/routing/queues/{queueId}/users/{memberId} | Delete queue member |
| [**RoutingQueuesQueueidUsersMemberidPatch**](RoutingApi.md#routingqueuesqueueidusersmemberidpatch) | **PATCH** /api/v1/routing/queues/{queueId}/users/{memberId} | Update the ring number of joined status for a User in a Queue |
| [**RoutingQueuesQueueidUsersPatch**](RoutingApi.md#routingqueuesqueueiduserspatch) | **PATCH** /api/v1/routing/queues/{queueId}/users | Join or unjoin a set of users for a queue |
| [**RoutingQueuesQueueidUsersPost**](RoutingApi.md#routingqueuesqueueiduserspost) | **POST** /api/v1/routing/queues/{queueId}/users | Bulk add or delete up to 100 queue members |
| [**RoutingQueuesQueueidWrapupcodesCodeidDelete**](RoutingApi.md#routingqueuesqueueidwrapupcodescodeiddelete) | **DELETE** /api/v1/routing/queues/{queueId}/wrapupcodes/{codeId} | Delete a wrap-up code from a queue |
| [**RoutingQueuesQueueidWrapupcodesGet**](RoutingApi.md#routingqueuesqueueidwrapupcodesget) | **GET** /api/v1/routing/queues/{queueId}/wrapupcodes | Get the wrap-up codes for a queue |
| [**RoutingQueuesQueueidWrapupcodesPost**](RoutingApi.md#routingqueuesqueueidwrapupcodespost) | **POST** /api/v1/routing/queues/{queueId}/wrapupcodes | Add up to 100 wrap-up codes to a queue |
| [**RoutingSkillsGet**](RoutingApi.md#routingskillsget) | **GET** /api/v1/routing/skills | Get the list of skills. |
| [**RoutingUtilizationDelete**](RoutingApi.md#routingutilizationdelete) | **DELETE** /api/v1/routing/utilization | Delete utilization settings and revert to system defaults. |
| [**RoutingUtilizationGet**](RoutingApi.md#routingutilizationget) | **GET** /api/v1/routing/utilization | Get the utilization settings. |
| [**RoutingUtilizationPut**](RoutingApi.md#routingutilizationput) | **PUT** /api/v1/routing/utilization | Update the utilization settings. |
| [**RoutingWrapupcodesCodeidDelete**](RoutingApi.md#routingwrapupcodescodeiddelete) | **DELETE** /api/v1/routing/wrapupcodes/{codeId} | Delete wrap-up code |
| [**RoutingWrapupcodesCodeidGet**](RoutingApi.md#routingwrapupcodescodeidget) | **GET** /api/v1/routing/wrapupcodes/{codeId} | Get details about this wrap-up code. |
| [**RoutingWrapupcodesCodeidPut**](RoutingApi.md#routingwrapupcodescodeidput) | **PUT** /api/v1/routing/wrapupcodes/{codeId} | Update wrap-up code |
| [**RoutingWrapupcodesGet**](RoutingApi.md#routingwrapupcodesget) | **GET** /api/v1/routing/wrapupcodes | Get list of wrapup codes. |
| [**RoutingWrapupcodesPost**](RoutingApi.md#routingwrapupcodespost) | **POST** /api/v1/routing/wrapupcodes | Create a wrap-up code |
{: class="table table-striped"}

<a name="RoutingEmailDomainsDomainRoutesGet"></a>
## [**InboundRouteEntityListing**](InboundRouteEntityListing.html) RoutingEmailDomainsDomainRoutesGet (string domain)

Get routes



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingEmailDomainsDomainRoutesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domain = domain_example;  // string | email domain

            try
            {
                // Get routes
                InboundRouteEntityListing result = apiInstance.RoutingEmailDomainsDomainRoutesGet(domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingEmailDomainsDomainRoutesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domain** | **string**| email domain |  |
{: class="table table-striped"}

### Return type

[**InboundRouteEntityListing**](InboundRouteEntityListing.md)

<a name="RoutingEmailDomainsDomainRoutesIdDelete"></a>
## string** RoutingEmailDomainsDomainRoutesIdDelete (string domain, string id)

Delete a route



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingEmailDomainsDomainRoutesIdDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domain = domain_example;  // string | email domain
            var id = id_example;  // string | route ID

            try
            {
                // Delete a route
                string result = apiInstance.RoutingEmailDomainsDomainRoutesIdDelete(domain, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingEmailDomainsDomainRoutesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domain** | **string**| email domain |  |
| **id** | **string**| route ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="RoutingEmailDomainsDomainRoutesIdGet"></a>
## [**InboundRoute**](InboundRoute.html) RoutingEmailDomainsDomainRoutesIdGet (string domain, string id)

Get a route



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingEmailDomainsDomainRoutesIdGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domain = domain_example;  // string | email domain
            var id = id_example;  // string | route ID

            try
            {
                // Get a route
                InboundRoute result = apiInstance.RoutingEmailDomainsDomainRoutesIdGet(domain, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingEmailDomainsDomainRoutesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domain** | **string**| email domain |  |
| **id** | **string**| route ID |  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.md)

<a name="RoutingEmailDomainsDomainRoutesIdPut"></a>
## [**InboundRoute**](InboundRoute.html) RoutingEmailDomainsDomainRoutesIdPut (string domain, string id, InboundRoute body = null)

Update a route



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingEmailDomainsDomainRoutesIdPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domain = domain_example;  // string | email domain
            var id = id_example;  // string | route ID
            var body = new InboundRoute(); // InboundRoute | Route (optional) 

            try
            {
                // Update a route
                InboundRoute result = apiInstance.RoutingEmailDomainsDomainRoutesIdPut(domain, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingEmailDomainsDomainRoutesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domain** | **string**| email domain |  |
| **id** | **string**| route ID |  |
| **body** | [**InboundRoute**](InboundRoute.md)| Route | [optional]  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.md)

<a name="RoutingEmailDomainsDomainRoutesPost"></a>
## [**InboundRoute**](InboundRoute.html) RoutingEmailDomainsDomainRoutesPost (string domain, InboundRoute body = null)

Create a route



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingEmailDomainsDomainRoutesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var domain = domain_example;  // string | email domain
            var body = new InboundRoute(); // InboundRoute | Route (optional) 

            try
            {
                // Create a route
                InboundRoute result = apiInstance.RoutingEmailDomainsDomainRoutesPost(domain, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingEmailDomainsDomainRoutesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **domain** | **string**| email domain |  |
| **body** | [**InboundRoute**](InboundRoute.md)| Route | [optional]  |
{: class="table table-striped"}

### Return type

[**InboundRoute**](InboundRoute.md)

<a name="RoutingEmailDomainsGet"></a>
## [**InboundDomainEntityListing**](InboundDomainEntityListing.html) RoutingEmailDomainsGet ()

Get domains



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingEmailDomainsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();

            try
            {
                // Get domains
                InboundDomainEntityListing result = apiInstance.RoutingEmailDomainsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingEmailDomainsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**InboundDomainEntityListing**](InboundDomainEntityListing.md)

<a name="RoutingEmailDomainsIdDelete"></a>
## string** RoutingEmailDomainsIdDelete (string id)

Delete a domain



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingEmailDomainsIdDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var id = id_example;  // string | domain ID

            try
            {
                // Delete a domain
                string result = apiInstance.RoutingEmailDomainsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingEmailDomainsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **string**| domain ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="RoutingEmailDomainsPost"></a>
## [**InboundDomain**](InboundDomain.html) RoutingEmailDomainsPost (InboundDomain body = null)

Create a domain



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingEmailDomainsPostExample
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
                InboundDomain result = apiInstance.RoutingEmailDomainsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingEmailDomainsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**InboundDomain**](InboundDomain.md)| Domain | [optional]  |
{: class="table table-striped"}

### Return type

[**InboundDomain**](InboundDomain.md)

<a name="RoutingEmailSetupGet"></a>
## [**EmailSetup**](EmailSetup.html) RoutingEmailSetupGet ()

Get email setup



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingEmailSetupGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();

            try
            {
                // Get email setup
                EmailSetup result = apiInstance.RoutingEmailSetupGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingEmailSetupGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EmailSetup**](EmailSetup.md)

<a name="RoutingQueuesGet"></a>
## [**QueueEntityListing**](QueueEntityListing.html) RoutingQueuesGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)

Get list of queues.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesGetExample
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
            var name = name_example;  // string | Name (optional) 
            var active = true;  // bool? | Active (optional) 

            try
            {
                // Get list of queues.
                QueueEntityListing result = apiInstance.RoutingQueuesGet(queueId, pageSize, pageNumber, sortBy, name, active);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **name** | **string**| Name | [optional]  |
| **active** | **bool?**| Active | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueEntityListing**](QueueEntityListing.md)

<a name="RoutingQueuesPost"></a>
## [**Queue**](Queue.html) RoutingQueuesPost (string queueId, Queue body = null)

Create queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesPostExample
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
                // Create queue
                Queue result = apiInstance.RoutingQueuesPost(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**Queue**](Queue.md)| Queue | [optional]  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.md)

<a name="RoutingQueuesQueueidDelete"></a>
## string** RoutingQueuesQueueidDelete (string queueId)

Delete a queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID

            try
            {
                // Delete a queue
                string result = apiInstance.RoutingQueuesQueueidDelete(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="RoutingQueuesQueueidGet"></a>
## [**Queue**](Queue.html) RoutingQueuesQueueidGet (string queueId)

Get details about this queue.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidGetExample
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
                Queue result = apiInstance.RoutingQueuesQueueidGet(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.md)

<a name="RoutingQueuesQueueidMembersGet"></a>
## [**QueueMemberEntityListing**](QueueMemberEntityListing.html) RoutingQueuesQueueidMembersGet (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)

Get members in a queue

Get the list of members of a queue

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidMembersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var userId = userId_example;  // string | UserID (optional) 
            var statusId = statusId_example;  // string | Status ID (optional) 
            var joined = true;  // bool? | Joined (optional) 
            var expand = expand_example;  // string | expand (optional) 

            try
            {
                // Get members in a queue
                QueueMemberEntityListing result = apiInstance.RoutingQueuesQueueidMembersGet(queueId, pageSize, pageNumber, userId, statusId, joined, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**|  |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **userId** | **string**| UserID | [optional]  |
| **statusId** | **string**| Status ID | [optional]  |
| **joined** | **bool?**| Joined | [optional]  |
| **expand** | **string**| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueMemberEntityListing**](QueueMemberEntityListing.md)

<a name="RoutingQueuesQueueidMembersMemberidPut"></a>
## [**QueueMember**](QueueMember.html) RoutingQueuesQueueidMembersMemberidPut (string queueId, string memberId, QueueMember body = null)

Join or unjoin a user to the queue.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidMembersMemberidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();
            var queueId = queueId_example;  // string | Queue ID
            var memberId = memberId_example;  // string | Member/User ID
            var body = new QueueMember(); // QueueMember | To join queue ~ \"joined\":true (optional) 

            try
            {
                // Join or unjoin a user to the queue.
                QueueMember result = apiInstance.RoutingQueuesQueueidMembersMemberidPut(queueId, memberId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidMembersMemberidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member/User ID |  |
| **body** | [**QueueMember**](QueueMember.md)| To join queue ~ \&quot;joined\&quot;:true | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueMember**](QueueMember.md)

<a name="RoutingQueuesQueueidPut"></a>
## [**Queue**](Queue.html) RoutingQueuesQueueidPut (string queueId, Queue body = null)

Update a queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidPutExample
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
                Queue result = apiInstance.RoutingQueuesQueueidPut(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**Queue**](Queue.md)| Queue | [optional]  |
{: class="table table-striped"}

### Return type

[**Queue**](Queue.md)

<a name="RoutingQueuesQueueidUsersGet"></a>
## [**QueueMember**](QueueMember.html) RoutingQueuesQueueidUsersGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)

Get the members of this queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidUsersGetExample
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
                QueueMember result = apiInstance.RoutingQueuesQueueidUsersGet(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidUsersGet: " + e.Message );
            }
        }
    }
}
```

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

[**QueueMember**](QueueMember.md)

<a name="RoutingQueuesQueueidUsersMemberidDelete"></a>
## string** RoutingQueuesQueueidUsersMemberidDelete (string queueId, string memberId)

Delete queue member



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidUsersMemberidDeleteExample
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
                string result = apiInstance.RoutingQueuesQueueidUsersMemberidDelete(queueId, memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidUsersMemberidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="RoutingQueuesQueueidUsersMemberidPatch"></a>
## [**QueueMember**](QueueMember.html) RoutingQueuesQueueidUsersMemberidPatch (string queueId, string memberId, QueueMember body = null)

Update the ring number of joined status for a User in a Queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidUsersMemberidPatchExample
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
                QueueMember result = apiInstance.RoutingQueuesQueueidUsersMemberidPatch(queueId, memberId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidUsersMemberidPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**QueueMember**](QueueMember.md)| Queue Member | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueMember**](QueueMember.md)

<a name="RoutingQueuesQueueidUsersPatch"></a>
## [**QueueMember**](QueueMember.html) RoutingQueuesQueueidUsersPatch (string queueId, List<QueueMember> body = null)

Join or unjoin a set of users for a queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidUsersPatchExample
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
                QueueMember result = apiInstance.RoutingQueuesQueueidUsersPatch(queueId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidUsersPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<QueueMember>**](QueueMember.md)| Queue Members | [optional]  |
{: class="table table-striped"}

### Return type

[**QueueMember**](QueueMember.md)

<a name="RoutingQueuesQueueidUsersPost"></a>
## [**QueueMember**](QueueMember.html) RoutingQueuesQueueidUsersPost (string queueId, List<QueueMember> body = null, bool? delete = null)

Bulk add or delete up to 100 queue members



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidUsersPostExample
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
                QueueMember result = apiInstance.RoutingQueuesQueueidUsersPost(queueId, body, delete);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **body** | [**List<QueueMember>**](QueueMember.md)| Queue Members | [optional]  |
| **delete** | **bool?**| True to delete queue members | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**QueueMember**](QueueMember.md)

<a name="RoutingQueuesQueueidWrapupcodesCodeidDelete"></a>
## string** RoutingQueuesQueueidWrapupcodesCodeidDelete (string queueId, string codeId)

Delete a wrap-up code from a queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidWrapupcodesCodeidDeleteExample
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
                string result = apiInstance.RoutingQueuesQueueidWrapupcodesCodeidDelete(queueId, codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidWrapupcodesCodeidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **codeId** | **string**| Code ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="RoutingQueuesQueueidWrapupcodesGet"></a>
## [**WrapupCode**](WrapupCode.html) RoutingQueuesQueueidWrapupcodesGet (string queueId, string codeId)

Get the wrap-up codes for a queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidWrapupcodesGetExample
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
                WrapupCode result = apiInstance.RoutingQueuesQueueidWrapupcodesGet(queueId, codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidWrapupcodesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **codeId** | **string**| Code ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.md)

<a name="RoutingQueuesQueueidWrapupcodesPost"></a>
## [**WrapupCode**](WrapupCode.html) RoutingQueuesQueueidWrapupcodesPost (string queueId, string codeId, List<WrapupCode> body = null)

Add up to 100 wrap-up codes to a queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingQueuesQueueidWrapupcodesPostExample
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
                WrapupCode result = apiInstance.RoutingQueuesQueueidWrapupcodesPost(queueId, codeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingQueuesQueueidWrapupcodesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queueId** | **string**| Queue ID |  |
| **codeId** | **string**| Code ID |  |
| **body** | [**List<WrapupCode>**](WrapupCode.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.md)

<a name="RoutingSkillsGet"></a>
## [**SkillEntityListing**](SkillEntityListing.html) RoutingSkillsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)

Get the list of skills.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingSkillsGetExample
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

            try
            {
                // Get the list of skills.
                SkillEntityListing result = apiInstance.RoutingSkillsGet(pageSize, pageNumber, sortBy, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingSkillsGet: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**SkillEntityListing**](SkillEntityListing.md)

<a name="RoutingUtilizationDelete"></a>
## string** RoutingUtilizationDelete ()

Delete utilization settings and revert to system defaults.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingUtilizationDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();

            try
            {
                // Delete utilization settings and revert to system defaults.
                string result = apiInstance.RoutingUtilizationDelete();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingUtilizationDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**string**

<a name="RoutingUtilizationGet"></a>
## [**Utilization**](Utilization.html) RoutingUtilizationGet ()

Get the utilization settings.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingUtilizationGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RoutingApi();

            try
            {
                // Get the utilization settings.
                Utilization result = apiInstance.RoutingUtilizationGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingUtilizationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Utilization**](Utilization.md)

<a name="RoutingUtilizationPut"></a>
## [**Utilization**](Utilization.html) RoutingUtilizationPut (Utilization body = null)

Update the utilization settings.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingUtilizationPutExample
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
                Utilization result = apiInstance.RoutingUtilizationPut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingUtilizationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Utilization**](Utilization.md)| utilization | [optional]  |
{: class="table table-striped"}

### Return type

[**Utilization**](Utilization.md)

<a name="RoutingWrapupcodesCodeidDelete"></a>
## string** RoutingWrapupcodesCodeidDelete (string codeId)

Delete wrap-up code



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingWrapupcodesCodeidDeleteExample
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
                string result = apiInstance.RoutingWrapupcodesCodeidDelete(codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingWrapupcodesCodeidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="RoutingWrapupcodesCodeidGet"></a>
## [**WrapupCode**](WrapupCode.html) RoutingWrapupcodesCodeidGet (string codeId)

Get details about this wrap-up code.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingWrapupcodesCodeidGetExample
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
                WrapupCode result = apiInstance.RoutingWrapupcodesCodeidGet(codeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingWrapupcodesCodeidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.md)

<a name="RoutingWrapupcodesCodeidPut"></a>
## [**WrapupCode**](WrapupCode.html) RoutingWrapupcodesCodeidPut (string codeId, WrapupCode body = null)

Update wrap-up code



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingWrapupcodesCodeidPutExample
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
                WrapupCode result = apiInstance.RoutingWrapupcodesCodeidPut(codeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingWrapupcodesCodeidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **codeId** | **string**| Wrapup Code ID |  |
| **body** | [**WrapupCode**](WrapupCode.md)| WrapupCode | [optional]  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.md)

<a name="RoutingWrapupcodesGet"></a>
## [**WrapupCodeEntityListing**](WrapupCodeEntityListing.html) RoutingWrapupcodesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null)

Get list of wrapup codes.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingWrapupcodesGetExample
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
                WrapupCodeEntityListing result = apiInstance.RoutingWrapupcodesGet(pageSize, pageNumber, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingWrapupcodesGet: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**WrapupCodeEntityListing**](WrapupCodeEntityListing.md)

<a name="RoutingWrapupcodesPost"></a>
## [**CallableTimeSet**](CallableTimeSet.html) RoutingWrapupcodesPost (WrapupCode body = null)

Create a wrap-up code



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class RoutingWrapupcodesPostExample
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
                CallableTimeSet result = apiInstance.RoutingWrapupcodesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.RoutingWrapupcodesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WrapupCode**](WrapupCode.md)| WrapupCode | [optional]  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.md)

