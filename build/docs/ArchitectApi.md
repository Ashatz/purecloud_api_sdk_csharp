# ININ.PureCloudApi.Api.ArchitectApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**FlowsDelete**](ArchitectApi.md#flowsdelete) | **DELETE** /api/v1/flows | Batch-delete a list of flows |
| [**FlowsGet**](ArchitectApi.md#flowsget) | **GET** /api/v1/flows | Get a pageable list of flows, filtered by query parameters |
| [**FlowsPost**](ArchitectApi.md#flowspost) | **POST** /api/v1/flows | Create flow |
{: class="table table-striped"}

<a name="FlowsDelete"></a>
## void FlowsDelete (List<string> id, bool? ignoreDependencies = null)

Batch-delete a list of flows

Multiple IDs can be specified, in which case all specified flows will be deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class FlowsDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var id = new List<string>(); // List<string> | List of Flow IDs
            var ignoreDependencies = true;  // bool? | Ignore Dependencies (optional)  (default to false)

            try
            {
                // Batch-delete a list of flows
                apiInstance.FlowsDelete(id, ignoreDependencies);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.FlowsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | [**List<string>**](string.md)| List of Flow IDs |  |
| **ignoreDependencies** | **bool?**| Ignore Dependencies | [optional] [default to false] |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="FlowsGet"></a>
## [**FlowEntityListing**](FlowEntityListing.html) FlowsGet (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null)

Get a pageable list of flows, filtered by query parameters

Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class FlowsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var type = type_example;  // string | Type (optional) 
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to id)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to asc)
            var id = new List<string>(); // List<string> | ID (optional) 
            var name = name_example;  // string | Name (optional) 
            var description = description_example;  // string | Description (optional) 
            var nameOrDescription = nameOrDescription_example;  // string | Name or description (optional) 
            var publishVersionId = publishVersionId_example;  // string | Publish version ID (optional) 
            var lockedBy = lockedBy_example;  // string | Locked by (optional) 

            try
            {
                // Get a pageable list of flows, filtered by query parameters
                FlowEntityListing result = apiInstance.FlowsGet(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, lockedBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.FlowsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**| Type | [optional]  |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Sort by | [optional] [default to id] |
| **sortOrder** | **string**| Sort order | [optional] [default to asc] |
| **id** | [**List<string>**](string.md)| ID | [optional]  |
| **name** | **string**| Name | [optional]  |
| **description** | **string**| Description | [optional]  |
| **nameOrDescription** | **string**| Name or description | [optional]  |
| **publishVersionId** | **string**| Publish version ID | [optional]  |
| **lockedBy** | **string**| Locked by | [optional]  |
{: class="table table-striped"}

### Return type

[**FlowEntityListing**](FlowEntityListing.md)

<a name="FlowsPost"></a>
## [**Flow**](Flow.html) FlowsPost (Flow body = null)

Create flow



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class FlowsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ArchitectApi();
            var body = new Flow(); // Flow |  (optional) 

            try
            {
                // Create flow
                Flow result = apiInstance.FlowsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchitectApi.FlowsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Flow**](Flow.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Flow**](Flow.md)

