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
    public interface IContentManagementApi : IApiAccessor
    {
        #region Synchronous Operations
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
        void DeleteDocumentsDocumentId (string documentId, bool? _override = null);

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
        ApiResponse<Object> DeleteDocumentsDocumentIdWithHttpInfo (string documentId, bool? _override = null);
        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns></returns>
        void DeleteSharesShareId (string shareId);

        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSharesShareIdWithHttpInfo (string shareId);
        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns></returns>
        void DeleteStatusStatusId (string statusId);

        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteStatusStatusIdWithHttpInfo (string statusId);
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
        void DeleteWorkspacesWorkspaceId (string workspaceId, string moveChildrenToWorkspaceId = null);

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
        ApiResponse<Object> DeleteWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);
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
        void DeleteWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId);

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
        ApiResponse<Object> DeleteWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId);
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
        void DeleteWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId);

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
        ApiResponse<Object> DeleteWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId);
        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>DocumentEntityListing</returns>
        DocumentEntityListing GetDocuments (string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of DocumentEntityListing</returns>
        ApiResponse<DocumentEntityListing> GetDocumentsWithHttpInfo (string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Document</returns>
        Document GetDocumentsDocumentId (string documentId, List<string> expand = null);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> GetDocumentsDocumentIdWithHttpInfo (string documentId, List<string> expand = null);
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
        DocumentAuditEntityListing GetDocumentsDocumentIdAudits (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);

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
        ApiResponse<DocumentAuditEntityListing> GetDocumentsDocumentIdAuditsWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: a file attachment or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>DownloadResponse</returns>
        DownloadResponse GetDocumentsDocumentIdContent (string documentId, string disposition = null, string contentType = null);

        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: a file attachment or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        ApiResponse<DownloadResponse> GetDocumentsDocumentIdContentWithHttpInfo (string documentId, string disposition = null, string contentType = null);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>QueryResults</returns>
        QueryResults GetQuery (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> GetQueryWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null);
        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SecurityProfileEntityListing</returns>
        SecurityProfileEntityListing GetSecurityprofiles ();

        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        ApiResponse<SecurityProfileEntityListing> GetSecurityprofilesWithHttpInfo ();
        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>SecurityProfile</returns>
        SecurityProfile GetSecurityprofilesSecurityprofileId (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>ApiResponse of SecurityProfile</returns>
        ApiResponse<SecurityProfile> GetSecurityprofilesSecurityprofileIdWithHttpInfo (string securityProfileId);
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
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns></returns>
        void GetSharedSharedId (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);

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
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetSharedSharedIdWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ShareEntityListing</returns>
        ShareEntityListing GetShares (string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ShareEntityListing</returns>
        ApiResponse<ShareEntityListing> GetSharesWithHttpInfo (string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Share</returns>
        Share GetSharesShareId (string shareId, List<string> expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Share</returns>
        ApiResponse<Share> GetSharesShareIdWithHttpInfo (string shareId, List<string> expand = null);
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
        CommandStatusEntityListing GetStatus (int? pageSize = null, int? pageNumber = null);

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
        ApiResponse<CommandStatusEntityListing> GetStatusWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        CommandStatus GetStatusStatusId (string statusId);

        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of CommandStatus</returns>
        ApiResponse<CommandStatus> GetStatusStatusIdWithHttpInfo (string statusId);
        /// <summary>
        /// Get usage details.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Usage</returns>
        Usage GetUsage ();

        /// <summary>
        /// Get usage details.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Usage</returns>
        ApiResponse<Usage> GetUsageWithHttpInfo ();
        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkspaceEntityListing</returns>
        WorkspaceEntityListing GetWorkspaces (int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null);

        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkspaceEntityListing</returns>
        ApiResponse<WorkspaceEntityListing> GetWorkspacesWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null);
        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Workspace</returns>
        Workspace GetWorkspacesWorkspaceId (string workspaceId, List<string> expand = null);

        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> GetWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, List<string> expand = null);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkspaceMemberEntityListing</returns>
        WorkspaceMemberEntityListing GetWorkspacesWorkspaceIdMembers (string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkspaceMemberEntityListing</returns>
        ApiResponse<WorkspaceMemberEntityListing> GetWorkspacesWorkspaceIdMembersWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null);
        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkspaceMember</returns>
        WorkspaceMember GetWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, List<string> expand = null);

        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        ApiResponse<WorkspaceMember> GetWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, List<string> expand = null);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        TagValueEntityListing GetWorkspacesWorkspaceIdTagvalues (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        ApiResponse<TagValueEntityListing> GetWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null);
        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>TagValue</returns>
        TagValue GetWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, List<string> expand = null);

        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> GetWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, List<string> expand = null);
        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        QueryResults PostAuditquery (ContentQueryRequest body);

        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> PostAuditqueryWithHttpInfo (ContentQueryRequest body);
        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Document</returns>
        Document PostDocuments (DocumentUpload body, string copySource = null, string moveSource = null, bool? _override = null);

        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> PostDocumentsWithHttpInfo (DocumentUpload body, string copySource = null, string moveSource = null, bool? _override = null);
        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Document</returns>
        Document PostDocumentsDocumentId (string documentId, DocumentUpdate body, string expand = null, bool? _override = null);

        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> PostDocumentsDocumentIdWithHttpInfo (string documentId, DocumentUpdate body, string expand = null, bool? _override = null);
        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ReplaceResponse</returns>
        ReplaceResponse PostDocumentsDocumentIdContent (string documentId, ReplaceRequest body, bool? _override = null);

        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of ReplaceResponse</returns>
        ApiResponse<ReplaceResponse> PostDocumentsDocumentIdContentWithHttpInfo (string documentId, ReplaceRequest body, bool? _override = null);
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
        QueryResults PostQuery (QueryRequest body, string expand = null);

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
        ApiResponse<QueryResults> PostQueryWithHttpInfo (QueryRequest body, string expand = null);
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>CreateShareResponse</returns>
        CreateShareResponse PostShares (CreateShareRequest body);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>ApiResponse of CreateShareResponse</returns>
        ApiResponse<CreateShareResponse> PostSharesWithHttpInfo (CreateShareRequest body);
        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace</param>
        /// <returns>Workspace</returns>
        Workspace PostWorkspaces (WorkspaceCreate body);

        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> PostWorkspacesWithHttpInfo (WorkspaceCreate body);
        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>TagValue</returns>
        TagValue PostWorkspacesWorkspaceIdTagvalues (string workspaceId, TagValue body);

        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> PostWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, TagValue body);
        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        TagValueEntityListing PostWorkspacesWorkspaceIdTagvaluesQuery (string workspaceId, TagQueryRequest body, List<string> expand = null);

        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        ApiResponse<TagValueEntityListing> PostWorkspacesWorkspaceIdTagvaluesQueryWithHttpInfo (string workspaceId, TagQueryRequest body, List<string> expand = null);
        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Workspace</returns>
        Workspace PutWorkspacesWorkspaceId (string workspaceId, Workspace body);

        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> PutWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, Workspace body);
        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace Member</param>
        /// <returns>WorkspaceMember</returns>
        WorkspaceMember PutWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, WorkspaceMember body);

        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace Member</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        ApiResponse<WorkspaceMember> PutWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body);
        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>TagValue</returns>
        TagValue PutWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, TagValue body);

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> PutWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, TagValue body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
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
        System.Threading.Tasks.Task DeleteDocumentsDocumentIdAsync (string documentId, bool? _override = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentsDocumentIdAsyncWithHttpInfo (string documentId, bool? _override = null);
        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSharesShareIdAsync (string shareId);

        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSharesShareIdAsyncWithHttpInfo (string shareId);
        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteStatusStatusIdAsync (string statusId);

        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteStatusStatusIdAsyncWithHttpInfo (string statusId);
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
        System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdAsync (string workspaceId, string moveChildrenToWorkspaceId = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);
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
        System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId);
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
        System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId);
        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of DocumentEntityListing</returns>
        System.Threading.Tasks.Task<DocumentEntityListing> GetDocumentsAsync (string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (DocumentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> GetDocumentsDocumentIdAsync (string documentId, List<string> expand = null);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> GetDocumentsDocumentIdAsyncWithHttpInfo (string documentId, List<string> expand = null);
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
        System.Threading.Tasks.Task<DocumentAuditEntityListing> GetDocumentsDocumentIdAuditsAsync (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<DocumentAuditEntityListing>> GetDocumentsDocumentIdAuditsAsyncWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: a file attachment or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>Task of DownloadResponse</returns>
        System.Threading.Tasks.Task<DownloadResponse> GetDocumentsDocumentIdContentAsync (string documentId, string disposition = null, string contentType = null);

        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: a file attachment or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> GetDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, string disposition = null, string contentType = null);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> GetQueryAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> GetQueryAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null);
        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SecurityProfileEntityListing</returns>
        System.Threading.Tasks.Task<SecurityProfileEntityListing> GetSecurityprofilesAsync ();

        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> GetSecurityprofilesAsyncWithHttpInfo ();
        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of SecurityProfile</returns>
        System.Threading.Tasks.Task<SecurityProfile> GetSecurityprofilesSecurityprofileIdAsync (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of ApiResponse (SecurityProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfile>> GetSecurityprofilesSecurityprofileIdAsyncWithHttpInfo (string securityProfileId);
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
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetSharedSharedIdAsync (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);

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
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetSharedSharedIdAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ShareEntityListing</returns>
        System.Threading.Tasks.Task<ShareEntityListing> GetSharesAsync (string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ShareEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> GetSharesAsyncWithHttpInfo (string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Share</returns>
        System.Threading.Tasks.Task<Share> GetSharesShareIdAsync (string shareId, List<string> expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        System.Threading.Tasks.Task<ApiResponse<Share>> GetSharesShareIdAsyncWithHttpInfo (string shareId, List<string> expand = null);
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
        System.Threading.Tasks.Task<CommandStatusEntityListing> GetStatusAsync (int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> GetStatusAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        System.Threading.Tasks.Task<CommandStatus> GetStatusStatusIdAsync (string statusId);

        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatus>> GetStatusStatusIdAsyncWithHttpInfo (string statusId);
        /// <summary>
        /// Get usage details.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Usage</returns>
        System.Threading.Tasks.Task<Usage> GetUsageAsync ();

        /// <summary>
        /// Get usage details.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Usage)</returns>
        System.Threading.Tasks.Task<ApiResponse<Usage>> GetUsageAsyncWithHttpInfo ();
        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkspaceEntityListing</returns>
        System.Threading.Tasks.Task<WorkspaceEntityListing> GetWorkspacesAsync (int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null);

        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> GetWorkspacesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null);
        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> GetWorkspacesWorkspaceIdAsync (string workspaceId, List<string> expand = null);

        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> GetWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, List<string> expand = null);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkspaceMemberEntityListing</returns>
        System.Threading.Tasks.Task<WorkspaceMemberEntityListing> GetWorkspacesWorkspaceIdMembersAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMemberEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> GetWorkspacesWorkspaceIdMembersAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null);
        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        System.Threading.Tasks.Task<WorkspaceMember> GetWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, List<string> expand = null);

        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> GetWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, List<string> expand = null);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        System.Threading.Tasks.Task<TagValueEntityListing> GetWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> GetWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null);
        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> GetWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, List<string> expand = null);

        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> GetWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, List<string> expand = null);
        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> PostAuditqueryAsync (ContentQueryRequest body);

        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostAuditqueryAsyncWithHttpInfo (ContentQueryRequest body);
        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> PostDocumentsAsync (DocumentUpload body, string copySource = null, string moveSource = null, bool? _override = null);

        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsAsyncWithHttpInfo (DocumentUpload body, string copySource = null, string moveSource = null, bool? _override = null);
        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> PostDocumentsDocumentIdAsync (string documentId, DocumentUpdate body, string expand = null, bool? _override = null);

        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsDocumentIdAsyncWithHttpInfo (string documentId, DocumentUpdate body, string expand = null, bool? _override = null);
        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ReplaceResponse</returns>
        System.Threading.Tasks.Task<ReplaceResponse> PostDocumentsDocumentIdContentAsync (string documentId, ReplaceRequest body, bool? _override = null);

        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (ReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> PostDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, ReplaceRequest body, bool? _override = null);
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
        System.Threading.Tasks.Task<QueryResults> PostQueryAsync (QueryRequest body, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostQueryAsyncWithHttpInfo (QueryRequest body, string expand = null);
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of CreateShareResponse</returns>
        System.Threading.Tasks.Task<CreateShareResponse> PostSharesAsync (CreateShareRequest body);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> PostSharesAsyncWithHttpInfo (CreateShareRequest body);
        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> PostWorkspacesAsync (WorkspaceCreate body);

        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> PostWorkspacesAsyncWithHttpInfo (WorkspaceCreate body);
        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> PostWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, TagValue body);

        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> PostWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, TagValue body);
        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        System.Threading.Tasks.Task<TagValueEntityListing> PostWorkspacesWorkspaceIdTagvaluesQueryAsync (string workspaceId, TagQueryRequest body, List<string> expand = null);

        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> PostWorkspacesWorkspaceIdTagvaluesQueryAsyncWithHttpInfo (string workspaceId, TagQueryRequest body, List<string> expand = null);
        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> PutWorkspacesWorkspaceIdAsync (string workspaceId, Workspace body);

        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> PutWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, Workspace body);
        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace Member</param>
        /// <returns>Task of WorkspaceMember</returns>
        System.Threading.Tasks.Task<WorkspaceMember> PutWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, WorkspaceMember body);

        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace Member</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> PutWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body);
        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> PutWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, TagValue body);

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> PutWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ContentManagementApi : IContentManagementApi
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns></returns>
        public void DeleteDocumentsDocumentId (string documentId, bool? _override = null)
        {
             DeleteDocumentsDocumentIdWithHttpInfo(documentId, _override);
        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteDocumentsDocumentIdWithHttpInfo (string documentId, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->DeleteDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task DeleteDocumentsDocumentIdAsync (string documentId, bool? _override = null)
        {
             await DeleteDocumentsDocumentIdAsyncWithHttpInfo(documentId, _override);

        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentsDocumentIdAsyncWithHttpInfo (string documentId, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->DeleteDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns></returns>
        public void DeleteSharesShareId (string shareId)
        {
             DeleteSharesShareIdWithHttpInfo(shareId);
        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteSharesShareIdWithHttpInfo (string shareId)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->DeleteSharesShareId");

            var localVarPath = "/api/v2/contentmanagement/shares/{shareId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSharesShareId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSharesShareId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task DeleteSharesShareIdAsync (string shareId)
        {
             await DeleteSharesShareIdAsyncWithHttpInfo(shareId);

        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSharesShareIdAsyncWithHttpInfo (string shareId)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->DeleteSharesShareId");

            var localVarPath = "/api/v2/contentmanagement/shares/{shareId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSharesShareId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSharesShareId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns></returns>
        public void DeleteStatusStatusId (string statusId)
        {
             DeleteStatusStatusIdWithHttpInfo(statusId);
        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteStatusStatusIdWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->DeleteStatusStatusId");

            var localVarPath = "/api/v2/contentmanagement/status/{statusId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteStatusStatusId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task DeleteStatusStatusIdAsync (string statusId)
        {
             await DeleteStatusStatusIdAsyncWithHttpInfo(statusId);

        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteStatusStatusIdAsyncWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->DeleteStatusStatusId");

            var localVarPath = "/api/v2/contentmanagement/status/{statusId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteStatusStatusId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <returns></returns>
        public void DeleteWorkspacesWorkspaceId (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             DeleteWorkspacesWorkspaceIdWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);
        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdAsync (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             await DeleteWorkspacesWorkspaceIdAsyncWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);

        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <returns></returns>
        public void DeleteWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId)
        {
             DeleteWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo(workspaceId, memberId);
        }

        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceIdMembersMemberId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId)
        {
             await DeleteWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo(workspaceId, memberId);

        }

        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceIdMembersMemberId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <returns></returns>
        public void DeleteWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId)
        {
             DeleteWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo(workspaceId, tagId);
        }

        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId)
        {
             await DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo(workspaceId, tagId);

        }

        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>DocumentEntityListing</returns>
        public DocumentEntityListing GetDocuments (string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> localVarResponse = GetDocumentsWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of DocumentEntityListing</returns>
        public ApiResponse< DocumentEntityListing > GetDocumentsWithHttpInfo (string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetDocuments");

            var localVarPath = "/api/v2/contentmanagement/documents";
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
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of DocumentEntityListing</returns>
        public async System.Threading.Tasks.Task<DocumentEntityListing> GetDocumentsAsync (string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> localVarResponse = await GetDocumentsAsyncWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (DocumentEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetDocuments");

            var localVarPath = "/api/v2/contentmanagement/documents";
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
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentEntityListing)));
            
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Document</returns>
        public Document GetDocumentsDocumentId (string documentId, List<string> expand = null)
        {
             ApiResponse<Document> localVarResponse = GetDocumentsDocumentIdWithHttpInfo(documentId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > GetDocumentsDocumentIdWithHttpInfo (string documentId, List<string> expand = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> GetDocumentsDocumentIdAsync (string documentId, List<string> expand = null)
        {
             ApiResponse<Document> localVarResponse = await GetDocumentsDocumentIdAsyncWithHttpInfo(documentId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> GetDocumentsDocumentIdAsyncWithHttpInfo (string documentId, List<string> expand = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
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
        public DocumentAuditEntityListing GetDocumentsDocumentIdAudits (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentAuditEntityListing> localVarResponse = GetDocumentsDocumentIdAuditsWithHttpInfo(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
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
        public ApiResponse< DocumentAuditEntityListing > GetDocumentsDocumentIdAuditsWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentIdAudits");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/audits";
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
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<DocumentAuditEntityListing> GetDocumentsDocumentIdAuditsAsync (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentAuditEntityListing> localVarResponse = await GetDocumentsDocumentIdAuditsAsyncWithHttpInfo(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<DocumentAuditEntityListing>> GetDocumentsDocumentIdAuditsAsyncWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentIdAudits");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/audits";
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
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentAuditEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAuditEntityListing)));
            
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: a file attachment or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>DownloadResponse</returns>
        public DownloadResponse GetDocumentsDocumentIdContent (string documentId, string disposition = null, string contentType = null)
        {
             ApiResponse<DownloadResponse> localVarResponse = GetDocumentsDocumentIdContentWithHttpInfo(documentId, disposition, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: a file attachment or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>ApiResponse of DownloadResponse</returns>
        public ApiResponse< DownloadResponse > GetDocumentsDocumentIdContentWithHttpInfo (string documentId, string disposition = null, string contentType = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/content";
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
            if (contentType != null) localVarQueryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
            
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: a file attachment or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>Task of DownloadResponse</returns>
        public async System.Threading.Tasks.Task<DownloadResponse> GetDocumentsDocumentIdContentAsync (string documentId, string disposition = null, string contentType = null)
        {
             ApiResponse<DownloadResponse> localVarResponse = await GetDocumentsDocumentIdContentAsyncWithHttpInfo(documentId, disposition, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: a file attachment or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>Task of ApiResponse (DownloadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DownloadResponse>> GetDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, string disposition = null, string contentType = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/content";
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
            if (contentType != null) localVarQueryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DownloadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DownloadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DownloadResponse)));
            
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>QueryResults</returns>
        public QueryResults GetQuery (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = GetQueryWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > GetQueryWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null)
        {
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null)
                throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling ContentManagementApi->GetQuery");

            var localVarPath = "/api/v2/contentmanagement/query";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> GetQueryAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = await GetQueryAsyncWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> GetQueryAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null)
        {
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null)
                throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling ContentManagementApi->GetQuery");

            var localVarPath = "/api/v2/contentmanagement/query";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SecurityProfileEntityListing</returns>
        public SecurityProfileEntityListing GetSecurityprofiles ()
        {
             ApiResponse<SecurityProfileEntityListing> localVarResponse = GetSecurityprofilesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        public ApiResponse< SecurityProfileEntityListing > GetSecurityprofilesWithHttpInfo ()
        {

            var localVarPath = "/api/v2/contentmanagement/securityprofiles";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofiles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofiles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SecurityProfileEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfileEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityProfileEntityListing)));
            
        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SecurityProfileEntityListing</returns>
        public async System.Threading.Tasks.Task<SecurityProfileEntityListing> GetSecurityprofilesAsync ()
        {
             ApiResponse<SecurityProfileEntityListing> localVarResponse = await GetSecurityprofilesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> GetSecurityprofilesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/contentmanagement/securityprofiles";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofiles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofiles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public SecurityProfile GetSecurityprofilesSecurityprofileId (string securityProfileId)
        {
             ApiResponse<SecurityProfile> localVarResponse = GetSecurityprofilesSecurityprofileIdWithHttpInfo(securityProfileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>ApiResponse of SecurityProfile</returns>
        public ApiResponse< SecurityProfile > GetSecurityprofilesSecurityprofileIdWithHttpInfo (string securityProfileId)
        {
            // verify the required parameter 'securityProfileId' is set
            if (securityProfileId == null)
                throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentManagementApi->GetSecurityprofilesSecurityprofileId");

            var localVarPath = "/api/v2/contentmanagement/securityprofiles/{securityProfileId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<SecurityProfile> GetSecurityprofilesSecurityprofileIdAsync (string securityProfileId)
        {
             ApiResponse<SecurityProfile> localVarResponse = await GetSecurityprofilesSecurityprofileIdAsyncWithHttpInfo(securityProfileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of ApiResponse (SecurityProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityProfile>> GetSecurityprofilesSecurityprofileIdAsyncWithHttpInfo (string securityProfileId)
        {
            // verify the required parameter 'securityProfileId' is set
            if (securityProfileId == null)
                throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentManagementApi->GetSecurityprofilesSecurityprofileId");

            var localVarPath = "/api/v2/contentmanagement/securityprofiles/{securityProfileId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns></returns>
        public void GetSharedSharedId (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
             GetSharedSharedIdWithHttpInfo(sharedId, redirect, disposition, contentType, expand);
        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetSharedSharedIdWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
            // verify the required parameter 'sharedId' is set
            if (sharedId == null)
                throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentManagementApi->GetSharedSharedId");

            var localVarPath = "/api/v2/contentmanagement/shared/{sharedId}";
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
            if (contentType != null) localVarQueryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetSharedSharedId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSharedSharedId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetSharedSharedIdAsync (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
             await GetSharedSharedIdAsyncWithHttpInfo(sharedId, redirect, disposition, contentType, expand);

        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetSharedSharedIdAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
            // verify the required parameter 'sharedId' is set
            if (sharedId == null)
                throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentManagementApi->GetSharedSharedId");

            var localVarPath = "/api/v2/contentmanagement/shared/{sharedId}";
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
            if (contentType != null) localVarQueryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetSharedSharedId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSharedSharedId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ShareEntityListing</returns>
        public ShareEntityListing GetShares (string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ShareEntityListing> localVarResponse = GetSharesWithHttpInfo(entityId, expand, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ShareEntityListing</returns>
        public ApiResponse< ShareEntityListing > GetSharesWithHttpInfo (string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/contentmanagement/shares";
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
                throw new ApiException (localVarStatusCode, "Error calling GetShares: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShares: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShareEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShareEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShareEntityListing)));
            
        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ShareEntityListing</returns>
        public async System.Threading.Tasks.Task<ShareEntityListing> GetSharesAsync (string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ShareEntityListing> localVarResponse = await GetSharesAsyncWithHttpInfo(entityId, expand, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ShareEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> GetSharesAsyncWithHttpInfo (string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/contentmanagement/shares";
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
                throw new ApiException (localVarStatusCode, "Error calling GetShares: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShares: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShareEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShareEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShareEntityListing)));
            
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Share</returns>
        public Share GetSharesShareId (string shareId, List<string> expand = null)
        {
             ApiResponse<Share> localVarResponse = GetSharesShareIdWithHttpInfo(shareId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Share</returns>
        public ApiResponse< Share > GetSharesShareIdWithHttpInfo (string shareId, List<string> expand = null)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->GetSharesShareId");

            var localVarPath = "/api/v2/contentmanagement/shares/{shareId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSharesShareId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSharesShareId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Share>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Share)));
            
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Share</returns>
        public async System.Threading.Tasks.Task<Share> GetSharesShareIdAsync (string shareId, List<string> expand = null)
        {
             ApiResponse<Share> localVarResponse = await GetSharesShareIdAsyncWithHttpInfo(shareId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Share>> GetSharesShareIdAsyncWithHttpInfo (string shareId, List<string> expand = null)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->GetSharesShareId");

            var localVarPath = "/api/v2/contentmanagement/shares/{shareId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSharesShareId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSharesShareId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public CommandStatusEntityListing GetStatus (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> localVarResponse = GetStatusWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of CommandStatusEntityListing</returns>
        public ApiResponse< CommandStatusEntityListing > GetStatusWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/contentmanagement/status";
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
                throw new ApiException (localVarStatusCode, "Error calling GetStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CommandStatusEntityListing> GetStatusAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> localVarResponse = await GetStatusAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> GetStatusAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/contentmanagement/status";
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
                throw new ApiException (localVarStatusCode, "Error calling GetStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatusEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatusEntityListing)));
            
        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        public CommandStatus GetStatusStatusId (string statusId)
        {
             ApiResponse<CommandStatus> localVarResponse = GetStatusStatusIdWithHttpInfo(statusId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of CommandStatus</returns>
        public ApiResponse< CommandStatus > GetStatusStatusIdWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->GetStatusStatusId");

            var localVarPath = "/api/v2/contentmanagement/status/{statusId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetStatusStatusId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CommandStatus> GetStatusStatusIdAsync (string statusId)
        {
             ApiResponse<CommandStatus> localVarResponse = await GetStatusStatusIdAsyncWithHttpInfo(statusId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatus>> GetStatusStatusIdAsyncWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->GetStatusStatusId");

            var localVarPath = "/api/v2/contentmanagement/status/{statusId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetStatusStatusId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatus)));
            
        }

        /// <summary>
        /// Get usage details. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Usage</returns>
        public Usage GetUsage ()
        {
             ApiResponse<Usage> localVarResponse = GetUsageWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get usage details. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Usage</returns>
        public ApiResponse< Usage > GetUsageWithHttpInfo ()
        {

            var localVarPath = "/api/v2/contentmanagement/usage";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUsage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Usage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Usage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Usage)));
            
        }

        /// <summary>
        /// Get usage details. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Usage</returns>
        public async System.Threading.Tasks.Task<Usage> GetUsageAsync ()
        {
             ApiResponse<Usage> localVarResponse = await GetUsageAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get usage details. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Usage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Usage>> GetUsageAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/contentmanagement/usage";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUsage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Usage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Usage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Usage)));
            
        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkspaceEntityListing</returns>
        public WorkspaceEntityListing GetWorkspaces (int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null)
        {
             ApiResponse<WorkspaceEntityListing> localVarResponse = GetWorkspacesWithHttpInfo(pageSize, pageNumber, access, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkspaceEntityListing</returns>
        public ApiResponse< WorkspaceEntityListing > GetWorkspacesWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null)
        {

            var localVarPath = "/api/v2/contentmanagement/workspaces";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="access">Requested access level. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkspaceEntityListing</returns>
        public async System.Threading.Tasks.Task<WorkspaceEntityListing> GetWorkspacesAsync (int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null)
        {
             ApiResponse<WorkspaceEntityListing> localVarResponse = await GetWorkspacesAsyncWithHttpInfo(pageSize, pageNumber, access, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level. (optional)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> GetWorkspacesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null)
        {

            var localVarPath = "/api/v2/contentmanagement/workspaces";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceEntityListing)));
            
        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace GetWorkspacesWorkspaceId (string workspaceId, List<string> expand = null)
        {
             ApiResponse<Workspace> localVarResponse = GetWorkspacesWorkspaceIdWithHttpInfo(workspaceId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > GetWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> GetWorkspacesWorkspaceIdAsync (string workspaceId, List<string> expand = null)
        {
             ApiResponse<Workspace> localVarResponse = await GetWorkspacesWorkspaceIdAsyncWithHttpInfo(workspaceId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> GetWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkspaceMemberEntityListing</returns>
        public WorkspaceMemberEntityListing GetWorkspacesWorkspaceIdMembers (string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> localVarResponse = GetWorkspacesWorkspaceIdMembersWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkspaceMemberEntityListing</returns>
        public ApiResponse< WorkspaceMemberEntityListing > GetWorkspacesWorkspaceIdMembersWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembers");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkspaceMemberEntityListing</returns>
        public async System.Threading.Tasks.Task<WorkspaceMemberEntityListing> GetWorkspacesWorkspaceIdMembersAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> localVarResponse = await GetWorkspacesWorkspaceIdMembersAsyncWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMemberEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> GetWorkspacesWorkspaceIdMembersAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembers");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMemberEntityListing)));
            
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember GetWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, List<string> expand = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = GetWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo(workspaceId, memberId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > GetWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembersMemberId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> GetWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, List<string> expand = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = await GetWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo(workspaceId, memberId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> GetWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembersMemberId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
            
        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        public TagValueEntityListing GetWorkspacesWorkspaceIdTagvalues (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = GetWorkspacesWorkspaceIdTagvaluesWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        public ApiResponse< TagValueEntityListing > GetWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvalues");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        public async System.Threading.Tasks.Task<TagValueEntityListing> GetWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = await GetWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> GetWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvalues");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
            
        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>TagValue</returns>
        public TagValue GetWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, List<string> expand = null)
        {
             ApiResponse<TagValue> localVarResponse = GetWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo(workspaceId, tagId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > GetWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> GetWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, List<string> expand = null)
        {
             ApiResponse<TagValue> localVarResponse = await GetWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo(workspaceId, tagId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> GetWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        public QueryResults PostAuditquery (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> localVarResponse = PostAuditqueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > PostAuditqueryWithHttpInfo (ContentQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostAuditquery");

            var localVarPath = "/api/v2/contentmanagement/auditquery";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuditquery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditquery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<QueryResults> PostAuditqueryAsync (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> localVarResponse = await PostAuditqueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostAuditqueryAsyncWithHttpInfo (ContentQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostAuditquery");

            var localVarPath = "/api/v2/contentmanagement/auditquery";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuditquery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditquery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Document</returns>
        public Document PostDocuments (DocumentUpload body, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = PostDocumentsWithHttpInfo(body, copySource, moveSource, _override);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > PostDocumentsWithHttpInfo (DocumentUpload body, string copySource = null, string moveSource = null, bool? _override = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostDocuments");

            var localVarPath = "/api/v2/contentmanagement/documents";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> PostDocumentsAsync (DocumentUpload body, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = await PostDocumentsAsyncWithHttpInfo(body, copySource, moveSource, _override);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsAsyncWithHttpInfo (DocumentUpload body, string copySource = null, string moveSource = null, bool? _override = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostDocuments");

            var localVarPath = "/api/v2/contentmanagement/documents";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Document</returns>
        public Document PostDocumentsDocumentId (string documentId, DocumentUpdate body, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = PostDocumentsDocumentIdWithHttpInfo(documentId, body, expand, _override);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > PostDocumentsDocumentIdWithHttpInfo (string documentId, DocumentUpdate body, string expand = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> PostDocumentsDocumentIdAsync (string documentId, DocumentUpdate body, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = await PostDocumentsDocumentIdAsyncWithHttpInfo(documentId, body, expand, _override);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsDocumentIdAsyncWithHttpInfo (string documentId, DocumentUpdate body, string expand = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ReplaceResponse</returns>
        public ReplaceResponse PostDocumentsDocumentIdContent (string documentId, ReplaceRequest body, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> localVarResponse = PostDocumentsDocumentIdContentWithHttpInfo(documentId, body, _override);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of ReplaceResponse</returns>
        public ApiResponse< ReplaceResponse > PostDocumentsDocumentIdContentWithHttpInfo (string documentId, ReplaceRequest body, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentIdContent");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/content";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplaceResponse)));
            
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ReplaceResponse</returns>
        public async System.Threading.Tasks.Task<ReplaceResponse> PostDocumentsDocumentIdContentAsync (string documentId, ReplaceRequest body, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> localVarResponse = await PostDocumentsDocumentIdContentAsyncWithHttpInfo(documentId, body, _override);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (ReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> PostDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, ReplaceRequest body, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentIdContent");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/content";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplaceResponse)));
            
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        public QueryResults PostQuery (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = PostQueryWithHttpInfo(body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > PostQueryWithHttpInfo (QueryRequest body, string expand = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostQuery");

            var localVarPath = "/api/v2/contentmanagement/query";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<QueryResults> PostQueryAsync (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = await PostQueryAsyncWithHttpInfo(body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostQueryAsyncWithHttpInfo (QueryRequest body, string expand = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostQuery");

            var localVarPath = "/api/v2/contentmanagement/query";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>CreateShareResponse</returns>
        public CreateShareResponse PostShares (CreateShareRequest body)
        {
             ApiResponse<CreateShareResponse> localVarResponse = PostSharesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>ApiResponse of CreateShareResponse</returns>
        public ApiResponse< CreateShareResponse > PostSharesWithHttpInfo (CreateShareRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostShares");

            var localVarPath = "/api/v2/contentmanagement/shares";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostShares: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostShares: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateShareResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateShareResponse)));
            
        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of CreateShareResponse</returns>
        public async System.Threading.Tasks.Task<CreateShareResponse> PostSharesAsync (CreateShareRequest body)
        {
             ApiResponse<CreateShareResponse> localVarResponse = await PostSharesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> PostSharesAsyncWithHttpInfo (CreateShareRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostShares");

            var localVarPath = "/api/v2/contentmanagement/shares";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostShares: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostShares: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateShareResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateShareResponse)));
            
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace</param>
        /// <returns>Workspace</returns>
        public Workspace PostWorkspaces (WorkspaceCreate body)
        {
             ApiResponse<Workspace> localVarResponse = PostWorkspacesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > PostWorkspacesWithHttpInfo (WorkspaceCreate body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostWorkspaces");

            var localVarPath = "/api/v2/contentmanagement/workspaces";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> PostWorkspacesAsync (WorkspaceCreate body)
        {
             ApiResponse<Workspace> localVarResponse = await PostWorkspacesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> PostWorkspacesAsyncWithHttpInfo (WorkspaceCreate body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostWorkspaces");

            var localVarPath = "/api/v2/contentmanagement/workspaces";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>TagValue</returns>
        public TagValue PostWorkspacesWorkspaceIdTagvalues (string workspaceId, TagValue body)
        {
             ApiResponse<TagValue> localVarResponse = PostWorkspacesWorkspaceIdTagvaluesWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > PostWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, TagValue body)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvalues");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvalues");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> PostWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, TagValue body)
        {
             ApiResponse<TagValue> localVarResponse = await PostWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> PostWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, TagValue body)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvalues");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvalues");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        public TagValueEntityListing PostWorkspacesWorkspaceIdTagvaluesQuery (string workspaceId, TagQueryRequest body, List<string> expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = PostWorkspacesWorkspaceIdTagvaluesQueryWithHttpInfo(workspaceId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        public ApiResponse< TagValueEntityListing > PostWorkspacesWorkspaceIdTagvaluesQueryWithHttpInfo (string workspaceId, TagQueryRequest body, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvaluesQuery");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvaluesQuery");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
            
        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        public async System.Threading.Tasks.Task<TagValueEntityListing> PostWorkspacesWorkspaceIdTagvaluesQueryAsync (string workspaceId, TagQueryRequest body, List<string> expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = await PostWorkspacesWorkspaceIdTagvaluesQueryAsyncWithHttpInfo(workspaceId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> PostWorkspacesWorkspaceIdTagvaluesQueryAsyncWithHttpInfo (string workspaceId, TagQueryRequest body, List<string> expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvaluesQuery");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvaluesQuery");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
            
        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Workspace</returns>
        public Workspace PutWorkspacesWorkspaceId (string workspaceId, Workspace body)
        {
             ApiResponse<Workspace> localVarResponse = PutWorkspacesWorkspaceIdWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > PutWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, Workspace body)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PutWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> PutWorkspacesWorkspaceIdAsync (string workspaceId, Workspace body)
        {
             ApiResponse<Workspace> localVarResponse = await PutWorkspacesWorkspaceIdAsyncWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> PutWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, Workspace body)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PutWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
            
        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace Member</param>
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember PutWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, WorkspaceMember body)
        {
             ApiResponse<WorkspaceMember> localVarResponse = PutWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo(workspaceId, memberId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace Member</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > PutWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="body">Workspace Member</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> PutWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, WorkspaceMember body)
        {
             ApiResponse<WorkspaceMember> localVarResponse = await PutWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo(workspaceId, memberId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace Member</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> PutWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
            
        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>TagValue</returns>
        public TagValue PutWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, TagValue body)
        {
             ApiResponse<TagValue> localVarResponse = PutWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo(workspaceId, tagId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > PutWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, TagValue body)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="body">Workspace</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> PutWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, TagValue body)
        {
             ApiResponse<TagValue> localVarResponse = await PutWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo(workspaceId, tagId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> PutWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

    }
}
