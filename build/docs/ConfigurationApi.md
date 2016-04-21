# ININ.PureCloudApi.Api.ConfigurationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**ConfigurationDidpoolsDidpoolidDelete**](ConfigurationApi.md#configurationdidpoolsdidpooliddelete) | **DELETE** /api/v1/configuration/didpools/{didPoolId} | Delete a DID Pool by ID. |
| [**ConfigurationDidpoolsDidpoolidGet**](ConfigurationApi.md#configurationdidpoolsdidpoolidget) | **GET** /api/v1/configuration/didpools/{didPoolId} | Get a DID Pool by ID. |
| [**ConfigurationDidpoolsDidpoolidPut**](ConfigurationApi.md#configurationdidpoolsdidpoolidput) | **PUT** /api/v1/configuration/didpools/{didPoolId} | Update a DID Pool by ID. |
| [**ConfigurationDidpoolsGet**](ConfigurationApi.md#configurationdidpoolsget) | **GET** /api/v1/configuration/didpools | Get a listing of DID Pools |
| [**ConfigurationDidpoolsPost**](ConfigurationApi.md#configurationdidpoolspost) | **POST** /api/v1/configuration/didpools | Create a new DID pool |
| [**ConfigurationDidsDididGet**](ConfigurationApi.md#configurationdidsdididget) | **GET** /api/v1/configuration/dids/{didId} | Get a DID by ID. |
| [**ConfigurationDidsDididPut**](ConfigurationApi.md#configurationdidsdididput) | **PUT** /api/v1/configuration/dids/{didId} | Update a DID by ID. |
| [**ConfigurationDidsGet**](ConfigurationApi.md#configurationdidsget) | **GET** /api/v1/configuration/dids | Get a listing of DIDs |
| [**ConfigurationEdgesCertificateauthoritiesCertificateidDelete**](ConfigurationApi.md#configurationedgescertificateauthoritiescertificateiddelete) | **DELETE** /api/v1/configuration/edges/certificateauthorities/{certificateId} | Delete a certificate authority. |
| [**ConfigurationEdgesCertificateauthoritiesCertificateidGet**](ConfigurationApi.md#configurationedgescertificateauthoritiescertificateidget) | **GET** /api/v1/configuration/edges/certificateauthorities/{certificateId} | Get a certificate authority. |
| [**ConfigurationEdgesCertificateauthoritiesCertificateidPut**](ConfigurationApi.md#configurationedgescertificateauthoritiescertificateidput) | **PUT** /api/v1/configuration/edges/certificateauthorities/{certificateId} | Update a certificate authority. |
| [**ConfigurationEdgesCertificateauthoritiesGet**](ConfigurationApi.md#configurationedgescertificateauthoritiesget) | **GET** /api/v1/configuration/edges/certificateauthorities | Get the list of certificate authorities. |
| [**ConfigurationEdgesCertificateauthoritiesPost**](ConfigurationApi.md#configurationedgescertificateauthoritiespost) | **POST** /api/v1/configuration/edges/certificateauthorities | Create a certificate authority. |
| [**ConfigurationEdgesEdgeidDelete**](ConfigurationApi.md#configurationedgesedgeiddelete) | **DELETE** /api/v1/configuration/edges/{edgeId} | Delete a edge. |
| [**ConfigurationEdgesEdgeidGet**](ConfigurationApi.md#configurationedgesedgeidget) | **GET** /api/v1/configuration/edges/{edgeId} | Get edge. |
| [**ConfigurationEdgesEdgeidLinesGet**](ConfigurationApi.md#configurationedgesedgeidlinesget) | **GET** /api/v1/configuration/edges/{edgeId}/lines | Get the list of lines. |
| [**ConfigurationEdgesEdgeidLinesLineidGet**](ConfigurationApi.md#configurationedgesedgeidlineslineidget) | **GET** /api/v1/configuration/edges/{edgeId}/lines/{lineId} | Get line |
| [**ConfigurationEdgesEdgeidLinesLineidPut**](ConfigurationApi.md#configurationedgesedgeidlineslineidput) | **PUT** /api/v1/configuration/edges/{edgeId}/lines/{lineId} | Update a line. |
| [**ConfigurationEdgesEdgeidLogicalinterfacesGet**](ConfigurationApi.md#configurationedgesedgeidlogicalinterfacesget) | **GET** /api/v1/configuration/edges/{edgeId}/logicalinterfaces | Get edge logical interfaces. |
| [**ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete**](ConfigurationApi.md#configurationedgesedgeidlogicalinterfacesinterfaceiddelete) | **DELETE** /api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId} | Delete an edge logical interface |
| [**ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet**](ConfigurationApi.md#configurationedgesedgeidlogicalinterfacesinterfaceidget) | **GET** /api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId} | Get an edge logical interface |
| [**ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut**](ConfigurationApi.md#configurationedgesedgeidlogicalinterfacesinterfaceidput) | **PUT** /api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId} | Update an edge logical interface. |
| [**ConfigurationEdgesEdgeidLogicalinterfacesPost**](ConfigurationApi.md#configurationedgesedgeidlogicalinterfacespost) | **POST** /api/v1/configuration/edges/{edgeId}/logicalinterfaces | Create an edge logical interface. |
| [**ConfigurationEdgesEdgeidPhysicalinterfacesGet**](ConfigurationApi.md#configurationedgesedgeidphysicalinterfacesget) | **GET** /api/v1/configuration/edges/{edgeId}/physicalinterfaces | Retrieve a list of all configured physical interfaces from a specific edge. |
| [**ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet**](ConfigurationApi.md#configurationedgesedgeidphysicalinterfacesinterfaceidget) | **GET** /api/v1/configuration/edges/{edgeId}/physicalinterfaces/{interfaceId} | Get edge physical interface. |
| [**ConfigurationEdgesEdgeidPut**](ConfigurationApi.md#configurationedgesedgeidput) | **PUT** /api/v1/configuration/edges/{edgeId} | Update a edge. |
| [**ConfigurationEdgesEdgeidRebootPost**](ConfigurationApi.md#configurationedgesedgeidrebootpost) | **POST** /api/v1/configuration/edges/{edgeId}/reboot | Reboot an Edge |
| [**ConfigurationEdgesEdgeidSoftwareupdateDelete**](ConfigurationApi.md#configurationedgesedgeidsoftwareupdatedelete) | **DELETE** /api/v1/configuration/edges/{edgeId}/softwareupdate | Cancels any in-progress update for this edge. |
| [**ConfigurationEdgesEdgeidSoftwareupdateGet**](ConfigurationApi.md#configurationedgesedgeidsoftwareupdateget) | **GET** /api/v1/configuration/edges/{edgeId}/softwareupdate | Gets software update status information about any edge. |
| [**ConfigurationEdgesEdgeidSoftwareupdatePost**](ConfigurationApi.md#configurationedgesedgeidsoftwareupdatepost) | **POST** /api/v1/configuration/edges/{edgeId}/softwareupdate | Starts a software update for this edge. |
| [**ConfigurationEdgesEdgeidSoftwareversionsGet**](ConfigurationApi.md#configurationedgesedgeidsoftwareversionsget) | **GET** /api/v1/configuration/edges/{edgeId}/softwareversions | Gets all the available software versions for this edge. |
| [**ConfigurationEdgesEdgeidUnpairPost**](ConfigurationApi.md#configurationedgesedgeidunpairpost) | **POST** /api/v1/configuration/edges/{edgeId}/unpair | Unpair an Edge |
| [**ConfigurationEdgesGet**](ConfigurationApi.md#configurationedgesget) | **GET** /api/v1/configuration/edges | Get the list of edges. |
| [**ConfigurationEdgesPost**](ConfigurationApi.md#configurationedgespost) | **POST** /api/v1/configuration/edges | Create a edge. |
| [**ConfigurationEdgeversionreportGet**](ConfigurationApi.md#configurationedgeversionreportget) | **GET** /api/v1/configuration/edgeversionreport | Get the edge version report. |
| [**ConfigurationEndpointsEndpointidDelete**](ConfigurationApi.md#configurationendpointsendpointiddelete) | **DELETE** /api/v1/configuration/endpoints/{endpointId} | Delete endpoint |
| [**ConfigurationEndpointsEndpointidGet**](ConfigurationApi.md#configurationendpointsendpointidget) | **GET** /api/v1/configuration/endpoints/{endpointId} | Get endpoint |
| [**ConfigurationEndpointsEndpointidPut**](ConfigurationApi.md#configurationendpointsendpointidput) | **PUT** /api/v1/configuration/endpoints/{endpointId} | Update endpoint |
| [**ConfigurationEndpointsGet**](ConfigurationApi.md#configurationendpointsget) | **GET** /api/v1/configuration/endpoints | Get endpoints |
| [**ConfigurationEndpointsPost**](ConfigurationApi.md#configurationendpointspost) | **POST** /api/v1/configuration/endpoints | Create endpoint |
| [**ConfigurationExtensionpoolsExtensionpoolidDelete**](ConfigurationApi.md#configurationextensionpoolsextensionpooliddelete) | **DELETE** /api/v1/configuration/extensionpools/{extensionPoolId} | Delete an extension pool by ID |
| [**ConfigurationExtensionpoolsExtensionpoolidGet**](ConfigurationApi.md#configurationextensionpoolsextensionpoolidget) | **GET** /api/v1/configuration/extensionpools/{extensionPoolId} | Get an extension pool by ID |
| [**ConfigurationExtensionpoolsExtensionpoolidPut**](ConfigurationApi.md#configurationextensionpoolsextensionpoolidput) | **PUT** /api/v1/configuration/extensionpools/{extensionPoolId} | Update an extension pool by ID |
| [**ConfigurationExtensionpoolsGet**](ConfigurationApi.md#configurationextensionpoolsget) | **GET** /api/v1/configuration/extensionpools | Get a listing of extension pools |
| [**ConfigurationExtensionpoolsPost**](ConfigurationApi.md#configurationextensionpoolspost) | **POST** /api/v1/configuration/extensionpools | Create a new extension pool |
| [**ConfigurationExtensionsExtensionidGet**](ConfigurationApi.md#configurationextensionsextensionidget) | **GET** /api/v1/configuration/extensions/{extensionId} | Get an extension by ID. |
| [**ConfigurationExtensionsExtensionidPut**](ConfigurationApi.md#configurationextensionsextensionidput) | **PUT** /api/v1/configuration/extensions/{extensionId} | Update an extension by ID. |
| [**ConfigurationExtensionsGet**](ConfigurationApi.md#configurationextensionsget) | **GET** /api/v1/configuration/extensions | Get a listing of extensions |
| [**ConfigurationOrganizationGet**](ConfigurationApi.md#configurationorganizationget) | **GET** /api/v1/configuration/organization | Get context organization. |
| [**ConfigurationOrganizationPut**](ConfigurationApi.md#configurationorganizationput) | **PUT** /api/v1/configuration/organization | Update context organization. |
| [**ConfigurationOrganizationsOrgidDelete**](ConfigurationApi.md#configurationorganizationsorgiddelete) | **DELETE** /api/v1/configuration/organizations/{orgId} | Delete an organization. |
| [**ConfigurationOrganizationsOrgidGet**](ConfigurationApi.md#configurationorganizationsorgidget) | **GET** /api/v1/configuration/organizations/{orgId} | Get organization. |
| [**ConfigurationOrganizationsOrgidPut**](ConfigurationApi.md#configurationorganizationsorgidput) | **PUT** /api/v1/configuration/organizations/{orgId} | Update organization. |
| [**ConfigurationOrganizationsPost**](ConfigurationApi.md#configurationorganizationspost) | **POST** /api/v1/configuration/organizations | Create organization. |
| [**ConfigurationRecordingkeysGet**](ConfigurationApi.md#configurationrecordingkeysget) | **GET** /api/v1/configuration/recordingkeys | Get encryption key list |
| [**ConfigurationRecordingkeysPost**](ConfigurationApi.md#configurationrecordingkeyspost) | **POST** /api/v1/configuration/recordingkeys | Create encryption key |
| [**ConfigurationRecordingkeysRotationscheduleGet**](ConfigurationApi.md#configurationrecordingkeysrotationscheduleget) | **GET** /api/v1/configuration/recordingkeys/rotationschedule | Get key rotation schedule |
| [**ConfigurationRecordingkeysRotationschedulePut**](ConfigurationApi.md#configurationrecordingkeysrotationscheduleput) | **PUT** /api/v1/configuration/recordingkeys/rotationschedule | Update key rotation schedule |
| [**ConfigurationRetentionpoliciesDelete**](ConfigurationApi.md#configurationretentionpoliciesdelete) | **DELETE** /api/v1/configuration/retentionpolicies | Delete policies |
| [**ConfigurationRetentionpoliciesGet**](ConfigurationApi.md#configurationretentionpoliciesget) | **GET** /api/v1/configuration/retentionpolicies | Gets retention policy list with query options to filter on name and enabled. |
| [**ConfigurationRetentionpoliciesPolicyidDelete**](ConfigurationApi.md#configurationretentionpoliciespolicyiddelete) | **DELETE** /api/v1/configuration/retentionpolicies/{policyId} | Delete policy |
| [**ConfigurationRetentionpoliciesPolicyidGet**](ConfigurationApi.md#configurationretentionpoliciespolicyidget) | **GET** /api/v1/configuration/retentionpolicies/{policyId} | Get policy |
| [**ConfigurationRetentionpoliciesPolicyidPatch**](ConfigurationApi.md#configurationretentionpoliciespolicyidpatch) | **PATCH** /api/v1/configuration/retentionpolicies/{policyId} | Patch a retention policy |
| [**ConfigurationRetentionpoliciesPolicyidPut**](ConfigurationApi.md#configurationretentionpoliciespolicyidput) | **PUT** /api/v1/configuration/retentionpolicies/{policyId} | Update policy |
| [**ConfigurationRetentionpoliciesPost**](ConfigurationApi.md#configurationretentionpoliciespost) | **POST** /api/v1/configuration/retentionpolicies | Create retention policy |
| [**ConfigurationSchemasEdgesVnextGet**](ConfigurationApi.md#configurationschemasedgesvnextget) | **GET** /api/v1/configuration/schemas/edges/vnext | Lists available schema categories |
| [**ConfigurationSchemasEdgesVnextSchemacategoryGet**](ConfigurationApi.md#configurationschemasedgesvnextschemacategoryget) | **GET** /api/v1/configuration/schemas/edges/vnext/{schemaCategory} | List schemas of a specific category |
| [**ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet**](ConfigurationApi.md#configurationschemasedgesvnextschemacategoryschematypeget) | **GET** /api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType} | List schemas of a specific category |
| [**ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet**](ConfigurationApi.md#configurationschemasedgesvnextschemacategoryschematypeschemaidextensionmetadataidget) | **GET** /api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId} | Get metadata for a schema |
| [**ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet**](ConfigurationApi.md#configurationschemasedgesvnextschemacategoryschematypeschemaidget) | **GET** /api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId} | Get a json schema |
| [**ConfigurationSitesGet**](ConfigurationApi.md#configurationsitesget) | **GET** /api/v1/configuration/sites | Get the list of sites. |
| [**ConfigurationSitesPost**](ConfigurationApi.md#configurationsitespost) | **POST** /api/v1/configuration/sites | Create a endpoint. |
| [**ConfigurationSitesSiteidDelete**](ConfigurationApi.md#configurationsitessiteiddelete) | **DELETE** /api/v1/configuration/sites/{siteId} | Delete an ednpoint |
| [**ConfigurationSitesSiteidGet**](ConfigurationApi.md#configurationsitessiteidget) | **GET** /api/v1/configuration/sites/{siteId} | Get endpoint. |
| [**ConfigurationSitesSiteidNumberplansClassificationsGet**](ConfigurationApi.md#configurationsitessiteidnumberplansclassificationsget) | **GET** /api/v1/configuration/sites/{siteId}/numberplans/classifications | Get a list of Classifications for this Site |
| [**ConfigurationSitesSiteidNumberplansGet**](ConfigurationApi.md#configurationsitessiteidnumberplansget) | **GET** /api/v1/configuration/sites/{siteId}/numberplans | Get the list of Number Plans for this Site. |
| [**ConfigurationSitesSiteidNumberplansNumberplanidGet**](ConfigurationApi.md#configurationsitessiteidnumberplansnumberplanidget) | **GET** /api/v1/configuration/sites/{siteId}/numberplans/{numberPlanId} | Get a Number Plan by ID. |
| [**ConfigurationSitesSiteidNumberplansPut**](ConfigurationApi.md#configurationsitessiteidnumberplansput) | **PUT** /api/v1/configuration/sites/{siteId}/numberplans | Update the list of Number Plans. |
| [**ConfigurationSitesSiteidPut**](ConfigurationApi.md#configurationsitessiteidput) | **PUT** /api/v1/configuration/sites/{siteId} | Update a endpoint. |
| [**ConfigurationSitesSiteidRebalancePost**](ConfigurationApi.md#configurationsitessiteidrebalancepost) | **POST** /api/v1/configuration/sites/{siteId}/rebalance | Triggers the rebalance operation. |
{: class="table table-striped"}

<a name="ConfigurationDidpoolsDidpoolidDelete"></a>
## string** ConfigurationDidpoolsDidpoolidDelete (string didPoolId)

Delete a DID Pool by ID.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationDidpoolsDidpoolidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID

            try
            {
                // Delete a DID Pool by ID.
                string result = apiInstance.ConfigurationDidpoolsDidpoolidDelete(didPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationDidpoolsDidpoolidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationDidpoolsDidpoolidGet"></a>
## [**DIDPool**](DIDPool.html) ConfigurationDidpoolsDidpoolidGet (string didPoolId)

Get a DID Pool by ID.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationDidpoolsDidpoolidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID

            try
            {
                // Get a DID Pool by ID.
                DIDPool result = apiInstance.ConfigurationDidpoolsDidpoolidGet(didPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationDidpoolsDidpoolidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.md)

<a name="ConfigurationDidpoolsDidpoolidPut"></a>
## [**DIDPool**](DIDPool.html) ConfigurationDidpoolsDidpoolidPut (string didPoolId, DIDPool body = null)

Update a DID Pool by ID.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationDidpoolsDidpoolidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID
            var body = new DIDPool(); // DIDPool |  (optional) 

            try
            {
                // Update a DID Pool by ID.
                DIDPool result = apiInstance.ConfigurationDidpoolsDidpoolidPut(didPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationDidpoolsDidpoolidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
| **body** | [**DIDPool**](DIDPool.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.md)

<a name="ConfigurationDidpoolsGet"></a>
## [**DIDPoolEntityListing**](DIDPoolEntityListing.html) ConfigurationDidpoolsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null)

Get a listing of DID Pools



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationDidpoolsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to number)

            try
            {
                // Get a listing of DID Pools
                DIDPoolEntityListing result = apiInstance.ConfigurationDidpoolsGet(pageSize, pageNumber, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationDidpoolsGet: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to number] |
{: class="table table-striped"}

### Return type

[**DIDPoolEntityListing**](DIDPoolEntityListing.md)

<a name="ConfigurationDidpoolsPost"></a>
## [**DIDPool**](DIDPool.html) ConfigurationDidpoolsPost (DIDPool body = null)

Create a new DID pool



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationDidpoolsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new DIDPool(); // DIDPool |  (optional) 

            try
            {
                // Create a new DID pool
                DIDPool result = apiInstance.ConfigurationDidpoolsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationDidpoolsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DIDPool**](DIDPool.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.md)

<a name="ConfigurationDidsDididGet"></a>
## [**DID**](DID.html) ConfigurationDidsDididGet (string didId)

Get a DID by ID.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationDidsDididGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var didId = didId_example;  // string | DID ID

            try
            {
                // Get a DID by ID.
                DID result = apiInstance.ConfigurationDidsDididGet(didId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationDidsDididGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didId** | **string**| DID ID |  |
{: class="table table-striped"}

### Return type

[**DID**](DID.md)

<a name="ConfigurationDidsDididPut"></a>
## [**DID**](DID.html) ConfigurationDidsDididPut (string didId, DID body = null)

Update a DID by ID.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationDidsDididPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var didId = didId_example;  // string | DID ID
            var body = new DID(); // DID |  (optional) 

            try
            {
                // Update a DID by ID.
                DID result = apiInstance.ConfigurationDidsDididPut(didId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationDidsDididPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didId** | **string**| DID ID |  |
| **body** | [**DID**](DID.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DID**](DID.md)

<a name="ConfigurationDidsGet"></a>
## [**DIDEntityListing**](DIDEntityListing.html) ConfigurationDidsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)

Get a listing of DIDs



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationDidsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to number)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var phoneNumber = phoneNumber_example;  // string | Filter by phoneNumber (optional) 

            try
            {
                // Get a listing of DIDs
                DIDEntityListing result = apiInstance.ConfigurationDidsGet(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationDidsGet: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to number] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **phoneNumber** | **string**| Filter by phoneNumber | [optional]  |
{: class="table table-striped"}

### Return type

[**DIDEntityListing**](DIDEntityListing.md)

<a name="ConfigurationEdgesCertificateauthoritiesCertificateidDelete"></a>
## string** ConfigurationEdgesCertificateauthoritiesCertificateidDelete (string certificateId)

Delete a certificate authority.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesCertificateauthoritiesCertificateidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var certificateId = certificateId_example;  // string | Certificate ID

            try
            {
                // Delete a certificate authority.
                string result = apiInstance.ConfigurationEdgesCertificateauthoritiesCertificateidDelete(certificateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesCertificateauthoritiesCertificateidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationEdgesCertificateauthoritiesCertificateidGet"></a>
## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) ConfigurationEdgesCertificateauthoritiesCertificateidGet (string certificateId)

Get a certificate authority.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesCertificateauthoritiesCertificateidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var certificateId = certificateId_example;  // string | Certificate ID

            try
            {
                // Get a certificate authority.
                DomainCertificateAuthority result = apiInstance.ConfigurationEdgesCertificateauthoritiesCertificateidGet(certificateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesCertificateauthoritiesCertificateidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.md)

<a name="ConfigurationEdgesCertificateauthoritiesCertificateidPut"></a>
## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) ConfigurationEdgesCertificateauthoritiesCertificateidPut (string certificateId, DomainCertificateAuthority body = null)

Update a certificate authority.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesCertificateauthoritiesCertificateidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var certificateId = certificateId_example;  // string | Certificate ID
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority |  (optional) 

            try
            {
                // Update a certificate authority.
                DomainCertificateAuthority result = apiInstance.ConfigurationEdgesCertificateauthoritiesCertificateidPut(certificateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesCertificateauthoritiesCertificateidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.md)

<a name="ConfigurationEdgesCertificateauthoritiesGet"></a>
## [**CertificateAuthorityEntityListing**](CertificateAuthorityEntityListing.html) ConfigurationEdgesCertificateauthoritiesGet ()

Get the list of certificate authorities.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesCertificateauthoritiesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();

            try
            {
                // Get the list of certificate authorities.
                CertificateAuthorityEntityListing result = apiInstance.ConfigurationEdgesCertificateauthoritiesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesCertificateauthoritiesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CertificateAuthorityEntityListing**](CertificateAuthorityEntityListing.md)

<a name="ConfigurationEdgesCertificateauthoritiesPost"></a>
## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) ConfigurationEdgesCertificateauthoritiesPost (DomainCertificateAuthority body = null)

Create a certificate authority.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesCertificateauthoritiesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority | CertificateAuthority (optional) 

            try
            {
                // Create a certificate authority.
                DomainCertificateAuthority result = apiInstance.ConfigurationEdgesCertificateauthoritiesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesCertificateauthoritiesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority.md)| CertificateAuthority | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.md)

<a name="ConfigurationEdgesEdgeidDelete"></a>
## string** ConfigurationEdgesEdgeidDelete (string edgeId)

Delete a edge.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Delete a edge.
                string result = apiInstance.ConfigurationEdgesEdgeidDelete(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationEdgesEdgeidGet"></a>
## [**Edge**](Edge.html) ConfigurationEdgesEdgeidGet (string edgeId)

Get edge.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Get edge.
                Edge result = apiInstance.ConfigurationEdgesEdgeidGet(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.md)

<a name="ConfigurationEdgesEdgeidLinesGet"></a>
## [**EdgeLineEntityListing**](EdgeLineEntityListing.html) ConfigurationEdgesEdgeidLinesGet (string edgeId, int? pageSize = null, int? pageNumber = null)

Get the list of lines.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidLinesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get the list of lines.
                EdgeLineEntityListing result = apiInstance.ConfigurationEdgesEdgeidLinesGet(edgeId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidLinesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**EdgeLineEntityListing**](EdgeLineEntityListing.md)

<a name="ConfigurationEdgesEdgeidLinesLineidGet"></a>
## [**EdgeLine**](EdgeLine.html) ConfigurationEdgesEdgeidLinesLineidGet (string edgeId, string lineId)

Get line



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidLinesLineidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var lineId = lineId_example;  // string | Line ID

            try
            {
                // Get line
                EdgeLine result = apiInstance.ConfigurationEdgesEdgeidLinesLineidGet(edgeId, lineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidLinesLineidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **lineId** | **string**| Line ID |  |
{: class="table table-striped"}

### Return type

[**EdgeLine**](EdgeLine.md)

<a name="ConfigurationEdgesEdgeidLinesLineidPut"></a>
## [**EdgeLine**](EdgeLine.html) ConfigurationEdgesEdgeidLinesLineidPut (string edgeId, string lineId, EdgeLine body = null)

Update a line.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidLinesLineidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var lineId = lineId_example;  // string | Line ID
            var body = new EdgeLine(); // EdgeLine | Line (optional) 

            try
            {
                // Update a line.
                EdgeLine result = apiInstance.ConfigurationEdgesEdgeidLinesLineidPut(edgeId, lineId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidLinesLineidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **lineId** | **string**| Line ID |  |
| **body** | [**EdgeLine**](EdgeLine.md)| Line | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeLine**](EdgeLine.md)

<a name="ConfigurationEdgesEdgeidLogicalinterfacesGet"></a>
## [**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.html) ConfigurationEdgesEdgeidLogicalinterfacesGet (string edgeId)

Get edge logical interfaces.

Retrieve a list of all configured logical interfaces from a specific edge.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidLogicalinterfacesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Get edge logical interfaces.
                LogicalInterfaceEntityListing result = apiInstance.ConfigurationEdgesEdgeidLogicalinterfacesGet(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidLogicalinterfacesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.md)

<a name="ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete"></a>
## void ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete (string edgeId, string interfaceId)

Delete an edge logical interface



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            {
                // Delete an edge logical interface
                apiInstance.ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete(edgeId, interfaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet"></a>
## [**DomainLogicalInterface**](DomainLogicalInterface.html) ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet (string edgeId, string interfaceId)

Get an edge logical interface



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            {
                // Get an edge logical interface
                DomainLogicalInterface result = apiInstance.ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet(edgeId, interfaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.md)

<a name="ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut"></a>
## [**DomainLogicalInterface**](DomainLogicalInterface.html) ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut (string edgeId, string interfaceId, DomainLogicalInterface body = null)

Update an edge logical interface.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface |  (optional) 

            try
            {
                // Update an edge logical interface.
                DomainLogicalInterface result = apiInstance.ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut(edgeId, interfaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.md)

<a name="ConfigurationEdgesEdgeidLogicalinterfacesPost"></a>
## [**DomainLogicalInterface**](DomainLogicalInterface.html) ConfigurationEdgesEdgeidLogicalinterfacesPost (string edgeId, DomainLogicalInterface body = null)

Create an edge logical interface.

Create

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidLogicalinterfacesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface |  (optional) 

            try
            {
                // Create an edge logical interface.
                DomainLogicalInterface result = apiInstance.ConfigurationEdgesEdgeidLogicalinterfacesPost(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidLogicalinterfacesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.md)

<a name="ConfigurationEdgesEdgeidPhysicalinterfacesGet"></a>
## [**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing.html) ConfigurationEdgesEdgeidPhysicalinterfacesGet (string edgeId)

Retrieve a list of all configured physical interfaces from a specific edge.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidPhysicalinterfacesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Retrieve a list of all configured physical interfaces from a specific edge.
                PhysicalInterfaceEntityListing result = apiInstance.ConfigurationEdgesEdgeidPhysicalinterfacesGet(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidPhysicalinterfacesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing.md)

<a name="ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet"></a>
## [**DomainPhysicalInterface**](DomainPhysicalInterface.html) ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet (string edgeId, string interfaceId)

Get edge physical interface.

Retrieve a physical interface from a specific edge.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            {
                // Get edge physical interface.
                DomainPhysicalInterface result = apiInstance.ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet(edgeId, interfaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
{: class="table table-striped"}

### Return type

[**DomainPhysicalInterface**](DomainPhysicalInterface.md)

<a name="ConfigurationEdgesEdgeidPut"></a>
## [**Edge**](Edge.html) ConfigurationEdgesEdgeidPut (string edgeId, Edge body = null)

Update a edge.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new Edge(); // Edge | Edge (optional) 

            try
            {
                // Update a edge.
                Edge result = apiInstance.ConfigurationEdgesEdgeidPut(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**Edge**](Edge.md)| Edge | [optional]  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.md)

<a name="ConfigurationEdgesEdgeidRebootPost"></a>
## string** ConfigurationEdgesEdgeidRebootPost (string edgeId)

Reboot an Edge



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidRebootPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Reboot an Edge
                string result = apiInstance.ConfigurationEdgesEdgeidRebootPost(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidRebootPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationEdgesEdgeidSoftwareupdateDelete"></a>
## string** ConfigurationEdgesEdgeidSoftwareupdateDelete (string edgeId)

Cancels any in-progress update for this edge.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidSoftwareupdateDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Cancels any in-progress update for this edge.
                string result = apiInstance.ConfigurationEdgesEdgeidSoftwareupdateDelete(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidSoftwareupdateDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationEdgesEdgeidSoftwareupdateGet"></a>
## [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html) ConfigurationEdgesEdgeidSoftwareupdateGet (string edgeId)

Gets software update status information about any edge.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidSoftwareupdateGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Gets software update status information about any edge.
                DomainEdgeSoftwareUpdateDto result = apiInstance.ConfigurationEdgesEdgeidSoftwareupdateGet(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidSoftwareupdateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.md)

<a name="ConfigurationEdgesEdgeidSoftwareupdatePost"></a>
## void ConfigurationEdgesEdgeidSoftwareupdatePost (string edgeId, DomainEdgeSoftwareUpdateDto body = null)

Starts a software update for this edge.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidSoftwareupdatePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainEdgeSoftwareUpdateDto(); // DomainEdgeSoftwareUpdateDto |  (optional) 

            try
            {
                // Starts a software update for this edge.
                apiInstance.ConfigurationEdgesEdgeidSoftwareupdatePost(edgeId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidSoftwareupdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ConfigurationEdgesEdgeidSoftwareversionsGet"></a>
## [**DomainEdgeSoftwareVersionDto**](DomainEdgeSoftwareVersionDto.html) ConfigurationEdgesEdgeidSoftwareversionsGet (string edgeId)

Gets all the available software versions for this edge.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidSoftwareversionsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Gets all the available software versions for this edge.
                DomainEdgeSoftwareVersionDto result = apiInstance.ConfigurationEdgesEdgeidSoftwareversionsGet(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidSoftwareversionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**DomainEdgeSoftwareVersionDto**](DomainEdgeSoftwareVersionDto.md)

<a name="ConfigurationEdgesEdgeidUnpairPost"></a>
## string** ConfigurationEdgesEdgeidUnpairPost (string edgeId)

Unpair an Edge



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesEdgeidUnpairPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var edgeId = edgeId_example;  // string | Edge Id

            try
            {
                // Unpair an Edge
                string result = apiInstance.ConfigurationEdgesEdgeidUnpairPost(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesEdgeidUnpairPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationEdgesGet"></a>
## [**EdgeEntityListing**](EdgeEntityListing.html) ConfigurationEdgesGet (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)

Get the list of edges.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var siteId = siteId_example;  // string | Filter by site.id (optional) 
            var edgeGroupId = edgeGroupId_example;  // string | Filter by edgeGroup.id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)

            try
            {
                // Get the list of edges.
                EdgeEntityListing result = apiInstance.ConfigurationEdgesGet(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesGet: " + e.Message );
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
| **name** | **string**| Name | [optional]  |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **edgeGroupId** | **string**| Filter by edgeGroup.id | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**EdgeEntityListing**](EdgeEntityListing.md)

<a name="ConfigurationEdgesPost"></a>
## [**Edge**](Edge.html) ConfigurationEdgesPost (Edge body = null)

Create a edge.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new Edge(); // Edge | Edge (optional) 

            try
            {
                // Create a edge.
                Edge result = apiInstance.ConfigurationEdgesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Edge**](Edge.md)| Edge | [optional]  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.md)

<a name="ConfigurationEdgeversionreportGet"></a>
## [**EdgeVersionReport**](EdgeVersionReport.html) ConfigurationEdgeversionreportGet ()

Get the edge version report.

The report will not have consistent data about the edge version(s) until all edges have been reset.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEdgeversionreportGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();

            try
            {
                // Get the edge version report.
                EdgeVersionReport result = apiInstance.ConfigurationEdgeversionreportGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEdgeversionreportGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EdgeVersionReport**](EdgeVersionReport.md)

<a name="ConfigurationEndpointsEndpointidDelete"></a>
## string** ConfigurationEndpointsEndpointidDelete (string endpointId)

Delete endpoint



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEndpointsEndpointidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var endpointId = endpointId_example;  // string | Endpoint ID

            try
            {
                // Delete endpoint
                string result = apiInstance.ConfigurationEndpointsEndpointidDelete(endpointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEndpointsEndpointidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationEndpointsEndpointidGet"></a>
## [**Endpoint**](Endpoint.html) ConfigurationEndpointsEndpointidGet (string endpointId)

Get endpoint



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEndpointsEndpointidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var endpointId = endpointId_example;  // string | Endpoint ID

            try
            {
                // Get endpoint
                Endpoint result = apiInstance.ConfigurationEndpointsEndpointidGet(endpointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEndpointsEndpointidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.md)

<a name="ConfigurationEndpointsEndpointidPut"></a>
## [**Endpoint**](Endpoint.html) ConfigurationEndpointsEndpointidPut (string endpointId, Endpoint body = null)

Update endpoint



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEndpointsEndpointidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var endpointId = endpointId_example;  // string | Endpoint ID
            var body = new Endpoint(); // Endpoint | EndpointTemplate (optional) 

            try
            {
                // Update endpoint
                Endpoint result = apiInstance.ConfigurationEndpointsEndpointidPut(endpointId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEndpointsEndpointidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
| **body** | [**Endpoint**](Endpoint.md)| EndpointTemplate | [optional]  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.md)

<a name="ConfigurationEndpointsGet"></a>
## [**EndpointEntityListing**](EndpointEntityListing.html) ConfigurationEndpointsGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)

Get endpoints



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEndpointsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)

            try
            {
                // Get endpoints
                EndpointEntityListing result = apiInstance.ConfigurationEndpointsGet(pageSize, pageNumber, name, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEndpointsGet: " + e.Message );
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
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**EndpointEntityListing**](EndpointEntityListing.md)

<a name="ConfigurationEndpointsPost"></a>
## [**Endpoint**](Endpoint.html) ConfigurationEndpointsPost (Endpoint body = null)

Create endpoint



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationEndpointsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new Endpoint(); // Endpoint | EndpointTemplate (optional) 

            try
            {
                // Create endpoint
                Endpoint result = apiInstance.ConfigurationEndpointsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationEndpointsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Endpoint**](Endpoint.md)| EndpointTemplate | [optional]  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.md)

<a name="ConfigurationExtensionpoolsExtensionpoolidDelete"></a>
## string** ConfigurationExtensionpoolsExtensionpoolidDelete (string extensionPoolId)

Delete an extension pool by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationExtensionpoolsExtensionpoolidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID

            try
            {
                // Delete an extension pool by ID
                string result = apiInstance.ConfigurationExtensionpoolsExtensionpoolidDelete(extensionPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationExtensionpoolsExtensionpoolidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationExtensionpoolsExtensionpoolidGet"></a>
## [**ExtensionPool**](ExtensionPool.html) ConfigurationExtensionpoolsExtensionpoolidGet (string extensionPoolId)

Get an extension pool by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationExtensionpoolsExtensionpoolidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID

            try
            {
                // Get an extension pool by ID
                ExtensionPool result = apiInstance.ConfigurationExtensionpoolsExtensionpoolidGet(extensionPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationExtensionpoolsExtensionpoolidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
{: class="table table-striped"}

### Return type

[**ExtensionPool**](ExtensionPool.md)

<a name="ConfigurationExtensionpoolsExtensionpoolidPut"></a>
## [**ExtensionPool**](ExtensionPool.html) ConfigurationExtensionpoolsExtensionpoolidPut (string extensionPoolId, ExtensionPool body = null)

Update an extension pool by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationExtensionpoolsExtensionpoolidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool (optional) 

            try
            {
                // Update an extension pool by ID
                ExtensionPool result = apiInstance.ConfigurationExtensionpoolsExtensionpoolidPut(extensionPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationExtensionpoolsExtensionpoolidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
| **body** | [**ExtensionPool**](ExtensionPool.md)| ExtensionPool | [optional]  |
{: class="table table-striped"}

### Return type

[**ExtensionPool**](ExtensionPool.md)

<a name="ConfigurationExtensionpoolsGet"></a>
## [**ExtensionPoolEntityListing**](ExtensionPoolEntityListing.html) ConfigurationExtensionpoolsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)

Get a listing of extension pools



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationExtensionpoolsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to startNumber)
            var number = number_example;  // string | Number (optional) 

            try
            {
                // Get a listing of extension pools
                ExtensionPoolEntityListing result = apiInstance.ConfigurationExtensionpoolsGet(pageSize, pageNumber, sortBy, number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationExtensionpoolsGet: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to startNumber] |
| **number** | **string**| Number | [optional]  |
{: class="table table-striped"}

### Return type

[**ExtensionPoolEntityListing**](ExtensionPoolEntityListing.md)

<a name="ConfigurationExtensionpoolsPost"></a>
## [**Extension**](Extension.html) ConfigurationExtensionpoolsPost (ExtensionPool body = null)

Create a new extension pool



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationExtensionpoolsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool (optional) 

            try
            {
                // Create a new extension pool
                Extension result = apiInstance.ConfigurationExtensionpoolsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationExtensionpoolsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExtensionPool**](ExtensionPool.md)| ExtensionPool | [optional]  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.md)

<a name="ConfigurationExtensionsExtensionidGet"></a>
## [**Extension**](Extension.html) ConfigurationExtensionsExtensionidGet (string extensionId)

Get an extension by ID.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationExtensionsExtensionidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var extensionId = extensionId_example;  // string | Extension ID

            try
            {
                // Get an extension by ID.
                Extension result = apiInstance.ConfigurationExtensionsExtensionidGet(extensionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationExtensionsExtensionidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionId** | **string**| Extension ID |  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.md)

<a name="ConfigurationExtensionsExtensionidPut"></a>
## [**Extension**](Extension.html) ConfigurationExtensionsExtensionidPut (string extensionId, Extension body = null)

Update an extension by ID.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationExtensionsExtensionidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var extensionId = extensionId_example;  // string | Extension ID
            var body = new Extension(); // Extension |  (optional) 

            try
            {
                // Update an extension by ID.
                Extension result = apiInstance.ConfigurationExtensionsExtensionidPut(extensionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationExtensionsExtensionidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionId** | **string**| Extension ID |  |
| **body** | [**Extension**](Extension.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.md)

<a name="ConfigurationExtensionsGet"></a>
## [**ExtensionEntityListing**](ExtensionEntityListing.html) ConfigurationExtensionsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)

Get a listing of extensions



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationExtensionsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to number)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var number = number_example;  // string | Filter by number (optional) 

            try
            {
                // Get a listing of extensions
                ExtensionEntityListing result = apiInstance.ConfigurationExtensionsGet(pageSize, pageNumber, sortBy, sortOrder, number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationExtensionsGet: " + e.Message );
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
| **sortBy** | **string**| Sort by | [optional] [default to number] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **number** | **string**| Filter by number | [optional]  |
{: class="table table-striped"}

### Return type

[**ExtensionEntityListing**](ExtensionEntityListing.md)

<a name="ConfigurationOrganizationGet"></a>
## [**Organization**](Organization.html) ConfigurationOrganizationGet ()

Get context organization.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationOrganizationGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();

            try
            {
                // Get context organization.
                Organization result = apiInstance.ConfigurationOrganizationGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationOrganizationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="ConfigurationOrganizationPut"></a>
## [**Organization**](Organization.html) ConfigurationOrganizationPut (Organization body = null)

Update context organization.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationOrganizationPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new Organization(); // Organization | Organization (optional) 

            try
            {
                // Update context organization.
                Organization result = apiInstance.ConfigurationOrganizationPut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationOrganizationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Organization**](Organization.md)| Organization | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="ConfigurationOrganizationsOrgidDelete"></a>
## string** ConfigurationOrganizationsOrgidDelete (string orgId)

Delete an organization.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationOrganizationsOrgidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var orgId = orgId_example;  // string | Organization ID

            try
            {
                // Delete an organization.
                string result = apiInstance.ConfigurationOrganizationsOrgidDelete(orgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationOrganizationsOrgidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orgId** | **string**| Organization ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationOrganizationsOrgidGet"></a>
## [**Organization**](Organization.html) ConfigurationOrganizationsOrgidGet (string orgId)

Get organization.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationOrganizationsOrgidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var orgId = orgId_example;  // string | Organization ID

            try
            {
                // Get organization.
                Organization result = apiInstance.ConfigurationOrganizationsOrgidGet(orgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationOrganizationsOrgidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orgId** | **string**| Organization ID |  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="ConfigurationOrganizationsOrgidPut"></a>
## [**Organization**](Organization.html) ConfigurationOrganizationsOrgidPut (string orgId, Organization body = null)

Update organization.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationOrganizationsOrgidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var orgId = orgId_example;  // string | Organization ID
            var body = new Organization(); // Organization | Organization (optional) 

            try
            {
                // Update organization.
                Organization result = apiInstance.ConfigurationOrganizationsOrgidPut(orgId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationOrganizationsOrgidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orgId** | **string**| Organization ID |  |
| **body** | [**Organization**](Organization.md)| Organization | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="ConfigurationOrganizationsPost"></a>
## [**Organization**](Organization.html) ConfigurationOrganizationsPost (OrganizationCreate body = null)

Create organization.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationOrganizationsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new OrganizationCreate(); // OrganizationCreate | Organization (optional) 

            try
            {
                // Create organization.
                Organization result = apiInstance.ConfigurationOrganizationsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationOrganizationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OrganizationCreate**](OrganizationCreate.md)| Organization | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="ConfigurationRecordingkeysGet"></a>
## [**EncryptionKeyEntityListing**](EncryptionKeyEntityListing.html) ConfigurationRecordingkeysGet (int? pageSize = null, int? pageNumber = null)

Get encryption key list



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRecordingkeysGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get encryption key list
                EncryptionKeyEntityListing result = apiInstance.ConfigurationRecordingkeysGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRecordingkeysGet: " + e.Message );
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

[**EncryptionKeyEntityListing**](EncryptionKeyEntityListing.md)

<a name="ConfigurationRecordingkeysPost"></a>
## [**EncryptionKey**](EncryptionKey.html) ConfigurationRecordingkeysPost ()

Create encryption key



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRecordingkeysPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();

            try
            {
                // Create encryption key
                EncryptionKey result = apiInstance.ConfigurationRecordingkeysPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRecordingkeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EncryptionKey**](EncryptionKey.md)

<a name="ConfigurationRecordingkeysRotationscheduleGet"></a>
## [**KeyRotationSchedule**](KeyRotationSchedule.html) ConfigurationRecordingkeysRotationscheduleGet ()

Get key rotation schedule



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRecordingkeysRotationscheduleGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();

            try
            {
                // Get key rotation schedule
                KeyRotationSchedule result = apiInstance.ConfigurationRecordingkeysRotationscheduleGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRecordingkeysRotationscheduleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**KeyRotationSchedule**](KeyRotationSchedule.md)

<a name="ConfigurationRecordingkeysRotationschedulePut"></a>
## [**KeyRotationSchedule**](KeyRotationSchedule.html) ConfigurationRecordingkeysRotationschedulePut (KeyRotationSchedule body = null)

Update key rotation schedule



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRecordingkeysRotationschedulePutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new KeyRotationSchedule(); // KeyRotationSchedule | KeyRotationSchedule (optional) 

            try
            {
                // Update key rotation schedule
                KeyRotationSchedule result = apiInstance.ConfigurationRecordingkeysRotationschedulePut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRecordingkeysRotationschedulePut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KeyRotationSchedule**](KeyRotationSchedule.md)| KeyRotationSchedule | [optional]  |
{: class="table table-striped"}

### Return type

[**KeyRotationSchedule**](KeyRotationSchedule.md)

<a name="ConfigurationRetentionpoliciesDelete"></a>
## string** ConfigurationRetentionpoliciesDelete (string ids)

Delete policies

Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRetentionpoliciesDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var ids = ids_example;  // string | 

            try
            {
                // Delete policies
                string result = apiInstance.ConfigurationRetentionpoliciesDelete(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRetentionpoliciesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ids** | **string**|  |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationRetentionpoliciesGet"></a>
## [**PolicyEntityListing**](PolicyEntityListing.html) ConfigurationRetentionpoliciesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)

Gets retention policy list with query options to filter on name and enabled.

for a less verbose response, add summary=true to this endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRetentionpoliciesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var name = name_example;  // string | the policy name - used for filtering results in searches. (optional) 
            var enabled = true;  // bool? | checks to see if policy is enabled - use enabled = true or enabled = false (optional) 
            var summary = true;  // bool? | provides a less verbose response of policy lists. (optional)  (default to false)
            var hasErrors = true;  // bool? | provides a way to fetch all policies with errors or policies that do not have errors (optional) 

            try
            {
                // Gets retention policy list with query options to filter on name and enabled.
                PolicyEntityListing result = apiInstance.ConfigurationRetentionpoliciesGet(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRetentionpoliciesGet: " + e.Message );
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
| **name** | **string**| the policy name - used for filtering results in searches. | [optional]  |
| **enabled** | **bool?**| checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false | [optional]  |
| **summary** | **bool?**| provides a less verbose response of policy lists. | [optional] [default to false] |
| **hasErrors** | **bool?**| provides a way to fetch all policies with errors or policies that do not have errors | [optional]  |
{: class="table table-striped"}

### Return type

[**PolicyEntityListing**](PolicyEntityListing.md)

<a name="ConfigurationRetentionpoliciesPolicyidDelete"></a>
## string** ConfigurationRetentionpoliciesPolicyidDelete (string policyId)

Delete policy



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRetentionpoliciesPolicyidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var policyId = policyId_example;  // string | Policy ID

            try
            {
                // Delete policy
                string result = apiInstance.ConfigurationRetentionpoliciesPolicyidDelete(policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRetentionpoliciesPolicyidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationRetentionpoliciesPolicyidGet"></a>
## [**Policy**](Policy.html) ConfigurationRetentionpoliciesPolicyidGet (string policyId)

Get policy



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRetentionpoliciesPolicyidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var policyId = policyId_example;  // string | Policy ID

            try
            {
                // Get policy
                Policy result = apiInstance.ConfigurationRetentionpoliciesPolicyidGet(policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRetentionpoliciesPolicyidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.md)

<a name="ConfigurationRetentionpoliciesPolicyidPatch"></a>
## [**Policy**](Policy.html) ConfigurationRetentionpoliciesPolicyidPatch (string policyId, Policy body = null)

Patch a retention policy



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRetentionpoliciesPolicyidPatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var policyId = policyId_example;  // string | Policy ID
            var body = new Policy(); // Policy | Policy (optional) 

            try
            {
                // Patch a retention policy
                Policy result = apiInstance.ConfigurationRetentionpoliciesPolicyidPatch(policyId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRetentionpoliciesPolicyidPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
| **body** | [**Policy**](Policy.md)| Policy | [optional]  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.md)

<a name="ConfigurationRetentionpoliciesPolicyidPut"></a>
## [**Policy**](Policy.html) ConfigurationRetentionpoliciesPolicyidPut (string policyId, Policy body = null)

Update policy



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRetentionpoliciesPolicyidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var policyId = policyId_example;  // string | Policy ID
            var body = new Policy(); // Policy | Policy (optional) 

            try
            {
                // Update policy
                Policy result = apiInstance.ConfigurationRetentionpoliciesPolicyidPut(policyId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRetentionpoliciesPolicyidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
| **body** | [**Policy**](Policy.md)| Policy | [optional]  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.md)

<a name="ConfigurationRetentionpoliciesPost"></a>
## [**Policy**](Policy.html) ConfigurationRetentionpoliciesPost (Policy body = null)

Create retention policy



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationRetentionpoliciesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new Policy(); // Policy | Policy (optional) 

            try
            {
                // Create retention policy
                Policy result = apiInstance.ConfigurationRetentionpoliciesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationRetentionpoliciesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Policy**](Policy.md)| Policy | [optional]  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.md)

<a name="ConfigurationSchemasEdgesVnextGet"></a>
## [**SchemaCategoryEntityListing**](SchemaCategoryEntityListing.html) ConfigurationSchemasEdgesVnextGet (int? pageSize = null, int? pageNumber = null)

Lists available schema categories



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSchemasEdgesVnextGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Lists available schema categories
                SchemaCategoryEntityListing result = apiInstance.ConfigurationSchemasEdgesVnextGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSchemasEdgesVnextGet: " + e.Message );
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

[**SchemaCategoryEntityListing**](SchemaCategoryEntityListing.md)

<a name="ConfigurationSchemasEdgesVnextSchemacategoryGet"></a>
## [**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html) ConfigurationSchemasEdgesVnextSchemacategoryGet (string schemaCategory, int? pageSize = null, int? pageNumber = null)

List schemas of a specific category



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSchemasEdgesVnextSchemacategoryGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List schemas of a specific category
                SchemaReferenceEntityListing result = apiInstance.ConfigurationSchemasEdgesVnextSchemacategoryGet(schemaCategory, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSchemasEdgesVnextSchemacategoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.md)

<a name="ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet"></a>
## [**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html) ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)

List schemas of a specific category



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSchemasEdgesVnextSchemacategorySchematypeGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List schemas of a specific category
                SchemaReferenceEntityListing result = apiInstance.ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet(schemaCategory, schemaType, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **schemaType** | **string**| Schema type |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.md)

<a name="ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet"></a>
## [**Organization**](Organization.html) ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)

Get metadata for a schema



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var schemaId = schemaId_example;  // string | Schema ID
            var extension = extension_example;  // string | extension
            var metadataId = metadataId_example;  // string | Metadata ID
            var type = type_example;  // string | Type (optional) 

            try
            {
                // Get metadata for a schema
                Organization result = apiInstance.ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet(schemaCategory, schemaType, schemaId, extension, metadataId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **schemaType** | **string**| Schema type |  |
| **schemaId** | **string**| Schema ID |  |
| **extension** | **string**| extension |  |
| **metadataId** | **string**| Metadata ID |  |
| **type** | **string**| Type | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet"></a>
## [**Organization**](Organization.html) ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet (string schemaCategory, string schemaType, string schemaId)

Get a json schema



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var schemaId = schemaId_example;  // string | Schema ID

            try
            {
                // Get a json schema
                Organization result = apiInstance.ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet(schemaCategory, schemaType, schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **schemaType** | **string**| Schema type |  |
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="ConfigurationSitesGet"></a>
## [**SiteEntityListing**](SiteEntityListing.html) ConfigurationSitesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)

Get the list of sites.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var name = name_example;  // string | Name (optional) 
            var locationId = locationId_example;  // string | Location Id (optional) 

            try
            {
                // Get the list of sites.
                SiteEntityListing result = apiInstance.ConfigurationSitesGet(pageSize, pageNumber, sortBy, sortOrder, name, locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesGet: " + e.Message );
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
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **name** | **string**| Name | [optional]  |
| **locationId** | **string**| Location Id | [optional]  |
{: class="table table-striped"}

### Return type

[**SiteEntityListing**](SiteEntityListing.md)

<a name="ConfigurationSitesPost"></a>
## [**Site**](Site.html) ConfigurationSitesPost (Site body = null)

Create a endpoint.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new Site(); // Site | Site (optional) 

            try
            {
                // Create a endpoint.
                Site result = apiInstance.ConfigurationSitesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Site**](Site.md)| Site | [optional]  |
{: class="table table-striped"}

### Return type

[**Site**](Site.md)

<a name="ConfigurationSitesSiteidDelete"></a>
## string** ConfigurationSitesSiteidDelete (string siteId)

Delete an ednpoint



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesSiteidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Delete an ednpoint
                string result = apiInstance.ConfigurationSitesSiteidDelete(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesSiteidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConfigurationSitesSiteidGet"></a>
## [**Site**](Site.html) ConfigurationSitesSiteidGet (string siteId)

Get endpoint.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesSiteidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Get endpoint.
                Site result = apiInstance.ConfigurationSitesSiteidGet(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesSiteidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

[**Site**](Site.md)

<a name="ConfigurationSitesSiteidNumberplansClassificationsGet"></a>
## List&lt;string&gt;** ConfigurationSitesSiteidNumberplansClassificationsGet (string siteId, string classification = null)

Get a list of Classifications for this Site



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesSiteidNumberplansClassificationsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var siteId = siteId_example;  // string | Site ID
            var classification = classification_example;  // string | Classification (optional) 

            try
            {
                // Get a list of Classifications for this Site
                List&lt;string&gt; result = apiInstance.ConfigurationSitesSiteidNumberplansClassificationsGet(siteId, classification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesSiteidNumberplansClassificationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **classification** | **string**| Classification | [optional]  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="ConfigurationSitesSiteidNumberplansGet"></a>
## [**List&lt;NumberPlan&gt;**](NumberPlan.html) ConfigurationSitesSiteidNumberplansGet (string siteId)

Get the list of Number Plans for this Site.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesSiteidNumberplansGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Get the list of Number Plans for this Site.
                List&lt;NumberPlan&gt; result = apiInstance.ConfigurationSitesSiteidNumberplansGet(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesSiteidNumberplansGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

[**List<NumberPlan>**](NumberPlan.md)

<a name="ConfigurationSitesSiteidNumberplansNumberplanidGet"></a>
## [**NumberPlan**](NumberPlan.html) ConfigurationSitesSiteidNumberplansNumberplanidGet (string siteId, string numberPlanId)

Get a Number Plan by ID.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesSiteidNumberplansNumberplanidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var siteId = siteId_example;  // string | Site ID
            var numberPlanId = numberPlanId_example;  // string | Number Plan ID

            try
            {
                // Get a Number Plan by ID.
                NumberPlan result = apiInstance.ConfigurationSitesSiteidNumberplansNumberplanidGet(siteId, numberPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesSiteidNumberplansNumberplanidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **numberPlanId** | **string**| Number Plan ID |  |
{: class="table table-striped"}

### Return type

[**NumberPlan**](NumberPlan.md)

<a name="ConfigurationSitesSiteidNumberplansPut"></a>
## [**List&lt;NumberPlan&gt;**](NumberPlan.html) ConfigurationSitesSiteidNumberplansPut (string siteId, List<NumberPlan> body = null)

Update the list of Number Plans.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesSiteidNumberplansPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new List<NumberPlan>(); // List<NumberPlan> |  (optional) 

            try
            {
                // Update the list of Number Plans.
                List&lt;NumberPlan&gt; result = apiInstance.ConfigurationSitesSiteidNumberplansPut(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesSiteidNumberplansPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**List<NumberPlan>**](NumberPlan.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**List<NumberPlan>**](NumberPlan.md)

<a name="ConfigurationSitesSiteidPut"></a>
## [**Site**](Site.html) ConfigurationSitesSiteidPut (string siteId, Site body = null)

Update a endpoint.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesSiteidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new Site(); // Site | Site (optional) 

            try
            {
                // Update a endpoint.
                Site result = apiInstance.ConfigurationSitesSiteidPut(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesSiteidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**Site**](Site.md)| Site | [optional]  |
{: class="table table-striped"}

### Return type

[**Site**](Site.md)

<a name="ConfigurationSitesSiteidRebalancePost"></a>
## void ConfigurationSitesSiteidRebalancePost (string siteId)

Triggers the rebalance operation.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationSitesSiteidRebalancePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Triggers the rebalance operation.
                apiInstance.ConfigurationSitesSiteidRebalancePost(siteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.ConfigurationSitesSiteidRebalancePost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

