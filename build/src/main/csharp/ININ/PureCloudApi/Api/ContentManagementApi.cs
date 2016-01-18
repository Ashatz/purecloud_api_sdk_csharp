using System;
using System.IO;
using System.Collections.Generic;
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
        
        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        QueryResults ContentmanagementAuditqueryPost (ContentQueryRequest body);
  
        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> ContentmanagementAuditqueryPostWithHttpInfo (ContentQueryRequest body);

        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> ContentmanagementAuditqueryPostAsync (ContentQueryRequest body);

        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementAuditqueryPostAsyncWithHttpInfo (ContentQueryRequest body);
        
        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>DocumentEntityListing</returns>
        DocumentEntityListing ContentmanagementDocumentsGet (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>ApiResponse of DocumentEntityListing</returns>
        ApiResponse<DocumentEntityListing> ContentmanagementDocumentsGetWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of DocumentEntityListing</returns>
        System.Threading.Tasks.Task<DocumentEntityListing> ContentmanagementDocumentsGetAsync (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of ApiResponse (DocumentEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> ContentmanagementDocumentsGetAsyncWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source.</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source.</param>
        /// <param name="_override">Override any lock on the source document</param>
        /// <returns>Document</returns>
        Document ContentmanagementDocumentsPost (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
  
        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source.</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source.</param>
        /// <param name="_override">Override any lock on the source document</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> ContentmanagementDocumentsPostWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source.</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source.</param>
        /// <param name="_override">Override any lock on the source document</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> ContentmanagementDocumentsPostAsync (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

        /// <summary>
        /// Add a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source.</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source.</param>
        /// <param name="_override">Override any lock on the source document</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsPostAsyncWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
        
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Document</returns>
        Document ContentmanagementDocumentsDocumentidGet (string documentId, string expand = null);
  
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> ContentmanagementDocumentsDocumentidGetWithHttpInfo (string documentId, string expand = null);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidGetAsync (string documentId, string expand = null);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidGetAsyncWithHttpInfo (string documentId, string expand = null);
        
        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Document</returns>
        Document ContentmanagementDocumentsDocumentidPost (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
  
        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> ContentmanagementDocumentsDocumentidPostWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);

        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidPostAsync (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);

        /// <summary>
        /// Update a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidPostAsyncWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
        
        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns></returns>
        void ContentmanagementDocumentsDocumentidDelete (string documentId, bool? _override = null);
  
        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementDocumentsDocumentidDeleteWithHttpInfo (string documentId, bool? _override = null);

        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidDeleteAsync (string documentId, bool? _override = null);

        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidDeleteAsyncWithHttpInfo (string documentId, bool? _override = null);
        
        /// <summary>
        /// Get a list of audits for a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="transactionFilter">Transaction filter</param>
        /// <param name="level">level</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>DocumentAuditEntityListing</returns>
        DocumentAuditEntityListing ContentmanagementDocumentsDocumentidAuditsGet (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a list of audits for a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="transactionFilter">Transaction filter</param>
        /// <param name="level">level</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of DocumentAuditEntityListing</returns>
        ApiResponse<DocumentAuditEntityListing> ContentmanagementDocumentsDocumentidAuditsGetWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of audits for a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="transactionFilter">Transaction filter</param>
        /// <param name="level">level</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of DocumentAuditEntityListing</returns>
        System.Threading.Tasks.Task<DocumentAuditEntityListing> ContentmanagementDocumentsDocumentidAuditsGetAsync (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of audits for a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="transactionFilter">Transaction filter</param>
        /// <param name="level">level</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (DocumentAuditEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentAuditEntityListing>> ContentmanagementDocumentsDocumentidAuditsGetAsyncWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <returns></returns>
        void ContentmanagementDocumentsDocumentidContentGet (string documentId, string disposition = null);
  
        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementDocumentsDocumentidContentGetWithHttpInfo (string documentId, string disposition = null);

        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidContentGetAsync (string documentId, string disposition = null);

        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidContentGetAsyncWithHttpInfo (string documentId, string disposition = null);
        
        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>ReplaceResponse</returns>
        ReplaceResponse ContentmanagementDocumentsDocumentidContentPost (string documentId, ReplaceRequest body = null, bool? _override = null);
  
        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>ApiResponse of ReplaceResponse</returns>
        ApiResponse<ReplaceResponse> ContentmanagementDocumentsDocumentidContentPostWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);

        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ReplaceResponse</returns>
        System.Threading.Tasks.Task<ReplaceResponse> ContentmanagementDocumentsDocumentidContentPostAsync (string documentId, ReplaceRequest body = null, bool? _override = null);

        /// <summary>
        /// Replace the contents of a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ApiResponse (ReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> ContentmanagementDocumentsDocumentidContentPostAsyncWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);
        
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>QueryResults</returns>
        QueryResults ContentmanagementQueryGet (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
  
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> ContentmanagementQueryGetWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> ContentmanagementQueryGetAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementQueryGetAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
        
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>QueryResults</returns>
        QueryResults ContentmanagementQueryPost (QueryRequest body, string expand = null);
  
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> ContentmanagementQueryPostWithHttpInfo (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> ContentmanagementQueryPostAsync (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementQueryPostAsyncWithHttpInfo (QueryRequest body, string expand = null);
        
        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>SecurityProfileEntityListing</returns>
        SecurityProfileEntityListing ContentmanagementSecurityprofilesGet ();
  
        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        ApiResponse<SecurityProfileEntityListing> ContentmanagementSecurityprofilesGetWithHttpInfo ();

        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of SecurityProfileEntityListing</returns>
        System.Threading.Tasks.Task<SecurityProfileEntityListing> ContentmanagementSecurityprofilesGetAsync ();

        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> ContentmanagementSecurityprofilesGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>SecurityProfile</returns>
        SecurityProfile ContentmanagementSecurityprofilesSecurityprofileidGet (string securityProfileId);
  
        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>ApiResponse of SecurityProfile</returns>
        ApiResponse<SecurityProfile> ContentmanagementSecurityprofilesSecurityprofileidGetWithHttpInfo (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of SecurityProfile</returns>
        System.Threading.Tasks.Task<SecurityProfile> ContentmanagementSecurityprofilesSecurityprofileidGetAsync (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of ApiResponse (SecurityProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfile>> ContentmanagementSecurityprofilesSecurityprofileidGetAsyncWithHttpInfo (string securityProfileId);
        
        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns></returns>
        void ContentmanagementSharedSharedidGet (string sharedId, bool? redirect = null, string disposition = null, string expand = null);
  
        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementSharedSharedidGetWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string expand = null);

        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementSharedSharedidGetAsync (string sharedId, bool? redirect = null, string disposition = null, string expand = null);

        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementSharedSharedidGetAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string expand = null);
        
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter.</param>
        /// <param name="expand">Expand share fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ShareEntityListing</returns>
        ShareEntityListing ContentmanagementSharesGet (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter.</param>
        /// <param name="expand">Expand share fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of ShareEntityListing</returns>
        ApiResponse<ShareEntityListing> ContentmanagementSharesGetWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter.</param>
        /// <param name="expand">Expand share fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ShareEntityListing</returns>
        System.Threading.Tasks.Task<ShareEntityListing> ContentmanagementSharesGetAsync (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId).
        /// </summary>
        /// <remarks>
        /// Failing to specify a filter will return 400.
        /// </remarks>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter.</param>
        /// <param name="expand">Expand share fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (ShareEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> ContentmanagementSharesGetAsyncWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>CreateShareResponse</returns>
        CreateShareResponse ContentmanagementSharesPost (CreateShareRequest body = null);
  
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>ApiResponse of CreateShareResponse</returns>
        ApiResponse<CreateShareResponse> ContentmanagementSharesPostWithHttpInfo (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of CreateShareResponse</returns>
        System.Threading.Tasks.Task<CreateShareResponse> ContentmanagementSharesPostAsync (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> ContentmanagementSharesPostAsyncWithHttpInfo (CreateShareRequest body = null);
        
        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>Share</returns>
        Share ContentmanagementSharesShareidGet (string shareId, string expand = null);
  
        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>ApiResponse of Share</returns>
        ApiResponse<Share> ContentmanagementSharesShareidGetWithHttpInfo (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>Task of Share</returns>
        System.Threading.Tasks.Task<Share> ContentmanagementSharesShareidGetAsync (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        System.Threading.Tasks.Task<ApiResponse<Share>> ContentmanagementSharesShareidGetAsyncWithHttpInfo (string shareId, string expand = null);
        
        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <returns></returns>
        void ContentmanagementSharesShareidDelete (string shareId);
  
        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementSharesShareidDeleteWithHttpInfo (string shareId);

        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementSharesShareidDeleteAsync (string shareId);

        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementSharesShareidDeleteAsyncWithHttpInfo (string shareId);
        
        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>CommandStatusEntityListing</returns>
        CommandStatusEntityListing ContentmanagementStatusGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of CommandStatusEntityListing</returns>
        ApiResponse<CommandStatusEntityListing> ContentmanagementStatusGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of CommandStatusEntityListing</returns>
        System.Threading.Tasks.Task<CommandStatusEntityListing> ContentmanagementStatusGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> ContentmanagementStatusGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        CommandStatus ContentmanagementStatusStatusidGet (string statusId);
  
        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of CommandStatus</returns>
        ApiResponse<CommandStatus> ContentmanagementStatusStatusidGetWithHttpInfo (string statusId);

        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        System.Threading.Tasks.Task<CommandStatus> ContentmanagementStatusStatusidGetAsync (string statusId);

        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatus>> ContentmanagementStatusStatusidGetAsyncWithHttpInfo (string statusId);
        
        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns></returns>
        void ContentmanagementStatusStatusidDelete (string statusId);
  
        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementStatusStatusidDeleteWithHttpInfo (string statusId);

        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementStatusStatusidDeleteAsync (string statusId);

        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementStatusStatusidDeleteAsyncWithHttpInfo (string statusId);
        
        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="access">Requested access level</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>WorkspaceEntityListing</returns>
        WorkspaceEntityListing ContentmanagementWorkspacesGet (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
  
        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="access">Requested access level</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>ApiResponse of WorkspaceEntityListing</returns>
        ApiResponse<WorkspaceEntityListing> ContentmanagementWorkspacesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);

        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="access">Requested access level</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of WorkspaceEntityListing</returns>
        System.Threading.Tasks.Task<WorkspaceEntityListing> ContentmanagementWorkspacesGetAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);

        /// <summary>
        /// Get a list of workspaces.
        /// </summary>
        /// <remarks>
        /// Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="access">Requested access level</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of ApiResponse (WorkspaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> ContentmanagementWorkspacesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
        
        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Workspace</param>
        /// <returns>Workspace</returns>
        Workspace ContentmanagementWorkspacesPost (WorkspaceCreate body = null);
  
        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> ContentmanagementWorkspacesPostWithHttpInfo (WorkspaceCreate body = null);

        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesPostAsync (WorkspaceCreate body = null);

        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesPostAsyncWithHttpInfo (WorkspaceCreate body = null);
        
        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Workspace</returns>
        Workspace ContentmanagementWorkspacesWorkspaceidGet (string workspaceId, string expand = null);
  
        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> ContentmanagementWorkspacesWorkspaceidGetWithHttpInfo (string workspaceId, string expand = null);

        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidGetAsync (string workspaceId, string expand = null);

        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidGetAsyncWithHttpInfo (string workspaceId, string expand = null);
        
        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Workspace</returns>
        Workspace ContentmanagementWorkspacesWorkspaceidPut (string workspaceId, Workspace body = null);
  
        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> ContentmanagementWorkspacesWorkspaceidPutWithHttpInfo (string workspaceId, Workspace body = null);

        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidPutAsync (string workspaceId, Workspace body = null);

        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidPutAsyncWithHttpInfo (string workspaceId, Workspace body = null);
        
        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns></returns>
        void ContentmanagementWorkspacesWorkspaceidDelete (string workspaceId, string moveChildrenToWorkspaceId = null);
  
        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidDeleteWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);

        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidDeleteAsync (string workspaceId, string moveChildrenToWorkspaceId = null);

        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidDeleteAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);
        
        /// <summary>
        /// Get a list workspace members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>WorkspaceMemberEntityListing</returns>
        WorkspaceMemberEntityListing ContentmanagementWorkspacesWorkspaceidMembersGet (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
  
        /// <summary>
        /// Get a list workspace members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>ApiResponse of WorkspaceMemberEntityListing</returns>
        ApiResponse<WorkspaceMemberEntityListing> ContentmanagementWorkspacesWorkspaceidMembersGetWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list workspace members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>Task of WorkspaceMemberEntityListing</returns>
        System.Threading.Tasks.Task<WorkspaceMemberEntityListing> ContentmanagementWorkspacesWorkspaceidMembersGetAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list workspace members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>Task of ApiResponse (WorkspaceMemberEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> ContentmanagementWorkspacesWorkspaceidMembersGetAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
        
        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>WorkspaceMember</returns>
        WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidGet (string workspaceId, string memberId, string expand = null);
  
        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        ApiResponse<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetWithHttpInfo (string workspaceId, string memberId, string expand = null);

        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>Task of WorkspaceMember</returns>
        System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsync (string workspaceId, string memberId, string expand = null);

        /// <summary>
        /// Get a workspace member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsyncWithHttpInfo (string workspaceId, string memberId, string expand = null);
        
        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>WorkspaceMember</returns>
        WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidPut (string workspaceId, string memberId, WorkspaceMember body = null);
  
        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of WorkspaceMember</returns>
        ApiResponse<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);

        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of WorkspaceMember</returns>
        System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsync (string workspaceId, string memberId, WorkspaceMember body = null);

        /// <summary>
        /// Add a member to a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);
        
        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteWithHttpInfo (string workspaceId, string memberId);

        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsyncWithHttpInfo (string workspaceId, string memberId);
        
        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>TagValueEntityListing</returns>
        TagValueEntityListing ContentmanagementWorkspacesWorkspaceidTagvaluesGet (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
  
        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        ApiResponse<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesGetWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of TagValueEntityListing</returns>
        System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get a list of workspace tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
        
        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>TagValue</returns>
        TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesPost (string workspaceId, TagValue body = null);
  
        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesPostWithHttpInfo (string workspaceId, TagValue body = null);

        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsync (string workspaceId, TagValue body = null);

        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsyncWithHttpInfo (string workspaceId, TagValue body = null);
        
        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>TagValueEntityListing</returns>
        TagValueEntityListing ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost (string workspaceId, TagQueryRequest body = null, string expand = null);
  
        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        ApiResponse<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null);

        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of TagValueEntityListing</returns>
        System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsync (string workspaceId, TagQueryRequest body = null, string expand = null);

        /// <summary>
        /// Perform a prefix query on tags in the workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsyncWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null);
        
        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>TagValue</returns>
        TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet (string workspaceId, string tagId, string expand = null);
  
        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetWithHttpInfo (string workspaceId, string tagId, string expand = null);

        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsync (string workspaceId, string tagId, string expand = null);

        /// <summary>
        /// Get a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsyncWithHttpInfo (string workspaceId, string tagId, string expand = null);
        
        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>TagValue</returns>
        TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut (string workspaceId, string tagId, TagValue body = null);
  
        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutWithHttpInfo (string workspaceId, string tagId, TagValue body = null);

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsync (string workspaceId, string tagId, TagValue body = null);

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null);
        
        /// <summary>
        /// Delete workspace tag
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteWithHttpInfo (string workspaceId, string tagId);

        /// <summary>
        /// Delete workspace tag
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteAsyncWithHttpInfo (string workspaceId, string tagId);
        
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
        /// <param name="body">Allows for a filtered query returning facet information</param> 
        /// <returns>QueryResults</returns>
        public QueryResults ContentmanagementAuditqueryPost (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> response = ContentmanagementAuditqueryPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param> 
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > ContentmanagementAuditqueryPostWithHttpInfo (ContentQueryRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ContentmanagementAuditqueryPost");
            
    
            var path_ = "/api/v1/contentmanagement/auditquery";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementAuditqueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementAuditqueryPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(response, typeof(QueryResults)));
            
        }
    
        /// <summary>
        /// Query audits 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> ContentmanagementAuditqueryPostAsync (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> response = await ContentmanagementAuditqueryPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementAuditqueryPostAsyncWithHttpInfo (ContentQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ContentmanagementAuditqueryPost");
            
    
            var path_ = "/api/v1/contentmanagement/auditquery";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementAuditqueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementAuditqueryPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(response, typeof(QueryResults)));
            
        }
        
        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="name">Name</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">name or dateCreated</param> 
        /// <param name="sortOrder">ascending or descending</param> 
        /// <returns>DocumentEntityListing</returns>
        public DocumentEntityListing ContentmanagementDocumentsGet (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> response = ContentmanagementDocumentsGetWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="name">Name</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">name or dateCreated</param> 
        /// <param name="sortOrder">ascending or descending</param> 
        /// <returns>ApiResponse of DocumentEntityListing</returns>
        public ApiResponse< DocumentEntityListing > ContentmanagementDocumentsGetWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementDocumentsGet");
            
    
            var path_ = "/api/v1/contentmanagement/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (workspaceId != null) queryParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DocumentEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DocumentEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of DocumentEntityListing</returns>
        public async System.Threading.Tasks.Task<DocumentEntityListing> ContentmanagementDocumentsGetAsync (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> response = await ContentmanagementDocumentsGetAsyncWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a list of documents. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="name">Name</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <returns>Task of ApiResponse (DocumentEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> ContentmanagementDocumentsGetAsyncWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementDocumentsGet");
            
    
            var path_ = "/api/v1/contentmanagement/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (workspaceId != null) queryParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DocumentEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DocumentEntityListing)));
            
        }
        
        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <param name="body">Document</param> 
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source.</param> 
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source.</param> 
        /// <param name="_override">Override any lock on the source document</param> 
        /// <returns>Document</returns>
        public Document ContentmanagementDocumentsPost (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> response = ContentmanagementDocumentsPostWithHttpInfo(body, copySource, moveSource, _override);
             return response.Data;
        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <param name="body">Document</param> 
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source.</param> 
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source.</param> 
        /// <param name="_override">Override any lock on the source document</param> 
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > ContentmanagementDocumentsPostWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (copySource != null) queryParams.Add("copySource", Configuration.ApiClient.ParameterToString(copySource)); // query parameter
            if (moveSource != null) queryParams.Add("moveSource", Configuration.ApiClient.ParameterToString(moveSource)); // query parameter
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Document>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(response, typeof(Document)));
            
        }
    
        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source.</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source.</param>
        /// <param name="_override">Override any lock on the source document</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> ContentmanagementDocumentsPostAsync (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> response = await ContentmanagementDocumentsPostAsyncWithHttpInfo(body, copySource, moveSource, _override);
             return response.Data;

        }

        /// <summary>
        /// Add a document. 
        /// </summary>
        /// <param name="body">Document</param>
        /// <param name="copySource">Copy a document within a workspace or to a new workspace. Provide a document ID as the copy source.</param>
        /// <param name="moveSource">Move a document to a new workspace. Provide a document ID as the move source.</param>
        /// <param name="_override">Override any lock on the source document</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsPostAsyncWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (copySource != null) queryParams.Add("copySource", Configuration.ApiClient.ParameterToString(copySource)); // query parameter
            if (moveSource != null) queryParams.Add("moveSource", Configuration.ApiClient.ParameterToString(moveSource)); // query parameter
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Document>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(response, typeof(Document)));
            
        }
        
        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>Document</returns>
        public Document ContentmanagementDocumentsDocumentidGet (string documentId, string expand = null)
        {
             ApiResponse<Document> response = ContentmanagementDocumentsDocumentidGetWithHttpInfo(documentId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > ContentmanagementDocumentsDocumentidGetWithHttpInfo (string documentId, string expand = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidGet");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Document>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(response, typeof(Document)));
            
        }
    
        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidGetAsync (string documentId, string expand = null)
        {
             ApiResponse<Document> response = await ContentmanagementDocumentsDocumentidGetAsyncWithHttpInfo(documentId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidGetAsyncWithHttpInfo (string documentId, string expand = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidGet");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Document>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(response, typeof(Document)));
            
        }
        
        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="body">Document</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <param name="_override">Override any lock on the document</param> 
        /// <returns>Document</returns>
        public Document ContentmanagementDocumentsDocumentidPost (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> response = ContentmanagementDocumentsDocumentidPostWithHttpInfo(documentId, body, expand, _override);
             return response.Data;
        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="body">Document</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <param name="_override">Override any lock on the document</param> 
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > ContentmanagementDocumentsDocumentidPostWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidPost");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Document>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(response, typeof(Document)));
            
        }
    
        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of Document</returns>
        public async System.Threading.Tasks.Task<Document> ContentmanagementDocumentsDocumentidPostAsync (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> response = await ContentmanagementDocumentsDocumentidPostAsyncWithHttpInfo(documentId, body, expand, _override);
             return response.Data;

        }

        /// <summary>
        /// Update a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Document</param>
        /// <param name="expand">Expand some document fields</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> ContentmanagementDocumentsDocumentidPostAsyncWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidPost");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Document>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Document) Configuration.ApiClient.Deserialize(response, typeof(Document)));
            
        }
        
        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="_override">Override any lock on the document</param> 
        /// <returns></returns>
        public void ContentmanagementDocumentsDocumentidDelete (string documentId, bool? _override = null)
        {
             ContentmanagementDocumentsDocumentidDeleteWithHttpInfo(documentId, _override);
        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="_override">Override any lock on the document</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementDocumentsDocumentidDeleteWithHttpInfo (string documentId, bool? _override = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidDeleteAsync (string documentId, bool? _override = null)
        {
             await ContentmanagementDocumentsDocumentidDeleteAsyncWithHttpInfo(documentId, _override);

        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidDeleteAsyncWithHttpInfo (string documentId, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a list of audits for a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="transactionFilter">Transaction filter</param> 
        /// <param name="level">level</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>DocumentAuditEntityListing</returns>
        public DocumentAuditEntityListing ContentmanagementDocumentsDocumentidAuditsGet (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentAuditEntityListing> response = ContentmanagementDocumentsDocumentidAuditsGetWithHttpInfo(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a list of audits for a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="transactionFilter">Transaction filter</param> 
        /// <param name="level">level</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of DocumentAuditEntityListing</returns>
        public ApiResponse< DocumentAuditEntityListing > ContentmanagementDocumentsDocumentidAuditsGetWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidAuditsGet");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (transactionFilter != null) queryParams.Add("transactionFilter", Configuration.ApiClient.ParameterToString(transactionFilter)); // query parameter
            if (level != null) queryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DocumentAuditEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DocumentAuditEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of audits for a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="transactionFilter">Transaction filter</param>
        /// <param name="level">level</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of DocumentAuditEntityListing</returns>
        public async System.Threading.Tasks.Task<DocumentAuditEntityListing> ContentmanagementDocumentsDocumentidAuditsGetAsync (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentAuditEntityListing> response = await ContentmanagementDocumentsDocumentidAuditsGetAsyncWithHttpInfo(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a list of audits for a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="transactionFilter">Transaction filter</param>
        /// <param name="level">level</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (DocumentAuditEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentAuditEntityListing>> ContentmanagementDocumentsDocumentidAuditsGetAsyncWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidAuditsGet");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (transactionFilter != null) queryParams.Add("transactionFilter", Configuration.ApiClient.ParameterToString(transactionFilter)); // query parameter
            if (level != null) queryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidAuditsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DocumentAuditEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DocumentAuditEntityListing)));
            
        }
        
        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param> 
        /// <returns></returns>
        public void ContentmanagementDocumentsDocumentidContentGet (string documentId, string disposition = null)
        {
             ContentmanagementDocumentsDocumentidContentGetWithHttpInfo(documentId, disposition);
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementDocumentsDocumentidContentGetWithHttpInfo (string documentId, string disposition = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidContentGet");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/content";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (disposition != null) queryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementDocumentsDocumentidContentGetAsync (string documentId, string disposition = null)
        {
             await ContentmanagementDocumentsDocumentidContentGetAsyncWithHttpInfo(documentId, disposition);

        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementDocumentsDocumentidContentGetAsyncWithHttpInfo (string documentId, string disposition = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidContentGet");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/content";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (disposition != null) queryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidContentGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="body">Replace Request</param> 
        /// <param name="_override">Override any lock on the document</param> 
        /// <returns>ReplaceResponse</returns>
        public ReplaceResponse ContentmanagementDocumentsDocumentidContentPost (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> response = ContentmanagementDocumentsDocumentidContentPostWithHttpInfo(documentId, body, _override);
             return response.Data;
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="body">Replace Request</param> 
        /// <param name="_override">Override any lock on the document</param> 
        /// <returns>ApiResponse of ReplaceResponse</returns>
        public ApiResponse< ReplaceResponse > ContentmanagementDocumentsDocumentidContentPostWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidContentPost");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/content";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ReplaceResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(response, typeof(ReplaceResponse)));
            
        }
    
        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ReplaceResponse</returns>
        public async System.Threading.Tasks.Task<ReplaceResponse> ContentmanagementDocumentsDocumentidContentPostAsync (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> response = await ContentmanagementDocumentsDocumentidContentPostAsyncWithHttpInfo(documentId, body, _override);
             return response.Data;

        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ApiResponse (ReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> ContentmanagementDocumentsDocumentidContentPostAsyncWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentmanagementDocumentsDocumentidContentPost");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/content";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementDocumentsDocumentidContentPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ReplaceResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplaceResponse) Configuration.ApiClient.Deserialize(response, typeof(ReplaceResponse)));
            
        }
        
        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">name or dateCreated</param> 
        /// <param name="sortOrder">ascending or descending</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>QueryResults</returns>
        public QueryResults ContentmanagementQueryGet (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
             ApiResponse<QueryResults> response = ContentmanagementQueryGetWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
             return response.Data;
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">name or dateCreated</param> 
        /// <param name="sortOrder">ascending or descending</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > ContentmanagementQueryGetWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
            
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null) throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling ContentmanagementQueryGet");
            
    
            var path_ = "/api/v1/contentmanagement/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (queryPhrase != null) queryParams.Add("queryPhrase", Configuration.ApiClient.ParameterToString(queryPhrase)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementQueryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementQueryGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(response, typeof(QueryResults)));
            
        }
    
        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> ContentmanagementQueryGetAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
             ApiResponse<QueryResults> response = await ContentmanagementQueryGetAsyncWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
             return response.Data;

        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="queryPhrase">Phrase tokens are ANDed together over all searchable fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">name or dateCreated</param>
        /// <param name="sortOrder">ascending or descending</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementQueryGetAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null) throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling ContentmanagementQueryGet");
            
    
            var path_ = "/api/v1/contentmanagement/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (queryPhrase != null) queryParams.Add("queryPhrase", Configuration.ApiClient.ParameterToString(queryPhrase)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementQueryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementQueryGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(response, typeof(QueryResults)));
            
        }
        
        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>QueryResults</returns>
        public QueryResults ContentmanagementQueryPost (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> response = ContentmanagementQueryPostWithHttpInfo(body, expand);
             return response.Data;
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > ContentmanagementQueryPostWithHttpInfo (QueryRequest body, string expand = null)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ContentmanagementQueryPost");
            
    
            var path_ = "/api/v1/contentmanagement/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementQueryPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(response, typeof(QueryResults)));
            
        }
    
        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> ContentmanagementQueryPostAsync (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> response = await ContentmanagementQueryPostAsyncWithHttpInfo(body, expand);
             return response.Data;

        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> ContentmanagementQueryPostAsyncWithHttpInfo (QueryRequest body, string expand = null)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ContentmanagementQueryPost");
            
    
            var path_ = "/api/v1/contentmanagement/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementQueryPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(response, typeof(QueryResults)));
            
        }
        
        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <returns>SecurityProfileEntityListing</returns>
        public SecurityProfileEntityListing ContentmanagementSecurityprofilesGet ()
        {
             ApiResponse<SecurityProfileEntityListing> response = ContentmanagementSecurityprofilesGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        public ApiResponse< SecurityProfileEntityListing > ContentmanagementSecurityprofilesGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/contentmanagement/securityprofiles";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSecurityprofilesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSecurityprofilesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SecurityProfileEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfileEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SecurityProfileEntityListing)));
            
        }
    
        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <returns>Task of SecurityProfileEntityListing</returns>
        public async System.Threading.Tasks.Task<SecurityProfileEntityListing> ContentmanagementSecurityprofilesGetAsync ()
        {
             ApiResponse<SecurityProfileEntityListing> response = await ContentmanagementSecurityprofilesGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> ContentmanagementSecurityprofilesGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/contentmanagement/securityprofiles";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSecurityprofilesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSecurityprofilesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SecurityProfileEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfileEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SecurityProfileEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <param name="securityProfileId">Security Profile Id</param> 
        /// <returns>SecurityProfile</returns>
        public SecurityProfile ContentmanagementSecurityprofilesSecurityprofileidGet (string securityProfileId)
        {
             ApiResponse<SecurityProfile> response = ContentmanagementSecurityprofilesSecurityprofileidGetWithHttpInfo(securityProfileId);
             return response.Data;
        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <param name="securityProfileId">Security Profile Id</param> 
        /// <returns>ApiResponse of SecurityProfile</returns>
        public ApiResponse< SecurityProfile > ContentmanagementSecurityprofilesSecurityprofileidGetWithHttpInfo (string securityProfileId)
        {
            
            // verify the required parameter 'securityProfileId' is set
            if (securityProfileId == null) throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentmanagementSecurityprofilesSecurityprofileidGet");
            
    
            var path_ = "/api/v1/contentmanagement/securityprofiles/{securityProfileId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (securityProfileId != null) pathParams.Add("securityProfileId", Configuration.ApiClient.ParameterToString(securityProfileId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SecurityProfile>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfile) Configuration.ApiClient.Deserialize(response, typeof(SecurityProfile)));
            
        }
    
        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of SecurityProfile</returns>
        public async System.Threading.Tasks.Task<SecurityProfile> ContentmanagementSecurityprofilesSecurityprofileidGetAsync (string securityProfileId)
        {
             ApiResponse<SecurityProfile> response = await ContentmanagementSecurityprofilesSecurityprofileidGetAsyncWithHttpInfo(securityProfileId);
             return response.Data;

        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of ApiResponse (SecurityProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityProfile>> ContentmanagementSecurityprofilesSecurityprofileidGetAsyncWithHttpInfo (string securityProfileId)
        {
            // verify the required parameter 'securityProfileId' is set
            if (securityProfileId == null) throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentmanagementSecurityprofilesSecurityprofileidGet");
            
    
            var path_ = "/api/v1/contentmanagement/securityprofiles/{securityProfileId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (securityProfileId != null) pathParams.Add("securityProfileId", Configuration.ApiClient.ParameterToString(securityProfileId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSecurityprofilesSecurityprofileidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SecurityProfile>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfile) Configuration.ApiClient.Deserialize(response, typeof(SecurityProfile)));
            
        }
        
        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <param name="sharedId">Shared ID</param> 
        /// <param name="redirect">Turn on or off redirect</param> 
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns></returns>
        public void ContentmanagementSharedSharedidGet (string sharedId, bool? redirect = null, string disposition = null, string expand = null)
        {
             ContentmanagementSharedSharedidGetWithHttpInfo(sharedId, redirect, disposition, expand);
        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <param name="sharedId">Shared ID</param> 
        /// <param name="redirect">Turn on or off redirect</param> 
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementSharedSharedidGetWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string expand = null)
        {
            
            // verify the required parameter 'sharedId' is set
            if (sharedId == null) throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentmanagementSharedSharedidGet");
            
    
            var path_ = "/api/v1/contentmanagement/shared/{sharedId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (sharedId != null) pathParams.Add("sharedId", Configuration.ApiClient.ParameterToString(sharedId)); // path parameter
            
            if (redirect != null) queryParams.Add("redirect", Configuration.ApiClient.ParameterToString(redirect)); // query parameter
            if (disposition != null) queryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharedSharedidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharedSharedidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementSharedSharedidGetAsync (string sharedId, bool? redirect = null, string disposition = null, string expand = null)
        {
             await ContentmanagementSharedSharedidGetAsyncWithHttpInfo(sharedId, redirect, disposition, expand);

        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementSharedSharedidGetAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string expand = null)
        {
            // verify the required parameter 'sharedId' is set
            if (sharedId == null) throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentmanagementSharedSharedidGet");
            
    
            var path_ = "/api/v1/contentmanagement/shared/{sharedId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (sharedId != null) pathParams.Add("sharedId", Configuration.ApiClient.ParameterToString(sharedId)); // path parameter
            
            if (redirect != null) queryParams.Add("redirect", Configuration.ApiClient.ParameterToString(redirect)); // query parameter
            if (disposition != null) queryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharedSharedidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharedSharedidGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter.</param> 
        /// <param name="expand">Expand share fields</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ShareEntityListing</returns>
        public ShareEntityListing ContentmanagementSharesGet (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ShareEntityListing> response = ContentmanagementSharesGetWithHttpInfo(entityId, expand, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter.</param> 
        /// <param name="expand">Expand share fields</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of ShareEntityListing</returns>
        public ApiResponse< ShareEntityListing > ContentmanagementSharesGetWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/shares";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (entityId != null) queryParams.Add("entityId", Configuration.ApiClient.ParameterToString(entityId)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ShareEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShareEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ShareEntityListing)));
            
        }
    
        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter.</param>
        /// <param name="expand">Expand share fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ShareEntityListing</returns>
        public async System.Threading.Tasks.Task<ShareEntityListing> ContentmanagementSharesGetAsync (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ShareEntityListing> response = await ContentmanagementSharesGetAsyncWithHttpInfo(entityId, expand, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of shares.  You must specify at least one filter (e.g. entityId). Failing to specify a filter will return 400.
        /// </summary>
        /// <param name="entityId">Filters the shares returned to only the entity specified by the value of this parameter.</param>
        /// <param name="expand">Expand share fields</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (ShareEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> ContentmanagementSharesGetAsyncWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/shares";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (entityId != null) queryParams.Add("entityId", Configuration.ApiClient.ParameterToString(entityId)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ShareEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShareEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ShareEntityListing)));
            
        }
        
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param> 
        /// <returns>CreateShareResponse</returns>
        public CreateShareResponse ContentmanagementSharesPost (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> response = ContentmanagementSharesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param> 
        /// <returns>ApiResponse of CreateShareResponse</returns>
        public ApiResponse< CreateShareResponse > ContentmanagementSharesPostWithHttpInfo (CreateShareRequest body = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/shares";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CreateShareResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(response, typeof(CreateShareResponse)));
            
        }
    
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of CreateShareResponse</returns>
        public async System.Threading.Tasks.Task<CreateShareResponse> ContentmanagementSharesPostAsync (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> response = await ContentmanagementSharesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> ContentmanagementSharesPostAsyncWithHttpInfo (CreateShareRequest body = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/shares";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CreateShareResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(response, typeof(CreateShareResponse)));
            
        }
        
        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <param name="shareId">Share ID</param> 
        /// <param name="expand">Expand share fields</param> 
        /// <returns>Share</returns>
        public Share ContentmanagementSharesShareidGet (string shareId, string expand = null)
        {
             ApiResponse<Share> response = ContentmanagementSharesShareidGetWithHttpInfo(shareId, expand);
             return response.Data;
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <param name="shareId">Share ID</param> 
        /// <param name="expand">Expand share fields</param> 
        /// <returns>ApiResponse of Share</returns>
        public ApiResponse< Share > ContentmanagementSharesShareidGetWithHttpInfo (string shareId, string expand = null)
        {
            
            // verify the required parameter 'shareId' is set
            if (shareId == null) throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentmanagementSharesShareidGet");
            
    
            var path_ = "/api/v1/contentmanagement/shares/{shareId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (shareId != null) pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesShareidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesShareidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Share>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(response, typeof(Share)));
            
        }
    
        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>Task of Share</returns>
        public async System.Threading.Tasks.Task<Share> ContentmanagementSharesShareidGetAsync (string shareId, string expand = null)
        {
             ApiResponse<Share> response = await ContentmanagementSharesShareidGetAsyncWithHttpInfo(shareId, expand);
             return response.Data;

        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Share>> ContentmanagementSharesShareidGetAsyncWithHttpInfo (string shareId, string expand = null)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null) throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentmanagementSharesShareidGet");
            
    
            var path_ = "/api/v1/contentmanagement/shares/{shareId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (shareId != null) pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesShareidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesShareidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Share>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(response, typeof(Share)));
            
        }
        
        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <param name="shareId">Share ID</param> 
        /// <returns></returns>
        public void ContentmanagementSharesShareidDelete (string shareId)
        {
             ContentmanagementSharesShareidDeleteWithHttpInfo(shareId);
        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <param name="shareId">Share ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementSharesShareidDeleteWithHttpInfo (string shareId)
        {
            
            // verify the required parameter 'shareId' is set
            if (shareId == null) throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentmanagementSharesShareidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/shares/{shareId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (shareId != null) pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesShareidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesShareidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementSharesShareidDeleteAsync (string shareId)
        {
             await ContentmanagementSharesShareidDeleteAsyncWithHttpInfo(shareId);

        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementSharesShareidDeleteAsyncWithHttpInfo (string shareId)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null) throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentmanagementSharesShareidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/shares/{shareId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (shareId != null) pathParams.Add("shareId", Configuration.ApiClient.ParameterToString(shareId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesShareidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementSharesShareidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>CommandStatusEntityListing</returns>
        public CommandStatusEntityListing ContentmanagementStatusGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> response = ContentmanagementStatusGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of CommandStatusEntityListing</returns>
        public ApiResponse< CommandStatusEntityListing > ContentmanagementStatusGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CommandStatusEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CommandStatusEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of CommandStatusEntityListing</returns>
        public async System.Threading.Tasks.Task<CommandStatusEntityListing> ContentmanagementStatusGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> response = await ContentmanagementStatusGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> ContentmanagementStatusGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CommandStatusEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CommandStatusEntityListing)));
            
        }
        
        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <param name="statusId">Status ID</param> 
        /// <returns>CommandStatus</returns>
        public CommandStatus ContentmanagementStatusStatusidGet (string statusId)
        {
             ApiResponse<CommandStatus> response = ContentmanagementStatusStatusidGetWithHttpInfo(statusId);
             return response.Data;
        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <param name="statusId">Status ID</param> 
        /// <returns>ApiResponse of CommandStatus</returns>
        public ApiResponse< CommandStatus > ContentmanagementStatusStatusidGetWithHttpInfo (string statusId)
        {
            
            // verify the required parameter 'statusId' is set
            if (statusId == null) throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentmanagementStatusStatusidGet");
            
    
            var path_ = "/api/v1/contentmanagement/status/{statusId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (statusId != null) pathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusStatusidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusStatusidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CommandStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(response, typeof(CommandStatus)));
            
        }
    
        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        public async System.Threading.Tasks.Task<CommandStatus> ContentmanagementStatusStatusidGetAsync (string statusId)
        {
             ApiResponse<CommandStatus> response = await ContentmanagementStatusStatusidGetAsyncWithHttpInfo(statusId);
             return response.Data;

        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatus>> ContentmanagementStatusStatusidGetAsyncWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null) throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentmanagementStatusStatusidGet");
            
    
            var path_ = "/api/v1/contentmanagement/status/{statusId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (statusId != null) pathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusStatusidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusStatusidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CommandStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(response, typeof(CommandStatus)));
            
        }
        
        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <param name="statusId">Status ID</param> 
        /// <returns></returns>
        public void ContentmanagementStatusStatusidDelete (string statusId)
        {
             ContentmanagementStatusStatusidDeleteWithHttpInfo(statusId);
        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <param name="statusId">Status ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementStatusStatusidDeleteWithHttpInfo (string statusId)
        {
            
            // verify the required parameter 'statusId' is set
            if (statusId == null) throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentmanagementStatusStatusidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/status/{statusId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (statusId != null) pathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusStatusidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusStatusidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementStatusStatusidDeleteAsync (string statusId)
        {
             await ContentmanagementStatusStatusidDeleteAsyncWithHttpInfo(statusId);

        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementStatusStatusidDeleteAsyncWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null) throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentmanagementStatusStatusidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/status/{statusId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (statusId != null) pathParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusStatusidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementStatusStatusidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="access">Requested access level</param> 
        /// <param name="expand">Expand some workspace fields</param> 
        /// <returns>WorkspaceEntityListing</returns>
        public WorkspaceEntityListing ContentmanagementWorkspacesGet (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> response = ContentmanagementWorkspacesGetWithHttpInfo(pageSize, pageNumber, access, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="access">Requested access level</param> 
        /// <param name="expand">Expand some workspace fields</param> 
        /// <returns>ApiResponse of WorkspaceEntityListing</returns>
        public ApiResponse< WorkspaceEntityListing > ContentmanagementWorkspacesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/workspaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (access != null) queryParams.Add("access", Configuration.ApiClient.ParameterToString(access)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WorkspaceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(WorkspaceEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="access">Requested access level</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of WorkspaceEntityListing</returns>
        public async System.Threading.Tasks.Task<WorkspaceEntityListing> ContentmanagementWorkspacesGetAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> response = await ContentmanagementWorkspacesGetAsyncWithHttpInfo(pageSize, pageNumber, access, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a list of workspaces. Specifying &#39;content&#39; access will return all workspaces the user has document access to, while &#39;admin&#39; access will return all group workspaces the user has administrative rights to.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="access">Requested access level</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of ApiResponse (WorkspaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> ContentmanagementWorkspacesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/workspaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (access != null) queryParams.Add("access", Configuration.ApiClient.ParameterToString(access)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WorkspaceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(WorkspaceEntityListing)));
            
        }
        
        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <param name="body">Workspace</param> 
        /// <returns>Workspace</returns>
        public Workspace ContentmanagementWorkspacesPost (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> response = ContentmanagementWorkspacesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <param name="body">Workspace</param> 
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > ContentmanagementWorkspacesPostWithHttpInfo (WorkspaceCreate body = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/workspaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Workspace>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(response, typeof(Workspace)));
            
        }
    
        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesPostAsync (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> response = await ContentmanagementWorkspacesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesPostAsyncWithHttpInfo (WorkspaceCreate body = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/workspaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Workspace>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(response, typeof(Workspace)));
            
        }
        
        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="expand">Expand some workspace fields</param> 
        /// <returns>Workspace</returns>
        public Workspace ContentmanagementWorkspacesWorkspaceidGet (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> response = ContentmanagementWorkspacesWorkspaceidGetWithHttpInfo(workspaceId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="expand">Expand some workspace fields</param> 
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > ContentmanagementWorkspacesWorkspaceidGetWithHttpInfo (string workspaceId, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Workspace>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(response, typeof(Workspace)));
            
        }
    
        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidGetAsync (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> response = await ContentmanagementWorkspacesWorkspaceidGetAsyncWithHttpInfo(workspaceId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidGetAsyncWithHttpInfo (string workspaceId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Workspace>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(response, typeof(Workspace)));
            
        }
        
        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="body">Workspace</param> 
        /// <returns>Workspace</returns>
        public Workspace ContentmanagementWorkspacesWorkspaceidPut (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> response = ContentmanagementWorkspacesWorkspaceidPutWithHttpInfo(workspaceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="body">Workspace</param> 
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > ContentmanagementWorkspacesWorkspaceidPutWithHttpInfo (string workspaceId, Workspace body = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidPut");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Workspace>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(response, typeof(Workspace)));
            
        }
    
        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> ContentmanagementWorkspacesWorkspaceidPutAsync (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> response = await ContentmanagementWorkspacesWorkspaceidPutAsyncWithHttpInfo(workspaceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> ContentmanagementWorkspacesWorkspaceidPutAsyncWithHttpInfo (string workspaceId, Workspace body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidPut");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Workspace>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(response, typeof(Workspace)));
            
        }
        
        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param> 
        /// <returns></returns>
        public void ContentmanagementWorkspacesWorkspaceidDelete (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             ContentmanagementWorkspacesWorkspaceidDeleteWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);
        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidDeleteWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (moveChildrenToWorkspaceId != null) queryParams.Add("moveChildrenToWorkspaceId", Configuration.ApiClient.ParameterToString(moveChildrenToWorkspaceId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ContentmanagementWorkspacesWorkspaceidDeleteAsync (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             await ContentmanagementWorkspacesWorkspaceidDeleteAsyncWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);

        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidDeleteAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (moveChildrenToWorkspaceId != null) queryParams.Add("moveChildrenToWorkspaceId", Configuration.ApiClient.ParameterToString(moveChildrenToWorkspaceId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand workspace member fields</param> 
        /// <returns>WorkspaceMemberEntityListing</returns>
        public WorkspaceMemberEntityListing ContentmanagementWorkspacesWorkspaceidMembersGet (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> response = ContentmanagementWorkspacesWorkspaceidMembersGetWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand workspace member fields</param> 
        /// <returns>ApiResponse of WorkspaceMemberEntityListing</returns>
        public ApiResponse< WorkspaceMemberEntityListing > ContentmanagementWorkspacesWorkspaceidMembersGetWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidMembersGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WorkspaceMemberEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMemberEntityListing) Configuration.ApiClient.Deserialize(response, typeof(WorkspaceMemberEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>Task of WorkspaceMemberEntityListing</returns>
        public async System.Threading.Tasks.Task<WorkspaceMemberEntityListing> ContentmanagementWorkspacesWorkspaceidMembersGetAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> response = await ContentmanagementWorkspacesWorkspaceidMembersGetAsyncWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a list workspace members 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>Task of ApiResponse (WorkspaceMemberEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> ContentmanagementWorkspacesWorkspaceidMembersGetAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidMembersGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WorkspaceMemberEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMemberEntityListing) Configuration.ApiClient.Deserialize(response, typeof(WorkspaceMemberEntityListing)));
            
        }
        
        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="expand">Expand workspace member fields</param> 
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidGet (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> response = ContentmanagementWorkspacesWorkspaceidMembersMemberidGetWithHttpInfo(workspaceId, memberId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="expand">Expand workspace member fields</param> 
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > ContentmanagementWorkspacesWorkspaceidMembersMemberidGetWithHttpInfo (string workspaceId, string memberId, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WorkspaceMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(response, typeof(WorkspaceMember)));
            
        }
    
        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsync (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> response = await ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsyncWithHttpInfo(workspaceId, memberId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidGetAsyncWithHttpInfo (string workspaceId, string memberId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(response, typeof(WorkspaceMember)));
            
        }
        
        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="body">Workspace</param> 
        /// <returns>WorkspaceMember</returns>
        public WorkspaceMember ContentmanagementWorkspacesWorkspaceidMembersMemberidPut (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> response = ContentmanagementWorkspacesWorkspaceidMembersMemberidPutWithHttpInfo(workspaceId, memberId, body);
             return response.Data;
        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="body">Workspace</param> 
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > ContentmanagementWorkspacesWorkspaceidMembersMemberidPutWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WorkspaceMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(response, typeof(WorkspaceMember)));
            
        }
    
        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of WorkspaceMember</returns>
        public async System.Threading.Tasks.Task<WorkspaceMember> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsync (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> response = await ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsyncWithHttpInfo(workspaceId, memberId, body);
             return response.Data;

        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> ContentmanagementWorkspacesWorkspaceidMembersMemberidPutAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WorkspaceMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceMember) Configuration.ApiClient.Deserialize(response, typeof(WorkspaceMember)));
            
        }
        
        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
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
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteWithHttpInfo (string workspaceId, string memberId)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidMembersMemberidDeleteAsyncWithHttpInfo (string workspaceId, string memberId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidMembersMemberidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="value">filter the list of tags returned</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>TagValueEntityListing</returns>
        public TagValueEntityListing ContentmanagementWorkspacesWorkspaceidTagvaluesGet (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> response = ContentmanagementWorkspacesWorkspaceidTagvaluesGetWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="value">filter the list of tags returned</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        public ApiResponse< TagValueEntityListing > ContentmanagementWorkspacesWorkspaceidTagvaluesGetWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (value != null) queryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TagValueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TagValueEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of TagValueEntityListing</returns>
        public async System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> response = await ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsyncWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a list of workspace tags 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="value">filter the list of tags returned</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> ContentmanagementWorkspacesWorkspaceidTagvaluesGetAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (value != null) queryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TagValueEntityListing)));
            
        }
        
        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="body">tag</param> 
        /// <returns>TagValue</returns>
        public TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesPost (string workspaceId, TagValue body = null)
        {
             ApiResponse<TagValue> response = ContentmanagementWorkspacesWorkspaceidTagvaluesPostWithHttpInfo(workspaceId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="body">tag</param> 
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > ContentmanagementWorkspacesWorkspaceidTagvaluesPostWithHttpInfo (string workspaceId, TagValue body = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TagValue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(response, typeof(TagValue)));
            
        }
    
        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsync (string workspaceId, TagValue body = null)
        {
             ApiResponse<TagValue> response = await ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsyncWithHttpInfo(workspaceId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesPostAsyncWithHttpInfo (string workspaceId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TagValue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(response, typeof(TagValue)));
            
        }
        
        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="body">query</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>TagValueEntityListing</returns>
        public TagValueEntityListing ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> response = ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostWithHttpInfo(workspaceId, body, expand);
             return response.Data;
        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="body">query</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        public ApiResponse< TagValueEntityListing > ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TagValueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TagValueEntityListing)));
            
        }
    
        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of TagValueEntityListing</returns>
        public async System.Threading.Tasks.Task<TagValueEntityListing> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsync (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> response = await ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsyncWithHttpInfo(workspaceId, body, expand);
             return response.Data;

        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPostAsyncWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesQueryPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TagValueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TagValueEntityListing)));
            
        }
        
        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="tagId">Tag ID</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>TagValue</returns>
        public TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet (string workspaceId, string tagId, string expand = null)
        {
             ApiResponse<TagValue> response = ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetWithHttpInfo(workspaceId, tagId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="tagId">Tag ID</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetWithHttpInfo (string workspaceId, string tagId, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet");
            
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) pathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TagValue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(response, typeof(TagValue)));
            
        }
    
        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsync (string workspaceId, string tagId, string expand = null)
        {
             ApiResponse<TagValue> response = await ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsyncWithHttpInfo(workspaceId, tagId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGetAsyncWithHttpInfo (string workspaceId, string tagId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) pathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TagValue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(response, typeof(TagValue)));
            
        }
        
        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="tagId">Tag ID</param> 
        /// <param name="body">Workspace</param> 
        /// <returns>TagValue</returns>
        public TagValue ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> response = ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutWithHttpInfo(workspaceId, tagId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="tagId">Tag ID</param> 
        /// <param name="body">Workspace</param> 
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");
            
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) pathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TagValue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(response, typeof(TagValue)));
            
        }
    
        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of TagValue</returns>
        public async System.Threading.Tasks.Task<TagValue> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsync (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> response = await ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsyncWithHttpInfo(workspaceId, tagId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPutAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) pathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TagValue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagValue) Configuration.ApiClient.Deserialize(response, typeof(TagValue)));
            
        }
        
        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
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
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="tagId">Tag ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteWithHttpInfo (string workspaceId, string tagId)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete");
            
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) pathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDeleteAsyncWithHttpInfo (string workspaceId, string tagId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) pathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ContentmanagementWorkspacesWorkspaceidTagvaluesTagidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
