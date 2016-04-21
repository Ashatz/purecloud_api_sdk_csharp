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
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        QueryResults ContentmanagementAuditqueryPost (ContentQueryRequest body);
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns></returns>
        void DeleteDocumentsDocumentId (string documentId, bool? _override = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> ContentmanagementAuditqueryPostWithHttpInfo (ContentQueryRequest body);
        /// <summary>
        /// Get a list of audits for a document.
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);
        /// <summary>
        /// Delete a member from a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns></returns>
        void ContentmanagementDocumentsDocumentidContentGet (string documentId, string disposition = null);

        /// <summary>
        /// Download a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns></returns>
        void DeleteWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId);

        /// <summary>
        /// Delete a member from a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementDocumentsDocumentidContentGetWithHttpInfo (string documentId, string disposition = null);
        /// <summary>
        /// Replace the contents of a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId);
        /// <summary>
        /// Delete workspace tag
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ReplaceResponse</returns>
        ReplaceResponse ContentmanagementDocumentsDocumentidContentPost (string documentId, ReplaceRequest body = null, bool? _override = null);

        /// <summary>
        /// Replace the contents of a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns></returns>
        void DeleteWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId);

        /// <summary>
        /// Delete workspace tag
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of ReplaceResponse</returns>
        ApiResponse<ReplaceResponse> ContentmanagementDocumentsDocumentidContentPostWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);
        /// <summary>
        /// Delete a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId);
        /// <summary>
        /// Get a list of documents.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns></returns>
        void ContentmanagementDocumentsDocumentidDelete (string documentId, bool? _override = null);

        /// <summary>
        /// Delete a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>DocumentEntityListing</returns>
        DocumentEntityListing GetDocuments (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of documents.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementDocumentsDocumentidDeleteWithHttpInfo (string documentId, bool? _override = null);
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>ApiResponse of DocumentEntityListing</returns>
        ApiResponse<DocumentEntityListing> GetDocumentsWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        Document ContentmanagementDocumentsDocumentidGet (string documentId, string expand = null);
=======
        Document GetDocumentsDocumentId (string documentId, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
        ApiResponse<Document> ContentmanagementDocumentsDocumentidGetWithHttpInfo (string documentId, string expand = null);
=======
        ApiResponse<Document> GetDocumentsDocumentIdWithHttpInfo (string documentId, string expand = null);
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Document</returns>
        Document ContentmanagementDocumentsDocumentidPost (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
=======
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns></returns>
        void GetDocumentsDocumentIdContent (string documentId, string disposition = null, string contentType = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> ContentmanagementDocumentsDocumentidPostWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
        /// <summary>
        /// Get a list of documents.
=======
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetDocumentsDocumentIdContentWithHttpInfo (string documentId, string disposition = null, string contentType = null);
        /// <summary>
        /// Query content
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        QueryResults GetQuery (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

        /// <summary>
        /// Query content
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> GetQueryWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
        /// <summary>
        /// Get a List of Security Profiles
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Document</returns>
        Document ContentmanagementDocumentsPost (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

        /// <summary>
        /// Add a document.
=======
        /// <returns>SecurityProfileEntityListing</returns>
        SecurityProfileEntityListing GetSecurityprofiles ();

        /// <summary>
        /// Get a List of Security Profiles
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> ContentmanagementDocumentsPostWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
        /// <summary>
        /// Query content
=======
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        ApiResponse<SecurityProfileEntityListing> GetSecurityprofilesWithHttpInfo ();
        /// <summary>
        /// Get a Security Profile
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>SecurityProfile</returns>
        SecurityProfile GetSecurityprofilesSecurityprofileId (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>ApiResponse of SecurityProfile</returns>
        ApiResponse<SecurityProfile> GetSecurityprofilesSecurityprofileIdWithHttpInfo (string securityProfileId);
        /// <summary>
        /// Get shared documents. Securely download a shared document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        QueryResults ContentmanagementQueryPost (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
=======
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns></returns>
        void GetSharedSharedId (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);

        /// <summary>
        /// Get shared documents. Securely download a shared document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> ContentmanagementQueryPostWithHttpInfo (QueryRequest body, string expand = null);
        /// <summary>
        /// Get a List of Security Profiles
=======
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetSharedSharedIdWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>SecurityProfileEntityListing</returns>
        SecurityProfileEntityListing ContentmanagementSecurityprofilesGet ();

        /// <summary>
        /// Get a List of Security Profiles
=======
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ShareEntityListing</returns>
        ShareEntityListing GetShares (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        ApiResponse<SecurityProfileEntityListing> ContentmanagementSecurityprofilesGetWithHttpInfo ();
        /// <summary>
        /// Get a Security Profile
=======
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ShareEntityListing</returns>
        ApiResponse<ShareEntityListing> GetSharesWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Retrieve details about an existing share.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>SecurityProfile</returns>
        SecurityProfile ContentmanagementSecurityprofilesSecurityprofileidGet (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
=======
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Share</returns>
        Share GetSharesShareId (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>ApiResponse of SecurityProfile</returns>
        ApiResponse<SecurityProfile> ContentmanagementSecurityprofilesSecurityprofileidGetWithHttpInfo (string securityProfileId);
        /// <summary>
        /// Get shared documents. Securely download a shared document.
=======
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>ApiResponse of Share</returns>
        ApiResponse<Share> GetSharesShareIdWithHttpInfo (string shareId, string expand = null);
        /// <summary>
        /// Get a list of statuses for pending operations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns></returns>
        void ContentmanagementSharedSharedidGet (string sharedId, bool? redirect = null, string disposition = null, string expand = null);

        /// <summary>
        /// Get shared documents. Securely download a shared document.
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>CommandStatusEntityListing</returns>
        CommandStatusEntityListing GetStatus (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of statuses for pending operations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementSharedSharedidGetWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string expand = null);
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of CommandStatusEntityListing</returns>
        ApiResponse<CommandStatusEntityListing> GetStatusWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a status.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ShareEntityListing</returns>
        ShareEntityListing ContentmanagementSharesGet (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
=======
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        CommandStatus GetStatusStatusId (string statusId);

        /// <summary>
        /// Get a status.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ShareEntityListing</returns>
        ApiResponse<ShareEntityListing> ContentmanagementSharesGetWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
=======
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of CommandStatus</returns>
        ApiResponse<CommandStatus> GetStatusStatusIdWithHttpInfo (string statusId);
        /// <summary>
        /// Get a list of workspaces.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>CreateShareResponse</returns>
        CreateShareResponse ContentmanagementSharesPost (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>WorkspaceEntityListing</returns>
        WorkspaceEntityListing GetWorkspaces (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);

        /// <summary>
        /// Get a list of workspaces.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceEntityListing</returns>
        ApiResponse<WorkspaceEntityListing> GetWorkspacesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
        /// <summary>
        /// Get a workspace.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Share</returns>
        Share ContentmanagementSharesShareidGet (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Workspace</returns>
        Workspace GetWorkspacesWorkspaceId (string workspaceId, string expand = null);

        /// <summary>
        /// Get a workspace.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> GetWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, string expand = null);
        /// <summary>
        /// Get a list workspace members
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>WorkspaceMemberEntityListing</returns>
        WorkspaceMemberEntityListing GetWorkspacesWorkspaceIdMembers (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list workspace members
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementStatusStatusidDeleteWithHttpInfo (string statusId);
        /// <summary>
        /// Get a status.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceMemberEntityListing</returns>
        ApiResponse<WorkspaceMemberEntityListing> GetWorkspacesWorkspaceIdMembersWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
        /// <summary>
        /// Get a workspace member
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        CommandStatus ContentmanagementStatusStatusidGet (string statusId);

        /// <summary>
        /// Get a status.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>WorkspaceMember</returns>
        WorkspaceMember GetWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, string expand = null);

        /// <summary>
        /// Get a workspace member
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        ApiResponse<WorkspaceMember> GetWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, string expand = null);
        /// <summary>
        /// Get a list of workspace tags
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        Workspace ContentmanagementWorkspacesPost (WorkspaceCreate body = null);

        /// <summary>
        /// Create a group workspace
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        TagValueEntityListing GetWorkspacesWorkspaceIdTagvalues (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of workspace tags
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> ContentmanagementWorkspacesPostWithHttpInfo (WorkspaceCreate body = null);
        /// <summary>
        /// Delete a workspace
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        ApiResponse<TagValueEntityListing> GetWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
        /// <summary>
        /// Get a workspace tag
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
<<<<<<< HEAD
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns></returns>
        void ContentmanagementWorkspacesWorkspaceidDelete (string workspaceId, string moveChildrenToWorkspaceId = null);

        /// <summary>
        /// Delete a workspace
=======
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValue</returns>
        TagValue GetWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, string expand = null);

        /// <summary>
        /// Get a workspace tag
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
<<<<<<< HEAD
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
=======
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> GetWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, string expand = null);
        /// <summary>
        /// Query audits
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        QueryResults PostAuditquery (ContentQueryRequest body);

        /// <summary>
        /// Query audits
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceMemberEntityListing</returns>
        ApiResponse<WorkspaceMemberEntityListing> ContentmanagementWorkspacesWorkspaceidMembersGetWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
        /// <summary>
        /// Delete a member from a workspace
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> PostAuditqueryWithHttpInfo (ContentQueryRequest body);
        /// <summary>
        /// Add a document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns></returns>
        void ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete (string workspaceId, string memberId);

        /// <summary>
        /// Delete a member from a workspace
=======
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Document</returns>
        Document PostDocuments (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

        /// <summary>
        /// Add a document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> PostDocumentsWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
        /// <summary>
        /// Update a document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Document</returns>
        Document PostDocumentsDocumentId (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);

        /// <summary>
        /// Update a document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        ApiResponse<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);
        /// <summary>
        /// Update a workspace
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> PostDocumentsDocumentIdWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
        /// <summary>
        /// Replace the contents of a document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ReplaceResponse</returns>
        ReplaceResponse PostDocumentsDocumentIdContent (string documentId, ReplaceRequest body = null, bool? _override = null);

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
        ApiResponse<ReplaceResponse> PostDocumentsDocumentIdContentWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);
        /// <summary>
        /// Query content
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValue</returns>
        TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet (string workspaceId, string tagId, string expand = null);

        /// <summary>
        /// Get a workspace tag
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        QueryResults PostQuery (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> PostQueryWithHttpInfo (QueryRequest body, string expand = null);
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutWithHttpInfo (string workspaceId, string tagId, TagValue body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Query audits
=======
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>CreateShareResponse</returns>
        CreateShareResponse PostShares (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> ContentmanagementAuditqueryPostAsync (ContentQueryRequest body);

        /// <summary>
        /// Query audits
=======
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>ApiResponse of CreateShareResponse</returns>
        ApiResponse<CreateShareResponse> PostSharesWithHttpInfo (CreateShareRequest body = null);
        /// <summary>
        /// Create a group workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementAuditqueryPostAsyncWithHttpInfo (ContentQueryRequest body);
        /// <summary>
        /// Get a list of audits for a document.
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        Workspace PostWorkspaces (WorkspaceCreate body = null);

        /// <summary>
        /// Create a group workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> PostWorkspacesWithHttpInfo (WorkspaceCreate body = null);
        /// <summary>
        /// Create a workspace tag
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>TagValue</returns>
        TagValue PostWorkspacesWorkspaceIdTagvalues (string workspaceId, TagValue body = null);

        /// <summary>
        /// Create a workspace tag
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidContentGetAsync (string documentId, string disposition = null);

        /// <summary>
        /// Download a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> PostWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, TagValue body = null);
        /// <summary>
        /// Perform a prefix query on tags in the workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidContentGetAsyncWithHttpInfo (string documentId, string disposition = null);
        /// <summary>
        /// Replace the contents of a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        TagValueEntityListing PostWorkspacesWorkspaceIdTagvaluesQuery (string workspaceId, TagQueryRequest body = null, string expand = null);

        /// <summary>
        /// Perform a prefix query on tags in the workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ReplaceResponse</returns>
        System.Threading.Tasks.Task<ReplaceResponse> ContentmanagementDocumentsDocumentidContentPostAsync (string documentId, ReplaceRequest body = null, bool? _override = null);

        /// <summary>
        /// Replace the contents of a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        ApiResponse<TagValueEntityListing> PostWorkspacesWorkspaceIdTagvaluesQueryWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null);
        /// <summary>
        /// Update a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (ReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> ContentmanagementDocumentsDocumentidContentPostAsyncWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);
        /// <summary>
        /// Delete a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        Workspace PutWorkspacesWorkspaceId (string workspaceId, Workspace body = null);

        /// <summary>
        /// Update a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidDeleteAsync (string documentId, bool? _override = null);

        /// <summary>
        /// Delete a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> PutWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, Workspace body = null);
        /// <summary>
        /// Add a member to a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidDeleteAsyncWithHttpInfo (string documentId, bool? _override = null);
        /// <summary>
        /// Get a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>WorkspaceMember</returns>
        WorkspaceMember PutWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, WorkspaceMember body = null);

        /// <summary>
        /// Add a member to a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidGetAsync (string documentId, string expand = null);

        /// <summary>
        /// Get a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        ApiResponse<WorkspaceMember> PutWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);
        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidGetAsyncWithHttpInfo (string documentId, string expand = null);
        /// <summary>
        /// Update a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>TagValue</returns>
        TagValue PutWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, TagValue body = null);

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidPostAsync (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);

        /// <summary>
        /// Update a document.
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> PutWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, TagValue body = null);
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidPostAsyncWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
=======
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSharesShareIdAsync (string shareId);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSharesShareIdAsyncWithHttpInfo (string shareId);
        /// <summary>
        /// Cancel the command for this status
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteStatusStatusIdAsync (string statusId);

        /// <summary>
        /// Cancel the command for this status
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> ContentmanagementDocumentsPostAsync (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

        /// <summary>
        /// Add a document.
=======
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteStatusStatusIdAsyncWithHttpInfo (string statusId);
        /// <summary>
        /// Delete a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsPostAsyncWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
        /// <summary>
        /// Query content
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdAsync (string workspaceId, string moveChildrenToWorkspaceId = null);

        /// <summary>
        /// Delete a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);
        /// <summary>
        /// Delete a member from a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId);

        /// <summary>
        /// Delete a member from a workspace
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> ContentmanagementQueryPostAsync (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId);
        /// <summary>
        /// Delete workspace tag
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementQueryPostAsyncWithHttpInfo (QueryRequest body, string expand = null);
        /// <summary>
        /// Get a List of Security Profiles
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId);

        /// <summary>
        /// Delete workspace tag
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of SecurityProfileEntityListing</returns>
        System.Threading.Tasks.Task<SecurityProfileEntityListing> ContentmanagementSecurityprofilesGetAsync ();

        /// <summary>
        /// Get a List of Security Profiles
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId);
        /// <summary>
        /// Get a list of documents.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> ContentmanagementSecurityprofilesGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get a Security Profile
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of DocumentEntityListing</returns>
        System.Threading.Tasks.Task<DocumentEntityListing> GetDocumentsAsync (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of documents.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of SecurityProfile</returns>
        System.Threading.Tasks.Task<SecurityProfile> ContentmanagementSecurityprofilesSecurityprofileidGetAsync (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>Task of ApiResponse (DocumentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> GetDocumentsDocumentIdAsync (string documentId, string expand = null);

        /// <summary>
        /// Get a document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> GetDocumentsDocumentIdAsyncWithHttpInfo (string documentId, string expand = null);
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of CreateShareResponse</returns>
        System.Threading.Tasks.Task<CreateShareResponse> ContentmanagementSharesPostAsync (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetDocumentsDocumentIdContentAsync (string documentId, string disposition = null, string contentType = null);

        /// <summary>
        /// Download a document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> ContentmanagementSharesPostAsyncWithHttpInfo (CreateShareRequest body = null);
        /// <summary>
        /// Deletes an existing share.
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, string disposition = null, string contentType = null);
        /// <summary>
        /// Query content
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementSharesShareidDeleteAsync (string shareId);

        /// <summary>
        /// Deletes an existing share.
=======
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> GetQueryAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

        /// <summary>
        /// Query content
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementSharesShareidDeleteAsyncWithHttpInfo (string shareId);
        /// <summary>
        /// Retrieve details about an existing share.
=======
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> GetQueryAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
        /// <summary>
        /// Get a List of Security Profiles
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of Share</returns>
        System.Threading.Tasks.Task<Share> ContentmanagementSharesShareidGetAsync (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
=======
        /// <returns>Task of SecurityProfileEntityListing</returns>
        System.Threading.Tasks.Task<SecurityProfileEntityListing> GetSecurityprofilesAsync ();

        /// <summary>
        /// Get a List of Security Profiles
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        System.Threading.Tasks.Task<ApiResponse<Share>> ContentmanagementSharesShareidGetAsyncWithHttpInfo (string shareId, string expand = null);
        /// <summary>
        /// Get a list of statuses for pending operations
=======
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> GetSecurityprofilesAsyncWithHttpInfo ();
        /// <summary>
        /// Get a Security Profile
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of CommandStatusEntityListing</returns>
        System.Threading.Tasks.Task<CommandStatusEntityListing> ContentmanagementStatusGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of statuses for pending operations
=======
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of SecurityProfile</returns>
        System.Threading.Tasks.Task<SecurityProfile> GetSecurityprofilesSecurityprofileIdAsync (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> ContentmanagementStatusGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Cancel the command for this status
=======
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of ApiResponse (SecurityProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfile>> GetSecurityprofilesSecurityprofileIdAsyncWithHttpInfo (string securityProfileId);
        /// <summary>
        /// Get shared documents. Securely download a shared document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementStatusStatusidDeleteAsync (string statusId);

        /// <summary>
        /// Cancel the command for this status
=======
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetSharedSharedIdAsync (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);

        /// <summary>
        /// Get shared documents. Securely download a shared document.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementStatusStatusidDeleteAsyncWithHttpInfo (string statusId);
        /// <summary>
        /// Get a status.
=======
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect (optional, default to true)</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment. (optional, default to attachment)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetSharedSharedIdAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        System.Threading.Tasks.Task<CommandStatus> ContentmanagementStatusStatusidGetAsync (string statusId);

        /// <summary>
        /// Get a status.
=======
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter. (optional)</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ShareEntityListing</returns>
        System.Threading.Tasks.Task<ShareEntityListing> GetSharesAsync (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> GetSharesAsyncWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Retrieve details about an existing share.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatus>> ContentmanagementStatusStatusidGetAsyncWithHttpInfo (string statusId);
        /// <summary>
        /// Get a list of workspaces.
=======
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of Share</returns>
        System.Threading.Tasks.Task<Share> GetSharesShareIdAsync (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of WorkspaceEntityListing</returns>
        System.Threading.Tasks.Task<WorkspaceEntityListing> ContentmanagementWorkspacesGetAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);

        /// <summary>
        /// Get a list of workspaces.
=======
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        System.Threading.Tasks.Task<ApiResponse<Share>> GetSharesShareIdAsyncWithHttpInfo (string shareId, string expand = null);
        /// <summary>
        /// Get a list of statuses for pending operations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
<<<<<<< HEAD
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> ContentmanagementWorkspacesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
        /// <summary>
        /// Create a group workspace
=======
        /// <returns>Task of CommandStatusEntityListing</returns>
        System.Threading.Tasks.Task<CommandStatusEntityListing> GetStatusAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of statuses for pending operations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesPostAsync (WorkspaceCreate body = null);

        /// <summary>
        /// Create a group workspace
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> GetStatusAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a status.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesPostAsyncWithHttpInfo (WorkspaceCreate body = null);
=======
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        System.Threading.Tasks.Task<CommandStatus> GetStatusStatusIdAsync (string statusId);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidDeleteAsync (string workspaceId, string moveChildrenToWorkspaceId = null);
=======
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatus>> GetStatusStatusIdAsyncWithHttpInfo (string statusId);
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
        System.Threading.Tasks.Task<WorkspaceEntityListing> GetWorkspacesAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidDeleteAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> GetWorkspacesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidGetAsync (string workspaceId, string expand = null);
=======
        System.Threading.Tasks.Task<Workspace> GetWorkspacesWorkspaceIdAsync (string workspaceId, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidGetAsyncWithHttpInfo (string workspaceId, string expand = null);
=======
        System.Threading.Tasks.Task<ApiResponse<Workspace>> GetWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        System.Threading.Tasks.Task<WorkspaceMemberEntityListing> GetWorkspacesWorkspaceIdMembersAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);

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
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> ContentmanagementWorkspacesWorkspaceidMembersGetAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
=======
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> GetWorkspacesWorkspaceIdMembersAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
<<<<<<< HEAD
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsync (string workspaceId, string memberId);
=======
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        System.Threading.Tasks.Task<WorkspaceMember> GetWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsyncWithHttpInfo (string workspaceId, string memberId);
=======
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> GetWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
<<<<<<< HEAD
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsync (string workspaceId, string memberId, string expand = null);
=======
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        System.Threading.Tasks.Task<TagValueEntityListing> GetWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
<<<<<<< HEAD
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsyncWithHttpInfo (string workspaceId, string memberId, string expand = null);
=======
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> GetWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
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
        System.Threading.Tasks.Task<TagValue> GetWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<TagValue>> GetWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsync (string workspaceId, string memberId, WorkspaceMember body = null);
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> PostAuditqueryAsync (ContentQueryRequest body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);
        /// <summary>
        /// Update a workspace
=======
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
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> PostDocumentsAsync (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

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
        System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsAsyncWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
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
        System.Threading.Tasks.Task<Document> PostDocumentsDocumentIdAsync (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);

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
        System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsDocumentIdAsyncWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
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
        System.Threading.Tasks.Task<ReplaceResponse> PostDocumentsDocumentIdContentAsync (string documentId, ReplaceRequest body = null, bool? _override = null);

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
        System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> PostDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);
        /// <summary>
        /// Query content
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidPutAsync (string workspaceId, Workspace body = null);

        /// <summary>
        /// Update a workspace
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> PostQueryAsync (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidPutAsyncWithHttpInfo (string workspaceId, Workspace body = null);
        /// <summary>
        /// Get a list of workspace tags
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostQueryAsyncWithHttpInfo (QueryRequest body, string expand = null);
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of workspace tags
=======
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of CreateShareResponse</returns>
        System.Threading.Tasks.Task<CreateShareResponse> PostSharesAsync (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
=======
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> PostSharesAsyncWithHttpInfo (CreateShareRequest body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsync (string workspaceId, TagValue body = null);
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> PostWorkspacesAsync (WorkspaceCreate body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsyncWithHttpInfo (string workspaceId, TagValue body = null);
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> PostWorkspacesAsyncWithHttpInfo (WorkspaceCreate body = null);
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
        System.Threading.Tasks.Task<TagValue> PostWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, TagValue body = null);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
<<<<<<< HEAD
=======
        /// <param name="body">tag (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> PostWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, TagValue body = null);
        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="body">query (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        System.Threading.Tasks.Task<TagValueEntityListing> PostWorkspacesWorkspaceIdTagvaluesQueryAsync (string workspaceId, TagQueryRequest body = null, string expand = null);

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
<<<<<<< HEAD
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
=======
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> PostWorkspacesWorkspaceIdTagvaluesQueryAsyncWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
<<<<<<< HEAD
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsync (string workspaceId, string tagId, string expand = null);
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> PutWorkspacesWorkspaceIdAsync (string workspaceId, Workspace body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
<<<<<<< HEAD
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsyncWithHttpInfo (string workspaceId, string tagId, string expand = null);
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> PutWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, Workspace body = null);
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
        System.Threading.Tasks.Task<WorkspaceMember> PutWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, WorkspaceMember body = null);

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
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> PutWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        System.Threading.Tasks.Task<TagValue> PutWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, TagValue body = null);

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
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null);
=======
        System.Threading.Tasks.Task<ApiResponse<TagValue>> PutWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        public QueryResults ContentmanagementAuditqueryPost (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> localVarResponse = ContentmanagementAuditqueryPostWithHttpInfo(body);
             return localVarResponse.Data;
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns></returns>
        public void DeleteDocumentsDocumentId (string documentId, bool? _override = null)
        {
             DeleteDocumentsDocumentIdWithHttpInfo(documentId, _override);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > ContentmanagementAuditqueryPostWithHttpInfo (ContentQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->ContentmanagementAuditqueryPost");

            var localVarPath = "/api/v1/contentmanagement/auditquery";
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteDocumentsDocumentIdWithHttpInfo (string documentId, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->DeleteDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementAuditqueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementAuditqueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> ContentmanagementAuditqueryPostAsync (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> localVarResponse = await ContentmanagementAuditqueryPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteDocumentsDocumentIdAsync (string documentId, bool? _override = null)
        {
             await DeleteDocumentsDocumentIdAsyncWithHttpInfo(documentId, _override);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementAuditqueryPostAsyncWithHttpInfo (ContentQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->ContentmanagementAuditqueryPost");

            var localVarPath = "/api/v1/contentmanagement/auditquery";
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentsDocumentIdAsyncWithHttpInfo (string documentId, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->DeleteDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementAuditqueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementAuditqueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (transactionFilter != null) localVarQueryParams.Add("transactionFilter", Configuration.ApiClient.ParameterToString(transactionFilter)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
=======
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentAuditEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAuditEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteSharesShareId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSharesShareId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteSharesShareIdAsync (string shareId)
        {
             await DeleteSharesShareIdAsyncWithHttpInfo(shareId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (transactionFilter != null) localVarQueryParams.Add("transactionFilter", Configuration.ApiClient.ParameterToString(transactionFilter)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
=======
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentAuditEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAuditEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteSharesShareId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSharesShareId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (disposition != null) localVarQueryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
=======
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteStatusStatusId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidContentGetAsync (string documentId, string disposition = null)
        {
             await ContentmanagementDocumentsDocumentidContentGetAsyncWithHttpInfo(documentId, disposition);
=======
        /// Cancel the command for this status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteStatusStatusIdAsync (string statusId)
        {
             await DeleteStatusStatusIdAsyncWithHttpInfo(statusId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (disposition != null) localVarQueryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
=======
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteStatusStatusId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
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
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (moveChildrenToWorkspaceId != null) localVarQueryParams.Add("moveChildrenToWorkspaceId", Configuration.ApiClient.ParameterToString(moveChildrenToWorkspaceId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplaceResponse)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Delete a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdAsync (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             await DeleteWorkspacesWorkspaceIdAsyncWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
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
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (moveChildrenToWorkspaceId != null) localVarQueryParams.Add("moveChildrenToWorkspaceId", Configuration.ApiClient.ParameterToString(moveChildrenToWorkspaceId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplaceResponse)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidDeleteAsync (string documentId, bool? _override = null)
        {
             await ContentmanagementDocumentsDocumentidDeleteAsyncWithHttpInfo(documentId, _override);
=======
        /// Delete a member from a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId)
        {
             await DeleteWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo(workspaceId, memberId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (_override != null) localVarQueryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
            
<<<<<<< HEAD
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
=======
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
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
        /// <returns>DocumentEntityListing</returns>
        public DocumentEntityListing GetDocuments (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> localVarResponse = GetDocumentsWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
        public ApiResponse< DocumentEntityListing > GetDocumentsWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetDocuments");

            var localVarPath = "/api/v2/contentmanagement/documents";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
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
=======
            if (workspaceId != null) localVarQueryParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
        public async System.Threading.Tasks.Task<DocumentEntityListing> GetDocumentsAsync (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> localVarResponse = await GetDocumentsAsyncWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
        public async System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetDocuments");

            var localVarPath = "/api/v2/contentmanagement/documents";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
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
=======
            if (workspaceId != null) localVarQueryParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Document</returns>
        public Document GetDocumentsDocumentId (string documentId, string expand = null)
        {
             ApiResponse<Document> localVarResponse = GetDocumentsDocumentIdWithHttpInfo(documentId, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > GetDocumentsDocumentIdWithHttpInfo (string documentId, string expand = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarQueryParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> GetDocumentsDocumentIdAsync (string documentId, string expand = null)
        {
             ApiResponse<Document> localVarResponse = await GetDocumentsDocumentIdAsyncWithHttpInfo(documentId, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> GetDocumentsDocumentIdAsyncWithHttpInfo (string documentId, string expand = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarQueryParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
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
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (transactionFilter != null) localVarQueryParams.Add("transactionFilter", Configuration.ApiClient.ParameterToString(transactionFilter)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentAuditEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAuditEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
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
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (transactionFilter != null) localVarQueryParams.Add("transactionFilter", Configuration.ApiClient.ParameterToString(transactionFilter)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementDocumentsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentAuditEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAuditEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns></returns>
        public void GetDocumentsDocumentIdContent (string documentId, string disposition = null, string contentType = null)
        {
             GetDocumentsDocumentIdContentWithHttpInfo(documentId, disposition, contentType);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetDocumentsDocumentIdContentWithHttpInfo (string documentId, string disposition = null, string contentType = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/content";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (queryPhrase != null) localVarQueryParams.Add("queryPhrase", Configuration.ApiClient.ParameterToString(queryPhrase)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (disposition != null) localVarQueryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (contentType != null) localVarQueryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetDocumentsDocumentIdContentAsync (string documentId, string disposition = null, string contentType = null)
        {
             await GetDocumentsDocumentIdContentAsyncWithHttpInfo(documentId, disposition, contentType);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment. (optional)</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, string disposition = null, string contentType = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/content";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (queryPhrase != null) localVarQueryParams.Add("queryPhrase", Configuration.ApiClient.ParameterToString(queryPhrase)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (disposition != null) localVarQueryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (contentType != null) localVarQueryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
=======
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        public QueryResults GetQuery (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
<<<<<<< HEAD
             ApiResponse<QueryResults> localVarResponse = ContentmanagementQueryPostWithHttpInfo(body, expand);
=======
             ApiResponse<QueryResults> localVarResponse = GetQueryWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
=======
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > GetQueryWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
<<<<<<< HEAD
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->ContentmanagementQueryPost");

            var localVarPath = "/api/v1/contentmanagement/query";
=======
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null)
                throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling ContentManagementApi->GetQuery");

            var localVarPath = "/api/v2/contentmanagement/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (queryPhrase != null) localVarQueryParams.Add("queryPhrase", Configuration.ApiClient.ParameterToString(queryPhrase)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
            
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
=======
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> GetQueryAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
<<<<<<< HEAD
             ApiResponse<QueryResults> localVarResponse = await ContentmanagementQueryPostAsyncWithHttpInfo(body, expand);
=======
             ApiResponse<QueryResults> localVarResponse = await GetQueryAsyncWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Allows for a filtered query returning facet information</param>
=======
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">name or dateCreated (optional, default to name)</param>
        /// <param name="sortOrder">ascending or descending (optional, default to ascending)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> GetQueryAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
<<<<<<< HEAD
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->ContentmanagementQueryPost");

            var localVarPath = "/api/v1/contentmanagement/query";
=======
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null)
                throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling ContentManagementApi->GetQuery");

            var localVarPath = "/api/v2/contentmanagement/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (queryPhrase != null) localVarQueryParams.Add("queryPhrase", Configuration.ApiClient.ParameterToString(queryPhrase)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
             ApiResponse<SecurityProfileEntityListing> localVarResponse = ContentmanagementSecurityprofilesGetWithHttpInfo();
=======
             ApiResponse<SecurityProfileEntityListing> localVarResponse = GetSecurityprofilesWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        public ApiResponse< SecurityProfileEntityListing > GetSecurityprofilesWithHttpInfo ()
        {

<<<<<<< HEAD
            var localVarPath = "/api/v1/contentmanagement/securityprofiles";
=======
            var localVarPath = "/api/v2/contentmanagement/securityprofiles";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofiles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofiles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
             ApiResponse<SecurityProfileEntityListing> localVarResponse = await ContentmanagementSecurityprofilesGetAsyncWithHttpInfo();
=======
             ApiResponse<SecurityProfileEntityListing> localVarResponse = await GetSecurityprofilesAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> GetSecurityprofilesAsyncWithHttpInfo ()
        {

<<<<<<< HEAD
            var localVarPath = "/api/v1/contentmanagement/securityprofiles";
=======
            var localVarPath = "/api/v2/contentmanagement/securityprofiles";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofiles: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofiles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
             ApiResponse<SecurityProfile> localVarResponse = ContentmanagementSecurityprofilesSecurityprofileidGetWithHttpInfo(securityProfileId);
=======
             ApiResponse<SecurityProfile> localVarResponse = GetSecurityprofilesSecurityprofileIdWithHttpInfo(securityProfileId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentManagementApi->ContentmanagementSecurityprofilesSecurityprofileidGet");

            var localVarPath = "/api/v1/contentmanagement/securityprofiles/{securityProfileId}";
=======
                throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentManagementApi->GetSecurityprofilesSecurityprofileId");

            var localVarPath = "/api/v2/contentmanagement/securityprofiles/{securityProfileId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
             ApiResponse<SecurityProfile> localVarResponse = await ContentmanagementSecurityprofilesSecurityprofileidGetAsyncWithHttpInfo(securityProfileId);
=======
             ApiResponse<SecurityProfile> localVarResponse = await GetSecurityprofilesSecurityprofileIdAsyncWithHttpInfo(securityProfileId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentManagementApi->ContentmanagementSecurityprofilesSecurityprofileidGet");

            var localVarPath = "/api/v1/contentmanagement/securityprofiles/{securityProfileId}";
=======
                throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentManagementApi->GetSecurityprofilesSecurityprofileId");

            var localVarPath = "/api/v2/contentmanagement/securityprofiles/{securityProfileId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
=======
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetSharedSharedIdWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
            // verify the required parameter 'sharedId' is set
            if (sharedId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentManagementApi->ContentmanagementSharedSharedidGet");

            var localVarPath = "/api/v1/contentmanagement/shared/{sharedId}";
=======
                throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentManagementApi->GetSharedSharedId");

            var localVarPath = "/api/v2/contentmanagement/shared/{sharedId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (contentType != null) localVarQueryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharedSharedidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharedSharedidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSharedSharedId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSharedSharedId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            
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
<<<<<<< HEAD
=======
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType&#x3D;audio/wav (optional)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetSharedSharedIdAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
            // verify the required parameter 'sharedId' is set
            if (sharedId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentManagementApi->ContentmanagementSharedSharedidGet");

            var localVarPath = "/api/v1/contentmanagement/shared/{sharedId}";
=======
                throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentManagementApi->GetSharedSharedId");

            var localVarPath = "/api/v2/contentmanagement/shared/{sharedId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (contentType != null) localVarQueryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharedSharedidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharedSharedidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSharedSharedId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSharedSharedId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            
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
        public ShareEntityListing GetShares (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
<<<<<<< HEAD
             ApiResponse<ShareEntityListing> localVarResponse = ContentmanagementSharesGetWithHttpInfo(entityId, expand, pageSize, pageNumber);
=======
             ApiResponse<ShareEntityListing> localVarResponse = GetSharesWithHttpInfo(entityId, expand, pageSize, pageNumber);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        public ApiResponse< ShareEntityListing > GetSharesWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {

<<<<<<< HEAD
            var localVarPath = "/api/v1/contentmanagement/shares";
=======
            var localVarPath = "/api/v2/contentmanagement/shares";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetShares: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShares: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
        public async System.Threading.Tasks.Task<ShareEntityListing> GetSharesAsync (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
<<<<<<< HEAD
             ApiResponse<ShareEntityListing> localVarResponse = await ContentmanagementSharesGetAsyncWithHttpInfo(entityId, expand, pageSize, pageNumber);
=======
             ApiResponse<ShareEntityListing> localVarResponse = await GetSharesAsyncWithHttpInfo(entityId, expand, pageSize, pageNumber);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        public async System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> GetSharesAsyncWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {

<<<<<<< HEAD
            var localVarPath = "/api/v1/contentmanagement/shares";
=======
            var localVarPath = "/api/v2/contentmanagement/shares";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetShares: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShares: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<ShareEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShareEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShareEntityListing)));
            
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>CreateShareResponse</returns>
        public CreateShareResponse ContentmanagementSharesPost (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> localVarResponse = ContentmanagementSharesPostWithHttpInfo(body);
=======
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Share</returns>
        public Share GetSharesShareId (string shareId, string expand = null)
        {
             ApiResponse<Share> localVarResponse = GetSharesShareIdWithHttpInfo(shareId, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>ApiResponse of CreateShareResponse</returns>
        public ApiResponse< CreateShareResponse > ContentmanagementSharesPostWithHttpInfo (CreateShareRequest body = null)
        {

            var localVarPath = "/api/v1/contentmanagement/shares";
=======
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>ApiResponse of Share</returns>
        public ApiResponse< Share > GetSharesShareIdWithHttpInfo (string shareId, string expand = null)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->GetSharesShareId");

            var localVarPath = "/api/v2/contentmanagement/shares/{shareId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateShareResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateShareResponse)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSharesShareId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSharesShareId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Share>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Share)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of CreateShareResponse</returns>
        public async System.Threading.Tasks.Task<CreateShareResponse> ContentmanagementSharesPostAsync (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> localVarResponse = await ContentmanagementSharesPostAsyncWithHttpInfo(body);
=======
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of Share</returns>
        public async System.Threading.Tasks.Task<Share> GetSharesShareIdAsync (string shareId, string expand = null)
        {
             ApiResponse<Share> localVarResponse = await GetSharesShareIdAsyncWithHttpInfo(shareId, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> ContentmanagementSharesPostAsyncWithHttpInfo (CreateShareRequest body = null)
        {

            var localVarPath = "/api/v1/contentmanagement/shares";
=======
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Share>> GetSharesShareIdAsyncWithHttpInfo (string shareId, string expand = null)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->GetSharesShareId");

            var localVarPath = "/api/v2/contentmanagement/shares/{shareId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateShareResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateShareResponse)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSharesShareId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSharesShareId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Share>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Share)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatusEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatusEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementSharesShareidDeleteAsync (string shareId)
        {
             await ContentmanagementSharesShareidDeleteAsyncWithHttpInfo(shareId);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> GetStatusAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/contentmanagement/status";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatusEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatusEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Share</returns>
        public Share ContentmanagementSharesShareidGet (string shareId, string expand = null)
        {
             ApiResponse<Share> localVarResponse = ContentmanagementSharesShareidGetWithHttpInfo(shareId, expand);
=======
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        public CommandStatus GetStatusStatusId (string statusId)
        {
             ApiResponse<CommandStatus> localVarResponse = GetStatusStatusIdWithHttpInfo(statusId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Share>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Share)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetStatusStatusId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatus)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields (optional)</param>
        /// <returns>Task of Share</returns>
        public async System.Threading.Tasks.Task<Share> ContentmanagementSharesShareidGetAsync (string shareId, string expand = null)
        {
             ApiResponse<Share> localVarResponse = await ContentmanagementSharesShareidGetAsyncWithHttpInfo(shareId, expand);
=======
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        public async System.Threading.Tasks.Task<CommandStatus> GetStatusStatusIdAsync (string statusId)
        {
             ApiResponse<CommandStatus> localVarResponse = await GetStatusStatusIdAsyncWithHttpInfo(statusId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (shareId != null) localVarPathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementSharesShareidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Share>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Share)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetStatusStatusId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStatusStatusId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatus)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
<<<<<<< HEAD
        /// <returns>CommandStatusEntityListing</returns>
        public CommandStatusEntityListing ContentmanagementStatusGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> localVarResponse = ContentmanagementStatusGetWithHttpInfo(pageSize, pageNumber);
=======
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>WorkspaceEntityListing</returns>
        public WorkspaceEntityListing GetWorkspaces (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> localVarResponse = GetWorkspacesWithHttpInfo(pageSize, pageNumber, access, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
<<<<<<< HEAD
        /// <returns>ApiResponse of CommandStatusEntityListing</returns>
        public ApiResponse< CommandStatusEntityListing > ContentmanagementStatusGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/contentmanagement/status";
=======
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceEntityListing</returns>
        public ApiResponse< WorkspaceEntityListing > GetWorkspacesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {

            var localVarPath = "/api/v2/contentmanagement/workspaces";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (access != null) localVarQueryParams.Add("access", Configuration.ApiClient.ParameterToString(access)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatusEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatusEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
<<<<<<< HEAD
        /// <returns>Task of CommandStatusEntityListing</returns>
        public async System.Threading.Tasks.Task<CommandStatusEntityListing> ContentmanagementStatusGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> localVarResponse = await ContentmanagementStatusGetAsyncWithHttpInfo(pageSize, pageNumber);
=======
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of WorkspaceEntityListing</returns>
        public async System.Threading.Tasks.Task<WorkspaceEntityListing> GetWorkspacesAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> localVarResponse = await GetWorkspacesAsyncWithHttpInfo(pageSize, pageNumber, access, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> ContentmanagementStatusGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/contentmanagement/status";
=======
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> GetWorkspacesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {

            var localVarPath = "/api/v2/contentmanagement/workspaces";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (access != null) localVarQueryParams.Add("access", Configuration.ApiClient.ParameterToString(access)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatusEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatusEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace GetWorkspacesWorkspaceId (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> localVarResponse = GetWorkspacesWorkspaceIdWithHttpInfo(workspaceId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > GetWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Cancel the command for this status 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementStatusStatusidDeleteAsync (string statusId)
        {
             await ContentmanagementStatusStatusidDeleteAsyncWithHttpInfo(statusId);
=======
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> GetWorkspacesWorkspaceIdAsync (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> localVarResponse = await GetWorkspacesWorkspaceIdAsyncWithHttpInfo(workspaceId, expand);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> GetWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        public CommandStatus ContentmanagementStatusStatusidGet (string statusId)
        {
             ApiResponse<CommandStatus> localVarResponse = ContentmanagementStatusStatusidGetWithHttpInfo(statusId);
=======
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>WorkspaceMemberEntityListing</returns>
        public WorkspaceMemberEntityListing GetWorkspacesWorkspaceIdMembers (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> localVarResponse = GetWorkspacesWorkspaceIdMembersWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceMemberEntityListing</returns>
        public ApiResponse< WorkspaceMemberEntityListing > GetWorkspacesWorkspaceIdMembersWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembers");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatus)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMemberEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        public async System.Threading.Tasks.Task<CommandStatus> ContentmanagementStatusStatusidGetAsync (string statusId)
        {
             ApiResponse<CommandStatus> localVarResponse = await ContentmanagementStatusStatusidGetAsyncWithHttpInfo(statusId);
=======
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of WorkspaceMemberEntityListing</returns>
        public async System.Threading.Tasks.Task<WorkspaceMemberEntityListing> GetWorkspacesWorkspaceIdMembersAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> localVarResponse = await GetWorkspacesWorkspaceIdMembersAsyncWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a list workspace members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMemberEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> GetWorkspacesWorkspaceIdMembersAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembers");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (statusId != null) localVarPathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementStatusStatusidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CommandStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommandStatus)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMemberEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>WorkspaceEntityListing</returns>
        public WorkspaceEntityListing ContentmanagementWorkspacesGet (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> localVarResponse = ContentmanagementWorkspacesGetWithHttpInfo(pageSize, pageNumber, access, expand);
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember GetWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = GetWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo(workspaceId, memberId, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceEntityListing</returns>
        public ApiResponse< WorkspaceEntityListing > ContentmanagementWorkspacesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {

            var localVarPath = "/api/v1/contentmanagement/workspaces";
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > GetWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembersMemberId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (access != null) localVarQueryParams.Add("access", Configuration.ApiClient.ParameterToString(access)); // query parameter
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="access">Requested access level (optional, default to document:viewmetadata)</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of WorkspaceEntityListing</returns>
        public async System.Threading.Tasks.Task<WorkspaceEntityListing> ContentmanagementWorkspacesGetAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> localVarResponse = await ContentmanagementWorkspacesGetAsyncWithHttpInfo(pageSize, pageNumber, access, expand);
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> GetWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = await GetWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo(workspaceId, memberId, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> GetWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, string expand = null)
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace ContentmanagementWorkspacesPost (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> localVarResponse = ContentmanagementWorkspacesPostWithHttpInfo(body);
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        public TagValueEntityListing GetWorkspacesWorkspaceIdTagvalues (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = GetWorkspacesWorkspaceIdTagvaluesWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > ContentmanagementWorkspacesPostWithHttpInfo (WorkspaceCreate body = null)
        {

            var localVarPath = "/api/v1/contentmanagement/workspaces";
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        public ApiResponse< TagValueEntityListing > GetWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvalues");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesPostAsync (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> localVarResponse = await ContentmanagementWorkspacesPostAsyncWithHttpInfo(body);
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        public async System.Threading.Tasks.Task<TagValueEntityListing> GetWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = await GetWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesPostAsyncWithHttpInfo (WorkspaceCreate body = null)
        {

            var localVarPath = "/api/v1/contentmanagement/workspaces";
=======
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> GetWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvalues");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValue</returns>
        public TagValue GetWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, string expand = null)
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
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > GetWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (moveChildrenToWorkspaceId != null) localVarQueryParams.Add("moveChildrenToWorkspaceId", Configuration.ApiClient.ParameterToString(moveChildrenToWorkspaceId)); // query parameter
=======
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace. (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidDeleteAsync (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             await ContentmanagementWorkspacesWorkspaceidDeleteAsyncWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);
=======
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> GetWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, string expand = null)
        {
             ApiResponse<TagValue> localVarResponse = await GetWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo(workspaceId, tagId, expand);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> GetWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (moveChildrenToWorkspaceId != null) localVarQueryParams.Add("moveChildrenToWorkspaceId", Configuration.ApiClient.ParameterToString(moveChildrenToWorkspaceId)); // query parameter
=======
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace ContentmanagementWorkspacesWorkspaceidGet (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> localVarResponse = ContentmanagementWorkspacesWorkspaceidGetWithHttpInfo(workspaceId, expand);
=======
        /// Query audits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        public QueryResults PostAuditquery (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> localVarResponse = PostAuditqueryWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostAuditquery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditquery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a workspace. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidGetAsync (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> localVarResponse = await ContentmanagementWorkspacesWorkspaceidGetAsyncWithHttpInfo(workspaceId, expand);
=======
        /// Query audits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> PostAuditqueryAsync (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> localVarResponse = await PostAuditqueryAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostAuditquery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuditquery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Document</returns>
        public Document PostDocuments (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = PostDocumentsWithHttpInfo(body, copySource, moveSource, _override);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > PostDocumentsWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {

            var localVarPath = "/api/v2/contentmanagement/documents";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMemberEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> PostDocumentsAsync (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = await PostDocumentsAsyncWithHttpInfo(body, copySource, moveSource, _override);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Add a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Document (optional)</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source. (optional)</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source. (optional)</param>
        /// <param name="_override">Override any lock on the source document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsAsyncWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {

            var localVarPath = "/api/v2/contentmanagement/documents";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMemberEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostDocuments: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocuments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Document</returns>
        public Document PostDocumentsDocumentId (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = PostDocumentsDocumentIdWithHttpInfo(documentId, body, expand, _override);
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
        public ApiResponse< Document > PostDocumentsDocumentIdWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a member from a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsync (string workspaceId, string memberId)
        {
             await ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsyncWithHttpInfo(workspaceId, memberId);
=======
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> PostDocumentsDocumentIdAsync (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> localVarResponse = await PostDocumentsDocumentIdAsyncWithHttpInfo(documentId, body, expand, _override);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Update a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document (optional)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsDocumentIdAsyncWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentId");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Document>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Document)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidGet (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = ContentmanagementWorkspacesWorkspaceidMembersMemberidGetWithHttpInfo(workspaceId, memberId, expand);
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ReplaceResponse</returns>
        public ReplaceResponse PostDocumentsDocumentIdContent (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> localVarResponse = PostDocumentsDocumentIdContentWithHttpInfo(documentId, body, _override);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>ApiResponse of ReplaceResponse</returns>
        public ApiResponse< ReplaceResponse > PostDocumentsDocumentIdContentWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/content";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplaceResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsync (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = await ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsyncWithHttpInfo(workspaceId, memberId, expand);
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ReplaceResponse</returns>
        public async System.Threading.Tasks.Task<ReplaceResponse> PostDocumentsDocumentIdContentAsync (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> localVarResponse = await PostDocumentsDocumentIdContentAsyncWithHttpInfo(documentId, body, _override);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request (optional)</param>
        /// <param name="_override">Override any lock on the document (optional)</param>
        /// <returns>Task of ApiResponse (ReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> PostDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentIdContent");

            var localVarPath = "/api/v2/contentmanagement/documents/{documentId}/content";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentIdContent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDocumentsDocumentIdContent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplaceResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidPut (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = ContentmanagementWorkspacesWorkspaceidMembersMemberidPutWithHttpInfo(workspaceId, memberId, body);
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>QueryResults</returns>
        public QueryResults PostQuery (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = PostQueryWithHttpInfo(body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > PostQueryWithHttpInfo (QueryRequest body, string expand = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostQuery");

            var localVarPath = "/api/v2/contentmanagement/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
=======
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsync (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = await ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsyncWithHttpInfo(workspaceId, memberId, body);
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> PostQueryAsync (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> localVarResponse = await PostQueryAsyncWithHttpInfo(body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostQueryAsyncWithHttpInfo (QueryRequest body, string expand = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostQuery");

            var localVarPath = "/api/v2/contentmanagement/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
=======
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryResults)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace ContentmanagementWorkspacesWorkspaceidPut (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> localVarResponse = ContentmanagementWorkspacesWorkspaceidPutWithHttpInfo(workspaceId, body);
=======
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>CreateShareResponse</returns>
        public CreateShareResponse PostShares (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> localVarResponse = PostSharesWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>ApiResponse of CreateShareResponse</returns>
        public ApiResponse< CreateShareResponse > PostSharesWithHttpInfo (CreateShareRequest body = null)
        {

            var localVarPath = "/api/v2/contentmanagement/shares";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostShares: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostShares: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateShareResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateShareResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidPutAsync (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> localVarResponse = await ContentmanagementWorkspacesWorkspaceidPutAsyncWithHttpInfo(workspaceId, body);
=======
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of CreateShareResponse</returns>
        public async System.Threading.Tasks.Task<CreateShareResponse> PostSharesAsync (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> localVarResponse = await PostSharesAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required (optional)</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> PostSharesAsyncWithHttpInfo (CreateShareRequest body = null)
        {

            var localVarPath = "/api/v2/contentmanagement/shares";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostShares: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostShares: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateShareResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateShareResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>TagValueEntityListing</returns>
        public TagValueEntityListing ContentmanagementWorkspacesWorkspaceidTagvaluesGet (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = ContentmanagementWorkspacesWorkspaceidTagvaluesGetWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace PostWorkspaces (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> localVarResponse = PostWorkspacesWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > PostWorkspacesWithHttpInfo (WorkspaceCreate body = null)
        {

            var localVarPath = "/api/v2/contentmanagement/workspaces";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand some document fields (optional)</param>
        /// <returns>Task of TagValueEntityListing</returns>
        public async System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> localVarResponse = await ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsyncWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> PostWorkspacesAsync (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> localVarResponse = await PostWorkspacesAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> PostWorkspacesAsyncWithHttpInfo (WorkspaceCreate body = null)
        {

            var localVarPath = "/api/v2/contentmanagement/workspaces";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (workspaceId != null) localVarPathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>TagValue</returns>
        public TagValue PostWorkspacesWorkspaceIdTagvalues (string workspaceId, TagValue body = null)
        {
<<<<<<< HEAD
             ApiResponse<TagValue> localVarResponse = ContentmanagementWorkspacesWorkspaceidTagvaluesPostWithHttpInfo(workspaceId, body);
=======
             ApiResponse<TagValue> localVarResponse = PostWorkspacesWorkspaceIdTagvaluesWithHttpInfo(workspaceId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > PostWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesPost");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
=======
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvalues");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
        public async System.Threading.Tasks.Task<TagValue> PostWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, TagValue body = null)
        {
<<<<<<< HEAD
             ApiResponse<TagValue> localVarResponse = await ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsyncWithHttpInfo(workspaceId, body);
=======
             ApiResponse<TagValue> localVarResponse = await PostWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo(workspaceId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag (optional)</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> PostWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesPost");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
=======
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvalues");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
        public TagValueEntityListing PostWorkspacesWorkspaceIdTagvaluesQuery (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
<<<<<<< HEAD
             ApiResponse<TagValueEntityListing> localVarResponse = ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostWithHttpInfo(workspaceId, body, expand);
=======
             ApiResponse<TagValueEntityListing> localVarResponse = PostWorkspacesWorkspaceIdTagvaluesQueryWithHttpInfo(workspaceId, body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        public ApiResponse< TagValueEntityListing > PostWorkspacesWorkspaceIdTagvaluesQueryWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
=======
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvaluesQuery");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
        public async System.Threading.Tasks.Task<TagValueEntityListing> PostWorkspacesWorkspaceIdTagvaluesQueryAsync (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
<<<<<<< HEAD
             ApiResponse<TagValueEntityListing> localVarResponse = await ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsyncWithHttpInfo(workspaceId, body, expand);
=======
             ApiResponse<TagValueEntityListing> localVarResponse = await PostWorkspacesWorkspaceIdTagvaluesQueryAsyncWithHttpInfo(workspaceId, body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> PostWorkspacesWorkspaceIdTagvaluesQueryAsyncWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
=======
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvaluesQuery");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<TagValueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValueEntityListing)));
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Workspace</returns>
        public Workspace PutWorkspacesWorkspaceId (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> localVarResponse = PutWorkspacesWorkspaceIdWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > PutWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, Workspace body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteAsync (string workspaceId, string tagId)
        {
             await ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteAsyncWithHttpInfo(workspaceId, tagId);
=======
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> PutWorkspacesWorkspaceIdAsync (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> localVarResponse = await PutWorkspacesWorkspaceIdAsyncWithHttpInfo(workspaceId, body);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Update a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> PutWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, Workspace body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Workspace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Workspace)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember PutWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = PutWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo(workspaceId, memberId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > PutWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> PutWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> localVarResponse = await PutWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo(workspaceId, memberId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Add a member to a workspace 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> PutWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (tagId != null) localVarPathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkspaceMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace (optional)</param>
        /// <returns>TagValue</returns>
<<<<<<< HEAD
        public TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> localVarResponse = ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutWithHttpInfo(workspaceId, tagId, body);
=======
        public TagValue PutWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> localVarResponse = PutWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo(workspaceId, tagId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        public ApiResponse< TagValue > ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
=======
        public ApiResponse< TagValue > PutWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsync (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> localVarResponse = await ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsyncWithHttpInfo(workspaceId, tagId, body);
=======
        public async System.Threading.Tasks.Task<TagValue> PutWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> localVarResponse = await PutWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo(workspaceId, tagId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");

            var localVarPath = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
=======
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> PutWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");

            var localVarPath = "/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<TagValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagValue)));
            
        }

    }
}
