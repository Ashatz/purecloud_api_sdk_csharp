using System;
using System.IO;
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
        
        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>QueryResults</returns>
        QueryResults PostAuditquery (ContentQueryRequest body);
  
        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> PostAuditqueryWithHttpInfo (ContentQueryRequest body);

        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> PostAuditqueryAsync (ContentQueryRequest body);

        /// <summary>
        /// Query audits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostAuditqueryAsyncWithHttpInfo (ContentQueryRequest body);
        
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
        DocumentEntityListing GetDocuments (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<DocumentEntityListing> GetDocumentsWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<DocumentEntityListing> GetDocumentsAsync (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null);
        
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
        Document PostDocuments (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
  
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
        ApiResponse<Document> PostDocumentsWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

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
        System.Threading.Tasks.Task<Document> PostDocumentsAsync (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);

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
        System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsAsyncWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null);
        
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Document</returns>
        Document GetDocumentsDocumentId (string documentId, string expand = null);
  
        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> GetDocumentsDocumentIdWithHttpInfo (string documentId, string expand = null);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of Document</returns>
        System.Threading.Tasks.Task<Document> GetDocumentsDocumentIdAsync (string documentId, string expand = null);

        /// <summary>
        /// Get a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        System.Threading.Tasks.Task<ApiResponse<Document>> GetDocumentsDocumentIdAsyncWithHttpInfo (string documentId, string expand = null);
        
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
        Document PostDocumentsDocumentId (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
  
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
        ApiResponse<Document> PostDocumentsDocumentIdWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);

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
        System.Threading.Tasks.Task<Document> PostDocumentsDocumentIdAsync (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);

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
        System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsDocumentIdAsyncWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null);
        
        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns></returns>
        void DeleteDocumentsDocumentId (string documentId, bool? _override = null);
  
        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteDocumentsDocumentIdWithHttpInfo (string documentId, bool? _override = null);

        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteDocumentsDocumentIdAsync (string documentId, bool? _override = null);

        /// <summary>
        /// Delete a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentsDocumentIdAsyncWithHttpInfo (string documentId, bool? _override = null);
        
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
        DocumentAuditEntityListing GetDocumentsDocumentIdAudits (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<DocumentAuditEntityListing> GetDocumentsDocumentIdAuditsWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<DocumentAuditEntityListing> GetDocumentsDocumentIdAuditsAsync (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<DocumentAuditEntityListing>> GetDocumentsDocumentIdAuditsAsyncWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <returns></returns>
        void GetDocumentsDocumentIdContent (string documentId, string disposition = null, string contentType = null);
  
        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetDocumentsDocumentIdContentWithHttpInfo (string documentId, string disposition = null, string contentType = null);

        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetDocumentsDocumentIdContentAsync (string documentId, string disposition = null, string contentType = null);

        /// <summary>
        /// Download a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, string disposition = null, string contentType = null);
        
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
        ReplaceResponse PostDocumentsDocumentIdContent (string documentId, ReplaceRequest body = null, bool? _override = null);
  
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
        ApiResponse<ReplaceResponse> PostDocumentsDocumentIdContentWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);

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
        System.Threading.Tasks.Task<ReplaceResponse> PostDocumentsDocumentIdContentAsync (string documentId, ReplaceRequest body = null, bool? _override = null);

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
        System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> PostDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null);
        
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
        QueryResults GetQuery (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
  
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
        ApiResponse<QueryResults> GetQueryWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

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
        System.Threading.Tasks.Task<QueryResults> GetQueryAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> GetQueryAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null);
        
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>QueryResults</returns>
        QueryResults PostQuery (QueryRequest body, string expand = null);
  
        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of QueryResults</returns>
        ApiResponse<QueryResults> PostQueryWithHttpInfo (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of QueryResults</returns>
        System.Threading.Tasks.Task<QueryResults> PostQueryAsync (QueryRequest body, string expand = null);

        /// <summary>
        /// Query content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostQueryAsyncWithHttpInfo (QueryRequest body, string expand = null);
        
        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>SecurityProfileEntityListing</returns>
        SecurityProfileEntityListing GetSecurityprofiles ();
  
        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        ApiResponse<SecurityProfileEntityListing> GetSecurityprofilesWithHttpInfo ();

        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of SecurityProfileEntityListing</returns>
        System.Threading.Tasks.Task<SecurityProfileEntityListing> GetSecurityprofilesAsync ();

        /// <summary>
        /// Get a List of Security Profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> GetSecurityprofilesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>SecurityProfile</returns>
        SecurityProfile GetSecurityprofilesSecurityprofileId (string securityProfileId);
  
        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>ApiResponse of SecurityProfile</returns>
        ApiResponse<SecurityProfile> GetSecurityprofilesSecurityprofileIdWithHttpInfo (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of SecurityProfile</returns>
        System.Threading.Tasks.Task<SecurityProfile> GetSecurityprofilesSecurityprofileIdAsync (string securityProfileId);

        /// <summary>
        /// Get a Security Profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of ApiResponse (SecurityProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityProfile>> GetSecurityprofilesSecurityprofileIdAsyncWithHttpInfo (string securityProfileId);
        
        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns></returns>
        void GetSharedSharedId (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);
  
        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetSharedSharedIdWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);

        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetSharedSharedIdAsync (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);

        /// <summary>
        /// Get shared documents. Securely download a shared document.
        /// </summary>
        /// <remarks>
        /// This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </remarks>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetSharedSharedIdAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null);
        
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
        ShareEntityListing GetShares (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<ShareEntityListing> GetSharesWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ShareEntityListing> GetSharesAsync (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> GetSharesAsyncWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>CreateShareResponse</returns>
        CreateShareResponse PostShares (CreateShareRequest body = null);
  
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>ApiResponse of CreateShareResponse</returns>
        ApiResponse<CreateShareResponse> PostSharesWithHttpInfo (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of CreateShareResponse</returns>
        System.Threading.Tasks.Task<CreateShareResponse> PostSharesAsync (CreateShareRequest body = null);

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> PostSharesAsyncWithHttpInfo (CreateShareRequest body = null);
        
        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>Share</returns>
        Share GetSharesShareId (string shareId, string expand = null);
  
        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>ApiResponse of Share</returns>
        ApiResponse<Share> GetSharesShareIdWithHttpInfo (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>Task of Share</returns>
        System.Threading.Tasks.Task<Share> GetSharesShareIdAsync (string shareId, string expand = null);

        /// <summary>
        /// Retrieve details about an existing share.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        System.Threading.Tasks.Task<ApiResponse<Share>> GetSharesShareIdAsyncWithHttpInfo (string shareId, string expand = null);
        
        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <returns></returns>
        void DeleteSharesShareId (string shareId);
  
        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSharesShareIdWithHttpInfo (string shareId);

        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSharesShareIdAsync (string shareId);

        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <remarks>
        /// This revokes sharing rights specified in the share record
        /// </remarks>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSharesShareIdAsyncWithHttpInfo (string shareId);
        
        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>CommandStatusEntityListing</returns>
        CommandStatusEntityListing GetStatus (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of CommandStatusEntityListing</returns>
        ApiResponse<CommandStatusEntityListing> GetStatusWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of CommandStatusEntityListing</returns>
        System.Threading.Tasks.Task<CommandStatusEntityListing> GetStatusAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of statuses for pending operations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> GetStatusAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>CommandStatus</returns>
        CommandStatus GetStatusStatusId (string statusId);
  
        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of CommandStatus</returns>
        ApiResponse<CommandStatus> GetStatusStatusIdWithHttpInfo (string statusId);

        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        System.Threading.Tasks.Task<CommandStatus> GetStatusStatusIdAsync (string statusId);

        /// <summary>
        /// Get a status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommandStatus>> GetStatusStatusIdAsyncWithHttpInfo (string statusId);
        
        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns></returns>
        void DeleteStatusStatusId (string statusId);
  
        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteStatusStatusIdWithHttpInfo (string statusId);

        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteStatusStatusIdAsync (string statusId);

        /// <summary>
        /// Cancel the command for this status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteStatusStatusIdAsyncWithHttpInfo (string statusId);
        
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
        WorkspaceEntityListing GetWorkspaces (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
  
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
        ApiResponse<WorkspaceEntityListing> GetWorkspacesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);

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
        System.Threading.Tasks.Task<WorkspaceEntityListing> GetWorkspacesAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> GetWorkspacesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null);
        
        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Workspace</param>
        /// <returns>Workspace</returns>
        Workspace PostWorkspaces (WorkspaceCreate body = null);
  
        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> PostWorkspacesWithHttpInfo (WorkspaceCreate body = null);

        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> PostWorkspacesAsync (WorkspaceCreate body = null);

        /// <summary>
        /// Create a group workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> PostWorkspacesAsyncWithHttpInfo (WorkspaceCreate body = null);
        
        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Workspace</returns>
        Workspace GetWorkspacesWorkspaceId (string workspaceId, string expand = null);
  
        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> GetWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, string expand = null);

        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> GetWorkspacesWorkspaceIdAsync (string workspaceId, string expand = null);

        /// <summary>
        /// Get a workspace.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> GetWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, string expand = null);
        
        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Workspace</returns>
        Workspace PutWorkspacesWorkspaceId (string workspaceId, Workspace body = null);
  
        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>ApiResponse of Workspace</returns>
        ApiResponse<Workspace> PutWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, Workspace body = null);

        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        System.Threading.Tasks.Task<Workspace> PutWorkspacesWorkspaceIdAsync (string workspaceId, Workspace body = null);

        /// <summary>
        /// Update a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        System.Threading.Tasks.Task<ApiResponse<Workspace>> PutWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, Workspace body = null);
        
        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns></returns>
        void DeleteWorkspacesWorkspaceId (string workspaceId, string moveChildrenToWorkspaceId = null);
  
        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);

        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdAsync (string workspaceId, string moveChildrenToWorkspaceId = null);

        /// <summary>
        /// Delete a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null);
        
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
        WorkspaceMemberEntityListing GetWorkspacesWorkspaceIdMembers (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
  
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
        ApiResponse<WorkspaceMemberEntityListing> GetWorkspacesWorkspaceIdMembersWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);

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
        System.Threading.Tasks.Task<WorkspaceMemberEntityListing> GetWorkspacesWorkspaceIdMembersAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> GetWorkspacesWorkspaceIdMembersAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null);
        
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
        WorkspaceMember GetWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, string expand = null);
  
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
        ApiResponse<WorkspaceMember> GetWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, string expand = null);

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
        System.Threading.Tasks.Task<WorkspaceMember> GetWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> GetWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, string expand = null);
        
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
        WorkspaceMember PutWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, WorkspaceMember body = null);
  
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
        ApiResponse<WorkspaceMember> PutWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);

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
        System.Threading.Tasks.Task<WorkspaceMember> PutWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, WorkspaceMember body = null);

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
        System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> PutWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null);
        
        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId);

        /// <summary>
        /// Delete a member from a workspace
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId);
        
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
        TagValueEntityListing GetWorkspacesWorkspaceIdTagvalues (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
  
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
        ApiResponse<TagValueEntityListing> GetWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);

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
        System.Threading.Tasks.Task<TagValueEntityListing> GetWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> GetWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null);
        
        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>TagValue</returns>
        TagValue PostWorkspacesWorkspaceIdTagvalues (string workspaceId, TagValue body = null);
  
        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>ApiResponse of TagValue</returns>
        ApiResponse<TagValue> PostWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, TagValue body = null);

        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of TagValue</returns>
        System.Threading.Tasks.Task<TagValue> PostWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, TagValue body = null);

        /// <summary>
        /// Create a workspace tag
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagValue>> PostWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, TagValue body = null);
        
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
        TagValueEntityListing PostWorkspacesWorkspaceIdTagvaluesQuery (string workspaceId, TagQueryRequest body = null, string expand = null);
  
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
        ApiResponse<TagValueEntityListing> PostWorkspacesWorkspaceIdTagvaluesQueryWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null);

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
        System.Threading.Tasks.Task<TagValueEntityListing> PostWorkspacesWorkspaceIdTagvaluesQueryAsync (string workspaceId, TagQueryRequest body = null, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> PostWorkspacesWorkspaceIdTagvaluesQueryAsyncWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null);
        
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
        TagValue GetWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, string expand = null);
  
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
        ApiResponse<TagValue> GetWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, string expand = null);

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
        System.Threading.Tasks.Task<TagValue> GetWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<TagValue>> GetWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, string expand = null);
        
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
        TagValue PutWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, TagValue body = null);
  
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
        ApiResponse<TagValue> PutWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, TagValue body = null);

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
        System.Threading.Tasks.Task<TagValue> PutWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, TagValue body = null);

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
        System.Threading.Tasks.Task<ApiResponse<TagValue>> PutWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null);
        
        /// <summary>
        /// Delete workspace tag
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId);

        /// <summary>
        /// Delete workspace tag
        /// </summary>
        /// <remarks>
        /// Delete a tag from a workspace. Will remove this tag from all documents.
        /// </remarks>
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
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId);
        
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
        public QueryResults PostAuditquery (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> response = PostAuditqueryWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param> 
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > PostAuditqueryWithHttpInfo (ContentQueryRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostAuditquery");
            
    
            var path_ = "/api/v1/contentmanagement/auditquery";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostAuditquery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAuditquery: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(response, typeof(QueryResults)));
            
        }
    
        /// <summary>
        /// Query audits 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of QueryResults</returns>
        public async System.Threading.Tasks.Task<QueryResults> PostAuditqueryAsync (ContentQueryRequest body)
        {
             ApiResponse<QueryResults> response = await PostAuditqueryAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Query audits 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostAuditqueryAsyncWithHttpInfo (ContentQueryRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostAuditquery");
            
    
            var path_ = "/api/v1/contentmanagement/auditquery";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostAuditquery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAuditquery: " + response.ErrorMessage, response.ErrorMessage);

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
        public DocumentEntityListing GetDocuments (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> response = GetDocumentsWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
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
        public ApiResponse< DocumentEntityListing > GetDocumentsWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetDocuments");
            
    
            var path_ = "/api/v1/contentmanagement/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DocumentEntityListing> GetDocumentsAsync (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentEntityListing> response = await GetDocumentsAsyncWithHttpInfo(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<DocumentEntityListing>> GetDocumentsAsyncWithHttpInfo (string workspaceId, string name = null, string expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling GetDocuments");
            
    
            var path_ = "/api/v1/contentmanagement/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocuments: " + response.ErrorMessage, response.ErrorMessage);

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
        public Document PostDocuments (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> response = PostDocumentsWithHttpInfo(body, copySource, moveSource, _override);
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
        public ApiResponse< Document > PostDocumentsWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (copySource != null) queryParams.Add("copySource", Configuration.ApiClient.ParameterToString(copySource)); // query parameter
            if (moveSource != null) queryParams.Add("moveSource", Configuration.ApiClient.ParameterToString(moveSource)); // query parameter
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Document> PostDocumentsAsync (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
             ApiResponse<Document> response = await PostDocumentsAsyncWithHttpInfo(body, copySource, moveSource, _override);
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
        public async System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsAsyncWithHttpInfo (DocumentUpload body = null, string copySource = null, string moveSource = null, bool? _override = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDocuments: " + response.ErrorMessage, response.ErrorMessage);

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
        public Document GetDocumentsDocumentId (string documentId, string expand = null)
        {
             ApiResponse<Document> response = GetDocumentsDocumentIdWithHttpInfo(documentId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of Document</returns>
        public ApiResponse< Document > GetDocumentsDocumentIdWithHttpInfo (string documentId, string expand = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentId");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Document> GetDocumentsDocumentIdAsync (string documentId, string expand = null)
        {
             ApiResponse<Document> response = await GetDocumentsDocumentIdAsyncWithHttpInfo(documentId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Document>> GetDocumentsDocumentIdAsyncWithHttpInfo (string documentId, string expand = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocumentsDocumentId");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Document PostDocumentsDocumentId (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> response = PostDocumentsDocumentIdWithHttpInfo(documentId, body, expand, _override);
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
        public ApiResponse< Document > PostDocumentsDocumentIdWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentId");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostDocumentsDocumentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDocumentsDocumentId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Document> PostDocumentsDocumentIdAsync (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
             ApiResponse<Document> response = await PostDocumentsDocumentIdAsyncWithHttpInfo(documentId, body, expand, _override);
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
        public async System.Threading.Tasks.Task<ApiResponse<Document>> PostDocumentsDocumentIdAsyncWithHttpInfo (string documentId, DocumentUpdate body = null, string expand = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling PostDocumentsDocumentId");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostDocumentsDocumentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDocumentsDocumentId: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteDocumentsDocumentId (string documentId, bool? _override = null)
        {
             DeleteDocumentsDocumentIdWithHttpInfo(documentId, _override);
        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="_override">Override any lock on the document</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteDocumentsDocumentIdWithHttpInfo (string documentId, bool? _override = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->DeleteDocumentsDocumentId");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocumentsDocumentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocumentsDocumentId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteDocumentsDocumentIdAsync (string documentId, bool? _override = null)
        {
             await DeleteDocumentsDocumentIdAsyncWithHttpInfo(documentId, _override);

        }

        /// <summary>
        /// Delete a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentsDocumentIdAsyncWithHttpInfo (string documentId, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocumentsDocumentId");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocumentsDocumentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocumentsDocumentId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public DocumentAuditEntityListing GetDocumentsDocumentIdAudits (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentAuditEntityListing> response = GetDocumentsDocumentIdAuditsWithHttpInfo(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
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
        public ApiResponse< DocumentAuditEntityListing > GetDocumentsDocumentIdAuditsWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentIdAudits");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentIdAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentIdAudits: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DocumentAuditEntityListing> GetDocumentsDocumentIdAuditsAsync (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DocumentAuditEntityListing> response = await GetDocumentsDocumentIdAuditsAsyncWithHttpInfo(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<DocumentAuditEntityListing>> GetDocumentsDocumentIdAuditsAsyncWithHttpInfo (string documentId, int? pageSize = null, int? pageNumber = null, string transactionFilter = null, string level = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocumentsDocumentIdAudits");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentIdAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentIdAudits: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DocumentAuditEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentAuditEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DocumentAuditEntityListing)));
            
        }
        
        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param> 
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param> 
        /// <returns></returns>
        public void GetDocumentsDocumentIdContent (string documentId, string disposition = null, string contentType = null)
        {
             GetDocumentsDocumentIdContentWithHttpInfo(documentId, disposition, contentType);
        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param> 
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetDocumentsDocumentIdContentWithHttpInfo (string documentId, string disposition = null, string contentType = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->GetDocumentsDocumentIdContent");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/content";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (disposition != null) queryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (contentType != null) queryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentIdContent: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentIdContent: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetDocumentsDocumentIdContentAsync (string documentId, string disposition = null, string contentType = null)
        {
             await GetDocumentsDocumentIdContentAsyncWithHttpInfo(documentId, disposition, contentType);

        }

        /// <summary>
        /// Download a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="disposition">Request how the content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, string disposition = null, string contentType = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocumentsDocumentIdContent");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/content";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (disposition != null) queryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (contentType != null) queryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentIdContent: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocumentsDocumentIdContent: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public ReplaceResponse PostDocumentsDocumentIdContent (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> response = PostDocumentsDocumentIdContentWithHttpInfo(documentId, body, _override);
             return response.Data;
        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param> 
        /// <param name="body">Replace Request</param> 
        /// <param name="_override">Override any lock on the document</param> 
        /// <returns>ApiResponse of ReplaceResponse</returns>
        public ApiResponse< ReplaceResponse > PostDocumentsDocumentIdContentWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling ContentManagementApi->PostDocumentsDocumentIdContent");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/content";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            if (_override != null) queryParams.Add("override", Configuration.ApiClient.ParameterToString(_override)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostDocumentsDocumentIdContent: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDocumentsDocumentIdContent: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ReplaceResponse> PostDocumentsDocumentIdContentAsync (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
             ApiResponse<ReplaceResponse> response = await PostDocumentsDocumentIdContentAsyncWithHttpInfo(documentId, body, _override);
             return response.Data;

        }

        /// <summary>
        /// Replace the contents of a document. 
        /// </summary>
        /// <param name="documentId">Document ID</param>
        /// <param name="body">Replace Request</param>
        /// <param name="_override">Override any lock on the document</param>
        /// <returns>Task of ApiResponse (ReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReplaceResponse>> PostDocumentsDocumentIdContentAsyncWithHttpInfo (string documentId, ReplaceRequest body = null, bool? _override = null)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling PostDocumentsDocumentIdContent");
            
    
            var path_ = "/api/v1/contentmanagement/documents/{documentId}/content";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostDocumentsDocumentIdContent: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDocumentsDocumentIdContent: " + response.ErrorMessage, response.ErrorMessage);

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
        public QueryResults GetQuery (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
             ApiResponse<QueryResults> response = GetQueryWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
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
        public ApiResponse< QueryResults > GetQueryWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
            
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null)
                throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling ContentManagementApi->GetQuery");
            
    
            var path_ = "/api/v1/contentmanagement/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQuery: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<QueryResults> GetQueryAsync (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
             ApiResponse<QueryResults> response = await GetQueryAsyncWithHttpInfo(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
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
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> GetQueryAsyncWithHttpInfo (string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string expand = null)
        {
            // verify the required parameter 'queryPhrase' is set
            if (queryPhrase == null) throw new ApiException(400, "Missing required parameter 'queryPhrase' when calling GetQuery");
            
    
            var path_ = "/api/v1/contentmanagement/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQuery: " + response.ErrorMessage, response.ErrorMessage);

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
        public QueryResults PostQuery (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> response = PostQueryWithHttpInfo(body, expand);
             return response.Data;
        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of QueryResults</returns>
        public ApiResponse< QueryResults > PostQueryWithHttpInfo (QueryRequest body, string expand = null)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContentManagementApi->PostQuery");
            
    
            var path_ = "/api/v1/contentmanagement/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<QueryResults> PostQueryAsync (QueryRequest body, string expand = null)
        {
             ApiResponse<QueryResults> response = await PostQueryAsyncWithHttpInfo(body, expand);
             return response.Data;

        }

        /// <summary>
        /// Query content 
        /// </summary>
        /// <param name="body">Allows for a filtered query returning facet information</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (QueryResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryResults>> PostQueryAsyncWithHttpInfo (QueryRequest body, string expand = null)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostQuery");
            
    
            var path_ = "/api/v1/contentmanagement/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueryResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryResults) Configuration.ApiClient.Deserialize(response, typeof(QueryResults)));
            
        }
        
        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <returns>SecurityProfileEntityListing</returns>
        public SecurityProfileEntityListing GetSecurityprofiles ()
        {
             ApiResponse<SecurityProfileEntityListing> response = GetSecurityprofilesWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <returns>ApiResponse of SecurityProfileEntityListing</returns>
        public ApiResponse< SecurityProfileEntityListing > GetSecurityprofilesWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/contentmanagement/securityprofiles";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSecurityprofiles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSecurityprofiles: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SecurityProfileEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfileEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SecurityProfileEntityListing)));
            
        }
    
        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <returns>Task of SecurityProfileEntityListing</returns>
        public async System.Threading.Tasks.Task<SecurityProfileEntityListing> GetSecurityprofilesAsync ()
        {
             ApiResponse<SecurityProfileEntityListing> response = await GetSecurityprofilesAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get a List of Security Profiles 
        /// </summary>
        /// <returns>Task of ApiResponse (SecurityProfileEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityProfileEntityListing>> GetSecurityprofilesAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/contentmanagement/securityprofiles";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSecurityprofiles: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSecurityprofiles: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SecurityProfileEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfileEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SecurityProfileEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <param name="securityProfileId">Security Profile Id</param> 
        /// <returns>SecurityProfile</returns>
        public SecurityProfile GetSecurityprofilesSecurityprofileId (string securityProfileId)
        {
             ApiResponse<SecurityProfile> response = GetSecurityprofilesSecurityprofileIdWithHttpInfo(securityProfileId);
             return response.Data;
        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <param name="securityProfileId">Security Profile Id</param> 
        /// <returns>ApiResponse of SecurityProfile</returns>
        public ApiResponse< SecurityProfile > GetSecurityprofilesSecurityprofileIdWithHttpInfo (string securityProfileId)
        {
            
            // verify the required parameter 'securityProfileId' is set
            if (securityProfileId == null)
                throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling ContentManagementApi->GetSecurityprofilesSecurityprofileId");
            
    
            var path_ = "/api/v1/contentmanagement/securityprofiles/{securityProfileId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SecurityProfile>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityProfile) Configuration.ApiClient.Deserialize(response, typeof(SecurityProfile)));
            
        }
    
        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of SecurityProfile</returns>
        public async System.Threading.Tasks.Task<SecurityProfile> GetSecurityprofilesSecurityprofileIdAsync (string securityProfileId)
        {
             ApiResponse<SecurityProfile> response = await GetSecurityprofilesSecurityprofileIdAsyncWithHttpInfo(securityProfileId);
             return response.Data;

        }

        /// <summary>
        /// Get a Security Profile 
        /// </summary>
        /// <param name="securityProfileId">Security Profile Id</param>
        /// <returns>Task of ApiResponse (SecurityProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityProfile>> GetSecurityprofilesSecurityprofileIdAsyncWithHttpInfo (string securityProfileId)
        {
            // verify the required parameter 'securityProfileId' is set
            if (securityProfileId == null) throw new ApiException(400, "Missing required parameter 'securityProfileId' when calling GetSecurityprofilesSecurityprofileId");
            
    
            var path_ = "/api/v1/contentmanagement/securityprofiles/{securityProfileId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSecurityprofilesSecurityprofileId: " + response.ErrorMessage, response.ErrorMessage);

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
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns></returns>
        public void GetSharedSharedId (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
             GetSharedSharedIdWithHttpInfo(sharedId, redirect, disposition, contentType, expand);
        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <param name="sharedId">Shared ID</param> 
        /// <param name="redirect">Turn on or off redirect</param> 
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param> 
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetSharedSharedIdWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
            
            // verify the required parameter 'sharedId' is set
            if (sharedId == null)
                throw new ApiException(400, "Missing required parameter 'sharedId' when calling ContentManagementApi->GetSharedSharedId");
            
    
            var path_ = "/api/v1/contentmanagement/shared/{sharedId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (sharedId != null) pathParams.Add("sharedId", Configuration.ApiClient.ParameterToString(sharedId)); // path parameter
            
            if (redirect != null) queryParams.Add("redirect", Configuration.ApiClient.ParameterToString(redirect)); // query parameter
            if (disposition != null) queryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (contentType != null) queryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSharedSharedId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSharedSharedId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetSharedSharedIdAsync (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
             await GetSharedSharedIdAsyncWithHttpInfo(sharedId, redirect, disposition, contentType, expand);

        }

        /// <summary>
        /// Get shared documents. Securely download a shared document. This method requires the download sharing URI obtained in the get document response (downloadSharingUri). Documents may be shared between users in the same workspace. Documents may also be shared between any user by creating a content management share.
        /// </summary>
        /// <param name="sharedId">Shared ID</param>
        /// <param name="redirect">Turn on or off redirect</param>
        /// <param name="disposition">Request how the share content will be downloaded: attached as a file or inline. Default is attachment.</param>
        /// <param name="contentType">The requested format for the specified document. If supported, the document will be returned in that format. Example contentType=audio/wav</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetSharedSharedIdAsyncWithHttpInfo (string sharedId, bool? redirect = null, string disposition = null, string contentType = null, string expand = null)
        {
            // verify the required parameter 'sharedId' is set
            if (sharedId == null) throw new ApiException(400, "Missing required parameter 'sharedId' when calling GetSharedSharedId");
            
    
            var path_ = "/api/v1/contentmanagement/shared/{sharedId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (sharedId != null) pathParams.Add("sharedId", Configuration.ApiClient.ParameterToString(sharedId)); // path parameter
            
            if (redirect != null) queryParams.Add("redirect", Configuration.ApiClient.ParameterToString(redirect)); // query parameter
            if (disposition != null) queryParams.Add("disposition", Configuration.ApiClient.ParameterToString(disposition)); // query parameter
            if (contentType != null) queryParams.Add("contentType", Configuration.ApiClient.ParameterToString(contentType)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSharedSharedId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSharedSharedId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public ShareEntityListing GetShares (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ShareEntityListing> response = GetSharesWithHttpInfo(entityId, expand, pageSize, pageNumber);
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
        public ApiResponse< ShareEntityListing > GetSharesWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/shares";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetShares: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetShares: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ShareEntityListing> GetSharesAsync (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ShareEntityListing> response = await GetSharesAsyncWithHttpInfo(entityId, expand, pageSize, pageNumber);
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
        public async System.Threading.Tasks.Task<ApiResponse<ShareEntityListing>> GetSharesAsyncWithHttpInfo (string entityId = null, string expand = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/shares";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetShares: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetShares: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ShareEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShareEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ShareEntityListing)));
            
        }
        
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param> 
        /// <returns>CreateShareResponse</returns>
        public CreateShareResponse PostShares (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> response = PostSharesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param> 
        /// <returns>ApiResponse of CreateShareResponse</returns>
        public ApiResponse< CreateShareResponse > PostSharesWithHttpInfo (CreateShareRequest body = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/shares";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostShares: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostShares: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CreateShareResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateShareResponse) Configuration.ApiClient.Deserialize(response, typeof(CreateShareResponse)));
            
        }
    
        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of CreateShareResponse</returns>
        public async System.Threading.Tasks.Task<CreateShareResponse> PostSharesAsync (CreateShareRequest body = null)
        {
             ApiResponse<CreateShareResponse> response = await PostSharesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Creates a new share or updates an existing share if the entity has already been shared 
        /// </summary>
        /// <param name="body">CreateShareRequest - entity id and type and a single member or list of members are required</param>
        /// <returns>Task of ApiResponse (CreateShareResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateShareResponse>> PostSharesAsyncWithHttpInfo (CreateShareRequest body = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/shares";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostShares: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostShares: " + response.ErrorMessage, response.ErrorMessage);

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
        public Share GetSharesShareId (string shareId, string expand = null)
        {
             ApiResponse<Share> response = GetSharesShareIdWithHttpInfo(shareId, expand);
             return response.Data;
        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <param name="shareId">Share ID</param> 
        /// <param name="expand">Expand share fields</param> 
        /// <returns>ApiResponse of Share</returns>
        public ApiResponse< Share > GetSharesShareIdWithHttpInfo (string shareId, string expand = null)
        {
            
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->GetSharesShareId");
            
    
            var path_ = "/api/v1/contentmanagement/shares/{shareId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSharesShareId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSharesShareId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Share> GetSharesShareIdAsync (string shareId, string expand = null)
        {
             ApiResponse<Share> response = await GetSharesShareIdAsyncWithHttpInfo(shareId, expand);
             return response.Data;

        }

        /// <summary>
        /// Retrieve details about an existing share. 
        /// </summary>
        /// <param name="shareId">Share ID</param>
        /// <param name="expand">Expand share fields</param>
        /// <returns>Task of ApiResponse (Share)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Share>> GetSharesShareIdAsyncWithHttpInfo (string shareId, string expand = null)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null) throw new ApiException(400, "Missing required parameter 'shareId' when calling GetSharesShareId");
            
    
            var path_ = "/api/v1/contentmanagement/shares/{shareId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSharesShareId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSharesShareId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Share>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Share) Configuration.ApiClient.Deserialize(response, typeof(Share)));
            
        }
        
        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <param name="shareId">Share ID</param> 
        /// <returns></returns>
        public void DeleteSharesShareId (string shareId)
        {
             DeleteSharesShareIdWithHttpInfo(shareId);
        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <param name="shareId">Share ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteSharesShareIdWithHttpInfo (string shareId)
        {
            
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling ContentManagementApi->DeleteSharesShareId");
            
    
            var path_ = "/api/v1/contentmanagement/shares/{shareId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSharesShareId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSharesShareId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteSharesShareIdAsync (string shareId)
        {
             await DeleteSharesShareIdAsyncWithHttpInfo(shareId);

        }

        /// <summary>
        /// Deletes an existing share. This revokes sharing rights specified in the share record
        /// </summary>
        /// <param name="shareId">Share ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSharesShareIdAsyncWithHttpInfo (string shareId)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null) throw new ApiException(400, "Missing required parameter 'shareId' when calling DeleteSharesShareId");
            
    
            var path_ = "/api/v1/contentmanagement/shares/{shareId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSharesShareId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSharesShareId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public CommandStatusEntityListing GetStatus (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> response = GetStatusWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of CommandStatusEntityListing</returns>
        public ApiResponse< CommandStatusEntityListing > GetStatusWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<CommandStatusEntityListing> GetStatusAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<CommandStatusEntityListing> response = await GetStatusAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of statuses for pending operations 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (CommandStatusEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatusEntityListing>> GetStatusAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/status";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetStatus: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CommandStatusEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatusEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CommandStatusEntityListing)));
            
        }
        
        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <param name="statusId">Status ID</param> 
        /// <returns>CommandStatus</returns>
        public CommandStatus GetStatusStatusId (string statusId)
        {
             ApiResponse<CommandStatus> response = GetStatusStatusIdWithHttpInfo(statusId);
             return response.Data;
        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <param name="statusId">Status ID</param> 
        /// <returns>ApiResponse of CommandStatus</returns>
        public ApiResponse< CommandStatus > GetStatusStatusIdWithHttpInfo (string statusId)
        {
            
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->GetStatusStatusId");
            
    
            var path_ = "/api/v1/contentmanagement/status/{statusId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetStatusStatusId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetStatusStatusId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CommandStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(response, typeof(CommandStatus)));
            
        }
    
        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of CommandStatus</returns>
        public async System.Threading.Tasks.Task<CommandStatus> GetStatusStatusIdAsync (string statusId)
        {
             ApiResponse<CommandStatus> response = await GetStatusStatusIdAsyncWithHttpInfo(statusId);
             return response.Data;

        }

        /// <summary>
        /// Get a status. 
        /// </summary>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse (CommandStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommandStatus>> GetStatusStatusIdAsyncWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null) throw new ApiException(400, "Missing required parameter 'statusId' when calling GetStatusStatusId");
            
    
            var path_ = "/api/v1/contentmanagement/status/{statusId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetStatusStatusId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetStatusStatusId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CommandStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommandStatus) Configuration.ApiClient.Deserialize(response, typeof(CommandStatus)));
            
        }
        
        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <param name="statusId">Status ID</param> 
        /// <returns></returns>
        public void DeleteStatusStatusId (string statusId)
        {
             DeleteStatusStatusIdWithHttpInfo(statusId);
        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <param name="statusId">Status ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteStatusStatusIdWithHttpInfo (string statusId)
        {
            
            // verify the required parameter 'statusId' is set
            if (statusId == null)
                throw new ApiException(400, "Missing required parameter 'statusId' when calling ContentManagementApi->DeleteStatusStatusId");
            
    
            var path_ = "/api/v1/contentmanagement/status/{statusId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteStatusStatusId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteStatusStatusId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteStatusStatusIdAsync (string statusId)
        {
             await DeleteStatusStatusIdAsyncWithHttpInfo(statusId);

        }

        /// <summary>
        /// Cancel the command for this status 
        /// </summary>
        /// <param name="statusId">Status ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteStatusStatusIdAsyncWithHttpInfo (string statusId)
        {
            // verify the required parameter 'statusId' is set
            if (statusId == null) throw new ApiException(400, "Missing required parameter 'statusId' when calling DeleteStatusStatusId");
            
    
            var path_ = "/api/v1/contentmanagement/status/{statusId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteStatusStatusId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteStatusStatusId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public WorkspaceEntityListing GetWorkspaces (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> response = GetWorkspacesWithHttpInfo(pageSize, pageNumber, access, expand);
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
        public ApiResponse< WorkspaceEntityListing > GetWorkspacesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/workspaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspaces: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WorkspaceEntityListing> GetWorkspacesAsync (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
             ApiResponse<WorkspaceEntityListing> response = await GetWorkspacesAsyncWithHttpInfo(pageSize, pageNumber, access, expand);
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
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceEntityListing>> GetWorkspacesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string access = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/workspaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspaces: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WorkspaceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkspaceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(WorkspaceEntityListing)));
            
        }
        
        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <param name="body">Workspace</param> 
        /// <returns>Workspace</returns>
        public Workspace PostWorkspaces (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> response = PostWorkspacesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <param name="body">Workspace</param> 
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > PostWorkspacesWithHttpInfo (WorkspaceCreate body = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/workspaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostWorkspaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostWorkspaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Workspace>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Workspace) Configuration.ApiClient.Deserialize(response, typeof(Workspace)));
            
        }
    
        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <param name="body">Workspace</param>
        /// <returns>Task of Workspace</returns>
        public async System.Threading.Tasks.Task<Workspace> PostWorkspacesAsync (WorkspaceCreate body = null)
        {
             ApiResponse<Workspace> response = await PostWorkspacesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a group workspace 
        /// </summary>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> PostWorkspacesAsyncWithHttpInfo (WorkspaceCreate body = null)
        {
            
    
            var path_ = "/api/v1/contentmanagement/workspaces";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostWorkspaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostWorkspaces: " + response.ErrorMessage, response.ErrorMessage);

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
        public Workspace GetWorkspacesWorkspaceId (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> response = GetWorkspacesWorkspaceIdWithHttpInfo(workspaceId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="expand">Expand some workspace fields</param> 
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > GetWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Workspace> GetWorkspacesWorkspaceIdAsync (string workspaceId, string expand = null)
        {
             ApiResponse<Workspace> response = await GetWorkspacesWorkspaceIdAsyncWithHttpInfo(workspaceId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a workspace. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="expand">Expand some workspace fields</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> GetWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling GetWorkspacesWorkspaceId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Workspace PutWorkspacesWorkspaceId (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> response = PutWorkspacesWorkspaceIdWithHttpInfo(workspaceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="body">Workspace</param> 
        /// <returns>ApiResponse of Workspace</returns>
        public ApiResponse< Workspace > PutWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, Workspace body = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Workspace> PutWorkspacesWorkspaceIdAsync (string workspaceId, Workspace body = null)
        {
             ApiResponse<Workspace> response = await PutWorkspacesWorkspaceIdAsyncWithHttpInfo(workspaceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (Workspace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Workspace>> PutWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, Workspace body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling PutWorkspacesWorkspaceId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceId: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteWorkspacesWorkspaceId (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             DeleteWorkspacesWorkspaceIdWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);
        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkspacesWorkspaceIdWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->DeleteWorkspacesWorkspaceId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdAsync (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
             await DeleteWorkspacesWorkspaceIdAsyncWithHttpInfo(workspaceId, moveChildrenToWorkspaceId);

        }

        /// <summary>
        /// Delete a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="moveChildrenToWorkspaceId">New location for objects in deleted workspace.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdAsyncWithHttpInfo (string workspaceId, string moveChildrenToWorkspaceId = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling DeleteWorkspacesWorkspaceId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public WorkspaceMemberEntityListing GetWorkspacesWorkspaceIdMembers (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> response = GetWorkspacesWorkspaceIdMembersWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
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
        public ApiResponse< WorkspaceMemberEntityListing > GetWorkspacesWorkspaceIdMembersWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembers");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WorkspaceMemberEntityListing> GetWorkspacesWorkspaceIdMembersAsync (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<WorkspaceMemberEntityListing> response = await GetWorkspacesWorkspaceIdMembersAsyncWithHttpInfo(workspaceId, pageSize, pageNumber, expand);
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
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMemberEntityListing>> GetWorkspacesWorkspaceIdMembersAsyncWithHttpInfo (string workspaceId, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling GetWorkspacesWorkspaceIdMembers");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdMembers: " + response.ErrorMessage, response.ErrorMessage);

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
        public WorkspaceMember GetWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> response = GetWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo(workspaceId, memberId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="expand">Expand workspace member fields</param> 
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > GetWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembersMemberId");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdMembersMemberId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WorkspaceMember> GetWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, string expand = null)
        {
             ApiResponse<WorkspaceMember> response = await GetWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo(workspaceId, memberId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a workspace member 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand workspace member fields</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> GetWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling GetWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling GetWorkspacesWorkspaceIdMembersMemberId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);

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
        public WorkspaceMember PutWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> response = PutWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo(workspaceId, memberId, body);
             return response.Data;
        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="body">Workspace</param> 
        /// <returns>ApiResponse of WorkspaceMember</returns>
        public ApiResponse< WorkspaceMember > PutWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdMembersMemberId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WorkspaceMember> PutWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId, WorkspaceMember body = null)
        {
             ApiResponse<WorkspaceMember> response = await PutWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo(workspaceId, memberId, body);
             return response.Data;

        }

        /// <summary>
        /// Add a member to a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (WorkspaceMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkspaceMember>> PutWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId, WorkspaceMember body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling PutWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling PutWorkspacesWorkspaceIdMembersMemberId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteWorkspacesWorkspaceIdMembersMemberId (string workspaceId, string memberId)
        {
             DeleteWorkspacesWorkspaceIdMembersMemberIdWithHttpInfo(workspaceId, memberId);
        }

        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
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
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdMembersMemberIdAsync (string workspaceId, string memberId)
        {
             await DeleteWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo(workspaceId, memberId);

        }

        /// <summary>
        /// Delete a member from a workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdMembersMemberIdAsyncWithHttpInfo (string workspaceId, string memberId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling DeleteWorkspacesWorkspaceIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling DeleteWorkspacesWorkspaceIdMembersMemberId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/members/{memberId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public TagValueEntityListing GetWorkspacesWorkspaceIdTagvalues (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> response = GetWorkspacesWorkspaceIdTagvaluesWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
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
        public ApiResponse< TagValueEntityListing > GetWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvalues");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TagValueEntityListing> GetWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> response = await GetWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo(workspaceId, value, pageSize, pageNumber, expand);
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
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> GetWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling GetWorkspacesWorkspaceIdTagvalues");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdTagvalues: " + response.ErrorMessage, response.ErrorMessage);

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
        public TagValue PostWorkspacesWorkspaceIdTagvalues (string workspaceId, TagValue body = null)
        {
             ApiResponse<TagValue> response = PostWorkspacesWorkspaceIdTagvaluesWithHttpInfo(workspaceId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="body">tag</param> 
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > PostWorkspacesWorkspaceIdTagvaluesWithHttpInfo (string workspaceId, TagValue body = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvalues");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TagValue> PostWorkspacesWorkspaceIdTagvaluesAsync (string workspaceId, TagValue body = null)
        {
             ApiResponse<TagValue> response = await PostWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo(workspaceId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">tag</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> PostWorkspacesWorkspaceIdTagvaluesAsyncWithHttpInfo (string workspaceId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling PostWorkspacesWorkspaceIdTagvalues");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostWorkspacesWorkspaceIdTagvalues: " + response.ErrorMessage, response.ErrorMessage);

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
        public TagValueEntityListing PostWorkspacesWorkspaceIdTagvaluesQuery (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> response = PostWorkspacesWorkspaceIdTagvaluesQueryWithHttpInfo(workspaceId, body, expand);
             return response.Data;
        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="body">query</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of TagValueEntityListing</returns>
        public ApiResponse< TagValueEntityListing > PostWorkspacesWorkspaceIdTagvaluesQueryWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PostWorkspacesWorkspaceIdTagvaluesQuery");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TagValueEntityListing> PostWorkspacesWorkspaceIdTagvaluesQueryAsync (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
             ApiResponse<TagValueEntityListing> response = await PostWorkspacesWorkspaceIdTagvaluesQueryAsyncWithHttpInfo(workspaceId, body, expand);
             return response.Data;

        }

        /// <summary>
        /// Perform a prefix query on tags in the workspace 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="body">query</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (TagValueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValueEntityListing>> PostWorkspacesWorkspaceIdTagvaluesQueryAsyncWithHttpInfo (string workspaceId, TagQueryRequest body = null, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling PostWorkspacesWorkspaceIdTagvaluesQuery");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostWorkspacesWorkspaceIdTagvaluesQuery: " + response.ErrorMessage, response.ErrorMessage);

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
        public TagValue GetWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, string expand = null)
        {
             ApiResponse<TagValue> response = GetWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo(workspaceId, tagId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="tagId">Tag ID</param> 
        /// <param name="expand">Expand some document fields</param> 
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > GetWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, string expand = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");
            
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->GetWorkspacesWorkspaceIdTagvaluesTagId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TagValue> GetWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, string expand = null)
        {
             ApiResponse<TagValue> response = await GetWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo(workspaceId, tagId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a workspace tag 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="expand">Expand some document fields</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> GetWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, string expand = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling GetWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling GetWorkspacesWorkspaceIdTagvaluesTagId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWorkspacesWorkspaceIdTagvaluesTagId: " + response.ErrorMessage, response.ErrorMessage);

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
        public TagValue PutWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> response = PutWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo(workspaceId, tagId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param> 
        /// <param name="tagId">Tag ID</param> 
        /// <param name="body">Workspace</param> 
        /// <returns>ApiResponse of TagValue</returns>
        public ApiResponse< TagValue > PutWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");
            
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling ContentManagementApi->PutWorkspacesWorkspaceIdTagvaluesTagId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (workspaceId != null) pathParams.Add("workspaceId", Configuration.ApiClient.ParameterToString(workspaceId)); // path parameter
            if (tagId != null) pathParams.Add("tagId", Configuration.ApiClient.ParameterToString(tagId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TagValue> PutWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId, TagValue body = null)
        {
             ApiResponse<TagValue> response = await PutWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo(workspaceId, tagId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a workspace tag. Will update all documents with the new tag value. 
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <param name="body">Workspace</param>
        /// <returns>Task of ApiResponse (TagValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagValue>> PutWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId, TagValue body = null)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling PutWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling PutWorkspacesWorkspaceIdTagvaluesTagId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWorkspacesWorkspaceIdTagvaluesTagId: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteWorkspacesWorkspaceIdTagvaluesTagId (string workspaceId, string tagId)
        {
             DeleteWorkspacesWorkspaceIdTagvaluesTagIdWithHttpInfo(workspaceId, tagId);
        }

        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
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
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsync (string workspaceId, string tagId)
        {
             await DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo(workspaceId, tagId);

        }

        /// <summary>
        /// Delete workspace tag Delete a tag from a workspace. Will remove this tag from all documents.
        /// </summary>
        /// <param name="workspaceId">Workspace ID</param>
        /// <param name="tagId">Tag ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkspacesWorkspaceIdTagvaluesTagIdAsyncWithHttpInfo (string workspaceId, string tagId)
        {
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null) throw new ApiException(400, "Missing required parameter 'workspaceId' when calling DeleteWorkspacesWorkspaceIdTagvaluesTagId");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling DeleteWorkspacesWorkspaceIdTagvaluesTagId");
            
    
            var path_ = "/api/v1/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteWorkspacesWorkspaceIdTagvaluesTagId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
