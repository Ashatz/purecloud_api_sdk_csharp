# ININ.PureCloudApi.Api.ContentManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**ContentmanagementAuditqueryPost**](ContentManagementApi.md#contentmanagementauditquerypost) | **POST** /api/v1/contentmanagement/auditquery | Query audits |
| [**ContentmanagementDocumentsDocumentidAuditsGet**](ContentManagementApi.md#contentmanagementdocumentsdocumentidauditsget) | **GET** /api/v1/contentmanagement/documents/{documentId}/audits | Get a list of audits for a document. |
| [**ContentmanagementDocumentsDocumentidContentGet**](ContentManagementApi.md#contentmanagementdocumentsdocumentidcontentget) | **GET** /api/v1/contentmanagement/documents/{documentId}/content | Download a document. |
| [**ContentmanagementDocumentsDocumentidContentPost**](ContentManagementApi.md#contentmanagementdocumentsdocumentidcontentpost) | **POST** /api/v1/contentmanagement/documents/{documentId}/content | Replace the contents of a document. |
| [**ContentmanagementDocumentsDocumentidDelete**](ContentManagementApi.md#contentmanagementdocumentsdocumentiddelete) | **DELETE** /api/v1/contentmanagement/documents/{documentId} | Delete a document. |
| [**ContentmanagementDocumentsDocumentidGet**](ContentManagementApi.md#contentmanagementdocumentsdocumentidget) | **GET** /api/v1/contentmanagement/documents/{documentId} | Get a document. |
| [**ContentmanagementDocumentsDocumentidPost**](ContentManagementApi.md#contentmanagementdocumentsdocumentidpost) | **POST** /api/v1/contentmanagement/documents/{documentId} | Update a document. |
| [**ContentmanagementDocumentsGet**](ContentManagementApi.md#contentmanagementdocumentsget) | **GET** /api/v1/contentmanagement/documents | Get a list of documents. |
| [**ContentmanagementDocumentsPost**](ContentManagementApi.md#contentmanagementdocumentspost) | **POST** /api/v1/contentmanagement/documents | Add a document. |
| [**ContentmanagementQueryGet**](ContentManagementApi.md#contentmanagementqueryget) | **GET** /api/v1/contentmanagement/query | Query content |
| [**ContentmanagementQueryPost**](ContentManagementApi.md#contentmanagementquerypost) | **POST** /api/v1/contentmanagement/query | Query content |
| [**ContentmanagementSecurityprofilesGet**](ContentManagementApi.md#contentmanagementsecurityprofilesget) | **GET** /api/v1/contentmanagement/securityprofiles | Get a List of Security Profiles |
| [**ContentmanagementSecurityprofilesSecurityprofileidGet**](ContentManagementApi.md#contentmanagementsecurityprofilessecurityprofileidget) | **GET** /api/v1/contentmanagement/securityprofiles/{securityProfileId} | Get a Security Profile |
| [**ContentmanagementSharedSharedidGet**](ContentManagementApi.md#contentmanagementsharedsharedidget) | **GET** /api/v1/contentmanagement/shared/{sharedId} | Get shared documents. Securely download a shared document. |
| [**ContentmanagementSharesGet**](ContentManagementApi.md#contentmanagementsharesget) | **GET** /api/v1/contentmanagement/shares | Gets a list of shares.  You must specify at least one filter (e.g. entityId). |
| [**ContentmanagementSharesPost**](ContentManagementApi.md#contentmanagementsharespost) | **POST** /api/v1/contentmanagement/shares | Creates a new share or updates an existing share if the entity has already been shared |
| [**ContentmanagementSharesShareidDelete**](ContentManagementApi.md#contentmanagementsharesshareiddelete) | **DELETE** /api/v1/contentmanagement/shares/{shareId} | Deletes an existing share. |
| [**ContentmanagementSharesShareidGet**](ContentManagementApi.md#contentmanagementsharesshareidget) | **GET** /api/v1/contentmanagement/shares/{shareId} | Retrieve details about an existing share. |
| [**ContentmanagementStatusGet**](ContentManagementApi.md#contentmanagementstatusget) | **GET** /api/v1/contentmanagement/status | Get a list of statuses for pending operations |
| [**ContentmanagementStatusStatusidDelete**](ContentManagementApi.md#contentmanagementstatusstatusiddelete) | **DELETE** /api/v1/contentmanagement/status/{statusId} | Cancel the command for this status |
| [**ContentmanagementStatusStatusidGet**](ContentManagementApi.md#contentmanagementstatusstatusidget) | **GET** /api/v1/contentmanagement/status/{statusId} | Get a status. |
| [**ContentmanagementWorkspacesGet**](ContentManagementApi.md#contentmanagementworkspacesget) | **GET** /api/v1/contentmanagement/workspaces | Get a list of workspaces. |
| [**ContentmanagementWorkspacesPost**](ContentManagementApi.md#contentmanagementworkspacespost) | **POST** /api/v1/contentmanagement/workspaces | Create a group workspace |
| [**ContentmanagementWorkspacesWorkspaceidDelete**](ContentManagementApi.md#contentmanagementworkspacesworkspaceiddelete) | **DELETE** /api/v1/contentmanagement/workspaces/{workspaceId} | Delete a workspace |
| [**ContentmanagementWorkspacesWorkspaceidGet**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidget) | **GET** /api/v1/contentmanagement/workspaces/{workspaceId} | Get a workspace. |
| [**ContentmanagementWorkspacesWorkspaceidMembersGet**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidmembersget) | **GET** /api/v1/contentmanagement/workspaces/{workspaceId}/members | Get a list workspace members |
| [**ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidmembersmemberiddelete) | **DELETE** /api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId} | Delete a member from a workspace |
| [**ContentmanagementWorkspacesWorkspaceidMembersMemberidGet**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidmembersmemberidget) | **GET** /api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId} | Get a workspace member |
| [**ContentmanagementWorkspacesWorkspaceidMembersMemberidPut**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidmembersmemberidput) | **PUT** /api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId} | Add a member to a workspace |
| [**ContentmanagementWorkspacesWorkspaceidPut**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidput) | **PUT** /api/v1/contentmanagement/workspaces/{workspaceId} | Update a workspace |
| [**ContentmanagementWorkspacesWorkspaceidTagvaluesGet**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidtagvaluesget) | **GET** /api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues | Get a list of workspace tags |
| [**ContentmanagementWorkspacesWorkspaceidTagvaluesPost**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidtagvaluespost) | **POST** /api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues | Create a workspace tag |
| [**ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidtagvaluesquerypost) | **POST** /api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/query | Perform a prefix query on tags in the workspace |
| [**ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidtagvaluestagiddelete) | **DELETE** /api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId} | Delete workspace tag |
| [**ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidtagvaluestagidget) | **GET** /api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId} | Get a workspace tag |
| [**ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut**](ContentManagementApi.md#contentmanagementworkspacesworkspaceidtagvaluestagidput) | **PUT** /api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId} | Update a workspace tag. Will update all documents with the new tag value. |
{: class="table table-striped"}

<a name="ContentmanagementAuditqueryPost"></a>
## [**QueryResults**](QueryResults.html) ContentmanagementAuditqueryPost (ContentQueryRequest body)

Query audits



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementAuditqueryPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var body = new ContentQueryRequest(); // ContentQueryRequest | Allows for a filtered query returning facet information

            try
            {
                // Query audits
                QueryResults result = apiInstance.ContentmanagementAuditqueryPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementAuditqueryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContentQueryRequest**](ContentQueryRequest.md)| Allows for a filtered query returning facet information |  |
{: class="table table-striped"}

### Return type

[**QueryResults**](QueryResults.md)

<a name="ContentmanagementDocumentsDocumentidAuditsGet"></a>
## [**DocumentAuditEntityListing**](DocumentAuditEntityListing.html) ContentmanagementDocumentsDocumentidAuditsGet (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)

Get a list of audits for a document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementDocumentsDocumentidAuditsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var transactionFilter = transactionFilter_example;  // string | Transaction filter (optional) 
            var level = level_example;  // string | level (optional)  (default to USER)
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)

            try
            {
                // Get a list of audits for a document.
                DocumentAuditEntityListing result = apiInstance.ContentmanagementDocumentsDocumentidAuditsGet(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementDocumentsDocumentidAuditsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **transactionFilter** | **string**| Transaction filter | [optional]  |
| **level** | **string**| level | [optional] [default to USER] |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending] |
{: class="table table-striped"}

### Return type

[**DocumentAuditEntityListing**](DocumentAuditEntityListing.md)

<a name="ContentmanagementDocumentsDocumentidContentGet"></a>
## void ContentmanagementDocumentsDocumentidContentGet (string documentId, string disposition = null)

Download a document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementDocumentsDocumentidContentGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var disposition = disposition_example;  // string | Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional) 

            try
            {
                // Download a document.
                apiInstance.ContentmanagementDocumentsDocumentidContentGet(documentId, disposition);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementDocumentsDocumentidContentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **disposition** | **string**| Request how the content will be downloaded: attached as a file or inline. Default is attachment. | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ContentmanagementDocumentsDocumentidContentPost"></a>
## [**ReplaceResponse**](ReplaceResponse.html) ContentmanagementDocumentsDocumentidContentPost (string documentId, ReplaceRequest body = null, bool? _override = null)

Replace the contents of a document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementDocumentsDocumentidContentPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var body = new ReplaceRequest(); // ReplaceRequest | Replace Request (optional) 
            var _override = true;  // bool? | Override any lock on the document (optional) 

            try
            {
                // Replace the contents of a document.
                ReplaceResponse result = apiInstance.ContentmanagementDocumentsDocumentidContentPost(documentId, body, _override);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementDocumentsDocumentidContentPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **body** | [**ReplaceRequest**](ReplaceRequest.md)| Replace Request | [optional]  |
| **_override** | **bool?**| Override any lock on the document | [optional]  |
{: class="table table-striped"}

### Return type

[**ReplaceResponse**](ReplaceResponse.md)

<a name="ContentmanagementDocumentsDocumentidDelete"></a>
## void ContentmanagementDocumentsDocumentidDelete (string documentId, bool? _override = null)

Delete a document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementDocumentsDocumentidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var _override = true;  // bool? | Override any lock on the document (optional) 

            try
            {
                // Delete a document.
                apiInstance.ContentmanagementDocumentsDocumentidDelete(documentId, _override);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementDocumentsDocumentidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **_override** | **bool?**| Override any lock on the document | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ContentmanagementDocumentsDocumentidGet"></a>
## [**Document**](Document.html) ContentmanagementDocumentsDocumentidGet (string documentId, string expand = null)

Get a document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementDocumentsDocumentidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            {
                // Get a document.
                Document result = apiInstance.ContentmanagementDocumentsDocumentidGet(documentId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementDocumentsDocumentidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**Document**](Document.md)

<a name="ContentmanagementDocumentsDocumentidPost"></a>
## [**Document**](Document.html) ContentmanagementDocumentsDocumentidPost (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)

Update a document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementDocumentsDocumentidPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var body = new DocumentUpdate(); // DocumentUpdate | Document (optional) 
            var expand = expand_example;  // string | Expand some document fields (optional) 
            var _override = true;  // bool? | Override any lock on the document (optional) 

            try
            {
                // Update a document.
                Document result = apiInstance.ContentmanagementDocumentsDocumentidPost(documentId, body, expand, _override);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementDocumentsDocumentidPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **body** | [**DocumentUpdate**](DocumentUpdate.md)| Document | [optional]  |
| **expand** | **string**| Expand some document fields | [optional]  |
| **_override** | **bool?**| Override any lock on the document | [optional]  |
{: class="table table-striped"}

### Return type

[**Document**](Document.md)

<a name="ContentmanagementDocumentsGet"></a>
## [**DocumentEntityListing**](DocumentEntityListing.html) ContentmanagementDocumentsGet (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)

Get a list of documents.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementDocumentsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var name = name_example;  // string | Name (optional) 
            var expand = expand_example;  // string | Expand some document fields (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | name or dateCreated (optional) 
            var sortOrder = sortOrder_example;  // string | ascending or descending (optional)  (default to ascending)

            try
            {
                // Get a list of documents.
                DocumentEntityListing result = apiInstance.ContentmanagementDocumentsGet(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementDocumentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **name** | **string**| Name | [optional]  |
| **expand** | **string**| Expand some document fields | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| name or dateCreated | [optional]  |
| **sortOrder** | **string**| ascending or descending | [optional] [default to ascending] |
{: class="table table-striped"}

### Return type

[**DocumentEntityListing**](DocumentEntityListing.md)

<a name="ContentmanagementDocumentsPost"></a>
## [**Document**](Document.html) ContentmanagementDocumentsPost (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)

Add a document.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementDocumentsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var body = new DocumentUpload(); // DocumentUpload | Document (optional) 
            var copySource = copySource_example;  // string | Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional) 
            var moveSource = moveSource_example;  // string | Move a document to a new workspace. Provide a document ID as the move source. (optional) 
            var _override = true;  // bool? | Override any lock on the source document (optional) 

            try
            {
                // Add a document.
                Document result = apiInstance.ContentmanagementDocumentsPost(body, copySource, moveSource, _override);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementDocumentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DocumentUpload**](DocumentUpload.md)| Document | [optional]  |
| **copySource** | **string**| Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. | [optional]  |
| **moveSource** | **string**| Move a document to a new workspace. Provide a document ID as the move source. | [optional]  |
| **_override** | **bool?**| Override any lock on the source document | [optional]  |
{: class="table table-striped"}

### Return type

[**Document**](Document.md)

<a name="ContentmanagementQueryGet"></a>
## [**QueryResults**](QueryResults.html) ContentmanagementQueryGet (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)

Query content



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementQueryGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var queryPhrase = queryPhrase_example;  // string | Phrase tokens are ANDed together over all searchable fields
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | name or dateCreated (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | ascending or descending (optional)  (default to ascending)
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            {
                // Query content
                QueryResults result = apiInstance.ContentmanagementQueryGet(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementQueryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **queryPhrase** | **string**| Phrase tokens are ANDed together over all searchable fields |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| name or dateCreated | [optional] [default to name] |
| **sortOrder** | **string**| ascending or descending | [optional] [default to ascending] |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**QueryResults**](QueryResults.md)

<a name="ContentmanagementQueryPost"></a>
## [**QueryResults**](QueryResults.html) ContentmanagementQueryPost (QueryRequest body, string expand = null)

Query content



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementQueryPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var body = new QueryRequest(); // QueryRequest | Allows for a filtered query returning facet information
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            {
                // Query content
                QueryResults result = apiInstance.ContentmanagementQueryPost(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementQueryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**QueryRequest**](QueryRequest.md)| Allows for a filtered query returning facet information |  |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**QueryResults**](QueryResults.md)

<a name="ContentmanagementSecurityprofilesGet"></a>
## [**SecurityProfileEntityListing**](SecurityProfileEntityListing.html) ContentmanagementSecurityprofilesGet ()

Get a List of Security Profiles



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementSecurityprofilesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();

            try
            {
                // Get a List of Security Profiles
                SecurityProfileEntityListing result = apiInstance.ContentmanagementSecurityprofilesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementSecurityprofilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**SecurityProfileEntityListing**](SecurityProfileEntityListing.md)

<a name="ContentmanagementSecurityprofilesSecurityprofileidGet"></a>
## [**SecurityProfile**](SecurityProfile.html) ContentmanagementSecurityprofilesSecurityprofileidGet (string securityProfileId)

Get a Security Profile



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementSecurityprofilesSecurityprofileidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var securityProfileId = securityProfileId_example;  // string | Security Profile Id

            try
            {
                // Get a Security Profile
                SecurityProfile result = apiInstance.ContentmanagementSecurityprofilesSecurityprofileidGet(securityProfileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementSecurityprofilesSecurityprofileidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **securityProfileId** | **string**| Security Profile Id |  |
{: class="table table-striped"}

### Return type

[**SecurityProfile**](SecurityProfile.md)

<a name="ContentmanagementSharedSharedidGet"></a>
## void ContentmanagementSharedSharedidGet (string sharedId, bool? redirect = null, string disposition = null, string expand = null)

Get shared documents. Securely download a shared document.

This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementSharedSharedidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var sharedId = sharedId_example;  // string | Shared ID
            var redirect = true;  // bool? | Turn on or off redirect (optional)  (default to true)
            var disposition = disposition_example;  // string | Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional)  (default to attachment)
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            {
                // Get shared documents. Securely download a shared document.
                apiInstance.ContentmanagementSharedSharedidGet(sharedId, redirect, disposition, expand);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementSharedSharedidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sharedId** | **string**| Shared ID |  |
| **redirect** | **bool?**| Turn on or off redirect | [optional] [default to true] |
| **disposition** | **string**| Request how the share content will be downloaded: attached as a file or inline. Default is attachment. | [optional] [default to attachment] |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ContentmanagementSharesGet"></a>
## [**ShareEntityListing**](ShareEntityListing.html) ContentmanagementSharesGet (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)

Gets a list of shares.  You must specify at least one filter (e.g. entityId).

Failing to specify a filter will return 400.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementSharesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var entityId = entityId_example;  // string | Filters the shares returned to only the entity specified by the value of this parameter. (optional) 
            var expand = expand_example;  // string | Expand share fields (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Gets a list of shares.  You must specify at least one filter (e.g. entityId).
                ShareEntityListing result = apiInstance.ContentmanagementSharesGet(entityId, expand, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementSharesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **entityId** | **string**| Filters the shares returned to only the entity specified by the value of this parameter. | [optional]  |
| **expand** | **string**| Expand share fields | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**ShareEntityListing**](ShareEntityListing.md)

<a name="ContentmanagementSharesPost"></a>
## [**CreateShareResponse**](CreateShareResponse.html) ContentmanagementSharesPost (CreateShareRequest body = null)

Creates a new share or updates an existing share if the entity has already been shared



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementSharesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var body = new CreateShareRequest(); // CreateShareRequest | CreateShareRequest - entity id and type and a single member or list of members are required (optional) 

            try
            {
                // Creates a new share or updates an existing share if the entity has already been shared
                CreateShareResponse result = apiInstance.ContentmanagementSharesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementSharesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateShareRequest**](CreateShareRequest.md)| CreateShareRequest - entity id and type and a single member or list of members are required | [optional]  |
{: class="table table-striped"}

### Return type

[**CreateShareResponse**](CreateShareResponse.md)

<a name="ContentmanagementSharesShareidDelete"></a>
## void ContentmanagementSharesShareidDelete (string shareId)

Deletes an existing share.

This revokes sharing rights specified in the share record

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementSharesShareidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var shareId = shareId_example;  // string | Share ID

            try
            {
                // Deletes an existing share.
                apiInstance.ContentmanagementSharesShareidDelete(shareId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementSharesShareidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **shareId** | **string**| Share ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ContentmanagementSharesShareidGet"></a>
## [**Share**](Share.html) ContentmanagementSharesShareidGet (string shareId, string expand = null)

Retrieve details about an existing share.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementSharesShareidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var shareId = shareId_example;  // string | Share ID
            var expand = expand_example;  // string | Expand share fields (optional) 

            try
            {
                // Retrieve details about an existing share.
                Share result = apiInstance.ContentmanagementSharesShareidGet(shareId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementSharesShareidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **shareId** | **string**| Share ID |  |
| **expand** | **string**| Expand share fields | [optional]  |
{: class="table table-striped"}

### Return type

[**Share**](Share.md)

<a name="ContentmanagementStatusGet"></a>
## [**CommandStatusEntityListing**](CommandStatusEntityListing.html) ContentmanagementStatusGet (int? pageSize = null, int? pageNumber = null)

Get a list of statuses for pending operations



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementStatusGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get a list of statuses for pending operations
                CommandStatusEntityListing result = apiInstance.ContentmanagementStatusGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementStatusGet: " + e.Message );
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

[**CommandStatusEntityListing**](CommandStatusEntityListing.md)

<a name="ContentmanagementStatusStatusidDelete"></a>
## void ContentmanagementStatusStatusidDelete (string statusId)

Cancel the command for this status



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementStatusStatusidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var statusId = statusId_example;  // string | Status ID

            try
            {
                // Cancel the command for this status
                apiInstance.ContentmanagementStatusStatusidDelete(statusId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementStatusStatusidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **statusId** | **string**| Status ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ContentmanagementStatusStatusidGet"></a>
## [**CommandStatus**](CommandStatus.html) ContentmanagementStatusStatusidGet (string statusId)

Get a status.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementStatusStatusidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var statusId = statusId_example;  // string | Status ID

            try
            {
                // Get a status.
                CommandStatus result = apiInstance.ContentmanagementStatusStatusidGet(statusId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementStatusStatusidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **statusId** | **string**| Status ID |  |
{: class="table table-striped"}

### Return type

[**CommandStatus**](CommandStatus.md)

<a name="ContentmanagementWorkspacesGet"></a>
## [**WorkspaceEntityListing**](WorkspaceEntityListing.html) ContentmanagementWorkspacesGet (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)

Get a list of workspaces.

Specifying 'content' access will return all workspaces the user has document access to, while 'admin' access will return all group workspaces the user has administrative rights to.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var access = access_example;  // string | Requested access level (optional)  (default to document:viewmetadata)
            var expand = expand_example;  // string | Expand some workspace fields (optional) 

            try
            {
                // Get a list of workspaces.
                WorkspaceEntityListing result = apiInstance.ContentmanagementWorkspacesGet(pageSize, pageNumber, access, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesGet: " + e.Message );
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
| **access** | **string**| Requested access level | [optional] [default to document:viewmetadata] |
| **expand** | **string**| Expand some workspace fields | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkspaceEntityListing**](WorkspaceEntityListing.md)

<a name="ContentmanagementWorkspacesPost"></a>
## [**Workspace**](Workspace.html) ContentmanagementWorkspacesPost (WorkspaceCreate body = null)

Create a group workspace



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var body = new WorkspaceCreate(); // WorkspaceCreate | Workspace (optional) 

            try
            {
                // Create a group workspace
                Workspace result = apiInstance.ContentmanagementWorkspacesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorkspaceCreate**](WorkspaceCreate.md)| Workspace | [optional]  |
{: class="table table-striped"}

### Return type

[**Workspace**](Workspace.md)

<a name="ContentmanagementWorkspacesWorkspaceidDelete"></a>
## void ContentmanagementWorkspacesWorkspaceidDelete (string workspaceId, string moveChildrenToWorkspaceId = null)

Delete a workspace



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var moveChildrenToWorkspaceId = moveChildrenToWorkspaceId_example;  // string | New location for objects in deleted workspace. (optional) 

            try
            {
                // Delete a workspace
                apiInstance.ContentmanagementWorkspacesWorkspaceidDelete(workspaceId, moveChildrenToWorkspaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **moveChildrenToWorkspaceId** | **string**| New location for objects in deleted workspace. | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ContentmanagementWorkspacesWorkspaceidGet"></a>
## [**Workspace**](Workspace.html) ContentmanagementWorkspacesWorkspaceidGet (string workspaceId, string expand = null)

Get a workspace.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var expand = expand_example;  // string | Expand some workspace fields (optional) 

            try
            {
                // Get a workspace.
                Workspace result = apiInstance.ContentmanagementWorkspacesWorkspaceidGet(workspaceId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **expand** | **string**| Expand some workspace fields | [optional]  |
{: class="table table-striped"}

### Return type

[**Workspace**](Workspace.md)

<a name="ContentmanagementWorkspacesWorkspaceidMembersGet"></a>
## [**WorkspaceMemberEntityListing**](WorkspaceMemberEntityListing.html) ContentmanagementWorkspacesWorkspaceidMembersGet (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)

Get a list workspace members



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidMembersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand workspace member fields (optional) 

            try
            {
                // Get a list workspace members
                WorkspaceMemberEntityListing result = apiInstance.ContentmanagementWorkspacesWorkspaceidMembersGet(workspaceId, pageSize, pageNumber, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand workspace member fields | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkspaceMemberEntityListing**](WorkspaceMemberEntityListing.md)

<a name="ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete"></a>
## void ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete (string workspaceId, string memberId)

Delete a member from a workspace



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var memberId = memberId_example;  // string | Member ID

            try
            {
                // Delete a member from a workspace
                apiInstance.ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete(workspaceId, memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **memberId** | **string**| Member ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ContentmanagementWorkspacesWorkspaceidMembersMemberidGet"></a>
## [**WorkspaceMember**](WorkspaceMember.html) ContentmanagementWorkspacesWorkspaceidMembersMemberidGet (string workspaceId, string memberId, string expand = null)

Get a workspace member



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidMembersMemberidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var memberId = memberId_example;  // string | Member ID
            var expand = expand_example;  // string | Expand workspace member fields (optional) 

            try
            {
                // Get a workspace member
                WorkspaceMember result = apiInstance.ContentmanagementWorkspacesWorkspaceidMembersMemberidGet(workspaceId, memberId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **memberId** | **string**| Member ID |  |
| **expand** | **string**| Expand workspace member fields | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkspaceMember**](WorkspaceMember.md)

<a name="ContentmanagementWorkspacesWorkspaceidMembersMemberidPut"></a>
## [**WorkspaceMember**](WorkspaceMember.html) ContentmanagementWorkspacesWorkspaceidMembersMemberidPut (string workspaceId, string memberId, WorkspaceMember body = null)

Add a member to a workspace



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidMembersMemberidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var memberId = memberId_example;  // string | Member ID
            var body = new WorkspaceMember(); // WorkspaceMember | Workspace (optional) 

            try
            {
                // Add a member to a workspace
                WorkspaceMember result = apiInstance.ContentmanagementWorkspacesWorkspaceidMembersMemberidPut(workspaceId, memberId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**WorkspaceMember**](WorkspaceMember.md)| Workspace | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkspaceMember**](WorkspaceMember.md)

<a name="ContentmanagementWorkspacesWorkspaceidPut"></a>
## [**Workspace**](Workspace.html) ContentmanagementWorkspacesWorkspaceidPut (string workspaceId, Workspace body = null)

Update a workspace



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var body = new Workspace(); // Workspace | Workspace (optional) 

            try
            {
                // Update a workspace
                Workspace result = apiInstance.ContentmanagementWorkspacesWorkspaceidPut(workspaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **body** | [**Workspace**](Workspace.md)| Workspace | [optional]  |
{: class="table table-striped"}

### Return type

[**Workspace**](Workspace.md)

<a name="ContentmanagementWorkspacesWorkspaceidTagvaluesGet"></a>
## [**TagValueEntityListing**](TagValueEntityListing.html) ContentmanagementWorkspacesWorkspaceidTagvaluesGet (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)

Get a list of workspace tags



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidTagvaluesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var value = value_example;  // string | filter the list of tags returned (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            {
                // Get a list of workspace tags
                TagValueEntityListing result = apiInstance.ContentmanagementWorkspacesWorkspaceidTagvaluesGet(workspaceId, value, pageSize, pageNumber, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **value** | **string**| filter the list of tags returned | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**TagValueEntityListing**](TagValueEntityListing.md)

<a name="ContentmanagementWorkspacesWorkspaceidTagvaluesPost"></a>
## [**TagValue**](TagValue.html) ContentmanagementWorkspacesWorkspaceidTagvaluesPost (string workspaceId, TagValue body = null)

Create a workspace tag



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidTagvaluesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var body = new TagValue(); // TagValue | tag (optional) 

            try
            {
                // Create a workspace tag
                TagValue result = apiInstance.ContentmanagementWorkspacesWorkspaceidTagvaluesPost(workspaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **body** | [**TagValue**](TagValue.md)| tag | [optional]  |
{: class="table table-striped"}

### Return type

[**TagValue**](TagValue.md)

<a name="ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost"></a>
## [**TagValueEntityListing**](TagValueEntityListing.html) ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost (string workspaceId, TagQueryRequest body = null, string expand = null)

Perform a prefix query on tags in the workspace



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var body = new TagQueryRequest(); // TagQueryRequest | query (optional) 
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            {
                // Perform a prefix query on tags in the workspace
                TagValueEntityListing result = apiInstance.ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost(workspaceId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **body** | [**TagQueryRequest**](TagQueryRequest.md)| query | [optional]  |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**TagValueEntityListing**](TagValueEntityListing.md)

<a name="ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete"></a>
## void ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete (string workspaceId, string tagId)

Delete workspace tag

Delete a tag from a workspace. Will remove this tag from all documents.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var tagId = tagId_example;  // string | Tag ID

            try
            {
                // Delete workspace tag
                apiInstance.ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete(workspaceId, tagId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **tagId** | **string**| Tag ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet"></a>
## [**TagValue**](TagValue.html) ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet (string workspaceId, string tagId, string expand = null)

Get a workspace tag



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var tagId = tagId_example;  // string | Tag ID
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            {
                // Get a workspace tag
                TagValue result = apiInstance.ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet(workspaceId, tagId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **tagId** | **string**| Tag ID |  |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**TagValue**](TagValue.md)

<a name="ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut"></a>
## [**TagValue**](TagValue.html) ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut (string workspaceId, string tagId, TagValue body = null)

Update a workspace tag. Will update all documents with the new tag value.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var workspaceId = workspaceId_example;  // string | Workspace ID
            var tagId = tagId_example;  // string | Tag ID
            var body = new TagValue(); // TagValue | Workspace (optional) 

            try
            {
                // Update a workspace tag. Will update all documents with the new tag value.
                TagValue result = apiInstance.ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut(workspaceId, tagId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **tagId** | **string**| Tag ID |  |
| **body** | [**TagValue**](TagValue.md)| Workspace | [optional]  |
{: class="table table-striped"}

### Return type

[**TagValue**](TagValue.md)

