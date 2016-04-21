# ININ.PureCloudApi.Api.ContentManagementApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteDocumentsDocumentId**](ContentManagementApi.md#deletedocumentsdocumentid) | **DELETE** /api/v2/contentmanagement/documents/{documentId} | Delete a document. |
| [**DeleteSharesShareId**](ContentManagementApi.md#deletesharesshareid) | **DELETE** /api/v2/contentmanagement/shares/{shareId} | Deletes an existing share. |
| [**DeleteStatusStatusId**](ContentManagementApi.md#deletestatusstatusid) | **DELETE** /api/v2/contentmanagement/status/{statusId} | Cancel the command for this status |
| [**DeleteWorkspacesWorkspaceId**](ContentManagementApi.md#deleteworkspacesworkspaceid) | **DELETE** /api/v2/contentmanagement/workspaces/{workspaceId} | Delete a workspace |
| [**DeleteWorkspacesWorkspaceIdMembersMemberId**](ContentManagementApi.md#deleteworkspacesworkspaceidmembersmemberid) | **DELETE** /api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId} | Delete a member from a workspace |
| [**DeleteWorkspacesWorkspaceIdTagvaluesTagId**](ContentManagementApi.md#deleteworkspacesworkspaceidtagvaluestagid) | **DELETE** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId} | Delete workspace tag |
| [**GetDocuments**](ContentManagementApi.md#getdocuments) | **GET** /api/v2/contentmanagement/documents | Get a list of documents. |
| [**GetDocumentsDocumentId**](ContentManagementApi.md#getdocumentsdocumentid) | **GET** /api/v2/contentmanagement/documents/{documentId} | Get a document. |
| [**GetDocumentsDocumentIdAudits**](ContentManagementApi.md#getdocumentsdocumentidaudits) | **GET** /api/v2/contentmanagement/documents/{documentId}/audits | Get a list of audits for a document. |
| [**GetDocumentsDocumentIdContent**](ContentManagementApi.md#getdocumentsdocumentidcontent) | **GET** /api/v2/contentmanagement/documents/{documentId}/content | Download a document. |
| [**GetQuery**](ContentManagementApi.md#getquery) | **GET** /api/v2/contentmanagement/query | Query content |
| [**GetSecurityprofiles**](ContentManagementApi.md#getsecurityprofiles) | **GET** /api/v2/contentmanagement/securityprofiles | Get a List of Security Profiles |
| [**GetSecurityprofilesSecurityprofileId**](ContentManagementApi.md#getsecurityprofilessecurityprofileid) | **GET** /api/v2/contentmanagement/securityprofiles/{securityProfileId} | Get a Security Profile |
| [**GetSharedSharedId**](ContentManagementApi.md#getsharedsharedid) | **GET** /api/v2/contentmanagement/shared/{sharedId} | Get shared documents. Securely download a shared document. |
| [**GetShares**](ContentManagementApi.md#getshares) | **GET** /api/v2/contentmanagement/shares | Gets a list of shares.  You must specify at least one filter (e.g. entityId). |
| [**GetSharesShareId**](ContentManagementApi.md#getsharesshareid) | **GET** /api/v2/contentmanagement/shares/{shareId} | Retrieve details about an existing share. |
| [**GetStatus**](ContentManagementApi.md#getstatus) | **GET** /api/v2/contentmanagement/status | Get a list of statuses for pending operations |
| [**GetStatusStatusId**](ContentManagementApi.md#getstatusstatusid) | **GET** /api/v2/contentmanagement/status/{statusId} | Get a status. |
| [**GetWorkspaces**](ContentManagementApi.md#getworkspaces) | **GET** /api/v2/contentmanagement/workspaces | Get a list of workspaces. |
| [**GetWorkspacesWorkspaceId**](ContentManagementApi.md#getworkspacesworkspaceid) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId} | Get a workspace. |
| [**GetWorkspacesWorkspaceIdMembers**](ContentManagementApi.md#getworkspacesworkspaceidmembers) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId}/members | Get a list workspace members |
| [**GetWorkspacesWorkspaceIdMembersMemberId**](ContentManagementApi.md#getworkspacesworkspaceidmembersmemberid) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId} | Get a workspace member |
| [**GetWorkspacesWorkspaceIdTagvalues**](ContentManagementApi.md#getworkspacesworkspaceidtagvalues) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues | Get a list of workspace tags |
| [**GetWorkspacesWorkspaceIdTagvaluesTagId**](ContentManagementApi.md#getworkspacesworkspaceidtagvaluestagid) | **GET** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId} | Get a workspace tag |
| [**PostAuditquery**](ContentManagementApi.md#postauditquery) | **POST** /api/v2/contentmanagement/auditquery | Query audits |
| [**PostDocuments**](ContentManagementApi.md#postdocuments) | **POST** /api/v2/contentmanagement/documents | Add a document. |
| [**PostDocumentsDocumentId**](ContentManagementApi.md#postdocumentsdocumentid) | **POST** /api/v2/contentmanagement/documents/{documentId} | Update a document. |
| [**PostDocumentsDocumentIdContent**](ContentManagementApi.md#postdocumentsdocumentidcontent) | **POST** /api/v2/contentmanagement/documents/{documentId}/content | Replace the contents of a document. |
| [**PostQuery**](ContentManagementApi.md#postquery) | **POST** /api/v2/contentmanagement/query | Query content |
| [**PostShares**](ContentManagementApi.md#postshares) | **POST** /api/v2/contentmanagement/shares | Creates a new share or updates an existing share if the entity has already been shared |
| [**PostWorkspaces**](ContentManagementApi.md#postworkspaces) | **POST** /api/v2/contentmanagement/workspaces | Create a group workspace |
| [**PostWorkspacesWorkspaceIdTagvalues**](ContentManagementApi.md#postworkspacesworkspaceidtagvalues) | **POST** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues | Create a workspace tag |
| [**PostWorkspacesWorkspaceIdTagvaluesQuery**](ContentManagementApi.md#postworkspacesworkspaceidtagvaluesquery) | **POST** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/query | Perform a prefix query on tags in the workspace |
| [**PutWorkspacesWorkspaceId**](ContentManagementApi.md#putworkspacesworkspaceid) | **PUT** /api/v2/contentmanagement/workspaces/{workspaceId} | Update a workspace |
| [**PutWorkspacesWorkspaceIdMembersMemberId**](ContentManagementApi.md#putworkspacesworkspaceidmembersmemberid) | **PUT** /api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId} | Add a member to a workspace |
| [**PutWorkspacesWorkspaceIdTagvaluesTagId**](ContentManagementApi.md#putworkspacesworkspaceidtagvaluestagid) | **PUT** /api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId} | Update a workspace tag. Will update all documents with the new tag value. |
{: class="table table-striped"}

<a name="DeleteDocumentsDocumentId"></a>
## void DeleteDocumentsDocumentId (string documentId, bool? _override = null)

Delete a document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteDocumentsDocumentIdExample
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
                apiInstance.DeleteDocumentsDocumentId(documentId, _override);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteDocumentsDocumentId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **_override** | **bool?**| Override any lock on the document | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteSharesShareId"></a>
## void DeleteSharesShareId (string shareId)

Deletes an existing share.

This revokes sharing rights specified in the share record

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteSharesShareIdExample
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
                apiInstance.DeleteSharesShareId(shareId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteSharesShareId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **shareId** | **string**| Share ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteStatusStatusId"></a>
## void DeleteStatusStatusId (string statusId)

Cancel the command for this status



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteStatusStatusIdExample
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
                apiInstance.DeleteStatusStatusId(statusId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteStatusStatusId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **statusId** | **string**| Status ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteWorkspacesWorkspaceId"></a>
## void DeleteWorkspacesWorkspaceId (string workspaceId, string moveChildrenToWorkspaceId = null)

Delete a workspace



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteWorkspacesWorkspaceIdExample
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
                apiInstance.DeleteWorkspacesWorkspaceId(workspaceId, moveChildrenToWorkspaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteWorkspacesWorkspaceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **moveChildrenToWorkspaceId** | **string**| New location for objects in deleted workspace. | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteWorkspacesWorkspaceIdMembersMemberId"></a>
## void DeleteWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId)

Delete a member from a workspace



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteWorkspacesWorkspaceIdMembersMemberIdExample
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
                apiInstance.DeleteWorkspacesWorkspaceIdMembersMemberId(workspaceId, memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteWorkspacesWorkspaceIdMembersMemberId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **memberId** | **string**| Member ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteWorkspacesWorkspaceIdTagvaluesTagId"></a>
## void DeleteWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId)

Delete workspace tag

Delete a tag from a workspace. Will remove this tag from all documents.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteWorkspacesWorkspaceIdTagvaluesTagIdExample
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
                apiInstance.DeleteWorkspacesWorkspaceIdTagvaluesTagId(workspaceId, tagId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **tagId** | **string**| Tag ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="GetDocuments"></a>
## [**DocumentEntityListing**](DocumentEntityListing.html) GetDocuments (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)

Get a list of documents.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDocumentsExample
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
                DocumentEntityListing result = apiInstance.GetDocuments(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetDocuments: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetDocumentsDocumentId"></a>
## [**Document**](Document.html) GetDocumentsDocumentId (string documentId, string expand = null)

Get a document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDocumentsDocumentIdExample
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
                Document result = apiInstance.GetDocumentsDocumentId(documentId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetDocumentsDocumentId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**Document**](Document.md)

<a name="GetDocumentsDocumentIdAudits"></a>
## [**DocumentAuditEntityListing**](DocumentAuditEntityListing.html) GetDocumentsDocumentIdAudits (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)

Get a list of audits for a document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDocumentsDocumentIdAuditsExample
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
                DocumentAuditEntityListing result = apiInstance.GetDocumentsDocumentIdAudits(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetDocumentsDocumentIdAudits: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetDocumentsDocumentIdContent"></a>
## void GetDocumentsDocumentIdContent (string documentId, string disposition = null, string contentType = null)

Download a document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDocumentsDocumentIdContentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var documentId = documentId_example;  // string | Document ID
            var disposition = disposition_example;  // string | Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional) 
            var contentType = contentType_example;  // string | The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav (optional) 

            try
            {
                // Download a document.
                apiInstance.GetDocumentsDocumentIdContent(documentId, disposition, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetDocumentsDocumentIdContent: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **disposition** | **string**| Request how the content will be downloaded: attached as a file or inline. Default is attachment. | [optional]  |
| **contentType** | **string**| The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="GetQuery"></a>
## [**QueryResults**](QueryResults.html) GetQuery (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)

Query content



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetQueryExample
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
                QueryResults result = apiInstance.GetQuery(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetQuery: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetSecurityprofiles"></a>
## [**SecurityProfileEntityListing**](SecurityProfileEntityListing.html) GetSecurityprofiles ()

Get a List of Security Profiles



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSecurityprofilesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();

            try
            {
                // Get a List of Security Profiles
                SecurityProfileEntityListing result = apiInstance.GetSecurityprofiles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetSecurityprofiles: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**SecurityProfileEntityListing**](SecurityProfileEntityListing.md)

<a name="GetSecurityprofilesSecurityprofileId"></a>
## [**SecurityProfile**](SecurityProfile.html) GetSecurityprofilesSecurityprofileId (string securityProfileId)

Get a Security Profile



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSecurityprofilesSecurityprofileIdExample
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
                SecurityProfile result = apiInstance.GetSecurityprofilesSecurityprofileId(securityProfileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetSecurityprofilesSecurityprofileId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **securityProfileId** | **string**| Security Profile Id |  |
{: class="table table-striped"}

### Return type

[**SecurityProfile**](SecurityProfile.md)

<a name="GetSharedSharedId"></a>
## void GetSharedSharedId (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)

Get shared documents. Securely download a shared document.

This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSharedSharedIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ContentManagementApi();
            var sharedId = sharedId_example;  // string | Shared ID
            var redirect = true;  // bool? | Turn on or off redirect (optional)  (default to true)
            var disposition = disposition_example;  // string | Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional)  (default to attachment)
            var contentType = contentType_example;  // string | The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav (optional) 
            var expand = expand_example;  // string | Expand some document fields (optional) 

            try
            {
                // Get shared documents. Securely download a shared document.
                apiInstance.GetSharedSharedId(sharedId, redirect, disposition, contentType, expand);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetSharedSharedId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sharedId** | **string**| Shared ID |  |
| **redirect** | **bool?**| Turn on or off redirect | [optional] [default to true] |
| **disposition** | **string**| Request how the share content will be downloaded: attached as a file or inline. Default is attachment. | [optional] [default to attachment] |
| **contentType** | **string**| The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav | [optional]  |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="GetShares"></a>
## [**ShareEntityListing**](ShareEntityListing.html) GetShares (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)

Gets a list of shares.  You must specify at least one filter (e.g. entityId).

Failing to specify a filter will return 400.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSharesExample
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
                ShareEntityListing result = apiInstance.GetShares(entityId, expand, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetShares: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetSharesShareId"></a>
## [**Share**](Share.html) GetSharesShareId (string shareId, string expand = null)

Retrieve details about an existing share.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSharesShareIdExample
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
                Share result = apiInstance.GetSharesShareId(shareId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetSharesShareId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **shareId** | **string**| Share ID |  |
| **expand** | **string**| Expand share fields | [optional]  |
{: class="table table-striped"}

### Return type

[**Share**](Share.md)

<a name="GetStatus"></a>
## [**CommandStatusEntityListing**](CommandStatusEntityListing.html) GetStatus (int? pageSize = null, int? pageNumber = null)

Get a list of statuses for pending operations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetStatusExample
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
                CommandStatusEntityListing result = apiInstance.GetStatus(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetStatus: " + e.Message );
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

[**CommandStatusEntityListing**](CommandStatusEntityListing.md)

<a name="GetStatusStatusId"></a>
## [**CommandStatus**](CommandStatus.html) GetStatusStatusId (string statusId)

Get a status.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetStatusStatusIdExample
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
                CommandStatus result = apiInstance.GetStatusStatusId(statusId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetStatusStatusId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **statusId** | **string**| Status ID |  |
{: class="table table-striped"}

### Return type

[**CommandStatus**](CommandStatus.md)

<a name="GetWorkspaces"></a>
## [**WorkspaceEntityListing**](WorkspaceEntityListing.html) GetWorkspaces (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)

Get a list of workspaces.

Specifying 'content' access will return all workspaces the user has document access to, while 'admin' access will return all group workspaces the user has administrative rights to.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetWorkspacesExample
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
                WorkspaceEntityListing result = apiInstance.GetWorkspaces(pageSize, pageNumber, access, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetWorkspaces: " + e.Message );
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
| **access** | **string**| Requested access level | [optional] [default to document:viewmetadata] |
| **expand** | **string**| Expand some workspace fields | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkspaceEntityListing**](WorkspaceEntityListing.md)

<a name="GetWorkspacesWorkspaceId"></a>
## [**Workspace**](Workspace.html) GetWorkspacesWorkspaceId (string workspaceId, string expand = null)

Get a workspace.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetWorkspacesWorkspaceIdExample
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
                Workspace result = apiInstance.GetWorkspacesWorkspaceId(workspaceId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetWorkspacesWorkspaceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **expand** | **string**| Expand some workspace fields | [optional]  |
{: class="table table-striped"}

### Return type

[**Workspace**](Workspace.md)

<a name="GetWorkspacesWorkspaceIdMembers"></a>
## [**WorkspaceMemberEntityListing**](WorkspaceMemberEntityListing.html) GetWorkspacesWorkspaceIdMembers (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)

Get a list workspace members



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetWorkspacesWorkspaceIdMembersExample
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
                WorkspaceMemberEntityListing result = apiInstance.GetWorkspacesWorkspaceIdMembers(workspaceId, pageSize, pageNumber, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetWorkspacesWorkspaceIdMembers: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetWorkspacesWorkspaceIdMembersMemberId"></a>
## [**WorkspaceMember**](WorkspaceMember.html) GetWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, string expand = null)

Get a workspace member



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetWorkspacesWorkspaceIdMembersMemberIdExample
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
                WorkspaceMember result = apiInstance.GetWorkspacesWorkspaceIdMembersMemberId(workspaceId, memberId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetWorkspacesWorkspaceIdMembersMemberId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **memberId** | **string**| Member ID |  |
| **expand** | **string**| Expand workspace member fields | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkspaceMember**](WorkspaceMember.md)

<a name="GetWorkspacesWorkspaceIdTagvalues"></a>
## [**TagValueEntityListing**](TagValueEntityListing.html) GetWorkspacesWorkspaceIdTagvalues (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)

Get a list of workspace tags



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetWorkspacesWorkspaceIdTagvaluesExample
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
                TagValueEntityListing result = apiInstance.GetWorkspacesWorkspaceIdTagvalues(workspaceId, value, pageSize, pageNumber, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetWorkspacesWorkspaceIdTagvalues: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetWorkspacesWorkspaceIdTagvaluesTagId"></a>
## [**TagValue**](TagValue.html) GetWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, string expand = null)

Get a workspace tag



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetWorkspacesWorkspaceIdTagvaluesTagIdExample
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
                TagValue result = apiInstance.GetWorkspacesWorkspaceIdTagvaluesTagId(workspaceId, tagId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.GetWorkspacesWorkspaceIdTagvaluesTagId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **tagId** | **string**| Tag ID |  |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**TagValue**](TagValue.md)

<a name="PostAuditquery"></a>
## [**QueryResults**](QueryResults.html) PostAuditquery (ContentQueryRequest body)

Query audits



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostAuditqueryExample
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
                QueryResults result = apiInstance.PostAuditquery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostAuditquery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContentQueryRequest**](ContentQueryRequest.md)| Allows for a filtered query returning facet information |  |
{: class="table table-striped"}

### Return type

[**QueryResults**](QueryResults.md)

<a name="PostDocuments"></a>
## [**Document**](Document.html) PostDocuments (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)

Add a document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostDocumentsExample
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
                Document result = apiInstance.PostDocuments(body, copySource, moveSource, _override);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostDocuments: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="PostDocumentsDocumentId"></a>
## [**Document**](Document.html) PostDocumentsDocumentId (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)

Update a document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostDocumentsDocumentIdExample
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
                Document result = apiInstance.PostDocumentsDocumentId(documentId, body, expand, _override);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostDocumentsDocumentId: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="PostDocumentsDocumentIdContent"></a>
## [**ReplaceResponse**](ReplaceResponse.html) PostDocumentsDocumentIdContent (string documentId, ReplaceRequest body = null, bool? _override = null)

Replace the contents of a document.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostDocumentsDocumentIdContentExample
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
                ReplaceResponse result = apiInstance.PostDocumentsDocumentIdContent(documentId, body, _override);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostDocumentsDocumentIdContent: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **string**| Document ID |  |
| **body** | [**ReplaceRequest**](ReplaceRequest.md)| Replace Request | [optional]  |
| **_override** | **bool?**| Override any lock on the document | [optional]  |
{: class="table table-striped"}

### Return type

[**ReplaceResponse**](ReplaceResponse.md)

<a name="PostQuery"></a>
## [**QueryResults**](QueryResults.html) PostQuery (QueryRequest body, string expand = null)

Query content



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostQueryExample
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
                QueryResults result = apiInstance.PostQuery(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**QueryRequest**](QueryRequest.md)| Allows for a filtered query returning facet information |  |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**QueryResults**](QueryResults.md)

<a name="PostShares"></a>
## [**CreateShareResponse**](CreateShareResponse.html) PostShares (CreateShareRequest body = null)

Creates a new share or updates an existing share if the entity has already been shared



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostSharesExample
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
                CreateShareResponse result = apiInstance.PostShares(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostShares: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateShareRequest**](CreateShareRequest.md)| CreateShareRequest - entity id and type and a single member or list of members are required | [optional]  |
{: class="table table-striped"}

### Return type

[**CreateShareResponse**](CreateShareResponse.md)

<a name="PostWorkspaces"></a>
## [**Workspace**](Workspace.html) PostWorkspaces (WorkspaceCreate body = null)

Create a group workspace



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostWorkspacesExample
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
                Workspace result = apiInstance.PostWorkspaces(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostWorkspaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WorkspaceCreate**](WorkspaceCreate.md)| Workspace | [optional]  |
{: class="table table-striped"}

### Return type

[**Workspace**](Workspace.md)

<a name="PostWorkspacesWorkspaceIdTagvalues"></a>
## [**TagValue**](TagValue.html) PostWorkspacesWorkspaceIdTagvalues (string workspaceId, TagValue body = null)

Create a workspace tag



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostWorkspacesWorkspaceIdTagvaluesExample
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
                TagValue result = apiInstance.PostWorkspacesWorkspaceIdTagvalues(workspaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostWorkspacesWorkspaceIdTagvalues: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **body** | [**TagValue**](TagValue.md)| tag | [optional]  |
{: class="table table-striped"}

### Return type

[**TagValue**](TagValue.md)

<a name="PostWorkspacesWorkspaceIdTagvaluesQuery"></a>
## [**TagValueEntityListing**](TagValueEntityListing.html) PostWorkspacesWorkspaceIdTagvaluesQuery (string workspaceId, TagQueryRequest body = null, string expand = null)

Perform a prefix query on tags in the workspace



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostWorkspacesWorkspaceIdTagvaluesQueryExample
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
                TagValueEntityListing result = apiInstance.PostWorkspacesWorkspaceIdTagvaluesQuery(workspaceId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PostWorkspacesWorkspaceIdTagvaluesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **body** | [**TagQueryRequest**](TagQueryRequest.md)| query | [optional]  |
| **expand** | **string**| Expand some document fields | [optional]  |
{: class="table table-striped"}

### Return type

[**TagValueEntityListing**](TagValueEntityListing.md)

<a name="PutWorkspacesWorkspaceId"></a>
## [**Workspace**](Workspace.html) PutWorkspacesWorkspaceId (string workspaceId, Workspace body = null)

Update a workspace



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutWorkspacesWorkspaceIdExample
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
                Workspace result = apiInstance.PutWorkspacesWorkspaceId(workspaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PutWorkspacesWorkspaceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **body** | [**Workspace**](Workspace.md)| Workspace | [optional]  |
{: class="table table-striped"}

### Return type

[**Workspace**](Workspace.md)

<a name="PutWorkspacesWorkspaceIdMembersMemberId"></a>
## [**WorkspaceMember**](WorkspaceMember.html) PutWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, WorkspaceMember body = null)

Add a member to a workspace



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutWorkspacesWorkspaceIdMembersMemberIdExample
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
                WorkspaceMember result = apiInstance.PutWorkspacesWorkspaceIdMembersMemberId(workspaceId, memberId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PutWorkspacesWorkspaceIdMembersMemberId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **memberId** | **string**| Member ID |  |
| **body** | [**WorkspaceMember**](WorkspaceMember.md)| Workspace | [optional]  |
{: class="table table-striped"}

### Return type

[**WorkspaceMember**](WorkspaceMember.md)

<a name="PutWorkspacesWorkspaceIdTagvaluesTagId"></a>
## [**TagValue**](TagValue.html) PutWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, TagValue body = null)

Update a workspace tag. Will update all documents with the new tag value.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutWorkspacesWorkspaceIdTagvaluesTagIdExample
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
                TagValue result = apiInstance.PutWorkspacesWorkspaceIdTagvaluesTagId(workspaceId, tagId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentManagementApi.PutWorkspacesWorkspaceIdTagvaluesTagId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **workspaceId** | **string**| Workspace ID |  |
| **tagId** | **string**| Tag ID |  |
| **body** | [**TagValue**](TagValue.md)| Workspace | [optional]  |
{: class="table table-striped"}

### Return type

[**TagValue**](TagValue.md)

