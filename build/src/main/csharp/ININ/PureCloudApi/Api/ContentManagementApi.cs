using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContentManagementApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        QueryResults ContentmanagementAuditqueryPost (ContentQueryRequest body);

        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> ContentmanagementAuditqueryPostWithHttpInfo (ContentQueryRequest body);
        /// <summary>
        /// Get a list of audits for a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="transactionFilter">Transaction filter (optional)</param>
        /// <param name="level">level (optional, default to USER)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <returns>DocumentAuditEntityListing</returns>
        DocumentAuditEntityListing ContentmanagementDocumentsDocumentidAuditsGet (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of audits for a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="transactionFilter">Transaction filter (optional)</param>
        /// <param name="level">level (optional, default to USER)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <returns>ApiResponse of DocumentAuditEntityListing</returns>
        ApiResponse<DocumentAuditEntityListing> ContentmanagementDocumentsDocumentidAuditsGetWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns></returns>
        void ContentmanagementDocumentsDocumentidContentGet (string documentId, string disposition = null);

        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementDocumentsDocumentidContentGetWithHttpInfo (string documentId, string disposition = null);
        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ReplaceResponse</returns>
        ReplaceResponse ContentmanagementDocumentsDocumentidContentPost (string documentId, ReplaceRequest body = null, bool? _override = null);

        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of ReplaceResponse</returns>
        ApiResponse<ReplaceResponse> ContentmanagementDocumentsDocumentidContentPostWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);
        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns></returns>
        void ContentmanagementDocumentsDocumentidDelete (string documentId, bool? _override = null);

        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementDocumentsDocumentidDeleteWithHttpInfo (string documentId, bool? _override = null);
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Document</returns>
        Document ContentmanagementDocumentsDocumentidGet (string documentId, string expand = null);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> ContentmanagementDocumentsDocumentidGetWithHttpInfo (string documentId, string expand = null);
        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Document</returns>
        Document ContentmanagementDocumentsDocumentidPost (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);

        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> ContentmanagementDocumentsDocumentidPostWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>DocumentEntityListing</returns>
        DocumentEntityListing ContentmanagementDocumentsGet (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of DocumentEntityListing</returns>
        ApiResponse<DocumentEntityListing> ContentmanagementDocumentsGetWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Document</returns>
        Document ContentmanagementDocumentsPost (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> ContentmanagementDocumentsPostWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        QueryResults ContentmanagementQueryGet (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> ContentmanagementQueryGetWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        QueryResults ContentmanagementQueryPost (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> ContentmanagementQueryPostWithHttpInfo (QueryRequest body, string expand = null);
        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SecurityProfileEntityListing</returns>
        SecurityProfileEntityListing ContentmanagementSecurityprofilesGet ();

        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        ApiResponse<SecurityProfileEntityListing> ContentmanagementSecurityprofilesGetWithHttpInfo ();
        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>SecurityProfile</returns>
        SecurityProfile ContentmanagementSecurityprofilesSecurityprofileidGet (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>ApiResponse of SecurityProfile</returns>
        ApiResponse<SecurityProfile> ContentmanagementSecurityprofilesSecurityprofileidGetWithHttpInfo (string securityProfileId);
        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns></returns>
        void ContentmanagementSharedSharedidGet (string sharedId, bool? redirect = null, string disposition = null, string expand = null);

        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementSharedSharedidGetWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string expand = null);
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ShareEntityListing</returns>
        ShareEntityListing ContentmanagementSharesGet (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ShareEntityListing</returns>
        ApiResponse<ShareEntityListing> ContentmanagementSharesGetWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>CreateShareResponse</returns>
        CreateShareResponse ContentmanagementSharesPost (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>ApiResponse of CreateShareResponse</returns>
        ApiResponse<CreateShareResponse> ContentmanagementSharesPostWithHttpInfo (CreateShareRequest body = null);
        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns></returns>
        void ContentmanagementSharesShareidDelete (string shareId);

        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementSharesShareidDeleteWithHttpInfo (string shareId);
        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Share</returns>
        Share ContentmanagementSharesShareidGet (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>ApiResponse of Share</returns>
        ApiResponse<Share> ContentmanagementSharesShareidGetWithHttpInfo (string shareId, string expand = null);
        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>CommandStatusEntityListing</returns>
        CommandStatusEntityListing ContentmanagementStatusGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of CommandStatusEntityListing</returns>
        ApiResponse<CommandStatusEntityListing> ContentmanagementStatusGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns></returns>
        void ContentmanagementStatusStatusidDelete (string statusId);

        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementStatusStatusidDeleteWithHttpInfo (string statusId);
        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        CommandStatus ContentmanagementStatusStatusidGet (string statusId);

        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of CommandStatus</returns>
        ApiResponse<CommandStatus> ContentmanagementStatusStatusidGetWithHttpInfo (string statusId);
        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>WorkspaceEntityListing</returns>
        WorkspaceEntityListing ContentmanagementWorkspacesGet (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);

        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceEntityListing</returns>
        ApiResponse<WorkspaceEntityListing> ContentmanagementWorkspacesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        Workspace ContentmanagementWorkspacesPost (WorkspaceCreate body = null);

        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> ContentmanagementWorkspacesPostWithHttpInfo (WorkspaceCreate body = null);
        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns></returns>
        void ContentmanagementWorkspacesWorkspaceidDelete (string workspaceId, string moveChildrenToWorkspaceId = null);

        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidDeleteWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);
        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Workspace</returns>
        Workspace ContentmanagementWorkspacesWorkspaceidGet (string workspaceId, string expand = null);

        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> ContentmanagementWorkspacesWorkspaceidGetWithHttpInfo (string workspaceId, string expand = null);
        /// <summary>
        /// Get a list workspace members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>WorkspaceMemberEntityListing</returns>
        WorkspaceMemberEntityListing ContentmanagementWorkspacesWorkspaceidMembersGet (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list workspace members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceMemberEntityListing</returns>
        ApiResponse<WorkspaceMemberEntityListing> ContentmanagementWorkspacesWorkspaceidMembersGetWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns></returns>
        void ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete (string workspaceId, string memberId);

        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteWithHttpInfo (string workspaceId, string memberId);
        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>WorkspaceMember</returns>
        WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidGet (string workspaceId, string memberId, string expand = null);

        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        ApiResponse<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetWithHttpInfo (string workspaceId, string memberId, string expand = null);
        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>WorkspaceMember</returns>
        WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidPut (string workspaceId, string memberId, WorkspaceMember body = null);

        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        ApiResponse<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);
        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        Workspace ContentmanagementWorkspacesWorkspaceidPut (string workspaceId, Workspace body = null);

        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> ContentmanagementWorkspacesWorkspaceidPutWithHttpInfo (string workspaceId, Workspace body = null);
        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        TagValueEntityListing ContentmanagementWorkspacesWorkspaceidTagvaluesGet (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        ApiResponse<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesGetWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>TagValue</returns>
        TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesPost (string workspaceId, TagValue body = null);

        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesPostWithHttpInfo (string workspaceId, TagValue body = null);
        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        TagValueEntityListing ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost (string workspaceId, TagQueryRequest body = null, string expand = null);

        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        ApiResponse<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null);
        /// <summary>
        /// Delete workspace tag
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns></returns>
        void ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete (string workspaceId, string tagId);

        /// <summary>
        /// Delete workspace tag
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteWithHttpInfo (string workspaceId, string tagId);
        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValue</returns>
        TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet (string workspaceId, string tagId, string expand = null);

        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetWithHttpInfo (string workspaceId, string tagId, string expand = null);
        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>TagValue</returns>
        TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut (string workspaceId, string tagId, TagValue body = null);

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutWithHttpInfo (string workspaceId, string tagId, TagValue body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> ContentmanagementAuditqueryPostAsync (ContentQueryRequest body);

        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementAuditqueryPostAsyncWithHttpInfo (ContentQueryRequest body);
        /// <summary>
        /// Get a list of audits for a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="transactionFilter">Transaction filter (optional)</param>
        /// <param name="level">level (optional, default to USER)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <returns>Task of DocumentAuditEntityListing</returns>
        System.Threading.Tasks.Task<DocumentAuditEntityListing> ContentmanagementDocumentsDocumentidAuditsGetAsync (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of audits for a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="transactionFilter">Transaction filter (optional)</param>
        /// <param name="level">level (optional, default to USER)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (DocumentAuditEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentAuditEntityListing>> ContentmanagementDocumentsDocumentidAuditsGetAsyncWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidContentGetAsync (string documentId, string disposition = null);

        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidContentGetAsyncWithHttpInfo (string documentId, string disposition = null);
        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ReplaceResponse</returns>
        System.Threading.Tasks.Task<ReplaceResponse> ContentmanagementDocumentsDocumentidContentPostAsync (string documentId, ReplaceRequest body = null, bool? _override = null);

        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (ReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> ContentmanagementDocumentsDocumentidContentPostAsyncWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);
        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidDeleteAsync (string documentId, bool? _override = null);

        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidDeleteAsyncWithHttpInfo (string documentId, bool? _override = null);
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidGetAsync (string documentId, string expand = null);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidGetAsyncWithHttpInfo (string documentId, string expand = null);
        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidPostAsync (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);

        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidPostAsyncWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of DocumentEntityListing</returns>
        System.Threading.Tasks.Task<DocumentEntityListing> ContentmanagementDocumentsGetAsync (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (DocumentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> ContentmanagementDocumentsGetAsyncWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> ContentmanagementDocumentsPostAsync (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsPostAsyncWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> ContentmanagementQueryGetAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementQueryGetAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> ContentmanagementQueryPostAsync (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementQueryPostAsyncWithHttpInfo (QueryRequest body, string expand = null);
        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SecurityProfileEntityListing</returns>
        System.Threading.Tasks.Task<SecurityProfileEntityListing> ContentmanagementSecurityprofilesGetAsync ();

        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> ContentmanagementSecurityprofilesGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of SecurityProfile</returns>
        System.Threading.Tasks.Task<SecurityProfile> ContentmanagementSecurityprofilesSecurityprofileidGetAsync (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of ApiResponse (SecurityProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfile>> ContentmanagementSecurityprofilesSecurityprofileidGetAsyncWithHttpInfo (string securityProfileId);
        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementSharedSharedidGetAsync (string sharedId, bool? redirect = null, string disposition = null, string expand = null);

        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementSharedSharedidGetAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string expand = null);
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ShareEntityListing</returns>
        System.Threading.Tasks.Task<ShareEntityListing> ContentmanagementSharesGetAsync (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ShareEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> ContentmanagementSharesGetAsyncWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of CreateShareResponse</returns>
        System.Threading.Tasks.Task<CreateShareResponse> ContentmanagementSharesPostAsync (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> ContentmanagementSharesPostAsyncWithHttpInfo (CreateShareRequest body = null);
        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementSharesShareidDeleteAsync (string shareId);

        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementSharesShareidDeleteAsyncWithHttpInfo (string shareId);
        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of Share</returns>
        System.Threading.Tasks.Task<Share> ContentmanagementSharesShareidGetAsync (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        System.Threading.Tasks.Task<ApiResponse<Share>> ContentmanagementSharesShareidGetAsyncWithHttpInfo (string shareId, string expand = null);
        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of CommandStatusEntityListing</returns>
        System.Threading.Tasks.Task<CommandStatusEntityListing> ContentmanagementStatusGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> ContentmanagementStatusGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementStatusStatusidDeleteAsync (string statusId);

        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementStatusStatusidDeleteAsyncWithHttpInfo (string statusId);
        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        System.Threading.Tasks.Task<CommandStatus> ContentmanagementStatusStatusidGetAsync (string statusId);

        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatus>> ContentmanagementStatusStatusidGetAsyncWithHttpInfo (string statusId);
        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of WorkspaceEntityListing</returns>
        System.Threading.Tasks.Task<WorkspaceEntityListing> ContentmanagementWorkspacesGetAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);

        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> ContentmanagementWorkspacesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesPostAsync (WorkspaceCreate body = null);

        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesPostAsyncWithHttpInfo (WorkspaceCreate body = null);
        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidDeleteAsync (string workspaceId, string moveChildrenToWorkspaceId = null);

        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidDeleteAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);
        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidGetAsync (string workspaceId, string expand = null);

        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidGetAsyncWithHttpInfo (string workspaceId, string expand = null);
        /// <summary>
        /// Get a list workspace members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of WorkspaceMemberEntityListing</returns>
        System.Threading.Tasks.Task<WorkspaceMemberEntityListing> ContentmanagementWorkspacesWorkspaceidMembersGetAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list workspace members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMemberEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> ContentmanagementWorkspacesWorkspaceidMembersGetAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsync (string workspaceId, string memberId);

        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsyncWithHttpInfo (string workspaceId, string memberId);
        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsync (string workspaceId, string memberId, string expand = null);

        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsyncWithHttpInfo (string workspaceId, string memberId, string expand = null);
        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsync (string workspaceId, string memberId, WorkspaceMember body = null);

        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);
        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidPutAsync (string workspaceId, Workspace body = null);

        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidPutAsyncWithHttpInfo (string workspaceId, Workspace body = null);
        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsync (string workspaceId, TagValue body = null);

        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsyncWithHttpInfo (string workspaceId, TagValue body = null);
        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsync (string workspaceId, TagQueryRequest body = null, string expand = null);

        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsyncWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null);
        /// <summary>
        /// Delete workspace tag
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteAsync (string workspaceId, string tagId);

        /// <summary>
        /// Delete workspace tag
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteAsyncWithHttpInfo (string workspaceId, string tagId);
        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsync (string workspaceId, string tagId, string expand = null);

        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsyncWithHttpInfo (string workspaceId, string tagId, string expand = null);
        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsync (string workspaceId, string tagId, TagValue body = null);

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContentManagementApi : IContentManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContentManagementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContentManagementApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        public QueryResults ContentmanagementAuditqueryPost (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> localVarResponse = ContentmanagementAuditqueryPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > ContentmanagementAuditqueryPostWithHttpInfo (ContentQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->ContentmanagementAuditqueryPost");

            var localVarPath = "/api/v1/contentmanagement/auditquery";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementAuditqueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementAuditqueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> ContentmanagementAuditqueryPostAsync (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> localVarResponse = await ContentmanagementAuditqueryPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementAuditqueryPostAsyncWithHttpInfo (ContentQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->ContentmanagementAuditqueryPost");

            var localVarPath = "/api/v1/contentmanagement/auditquery";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementAuditqueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementAuditqueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Get a list of audits for a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="transactionFilter">Transaction filter (optional)</param>
        /// <param name="level">level (optional, default to USER)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <returns>DocumentAuditEntityListing</returns>
        public DocumentAuditEntityListing ContentmanagementDocumentsDocumentidAuditsGet (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentAuditEntityListing> localVarResponse = ContentmanagementDocumentsDocumentidAuditsGetWithHttpInfo(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of audits for a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="transactionFilter">Transaction filter (optional)</param>
        /// <param name="level">level (optional, default to USER)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <returns>ApiResponse of DocumentAuditEntityListing</returns>
        public ApiResponse< DocumentAuditEntityListing > ContentmanagementDocumentsDocumentidAuditsGetWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidAuditsGet");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}/audits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (transactionFilter != null) localVarQueryParams.Add("transactionFilter", Configuration.ApiClient.ParameterToString(transactionFilter)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentAuditEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAuditEntityListing)));
            
        }

        /// <summary>
        /// Get a list of audits for a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="transactionFilter">Transaction filter (optional)</param>
        /// <param name="level">level (optional, default to USER)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <returns>Task of DocumentAuditEntityListing</returns>
        public async System.Threading.Tasks.Task<DocumentAuditEntityListing> ContentmanagementDocumentsDocumentidAuditsGetAsync (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentAuditEntityListing> localVarResponse = await ContentmanagementDocumentsDocumentidAuditsGetAsyncWithHttpInfo(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of audits for a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="transactionFilter">Transaction filter (optional)</param>
        /// <param name="level">level (optional, default to USER)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (DocumentAuditEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentAuditEntityListing>> ContentmanagementDocumentsDocumentidAuditsGetAsyncWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidAuditsGet");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}/audits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (transactionFilter != null) localVarQueryParams.Add("transactionFilter", Configuration.ApiClient.ParameterToString(transactionFilter)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentAuditEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAuditEntityListing)));
            
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns></returns>
        public void ContentmanagementDocumentsDocumentidContentGet (string documentId, string disposition = null)
        {
             ContentmanagementDocumentsDocumentidContentGetWithHttpInfo(documentId, disposition);
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementDocumentsDocumentidContentGetWithHttpInfo (string documentId, string disposition = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidContentGet");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}/content";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (disposition != null) localVarQueryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidContentGetAsync (string documentId, string disposition = null)
        {
             await ContentmanagementDocumentsDocumentidContentGetAsyncWithHttpInfo(documentId, disposition);

        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidContentGetAsyncWithHttpInfo (string documentId, string disposition = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidContentGet");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}/content";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (disposition != null) localVarQueryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ReplaceResponse</returns>
        public ReplaceResponse ContentmanagementDocumentsDocumentidContentPost (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> localVarResponse = ContentmanagementDocumentsDocumentidContentPostWithHttpInfo(documentId, body, _override);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of ReplaceResponse</returns>
        public ApiResponse< ReplaceResponse > ContentmanagementDocumentsDocumentidContentPostWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidContentPost");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}/content";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplaceResponse)));
            
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ReplaceResponse</returns>
        public async System.Threading.Tasks.Task<ReplaceResponse> ContentmanagementDocumentsDocumentidContentPostAsync (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> localVarResponse = await ContentmanagementDocumentsDocumentidContentPostAsyncWithHttpInfo(documentId, body, _override);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (ReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> ContentmanagementDocumentsDocumentidContentPostAsyncWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidContentPost");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}/content";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplaceResponse)));
            
        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns></returns>
        public void ContentmanagementDocumentsDocumentidDelete (string documentId, bool? _override = null)
        {
             ContentmanagementDocumentsDocumentidDeleteWithHttpInfo(documentId, _override);
        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementDocumentsDocumentidDeleteWithHttpInfo (string documentId, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidDelete");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidDeleteAsync (string documentId, bool? _override = null)
        {
             await ContentmanagementDocumentsDocumentidDeleteAsyncWithHttpInfo(documentId, _override);

        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidDeleteAsyncWithHttpInfo (string documentId, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidDelete");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Document</returns>
        public Document ContentmanagementDocumentsDocumentidGet (string documentId, string expand = null)
        {
             ApiResponse<Document> localVarResponse = ContentmanagementDocumentsDocumentidGetWithHttpInfo(documentId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > ContentmanagementDocumentsDocumentidGetWithHttpInfo (string documentId, string expand = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidGet");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidGetAsync (string documentId, string expand = null)
        {
             ApiResponse<Document> localVarResponse = await ContentmanagementDocumentsDocumentidGetAsyncWithHttpInfo(documentId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidGetAsyncWithHttpInfo (string documentId, string expand = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidGet");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Document</returns>
        public Document ContentmanagementDocumentsDocumentidPost (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = ContentmanagementDocumentsDocumentidPostWithHttpInfo(documentId, body, expand, _override);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > ContentmanagementDocumentsDocumentidPostWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidPost");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidPostAsync (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = await ContentmanagementDocumentsDocumentidPostAsyncWithHttpInfo(documentId, body, expand, _override);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidPostAsyncWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->ContentmanagementDocumentsDocumentidPost");

            var localVarPath = "/api/v1/contentmanagement/documents/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>DocumentEntityListing</returns>
        public DocumentEntityListing ContentmanagementDocumentsGet (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> localVarResponse = ContentmanagementDocumentsGetWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of DocumentEntityListing</returns>
        public ApiResponse< DocumentEntityListing > ContentmanagementDocumentsGetWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementDocumentsGet");

            var localVarPath = "/api/v1/contentmanagement/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarQueryParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentEntityListing)));
            
        }

        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of DocumentEntityListing</returns>
        public async System.Threading.Tasks.Task<DocumentEntityListing> ContentmanagementDocumentsGetAsync (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> localVarResponse = await ContentmanagementDocumentsGetAsyncWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (DocumentEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> ContentmanagementDocumentsGetAsyncWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementDocumentsGet");

            var localVarPath = "/api/v1/contentmanagement/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarQueryParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentEntityListing)));
            
        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Document</returns>
        public Document ContentmanagementDocumentsPost (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = ContentmanagementDocumentsPostWithHttpInfo(body, copySource, moveSource, _override);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > ContentmanagementDocumentsPostWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {

            var localVarPath = "/api/v1/contentmanagement/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (copySource != null) localVarQueryParams.Add("copySource", Configuration.ApiClient.ParameterToString(copySource)); // query parameter
            if (moveSource != null) localVarQueryParams.Add("moveSource", Configuration.ApiClient.ParameterToString(moveSource)); // query parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> ContentmanagementDocumentsPostAsync (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = await ContentmanagementDocumentsPostAsyncWithHttpInfo(body, copySource, moveSource, _override);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsPostAsyncWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {

            var localVarPath = "/api/v1/contentmanagement/documents";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (copySource != null) localVarQueryParams.Add("copySource", Configuration.ApiClient.ParameterToString(copySource)); // query parameter
            if (moveSource != null) localVarQueryParams.Add("moveSource", Configuration.ApiClient.ParameterToString(moveSource)); // query parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        public QueryResults ContentmanagementQueryGet (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = ContentmanagementQueryGetWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > ContentmanagementQueryGetWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null)
                throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling ContentManagementApi->ContentmanagementQueryGet");

            var localVarPath = "/api/v1/contentmanagement/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (queryPhrase != null) localVarQueryParams.Add("queryPhrase", Configuration.ApiClient.ParameterToString(queryPhrase)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> ContentmanagementQueryGetAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = await ContentmanagementQueryGetAsyncWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementQueryGetAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null)
                throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling ContentManagementApi->ContentmanagementQueryGet");

            var localVarPath = "/api/v1/contentmanagement/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (queryPhrase != null) localVarQueryParams.Add("queryPhrase", Configuration.ApiClient.ParameterToString(queryPhrase)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        public QueryResults ContentmanagementQueryPost (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = ContentmanagementQueryPostWithHttpInfo(body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > ContentmanagementQueryPostWithHttpInfo (QueryRequest body, string expand = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->ContentmanagementQueryPost");

            var localVarPath = "/api/v1/contentmanagement/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> ContentmanagementQueryPostAsync (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = await ContentmanagementQueryPostAsyncWithHttpInfo(body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementQueryPostAsyncWithHttpInfo (QueryRequest body, string expand = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->ContentmanagementQueryPost");

            var localVarPath = "/api/v1/contentmanagement/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SecurityProfileEntityListing</returns>
        public SecurityProfileEntityListing ContentmanagementSecurityprofilesGet ()
        {
             ApiResponse<SecurityProfileEntityListing> localVarResponse = ContentmanagementSecurityprofilesGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        public ApiResponse< SecurityProfileEntityListing > ContentmanagementSecurityprofilesGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/contentmanagement/securityprofiles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SecurityProfileEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfileEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityProfileEntityListing)));
            
        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SecurityProfileEntityListing</returns>
        public async System.Threading.Tasks.Task<SecurityProfileEntityListing> ContentmanagementSecurityprofilesGetAsync ()
        {
             ApiResponse<SecurityProfileEntityListing> localVarResponse = await ContentmanagementSecurityprofilesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> ContentmanagementSecurityprofilesGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/contentmanagement/securityprofiles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SecurityProfileEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfileEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityProfileEntityListing)));
            
        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>SecurityProfile</returns>
        public SecurityProfile ContentmanagementSecurityprofilesSecurityprofileidGet (string securityProfileId)
        {
             ApiResponse<SecurityProfile> localVarResponse = ContentmanagementSecurityprofilesSecurityprofileidGetWithHttpInfo(securityProfileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>ApiResponse of SecurityProfile</returns>
        public ApiResponse< SecurityProfile > ContentmanagementSecurityprofilesSecurityprofileidGetWithHttpInfo (string securityProfileId)
        {
            // verify the required parameter 'securityProfileId' is set
            if (securityProfileId == null)
                throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentManagementApi->ContentmanagementSecurityprofilesSecurityprofileidGet");

            var localVarPath = "/api/v1/contentmanagement/securityprofiles/{securityProfileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (securityProfileId != null) localVarPathParams.Add("securityProfileId", Configuration.ApiClient.ParameterToString(securityProfileId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SecurityProfile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityProfile)));
            
        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of SecurityProfile</returns>
        public async System.Threading.Tasks.Task<SecurityProfile> ContentmanagementSecurityprofilesSecurityprofileidGetAsync (string securityProfileId)
        {
             ApiResponse<SecurityProfile> localVarResponse = await ContentmanagementSecurityprofilesSecurityprofileidGetAsyncWithHttpInfo(securityProfileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of ApiResponse (SecurityProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityProfile>> ContentmanagementSecurityprofilesSecurityprofileidGetAsyncWithHttpInfo (string securityProfileId)
        {
            // verify the required parameter 'securityProfileId' is set
            if (securityProfileId == null)
                throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentManagementApi->ContentmanagementSecurityprofilesSecurityprofileidGet");

            var localVarPath = "/api/v1/contentmanagement/securityprofiles/{securityProfileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (securityProfileId != null) localVarPathParams.Add("securityProfileId", Configuration.ApiClient.ParameterToString(securityProfileId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SecurityProfile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityProfile)));
            
        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns></returns>
        public void ContentmanagementSharedSharedidGet (string sharedId, bool? redirect = null, string disposition = null, string expand = null)
        {
             ContentmanagementSharedSharedidGetWithHttpInfo(sharedId, redirect, disposition, expand);
        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementSharedSharedidGetWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string expand = null)
        {
            // verify the required parameter 'sharedId' is set
            if (sharedId == null)
                throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentManagementApi->ContentmanagementSharedSharedidGet");

            var localVarPath = "/api/v1/contentmanagement/shared/{sharedId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sharedId != null) localVarPathParams.Add("sharedId", Configuration.ApiClient.ParameterToString(sharedId)); // path parameter
            if (redirect != null) localVarQueryParams.Add("redirect", Configuration.ApiClient.ParameterToString(redirect)); // query parameter
            if (disposition != null) localVarQueryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharedSharedidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharedSharedidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementSharedSharedidGetAsync (string sharedId, bool? redirect = null, string disposition = null, string expand = null)
        {
             await ContentmanagementSharedSharedidGetAsyncWithHttpInfo(sharedId, redirect, disposition, expand);

        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementSharedSharedidGetAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string expand = null)
        {
            // verify the required parameter 'sharedId' is set
            if (sharedId == null)
                throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentManagementApi->ContentmanagementSharedSharedidGet");

            var localVarPath = "/api/v1/contentmanagement/shared/{sharedId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sharedId != null) localVarPathParams.Add("sharedId", Configuration.ApiClient.ParameterToString(sharedId)); // path parameter
            if (redirect != null) localVarQueryParams.Add("redirect", Configuration.ApiClient.ParameterToString(redirect)); // query parameter
            if (disposition != null) localVarQueryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharedSharedidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharedSharedidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ShareEntityListing</returns>
        public ShareEntityListing ContentmanagementSharesGet (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ShareEntityListing> localVarResponse = ContentmanagementSharesGetWithHttpInfo(entityId, expand, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ShareEntityListing</returns>
        public ApiResponse< ShareEntityListing > ContentmanagementSharesGetWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/contentmanagement/shares";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (entityId != null) localVarQueryParams.Add("entityId", Configuration.ApiClient.ParameterToString(entityId)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShareEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShareEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShareEntityListing)));
            
        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ShareEntityListing</returns>
        public async System.Threading.Tasks.Task<ShareEntityListing> ContentmanagementSharesGetAsync (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ShareEntityListing> localVarResponse = await ContentmanagementSharesGetAsyncWithHttpInfo(entityId, expand, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ShareEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> ContentmanagementSharesGetAsyncWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/contentmanagement/shares";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (entityId != null) localVarQueryParams.Add("entityId", Configuration.ApiClient.ParameterToString(entityId)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShareEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShareEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShareEntityListing)));
            
        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>CreateShareResponse</returns>
        public CreateShareResponse ContentmanagementSharesPost (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> localVarResponse = ContentmanagementSharesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>ApiResponse of CreateShareResponse</returns>
        public ApiResponse< CreateShareResponse > ContentmanagementSharesPostWithHttpInfo (CreateShareRequest body = null)
        {

            var localVarPath = "/api/v1/contentmanagement/shares";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateShareResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateShareResponse)));
            
        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of CreateShareResponse</returns>
        public async System.Threading.Tasks.Task<CreateShareResponse> ContentmanagementSharesPostAsync (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> localVarResponse = await ContentmanagementSharesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> ContentmanagementSharesPostAsyncWithHttpInfo (CreateShareRequest body = null)
        {

            var localVarPath = "/api/v1/contentmanagement/shares";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateShareResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateShareResponse)));
            
        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns></returns>
        public void ContentmanagementSharesShareidDelete (string shareId)
        {
             ContentmanagementSharesShareidDeleteWithHttpInfo(shareId);
        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementSharesShareidDeleteWithHttpInfo (string shareId)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->ContentmanagementSharesShareidDelete");

            var localVarPath = "/api/v1/contentmanagement/shares/{shareId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementSharesShareidDeleteAsync (string shareId)
        {
             await ContentmanagementSharesShareidDeleteAsyncWithHttpInfo(shareId);

        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementSharesShareidDeleteAsyncWithHttpInfo (string shareId)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->ContentmanagementSharesShareidDelete");

            var localVarPath = "/api/v1/contentmanagement/shares/{shareId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Share</returns>
        public Share ContentmanagementSharesShareidGet (string shareId, string expand = null)
        {
             ApiResponse<Share> localVarResponse = ContentmanagementSharesShareidGetWithHttpInfo(shareId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>ApiResponse of Share</returns>
        public ApiResponse< Share > ContentmanagementSharesShareidGetWithHttpInfo (string shareId, string expand = null)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->ContentmanagementSharesShareidGet");

            var localVarPath = "/api/v1/contentmanagement/shares/{shareId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Share>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Share)));
            
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of Share</returns>
        public async System.Threading.Tasks.Task<Share> ContentmanagementSharesShareidGetAsync (string shareId, string expand = null)
        {
             ApiResponse<Share> localVarResponse = await ContentmanagementSharesShareidGetAsyncWithHttpInfo(shareId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Share>> ContentmanagementSharesShareidGetAsyncWithHttpInfo (string shareId, string expand = null)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->ContentmanagementSharesShareidGet");

            var localVarPath = "/api/v1/contentmanagement/shares/{shareId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Share>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Share)));
            
        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>CommandStatusEntityListing</returns>
        public CommandStatusEntityListing ContentmanagementStatusGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> localVarResponse = ContentmanagementStatusGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of CommandStatusEntityListing</returns>
        public ApiResponse< CommandStatusEntityListing > ContentmanagementStatusGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/contentmanagement/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatusEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatusEntityListing)));
            
        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of CommandStatusEntityListing</returns>
        public async System.Threading.Tasks.Task<CommandStatusEntityListing> ContentmanagementStatusGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> localVarResponse = await ContentmanagementStatusGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> ContentmanagementStatusGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/contentmanagement/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatusEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatusEntityListing)));
            
        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns></returns>
        public void ContentmanagementStatusStatusidDelete (string statusId)
        {
             ContentmanagementStatusStatusidDeleteWithHttpInfo(statusId);
        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementStatusStatusidDeleteWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->ContentmanagementStatusStatusidDelete");

            var localVarPath = "/api/v1/contentmanagement/status/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementStatusStatusidDeleteAsync (string statusId)
        {
             await ContentmanagementStatusStatusidDeleteAsyncWithHttpInfo(statusId);

        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementStatusStatusidDeleteAsyncWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->ContentmanagementStatusStatusidDelete");

            var localVarPath = "/api/v1/contentmanagement/status/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        public CommandStatus ContentmanagementStatusStatusidGet (string statusId)
        {
             ApiResponse<CommandStatus> localVarResponse = ContentmanagementStatusStatusidGetWithHttpInfo(statusId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of CommandStatus</returns>
        public ApiResponse< CommandStatus > ContentmanagementStatusStatusidGetWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->ContentmanagementStatusStatusidGet");

            var localVarPath = "/api/v1/contentmanagement/status/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatus)));
            
        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        public async System.Threading.Tasks.Task<CommandStatus> ContentmanagementStatusStatusidGetAsync (string statusId)
        {
             ApiResponse<CommandStatus> localVarResponse = await ContentmanagementStatusStatusidGetAsyncWithHttpInfo(statusId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatus>> ContentmanagementStatusStatusidGetAsyncWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->ContentmanagementStatusStatusidGet");

            var localVarPath = "/api/v1/contentmanagement/status/{statusId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatus)));
            
        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>WorkspaceEntityListing</returns>
        public WorkspaceEntityListing ContentmanagementWorkspacesGet (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> localVarResponse = ContentmanagementWorkspacesGetWithHttpInfo(pageSize, pageNumber, access, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceEntityListing</returns>
        public ApiResponse< WorkspaceEntityListing > ContentmanagementWorkspacesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {

            var localVarPath = "/api/v1/contentmanagement/workspaces";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (access != null) localVarQueryParams.Add("access", Configuration.ApiClient.ParameterToString(access)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceEntityListing)));
            
        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of WorkspaceEntityListing</returns>
        public async System.Threading.Tasks.Task<WorkspaceEntityListing> ContentmanagementWorkspacesGetAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> localVarResponse = await ContentmanagementWorkspacesGetAsyncWithHttpInfo(pageSize, pageNumber, access, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> ContentmanagementWorkspacesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {

            var localVarPath = "/api/v1/contentmanagement/workspaces";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (access != null) localVarQueryParams.Add("access", Configuration.ApiClient.ParameterToString(access)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceEntityListing)));
            
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace ContentmanagementWorkspacesPost (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> localVarResponse = ContentmanagementWorkspacesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > ContentmanagementWorkspacesPostWithHttpInfo (WorkspaceCreate body = null)
        {

            var localVarPath = "/api/v1/contentmanagement/workspaces";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesPostAsync (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> localVarResponse = await ContentmanagementWorkspacesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesPostAsyncWithHttpInfo (WorkspaceCreate body = null)
        {

            var localVarPath = "/api/v1/contentmanagement/workspaces";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns></returns>
        public void ContentmanagementWorkspacesWorkspaceidDelete (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             ContentmanagementWorkspacesWorkspaceidDeleteWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);
        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidDeleteWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidDelete");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (moveChildrenToWorkspaceId != null) localVarQueryParams.Add("moveChildrenToWorkspaceId", Configuration.ApiClient.ParameterToString(moveChildrenToWorkspaceId)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidDeleteAsync (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             await ContentmanagementWorkspacesWorkspaceidDeleteAsyncWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);

        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidDeleteAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidDelete");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (moveChildrenToWorkspaceId != null) localVarQueryParams.Add("moveChildrenToWorkspaceId", Configuration.ApiClient.ParameterToString(moveChildrenToWorkspaceId)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace ContentmanagementWorkspacesWorkspaceidGet (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> localVarResponse = ContentmanagementWorkspacesWorkspaceidGetWithHttpInfo(workspaceId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > ContentmanagementWorkspacesWorkspaceidGetWithHttpInfo (string workspaceId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidGetAsync (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> localVarResponse = await ContentmanagementWorkspacesWorkspaceidGetAsyncWithHttpInfo(workspaceId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidGetAsyncWithHttpInfo (string workspaceId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>WorkspaceMemberEntityListing</returns>
        public WorkspaceMemberEntityListing ContentmanagementWorkspacesWorkspaceidMembersGet (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> localVarResponse = ContentmanagementWorkspacesWorkspaceidMembersGetWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceMemberEntityListing</returns>
        public ApiResponse< WorkspaceMemberEntityListing > ContentmanagementWorkspacesWorkspaceidMembersGetWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMemberEntityListing)));
            
        }

        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of WorkspaceMemberEntityListing</returns>
        public async System.Threading.Tasks.Task<WorkspaceMemberEntityListing> ContentmanagementWorkspacesWorkspaceidMembersGetAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> localVarResponse = await ContentmanagementWorkspacesWorkspaceidMembersGetAsyncWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMemberEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> ContentmanagementWorkspacesWorkspaceidMembersGetAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMemberEntityListing)));
            
        }

        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns></returns>
        public void ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete (string workspaceId, string memberId)
        {
             ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteWithHttpInfo(workspaceId, memberId);
        }

        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteWithHttpInfo (string workspaceId, string memberId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsync (string workspaceId, string memberId)
        {
             await ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsyncWithHttpInfo(workspaceId, memberId);

        }

        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsyncWithHttpInfo (string workspaceId, string memberId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidGet (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = ContentmanagementWorkspacesWorkspaceidMembersMemberidGetWithHttpInfo(workspaceId, memberId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > ContentmanagementWorkspacesWorkspaceidMembersMemberidGetWithHttpInfo (string workspaceId, string memberId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidGet");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
            
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsync (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = await ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsyncWithHttpInfo(workspaceId, memberId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsyncWithHttpInfo (string workspaceId, string memberId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidGet");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
            
        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidPut (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = ContentmanagementWorkspacesWorkspaceidMembersMemberidPutWithHttpInfo(workspaceId, memberId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > ContentmanagementWorkspacesWorkspaceidMembersMemberidPutWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidPut");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidPut");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
            
        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsync (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = await ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsyncWithHttpInfo(workspaceId, memberId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidPut");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidMembersMemberidPut");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
            
        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace ContentmanagementWorkspacesWorkspaceidPut (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> localVarResponse = ContentmanagementWorkspacesWorkspaceidPutWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > ContentmanagementWorkspacesWorkspaceidPutWithHttpInfo (string workspaceId, Workspace body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidPut");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidPutAsync (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> localVarResponse = await ContentmanagementWorkspacesWorkspaceidPutAsyncWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidPutAsyncWithHttpInfo (string workspaceId, Workspace body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidPut");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        public TagValueEntityListing ContentmanagementWorkspacesWorkspaceidTagvaluesGet (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = ContentmanagementWorkspacesWorkspaceidTagvaluesGetWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        public ApiResponse< TagValueEntityListing > ContentmanagementWorkspacesWorkspaceidTagvaluesGetWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
            
        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        public async System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = await ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsyncWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
            
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>TagValue</returns>
        public TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesPost (string workspaceId, TagValue body = null)
        {
             ApiResponse<TagValue> localVarResponse = ContentmanagementWorkspacesWorkspaceidTagvaluesPostWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > ContentmanagementWorkspacesWorkspaceidTagvaluesPostWithHttpInfo (string workspaceId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesPost");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsync (string workspaceId, TagValue body = null)
        {
             ApiResponse<TagValue> localVarResponse = await ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsyncWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsyncWithHttpInfo (string workspaceId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesPost");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        public TagValueEntityListing ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostWithHttpInfo(workspaceId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        public ApiResponse< TagValueEntityListing > ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
            
        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        public async System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsync (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = await ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsyncWithHttpInfo(workspaceId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsyncWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
            
        }

        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns></returns>
        public void ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete (string workspaceId, string tagId)
        {
             ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteWithHttpInfo(workspaceId, tagId);
        }

        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteWithHttpInfo (string workspaceId, string tagId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteAsync (string workspaceId, string tagId)
        {
             await ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteAsyncWithHttpInfo(workspaceId, tagId);

        }

        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteAsyncWithHttpInfo (string workspaceId, string tagId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValue</returns>
        public TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet (string workspaceId, string tagId, string expand = null)
        {
             ApiResponse<TagValue> localVarResponse = ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetWithHttpInfo(workspaceId, tagId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetWithHttpInfo (string workspaceId, string tagId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsync (string workspaceId, string tagId, string expand = null)
        {
             ApiResponse<TagValue> localVarResponse = await ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsyncWithHttpInfo(workspaceId, tagId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsyncWithHttpInfo (string workspaceId, string tagId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>TagValue</returns>
        public TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> localVarResponse = ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutWithHttpInfo(workspaceId, tagId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsync (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> localVarResponse = await ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsyncWithHttpInfo(workspaceId, tagId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

    }
}
