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
    public interface IConfigurationApi
    {
        
        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>DIDPoolEntityListing</returns>
        DIDPoolEntityListing GetDidpools (int? pageSize = null, int? pageNumber = null, string sortBy = null);
  
        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of DIDPoolEntityListing</returns>
        ApiResponse<DIDPoolEntityListing> GetDidpoolsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of DIDPoolEntityListing</returns>
        System.Threading.Tasks.Task<DIDPoolEntityListing> GetDidpoolsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (DIDPoolEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPoolEntityListing>> GetDidpoolsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        
        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>DIDPool</returns>
        DIDPool CreateDidpools (DIDPool body = null);
  
        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> CreateDidpoolsWithHttpInfo (DIDPool body = null);

        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> CreateDidpoolsAsync (DIDPool body = null);

        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> CreateDidpoolsAsyncWithHttpInfo (DIDPool body = null);
        
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>DIDPool</returns>
        DIDPool GetDidpoolsDPoolId (string didPoolId);
  
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> GetDidpoolsDPoolIdWithHttpInfo (string didPoolId);

        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> GetDidpoolsDPoolIdAsync (string didPoolId);

        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> GetDidpoolsDPoolIdAsyncWithHttpInfo (string didPoolId);
        
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>DIDPool</returns>
        DIDPool UpdateDidpoolsDPoolId (string didPoolId, DIDPool body = null);
  
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> UpdateDidpoolsDPoolIdWithHttpInfo (string didPoolId, DIDPool body = null);

        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> UpdateDidpoolsDPoolIdAsync (string didPoolId, DIDPool body = null);

        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> UpdateDidpoolsDPoolIdAsyncWithHttpInfo (string didPoolId, DIDPool body = null);
        
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>string</returns>
        string DeleteDidpoolsDPoolId (string didPoolId);
  
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteDidpoolsDPoolIdWithHttpInfo (string didPoolId);

        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteDidpoolsDPoolIdAsync (string didPoolId);

        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteDidpoolsDPoolIdAsyncWithHttpInfo (string didPoolId);
        
        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>DIDEntityListing</returns>
        DIDEntityListing GetDids (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);
  
        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>ApiResponse of DIDEntityListing</returns>
        ApiResponse<DIDEntityListing> GetDidsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);

        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>Task of DIDEntityListing</returns>
        System.Threading.Tasks.Task<DIDEntityListing> GetDidsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);

        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>Task of ApiResponse (DIDEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDEntityListing>> GetDidsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);
        
        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>DID</returns>
        DID GetDId (string didId);
  
        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> GetDIdWithHttpInfo (string didId);

        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> GetDIdAsync (string didId);

        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> GetDIdAsyncWithHttpInfo (string didId);
        
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>DID</returns>
        DID UpdateDId (string didId, DID body = null);
  
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> UpdateDIdWithHttpInfo (string didId, DID body = null);

        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> UpdateDIdAsync (string didId, DID body = null);

        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> UpdateDIdAsyncWithHttpInfo (string didId, DID body = null);
        
        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>EdgeEntityListing</returns>
        EdgeEntityListing GetEdges (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);
  
        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of EdgeEntityListing</returns>
        ApiResponse<EdgeEntityListing> GetEdgesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);

        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EdgeEntityListing</returns>
        System.Threading.Tasks.Task<EdgeEntityListing> GetEdgesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);

        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EdgeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeEntityListing>> GetEdgesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);
        
        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Edge</param>
        /// <returns>Edge</returns>
        Edge CreateEdges (Edge body = null);
  
        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Edge</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> CreateEdgesWithHttpInfo (Edge body = null);

        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> CreateEdgesAsync (Edge body = null);

        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> CreateEdgesAsyncWithHttpInfo (Edge body = null);
        
        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>CertificateAuthorityEntityListing</returns>
        CertificateAuthorityEntityListing GetEdgesCertificateauthorities ();
  
        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of CertificateAuthorityEntityListing</returns>
        ApiResponse<CertificateAuthorityEntityListing> GetEdgesCertificateauthoritiesWithHttpInfo ();

        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of CertificateAuthorityEntityListing</returns>
        System.Threading.Tasks.Task<CertificateAuthorityEntityListing> GetEdgesCertificateauthoritiesAsync ();

        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (CertificateAuthorityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CertificateAuthorityEntityListing>> GetEdgesCertificateauthoritiesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority CreateEdgesCertificateauthorities (DomainCertificateAuthority body = null);
  
        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> CreateEdgesCertificateauthoritiesWithHttpInfo (DomainCertificateAuthority body = null);

        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> CreateEdgesCertificateauthoritiesAsync (DomainCertificateAuthority body = null);

        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> CreateEdgesCertificateauthoritiesAsyncWithHttpInfo (DomainCertificateAuthority body = null);
        
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority GetEdgesCertificateauthoritiesCertificate (string certificateId);
  
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> GetEdgesCertificateauthoritiesCertificateWithHttpInfo (string certificateId);

        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> GetEdgesCertificateauthoritiesCertificateAsync (string certificateId);

        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> GetEdgesCertificateauthoritiesCertificateAsyncWithHttpInfo (string certificateId);
        
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority UpdateEdgesCertificateauthoritiesCertificate (string certificateId, DomainCertificateAuthority body = null);
  
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> UpdateEdgesCertificateauthoritiesCertificateWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);

        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> UpdateEdgesCertificateauthoritiesCertificateAsync (string certificateId, DomainCertificateAuthority body = null);

        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> UpdateEdgesCertificateauthoritiesCertificateAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);
        
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>string</returns>
        string DeleteEdgesCertificateauthoritiesCertificate (string certificateId);
  
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgesCertificateauthoritiesCertificateWithHttpInfo (string certificateId);

        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgesCertificateauthoritiesCertificateAsync (string certificateId);

        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesCertificateauthoritiesCertificateAsyncWithHttpInfo (string certificateId);
        
        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Edge</returns>
        Edge GetEdge (string edgeId);
  
        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> GetEdgeWithHttpInfo (string edgeId);

        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> GetEdgeAsync (string edgeId);

        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> GetEdgeAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Edge</returns>
        Edge UpdateEdge (string edgeId, Edge body = null);
  
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> UpdateEdgeWithHttpInfo (string edgeId, Edge body = null);

        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> UpdateEdgeAsync (string edgeId, Edge body = null);

        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> UpdateEdgeAsyncWithHttpInfo (string edgeId, Edge body = null);
        
        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string DeleteEdge (string edgeId);
  
        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgeWithHttpInfo (string edgeId);

        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgeAsync (string edgeId);

        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgeAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>EdgeLineEntityListing</returns>
        EdgeLineEntityListing GetEdgeLines (string edgeId, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of EdgeLineEntityListing</returns>
        ApiResponse<EdgeLineEntityListing> GetEdgeLinesWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EdgeLineEntityListing</returns>
        System.Threading.Tasks.Task<EdgeLineEntityListing> GetEdgeLinesAsync (string edgeId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EdgeLineEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLineEntityListing>> GetEdgeLinesAsyncWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>EdgeLine</returns>
        EdgeLine GetEdgeLinesByLineId (string edgeId, string lineId);
  
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        ApiResponse<EdgeLine> GetEdgeLinesByLineIdWithHttpInfo (string edgeId, string lineId);

        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of EdgeLine</returns>
        System.Threading.Tasks.Task<EdgeLine> GetEdgeLinesByLineIdAsync (string edgeId, string lineId);

        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> GetEdgeLinesByLineIdAsyncWithHttpInfo (string edgeId, string lineId);
        
        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>EdgeLine</returns>
        EdgeLine UpdateEdgeLinesByLineId (string edgeId, string lineId, EdgeLine body = null);
  
        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        ApiResponse<EdgeLine> UpdateEdgeLinesByLineIdWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);

        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of EdgeLine</returns>
        System.Threading.Tasks.Task<EdgeLine> UpdateEdgeLinesByLineIdAsync (string edgeId, string lineId, EdgeLine body = null);

        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> UpdateEdgeLinesByLineIdAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);
        
        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>LogicalInterfaceEntityListing</returns>
        LogicalInterfaceEntityListing GetEdgeLogicalinterfaces (string edgeId);
  
        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of LogicalInterfaceEntityListing</returns>
        ApiResponse<LogicalInterfaceEntityListing> GetEdgeLogicalinterfacesWithHttpInfo (string edgeId);

        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of LogicalInterfaceEntityListing</returns>
        System.Threading.Tasks.Task<LogicalInterfaceEntityListing> GetEdgeLogicalinterfacesAsync (string edgeId);

        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (LogicalInterfaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LogicalInterfaceEntityListing>> GetEdgeLogicalinterfacesAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface CreateEdgeLogicalinterfaces (string edgeId, DomainLogicalInterface body = null);
  
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> CreateEdgeLogicalinterfacesWithHttpInfo (string edgeId, DomainLogicalInterface body = null);

        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> CreateEdgeLogicalinterfacesAsync (string edgeId, DomainLogicalInterface body = null);

        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> CreateEdgeLogicalinterfacesAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface GetEdgeLogicalinterfacesByInterfaceId (string edgeId, string interfaceId);
  
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> GetEdgeLogicalinterfacesByInterfaceIdWithHttpInfo (string edgeId, string interfaceId);

        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> GetEdgeLogicalinterfacesByInterfaceIdAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> GetEdgeLogicalinterfacesByInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface UpdateEdgeLogicalinterfacesByInterfaceId (string edgeId, string interfaceId, DomainLogicalInterface body = null);
  
        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> UpdateEdgeLogicalinterfacesByInterfaceIdWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);

        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> UpdateEdgeLogicalinterfacesByInterfaceIdAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null);

        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> UpdateEdgeLogicalinterfacesByInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns></returns>
        void DeleteEdgeLogicalinterfacesByInterfaceId (string edgeId, string interfaceId);
  
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteEdgeLogicalinterfacesByInterfaceIdWithHttpInfo (string edgeId, string interfaceId);

        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteEdgeLogicalinterfacesByInterfaceIdAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEdgeLogicalinterfacesByInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>PhysicalInterfaceEntityListing</returns>
        PhysicalInterfaceEntityListing GetEdgePhysicalinterfaces (string edgeId);
  
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of PhysicalInterfaceEntityListing</returns>
        ApiResponse<PhysicalInterfaceEntityListing> GetEdgePhysicalinterfacesWithHttpInfo (string edgeId);

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of PhysicalInterfaceEntityListing</returns>
        System.Threading.Tasks.Task<PhysicalInterfaceEntityListing> GetEdgePhysicalinterfacesAsync (string edgeId);

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (PhysicalInterfaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhysicalInterfaceEntityListing>> GetEdgePhysicalinterfacesAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainPhysicalInterface</returns>
        DomainPhysicalInterface GetEdgePhysicalinterfacesByInterfaceId (string edgeId, string interfaceId);
  
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        ApiResponse<DomainPhysicalInterface> GetEdgePhysicalinterfacesByInterfaceIdWithHttpInfo (string edgeId, string interfaceId);

        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainPhysicalInterface</returns>
        System.Threading.Tasks.Task<DomainPhysicalInterface> GetEdgePhysicalinterfacesByInterfaceIdAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> GetEdgePhysicalinterfacesByInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string CreateEdgeReboot (string edgeId);
  
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CreateEdgeRebootWithHttpInfo (string edgeId);

        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CreateEdgeRebootAsync (string edgeId);

        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CreateEdgeRebootAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        DomainEdgeSoftwareUpdateDto GetEdgeSoftwareupdate (string edgeId);
  
        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        ApiResponse<DomainEdgeSoftwareUpdateDto> GetEdgeSoftwareupdateWithHttpInfo (string edgeId);

        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> GetEdgeSoftwareupdateAsync (string edgeId);

        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> GetEdgeSoftwareupdateAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateEdgeSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
  
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateEdgeSoftwareupdateWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);

        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateEdgeSoftwareupdateAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null);

        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateEdgeSoftwareupdateAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
        
        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string DeleteEdgeSoftwareupdate (string edgeId);
  
        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgeSoftwareupdateWithHttpInfo (string edgeId);

        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgeSoftwareupdateAsync (string edgeId);

        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgeSoftwareupdateAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareVersionDto</returns>
        DomainEdgeSoftwareVersionDto GetEdgeSoftwareversions (string edgeId);
  
        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareVersionDto</returns>
        ApiResponse<DomainEdgeSoftwareVersionDto> GetEdgeSoftwareversionsWithHttpInfo (string edgeId);

        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareVersionDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareVersionDto> GetEdgeSoftwareversionsAsync (string edgeId);

        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareVersionDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareVersionDto>> GetEdgeSoftwareversionsAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>string</returns>
        string CreateEdgeUnpair (string edgeId);
  
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CreateEdgeUnpairWithHttpInfo (string edgeId);

        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CreateEdgeUnpairAsync (string edgeId);

        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CreateEdgeUnpairAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <returns>EdgeVersionReport</returns>
        EdgeVersionReport GetEdgeversionreport ();
  
        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <returns>ApiResponse of EdgeVersionReport</returns>
        ApiResponse<EdgeVersionReport> GetEdgeversionreportWithHttpInfo ();

        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <returns>Task of EdgeVersionReport</returns>
        System.Threading.Tasks.Task<EdgeVersionReport> GetEdgeversionreportAsync ();

        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <returns>Task of ApiResponse (EdgeVersionReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeVersionReport>> GetEdgeversionreportAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>EndpointEntityListing</returns>
        EndpointEntityListing GetEndpoints (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
  
        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of EndpointEntityListing</returns>
        ApiResponse<EndpointEntityListing> GetEndpointsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EndpointEntityListing</returns>
        System.Threading.Tasks.Task<EndpointEntityListing> GetEndpointsAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EndpointEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EndpointEntityListing>> GetEndpointsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        
        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Endpoint</returns>
        Endpoint CreateEndpoints (Endpoint body = null);
  
        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> CreateEndpointsWithHttpInfo (Endpoint body = null);

        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> CreateEndpointsAsync (Endpoint body = null);

        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> CreateEndpointsAsyncWithHttpInfo (Endpoint body = null);
        
        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Endpoint</returns>
        Endpoint GetEndpoint (string endpointId);
  
        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> GetEndpointWithHttpInfo (string endpointId);

        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> GetEndpointAsync (string endpointId);

        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> GetEndpointAsyncWithHttpInfo (string endpointId);
        
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Endpoint</returns>
        Endpoint UpdateEndpoint (string endpointId, Endpoint body = null);
  
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> UpdateEndpointWithHttpInfo (string endpointId, Endpoint body = null);

        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> UpdateEndpointAsync (string endpointId, Endpoint body = null);

        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> UpdateEndpointAsyncWithHttpInfo (string endpointId, Endpoint body = null);
        
        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>string</returns>
        string DeleteEndpoint (string endpointId);
  
        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEndpointWithHttpInfo (string endpointId);

        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEndpointAsync (string endpointId);

        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEndpointAsyncWithHttpInfo (string endpointId);
        
        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>ExtensionPoolEntityListing</returns>
        ExtensionPoolEntityListing GetExtensionpools (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);
  
        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>ApiResponse of ExtensionPoolEntityListing</returns>
        ApiResponse<ExtensionPoolEntityListing> GetExtensionpoolsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);

        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>Task of ExtensionPoolEntityListing</returns>
        System.Threading.Tasks.Task<ExtensionPoolEntityListing> GetExtensionpoolsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);

        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>Task of ApiResponse (ExtensionPoolEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPoolEntityListing>> GetExtensionpoolsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);
        
        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Extension</returns>
        Extension CreateExtensionpools (ExtensionPool body = null);
  
        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> CreateExtensionpoolsWithHttpInfo (ExtensionPool body = null);

        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> CreateExtensionpoolsAsync (ExtensionPool body = null);

        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> CreateExtensionpoolsAsyncWithHttpInfo (ExtensionPool body = null);
        
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ExtensionPool</returns>
        ExtensionPool GetExtensionPool (string extensionPoolId);
  
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> GetExtensionPoolWithHttpInfo (string extensionPoolId);

        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> GetExtensionPoolAsync (string extensionPoolId);

        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> GetExtensionPoolAsyncWithHttpInfo (string extensionPoolId);
        
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ExtensionPool</returns>
        ExtensionPool UpdateExtensionPool (string extensionPoolId, ExtensionPool body = null);
  
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> UpdateExtensionPoolWithHttpInfo (string extensionPoolId, ExtensionPool body = null);

        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> UpdateExtensionPoolAsync (string extensionPoolId, ExtensionPool body = null);

        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> UpdateExtensionPoolAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null);
        
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>string</returns>
        string DeleteExtensionPool (string extensionPoolId);
  
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteExtensionPoolWithHttpInfo (string extensionPoolId);

        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteExtensionPoolAsync (string extensionPoolId);

        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteExtensionPoolAsyncWithHttpInfo (string extensionPoolId);
        
        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>ExtensionEntityListing</returns>
        ExtensionEntityListing GetExtensions (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);
  
        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>ApiResponse of ExtensionEntityListing</returns>
        ApiResponse<ExtensionEntityListing> GetExtensionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);

        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>Task of ExtensionEntityListing</returns>
        System.Threading.Tasks.Task<ExtensionEntityListing> GetExtensionsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);

        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>Task of ApiResponse (ExtensionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionEntityListing>> GetExtensionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);
        
        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Extension</returns>
        Extension GetExtension (string extensionId);
  
        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> GetExtensionWithHttpInfo (string extensionId);

        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> GetExtensionAsync (string extensionId);

        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> GetExtensionAsyncWithHttpInfo (string extensionId);
        
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Extension</returns>
        Extension UpdateExtension (string extensionId, Extension body = null);
  
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> UpdateExtensionWithHttpInfo (string extensionId, Extension body = null);

        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> UpdateExtensionAsync (string extensionId, Extension body = null);

        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> UpdateExtensionAsyncWithHttpInfo (string extensionId, Extension body = null);
        
        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Organization</returns>
        Organization GetOrganization ();
  
        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetOrganizationWithHttpInfo ();

        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetOrganizationAsync ();

        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Organization</returns>
        Organization UpdateOrganization (Organization body = null);
  
        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> UpdateOrganizationWithHttpInfo (Organization body = null);

        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> UpdateOrganizationAsync (Organization body = null);

        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> UpdateOrganizationAsyncWithHttpInfo (Organization body = null);
        
        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Organization</returns>
        Organization CreateOrganizations (OrganizationCreate body = null);
  
        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> CreateOrganizationsWithHttpInfo (OrganizationCreate body = null);

        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> CreateOrganizationsAsync (OrganizationCreate body = null);

        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> CreateOrganizationsAsyncWithHttpInfo (OrganizationCreate body = null);
        
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Organization</returns>
        Organization GetOrganizationsOrg (string orgId);
  
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetOrganizationsOrgWithHttpInfo (string orgId);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetOrganizationsOrgAsync (string orgId);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationsOrgAsyncWithHttpInfo (string orgId);
        
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Organization</returns>
        Organization UpdateOrganizationsOrg (string orgId, Organization body = null);
  
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> UpdateOrganizationsOrgWithHttpInfo (string orgId, Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> UpdateOrganizationsOrgAsync (string orgId, Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> UpdateOrganizationsOrgAsyncWithHttpInfo (string orgId, Organization body = null);
        
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>string</returns>
        string DeleteOrganizationsOrg (string orgId);
  
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteOrganizationsOrgWithHttpInfo (string orgId);

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteOrganizationsOrgAsync (string orgId);

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteOrganizationsOrgAsyncWithHttpInfo (string orgId);
        
        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>EncryptionKeyEntityListing</returns>
        EncryptionKeyEntityListing GetRecordingkeys (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        ApiResponse<EncryptionKeyEntityListing> GetRecordingkeysWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        System.Threading.Tasks.Task<EncryptionKeyEntityListing> GetRecordingkeysAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> GetRecordingkeysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>EncryptionKey</returns>
        EncryptionKey CreateRecordingkeys ();
  
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of EncryptionKey</returns>
        ApiResponse<EncryptionKey> CreateRecordingkeysWithHttpInfo ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of EncryptionKey</returns>
        System.Threading.Tasks.Task<EncryptionKey> CreateRecordingkeysAsync ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> CreateRecordingkeysAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule GetRecordingkeysRotationschedule ();
  
        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> GetRecordingkeysRotationscheduleWithHttpInfo ();

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> GetRecordingkeysRotationscheduleAsync ();

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> GetRecordingkeysRotationscheduleAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule UpdateRecordingkeysRotationschedule (KeyRotationSchedule body = null);
  
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> UpdateRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body = null);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> UpdateRecordingkeysRotationscheduleAsync (KeyRotationSchedule body = null);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> UpdateRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body = null);
        
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>PolicyEntityListing</returns>
        PolicyEntityListing GetRetentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
  
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        ApiResponse<PolicyEntityListing> GetRetentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>Task of PolicyEntityListing</returns>
        System.Threading.Tasks.Task<PolicyEntityListing> GetRetentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetRetentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
        
        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy CreateRetentionpolicies (Policy body = null);
  
        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> CreateRetentionpoliciesWithHttpInfo (Policy body = null);

        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> CreateRetentionpoliciesAsync (Policy body = null);

        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> CreateRetentionpoliciesAsyncWithHttpInfo (Policy body = null);
        
        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <param name="ids"></param>
        /// <returns>string</returns>
        string DeleteRetentionpolicies (string ids);
  
        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteRetentionpoliciesWithHttpInfo (string ids);

        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteRetentionpoliciesAsync (string ids);

        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesAsyncWithHttpInfo (string ids);
        
        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Policy</returns>
        Policy GetRetentionpoliciesPolicy (string policyId);
  
        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> GetRetentionpoliciesPolicyWithHttpInfo (string policyId);

        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> GetRetentionpoliciesPolicyAsync (string policyId);

        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> GetRetentionpoliciesPolicyAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy UpdateRetentionpoliciesPolicy (string policyId, Policy body = null);
  
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> UpdateRetentionpoliciesPolicyWithHttpInfo (string policyId, Policy body = null);

        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> UpdateRetentionpoliciesPolicyAsync (string policyId, Policy body = null);

        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> UpdateRetentionpoliciesPolicyAsyncWithHttpInfo (string policyId, Policy body = null);
        
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>string</returns>
        string DeleteRetentionpoliciesPolicy (string policyId);
  
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteRetentionpoliciesPolicyWithHttpInfo (string policyId);

        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteRetentionpoliciesPolicyAsync (string policyId);

        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesPolicyAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PatchRetentionpoliciesPolicy (string policyId, Policy body = null);
  
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PatchRetentionpoliciesPolicyWithHttpInfo (string policyId, Policy body = null);

        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PatchRetentionpoliciesPolicyAsync (string policyId, Policy body = null);

        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRetentionpoliciesPolicyAsyncWithHttpInfo (string policyId, Policy body = null);
        
        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>SchemaCategoryEntityListing</returns>
        SchemaCategoryEntityListing GetSchemasEdgesVnext (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of SchemaCategoryEntityListing</returns>
        ApiResponse<SchemaCategoryEntityListing> GetSchemasEdgesVnextWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaCategoryEntityListing</returns>
        System.Threading.Tasks.Task<SchemaCategoryEntityListing> GetSchemasEdgesVnextAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaCategoryEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaCategoryEntityListing>> GetSchemasEdgesVnextAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>SchemaReferenceEntityListing</returns>
        SchemaReferenceEntityListing GetSchemasEdgesVnextSchemaCategory (string schemaCategory, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        ApiResponse<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemaCategoryWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemaCategoryAsync (string schemaCategory, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemaCategoryAsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>SchemaReferenceEntityListing</returns>
        SchemaReferenceEntityListing GetSchemasEdgesVnextSchemaCategoryBySchemaType (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        ApiResponse<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeAsync (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeAsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Organization</returns>
        Organization GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId (string schemaCategory, string schemaType, string schemaId);
  
        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId);

        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdAsync (string schemaCategory, string schemaType, string schemaId);

        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId);
        
        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Organization</returns>
        Organization GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
  
        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);

        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataIdAsync (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);

        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
        
        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>SiteEntityListing</returns>
        SiteEntityListing GetSites (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);
  
        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>ApiResponse of SiteEntityListing</returns>
        ApiResponse<SiteEntityListing> GetSitesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);

        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>Task of SiteEntityListing</returns>
        System.Threading.Tasks.Task<SiteEntityListing> GetSitesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);

        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>Task of ApiResponse (SiteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SiteEntityListing>> GetSitesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);
        
        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Site</param>
        /// <returns>Site</returns>
        Site CreateSites (Site body = null);
  
        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Site</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> CreateSitesWithHttpInfo (Site body = null);

        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> CreateSitesAsync (Site body = null);

        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> CreateSitesAsyncWithHttpInfo (Site body = null);
        
        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Site</returns>
        Site GetSite (string siteId);
  
        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> GetSiteWithHttpInfo (string siteId);

        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> GetSiteAsync (string siteId);

        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> GetSiteAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Site</returns>
        Site UpdateSite (string siteId, Site body = null);
  
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> UpdateSiteWithHttpInfo (string siteId, Site body = null);

        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> UpdateSiteAsync (string siteId, Site body = null);

        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> UpdateSiteAsyncWithHttpInfo (string siteId, Site body = null);
        
        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>string</returns>
        string DeleteSite (string siteId);
  
        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSiteWithHttpInfo (string siteId);

        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSiteAsync (string siteId);

        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSiteAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        List<NumberPlan> GetSiteNumberplans (string siteId);
  
        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        ApiResponse<List<NumberPlan>> GetSiteNumberplansWithHttpInfo (string siteId);

        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        System.Threading.Tasks.Task<List<NumberPlan>> GetSiteNumberplansAsync (string siteId);

        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> GetSiteNumberplansAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        List<NumberPlan> UpdateSiteNumberplans (string siteId, List<NumberPlan> body = null);
  
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        ApiResponse<List<NumberPlan>> UpdateSiteNumberplansWithHttpInfo (string siteId, List<NumberPlan> body = null);

        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        System.Threading.Tasks.Task<List<NumberPlan>> UpdateSiteNumberplansAsync (string siteId, List<NumberPlan> body = null);

        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> UpdateSiteNumberplansAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null);
        
        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetSiteNumberplansClassifications (string siteId, string classification = null);
  
        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetSiteNumberplansClassificationsWithHttpInfo (string siteId, string classification = null);

        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetSiteNumberplansClassificationsAsync (string siteId, string classification = null);

        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetSiteNumberplansClassificationsAsyncWithHttpInfo (string siteId, string classification = null);
        
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>NumberPlan</returns>
        NumberPlan GetSiteNumberplansByNumberPlanId (string siteId, string numberPlanId);
  
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>ApiResponse of NumberPlan</returns>
        ApiResponse<NumberPlan> GetSiteNumberplansByNumberPlanIdWithHttpInfo (string siteId, string numberPlanId);

        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of NumberPlan</returns>
        System.Threading.Tasks.Task<NumberPlan> GetSiteNumberplansByNumberPlanIdAsync (string siteId, string numberPlanId);

        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<NumberPlan>> GetSiteNumberplansByNumberPlanIdAsyncWithHttpInfo (string siteId, string numberPlanId);
        
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns></returns>
        void CreateSiteRebalance (string siteId);
  
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateSiteRebalanceWithHttpInfo (string siteId);

        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateSiteRebalanceAsync (string siteId);

        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateSiteRebalanceAsyncWithHttpInfo (string siteId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfigurationApi : IConfigurationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigurationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigurationApi(Configuration configuration = null)
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
        /// Get a listing of DID Pools 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>DIDPoolEntityListing</returns>
        public DIDPoolEntityListing GetDidpools (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<DIDPoolEntityListing> response = GetDidpoolsWithHttpInfo(pageSize, pageNumber, sortBy);
             return response.Data;
        }

        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of DIDPoolEntityListing</returns>
        public ApiResponse< DIDPoolEntityListing > GetDidpoolsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/configuration/didpools";
    
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
                throw new ApiException (statusCode, "Error calling GetDidpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidpools: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DIDPoolEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPoolEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DIDPoolEntityListing)));
            
        }
    
        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of DIDPoolEntityListing</returns>
        public async System.Threading.Tasks.Task<DIDPoolEntityListing> GetDidpoolsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<DIDPoolEntityListing> response = await GetDidpoolsAsyncWithHttpInfo(pageSize, pageNumber, sortBy);
             return response.Data;

        }

        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (DIDPoolEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPoolEntityListing>> GetDidpoolsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/configuration/didpools";
    
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
                throw new ApiException (statusCode, "Error calling GetDidpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidpools: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DIDPoolEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPoolEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DIDPoolEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>DIDPool</returns>
        public DIDPool CreateDidpools (DIDPool body = null)
        {
             ApiResponse<DIDPool> response = CreateDidpoolsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > CreateDidpoolsWithHttpInfo (DIDPool body = null)
        {
            
    
            var path_ = "/api/v1/configuration/didpools";
    
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
                throw new ApiException (statusCode, "Error calling CreateDidpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDidpools: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
    
        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> CreateDidpoolsAsync (DIDPool body = null)
        {
             ApiResponse<DIDPool> response = await CreateDidpoolsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> CreateDidpoolsAsyncWithHttpInfo (DIDPool body = null)
        {
            
    
            var path_ = "/api/v1/configuration/didpools";
    
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
                throw new ApiException (statusCode, "Error calling CreateDidpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDidpools: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
        
        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>DIDPool</returns>
        public DIDPool GetDidpoolsDPoolId (string didPoolId)
        {
             ApiResponse<DIDPool> response = GetDidpoolsDPoolIdWithHttpInfo(didPoolId);
             return response.Data;
        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > GetDidpoolsDPoolIdWithHttpInfo (string didPoolId)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling GetDidpoolsDPoolId");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDidpoolsDPoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidpoolsDPoolId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
    
        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> GetDidpoolsDPoolIdAsync (string didPoolId)
        {
             ApiResponse<DIDPool> response = await GetDidpoolsDPoolIdAsyncWithHttpInfo(didPoolId);
             return response.Data;

        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> GetDidpoolsDPoolIdAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling GetDidpoolsDPoolId");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDidpoolsDPoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidpoolsDPoolId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
        
        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <param name="body"></param> 
        /// <returns>DIDPool</returns>
        public DIDPool UpdateDidpoolsDPoolId (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> response = UpdateDidpoolsDPoolIdWithHttpInfo(didPoolId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > UpdateDidpoolsDPoolIdWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling UpdateDidpoolsDPoolId");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateDidpoolsDPoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDidpoolsDPoolId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
    
        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> UpdateDidpoolsDPoolIdAsync (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> response = await UpdateDidpoolsDPoolIdAsyncWithHttpInfo(didPoolId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> UpdateDidpoolsDPoolIdAsyncWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling UpdateDidpoolsDPoolId");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateDidpoolsDPoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDidpoolsDPoolId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
        
        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>string</returns>
        public string DeleteDidpoolsDPoolId (string didPoolId)
        {
             ApiResponse<string> response = DeleteDidpoolsDPoolIdWithHttpInfo(didPoolId);
             return response.Data;
        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteDidpoolsDPoolIdWithHttpInfo (string didPoolId)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling DeleteDidpoolsDPoolId");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteDidpoolsDPoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDidpoolsDPoolId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteDidpoolsDPoolIdAsync (string didPoolId)
        {
             ApiResponse<string> response = await DeleteDidpoolsDPoolIdAsyncWithHttpInfo(didPoolId);
             return response.Data;

        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteDidpoolsDPoolIdAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling DeleteDidpoolsDPoolId");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteDidpoolsDPoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDidpoolsDPoolId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="phoneNumber">Filter by phoneNumber</param> 
        /// <returns>DIDEntityListing</returns>
        public DIDEntityListing GetDids (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
             ApiResponse<DIDEntityListing> response = GetDidsWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="phoneNumber">Filter by phoneNumber</param> 
        /// <returns>ApiResponse of DIDEntityListing</returns>
        public ApiResponse< DIDEntityListing > GetDidsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
            
    
            var path_ = "/api/v1/configuration/dids";
    
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
            if (phoneNumber != null) queryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDids: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDids: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DIDEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DIDEntityListing)));
            
        }
    
        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>Task of DIDEntityListing</returns>
        public async System.Threading.Tasks.Task<DIDEntityListing> GetDidsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
             ApiResponse<DIDEntityListing> response = await GetDidsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>Task of ApiResponse (DIDEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDEntityListing>> GetDidsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
            
    
            var path_ = "/api/v1/configuration/dids";
    
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
            if (phoneNumber != null) queryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDids: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDids: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DIDEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DIDEntityListing)));
            
        }
        
        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param> 
        /// <returns>DID</returns>
        public DID GetDId (string didId)
        {
             ApiResponse<DID> response = GetDIdWithHttpInfo(didId);
             return response.Data;
        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param> 
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > GetDIdWithHttpInfo (string didId)
        {
            
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling GetDId");
            
    
            var path_ = "/api/v1/configuration/dids/{didId}";
    
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
            if (didId != null) pathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DID>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(response, typeof(DID)));
            
        }
    
        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        public async System.Threading.Tasks.Task<DID> GetDIdAsync (string didId)
        {
             ApiResponse<DID> response = await GetDIdAsyncWithHttpInfo(didId);
             return response.Data;

        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> GetDIdAsyncWithHttpInfo (string didId)
        {
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling GetDId");
            
    
            var path_ = "/api/v1/configuration/dids/{didId}";
    
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
            if (didId != null) pathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DID>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(response, typeof(DID)));
            
        }
        
        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param> 
        /// <param name="body"></param> 
        /// <returns>DID</returns>
        public DID UpdateDId (string didId, DID body = null)
        {
             ApiResponse<DID> response = UpdateDIdWithHttpInfo(didId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > UpdateDIdWithHttpInfo (string didId, DID body = null)
        {
            
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling UpdateDId");
            
    
            var path_ = "/api/v1/configuration/dids/{didId}";
    
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
            if (didId != null) pathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateDId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DID>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(response, typeof(DID)));
            
        }
    
        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DID</returns>
        public async System.Threading.Tasks.Task<DID> UpdateDIdAsync (string didId, DID body = null)
        {
             ApiResponse<DID> response = await UpdateDIdAsyncWithHttpInfo(didId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> UpdateDIdAsyncWithHttpInfo (string didId, DID body = null)
        {
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling UpdateDId");
            
    
            var path_ = "/api/v1/configuration/dids/{didId}";
    
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
            if (didId != null) pathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateDId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DID>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(response, typeof(DID)));
            
        }
        
        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>EdgeEntityListing</returns>
        public EdgeEntityListing GetEdges (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
             ApiResponse<EdgeEntityListing> response = GetEdgesWithHttpInfo(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy);
             return response.Data;
        }

        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of EdgeEntityListing</returns>
        public ApiResponse< EdgeEntityListing > GetEdgesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (siteId != null) queryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (edgeGroupId != null) queryParams.Add("edgeGroup.id", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdges: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdges: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EdgeEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EdgeEntityListing</returns>
        public async System.Threading.Tasks.Task<EdgeEntityListing> GetEdgesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
             ApiResponse<EdgeEntityListing> response = await GetEdgesAsyncWithHttpInfo(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy);
             return response.Data;

        }

        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EdgeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeEntityListing>> GetEdgesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (siteId != null) queryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (edgeGroupId != null) queryParams.Add("edgeGroup.id", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdges: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdges: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EdgeEntityListing)));
            
        }
        
        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <param name="body">Edge</param> 
        /// <returns>Edge</returns>
        public Edge CreateEdges (Edge body = null)
        {
             ApiResponse<Edge> response = CreateEdgesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <param name="body">Edge</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > CreateEdgesWithHttpInfo (Edge body = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges";
    
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
                throw new ApiException (statusCode, "Error calling CreateEdges: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdges: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Edge>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(response, typeof(Edge)));
            
        }
    
        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> CreateEdgesAsync (Edge body = null)
        {
             ApiResponse<Edge> response = await CreateEdgesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> CreateEdgesAsyncWithHttpInfo (Edge body = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges";
    
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
                throw new ApiException (statusCode, "Error calling CreateEdges: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdges: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Edge>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(response, typeof(Edge)));
            
        }
        
        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <returns>CertificateAuthorityEntityListing</returns>
        public CertificateAuthorityEntityListing GetEdgesCertificateauthorities ()
        {
             ApiResponse<CertificateAuthorityEntityListing> response = GetEdgesCertificateauthoritiesWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <returns>ApiResponse of CertificateAuthorityEntityListing</returns>
        public ApiResponse< CertificateAuthorityEntityListing > GetEdgesCertificateauthoritiesWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities";
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthorities: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthorities: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CertificateAuthorityEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CertificateAuthorityEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CertificateAuthorityEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <returns>Task of CertificateAuthorityEntityListing</returns>
        public async System.Threading.Tasks.Task<CertificateAuthorityEntityListing> GetEdgesCertificateauthoritiesAsync ()
        {
             ApiResponse<CertificateAuthorityEntityListing> response = await GetEdgesCertificateauthoritiesAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <returns>Task of ApiResponse (CertificateAuthorityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CertificateAuthorityEntityListing>> GetEdgesCertificateauthoritiesAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities";
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthorities: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthorities: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CertificateAuthorityEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CertificateAuthorityEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CertificateAuthorityEntityListing)));
            
        }
        
        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <param name="body">CertificateAuthority</param> 
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority CreateEdgesCertificateauthorities (DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = CreateEdgesCertificateauthoritiesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <param name="body">CertificateAuthority</param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > CreateEdgesCertificateauthoritiesWithHttpInfo (DomainCertificateAuthority body = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities";
    
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
                throw new ApiException (statusCode, "Error calling CreateEdgesCertificateauthorities: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgesCertificateauthorities: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
    
        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> CreateEdgesCertificateauthoritiesAsync (DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = await CreateEdgesCertificateauthoritiesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> CreateEdgesCertificateauthoritiesAsyncWithHttpInfo (DomainCertificateAuthority body = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities";
    
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
                throw new ApiException (statusCode, "Error calling CreateEdgesCertificateauthorities: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgesCertificateauthorities: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
        
        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority GetEdgesCertificateauthoritiesCertificate (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> response = GetEdgesCertificateauthoritiesCertificateWithHttpInfo(certificateId);
             return response.Data;
        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > GetEdgesCertificateauthoritiesCertificateWithHttpInfo (string certificateId)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling GetEdgesCertificateauthoritiesCertificate");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritiesCertificate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritiesCertificate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
    
        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> GetEdgesCertificateauthoritiesCertificateAsync (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> response = await GetEdgesCertificateauthoritiesCertificateAsyncWithHttpInfo(certificateId);
             return response.Data;

        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> GetEdgesCertificateauthoritiesCertificateAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling GetEdgesCertificateauthoritiesCertificate");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritiesCertificate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritiesCertificate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
        
        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <param name="body"></param> 
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority UpdateEdgesCertificateauthoritiesCertificate (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = UpdateEdgesCertificateauthoritiesCertificateWithHttpInfo(certificateId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > UpdateEdgesCertificateauthoritiesCertificateWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling UpdateEdgesCertificateauthoritiesCertificate");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEdgesCertificateauthoritiesCertificate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEdgesCertificateauthoritiesCertificate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
    
        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> UpdateEdgesCertificateauthoritiesCertificateAsync (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = await UpdateEdgesCertificateauthoritiesCertificateAsyncWithHttpInfo(certificateId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> UpdateEdgesCertificateauthoritiesCertificateAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling UpdateEdgesCertificateauthoritiesCertificate");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEdgesCertificateauthoritiesCertificate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEdgesCertificateauthoritiesCertificate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
        
        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>string</returns>
        public string DeleteEdgesCertificateauthoritiesCertificate (string certificateId)
        {
             ApiResponse<string> response = DeleteEdgesCertificateauthoritiesCertificateWithHttpInfo(certificateId);
             return response.Data;
        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgesCertificateauthoritiesCertificateWithHttpInfo (string certificateId)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling DeleteEdgesCertificateauthoritiesCertificate");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgesCertificateauthoritiesCertificateAsync (string certificateId)
        {
             ApiResponse<string> response = await DeleteEdgesCertificateauthoritiesCertificateAsyncWithHttpInfo(certificateId);
             return response.Data;

        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesCertificateauthoritiesCertificateAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling DeleteEdgesCertificateauthoritiesCertificate");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>Edge</returns>
        public Edge GetEdge (string edgeId)
        {
             ApiResponse<Edge> response = GetEdgeWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > GetEdgeWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdge: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Edge>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(response, typeof(Edge)));
            
        }
    
        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> GetEdgeAsync (string edgeId)
        {
             ApiResponse<Edge> response = await GetEdgeAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> GetEdgeAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdge: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Edge>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(response, typeof(Edge)));
            
        }
        
        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">Edge</param> 
        /// <returns>Edge</returns>
        public Edge UpdateEdge (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> response = UpdateEdgeWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">Edge</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > UpdateEdgeWithHttpInfo (string edgeId, Edge body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling UpdateEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEdge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEdge: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Edge>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(response, typeof(Edge)));
            
        }
    
        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> UpdateEdgeAsync (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> response = await UpdateEdgeAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> UpdateEdgeAsyncWithHttpInfo (string edgeId, Edge body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling UpdateEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEdge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEdge: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Edge>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(response, typeof(Edge)));
            
        }
        
        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string DeleteEdge (string edgeId)
        {
             ApiResponse<string> response = DeleteEdgeWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgeWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdge: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgeAsync (string edgeId)
        {
             ApiResponse<string> response = await DeleteEdgeAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgeAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdge: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>EdgeLineEntityListing</returns>
        public EdgeLineEntityListing GetEdgeLines (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EdgeLineEntityListing> response = GetEdgeLinesWithHttpInfo(edgeId, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of EdgeLineEntityListing</returns>
        public ApiResponse< EdgeLineEntityListing > GetEdgeLinesWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLines");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLines: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLines: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeLineEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLineEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EdgeLineEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EdgeLineEntityListing</returns>
        public async System.Threading.Tasks.Task<EdgeLineEntityListing> GetEdgeLinesAsync (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EdgeLineEntityListing> response = await GetEdgeLinesAsyncWithHttpInfo(edgeId, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EdgeLineEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLineEntityListing>> GetEdgeLinesAsyncWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLines");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLines: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLines: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeLineEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLineEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EdgeLineEntityListing)));
            
        }
        
        /// <summary>
        /// Get line 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <returns>EdgeLine</returns>
        public EdgeLine GetEdgeLinesByLineId (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> response = GetEdgeLinesByLineIdWithHttpInfo(edgeId, lineId);
             return response.Data;
        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > GetEdgeLinesByLineIdWithHttpInfo (string edgeId, string lineId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLinesByLineId");
            
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetEdgeLinesByLineId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) pathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLinesByLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLinesByLineId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeLine>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(response, typeof(EdgeLine)));
            
        }
    
        /// <summary>
        /// Get line 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of EdgeLine</returns>
        public async System.Threading.Tasks.Task<EdgeLine> GetEdgeLinesByLineIdAsync (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> response = await GetEdgeLinesByLineIdAsyncWithHttpInfo(edgeId, lineId);
             return response.Data;

        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> GetEdgeLinesByLineIdAsyncWithHttpInfo (string edgeId, string lineId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLinesByLineId");
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetEdgeLinesByLineId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) pathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLinesByLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLinesByLineId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeLine>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(response, typeof(EdgeLine)));
            
        }
        
        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <param name="body">Line</param> 
        /// <returns>EdgeLine</returns>
        public EdgeLine UpdateEdgeLinesByLineId (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> response = UpdateEdgeLinesByLineIdWithHttpInfo(edgeId, lineId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <param name="body">Line</param> 
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > UpdateEdgeLinesByLineIdWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling UpdateEdgeLinesByLineId");
            
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling UpdateEdgeLinesByLineId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) pathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEdgeLinesByLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEdgeLinesByLineId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeLine>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(response, typeof(EdgeLine)));
            
        }
    
        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of EdgeLine</returns>
        public async System.Threading.Tasks.Task<EdgeLine> UpdateEdgeLinesByLineIdAsync (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> response = await UpdateEdgeLinesByLineIdAsyncWithHttpInfo(edgeId, lineId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> UpdateEdgeLinesByLineIdAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling UpdateEdgeLinesByLineId");
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling UpdateEdgeLinesByLineId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) pathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEdgeLinesByLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEdgeLinesByLineId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeLine>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(response, typeof(EdgeLine)));
            
        }
        
        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>LogicalInterfaceEntityListing</returns>
        public LogicalInterfaceEntityListing GetEdgeLogicalinterfaces (string edgeId)
        {
             ApiResponse<LogicalInterfaceEntityListing> response = GetEdgeLogicalinterfacesWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of LogicalInterfaceEntityListing</returns>
        public ApiResponse< LogicalInterfaceEntityListing > GetEdgeLogicalinterfacesWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLogicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LogicalInterfaceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LogicalInterfaceEntityListing)));
            
        }
    
        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of LogicalInterfaceEntityListing</returns>
        public async System.Threading.Tasks.Task<LogicalInterfaceEntityListing> GetEdgeLogicalinterfacesAsync (string edgeId)
        {
             ApiResponse<LogicalInterfaceEntityListing> response = await GetEdgeLogicalinterfacesAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (LogicalInterfaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LogicalInterfaceEntityListing>> GetEdgeLogicalinterfacesAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLogicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LogicalInterfaceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LogicalInterfaceEntityListing)));
            
        }
        
        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>DomainLogicalInterface</returns>
        public DomainLogicalInterface CreateEdgeLogicalinterfaces (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = CreateEdgeLogicalinterfacesWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > CreateEdgeLogicalinterfacesWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling CreateEdgeLogicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CreateEdgeLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgeLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainLogicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainLogicalInterface)));
            
        }
    
        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainLogicalInterface> CreateEdgeLogicalinterfacesAsync (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = await CreateEdgeLogicalinterfacesAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> CreateEdgeLogicalinterfacesAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling CreateEdgeLogicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CreateEdgeLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgeLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainLogicalInterface)));
            
        }
        
        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>DomainLogicalInterface</returns>
        public DomainLogicalInterface GetEdgeLogicalinterfacesByInterfaceId (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> response = GetEdgeLogicalinterfacesByInterfaceIdWithHttpInfo(edgeId, interfaceId);
             return response.Data;
        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > GetEdgeLogicalinterfacesByInterfaceIdWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLogicalinterfacesByInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgeLogicalinterfacesByInterfaceId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterfacesByInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterfacesByInterfaceId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainLogicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainLogicalInterface)));
            
        }
    
        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainLogicalInterface> GetEdgeLogicalinterfacesByInterfaceIdAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> response = await GetEdgeLogicalinterfacesByInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId);
             return response.Data;

        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> GetEdgeLogicalinterfacesByInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLogicalinterfacesByInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgeLogicalinterfacesByInterfaceId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterfacesByInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterfacesByInterfaceId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainLogicalInterface)));
            
        }
        
        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <param name="body"></param> 
        /// <returns>DomainLogicalInterface</returns>
        public DomainLogicalInterface UpdateEdgeLogicalinterfacesByInterfaceId (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = UpdateEdgeLogicalinterfacesByInterfaceIdWithHttpInfo(edgeId, interfaceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > UpdateEdgeLogicalinterfacesByInterfaceIdWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling UpdateEdgeLogicalinterfacesByInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling UpdateEdgeLogicalinterfacesByInterfaceId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEdgeLogicalinterfacesByInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEdgeLogicalinterfacesByInterfaceId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainLogicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainLogicalInterface)));
            
        }
    
        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainLogicalInterface> UpdateEdgeLogicalinterfacesByInterfaceIdAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = await UpdateEdgeLogicalinterfacesByInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> UpdateEdgeLogicalinterfacesByInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling UpdateEdgeLogicalinterfacesByInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling UpdateEdgeLogicalinterfacesByInterfaceId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEdgeLogicalinterfacesByInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEdgeLogicalinterfacesByInterfaceId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainLogicalInterface)));
            
        }
        
        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns></returns>
        public void DeleteEdgeLogicalinterfacesByInterfaceId (string edgeId, string interfaceId)
        {
             DeleteEdgeLogicalinterfacesByInterfaceIdWithHttpInfo(edgeId, interfaceId);
        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteEdgeLogicalinterfacesByInterfaceIdWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgeLogicalinterfacesByInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling DeleteEdgeLogicalinterfacesByInterfaceId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdgeLogicalinterfacesByInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgeLogicalinterfacesByInterfaceId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteEdgeLogicalinterfacesByInterfaceIdAsync (string edgeId, string interfaceId)
        {
             await DeleteEdgeLogicalinterfacesByInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId);

        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEdgeLogicalinterfacesByInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgeLogicalinterfacesByInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling DeleteEdgeLogicalinterfacesByInterfaceId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdgeLogicalinterfacesByInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgeLogicalinterfacesByInterfaceId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>PhysicalInterfaceEntityListing</returns>
        public PhysicalInterfaceEntityListing GetEdgePhysicalinterfaces (string edgeId)
        {
             ApiResponse<PhysicalInterfaceEntityListing> response = GetEdgePhysicalinterfacesWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of PhysicalInterfaceEntityListing</returns>
        public ApiResponse< PhysicalInterfaceEntityListing > GetEdgePhysicalinterfacesWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgePhysicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhysicalInterfaceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhysicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhysicalInterfaceEntityListing)));
            
        }
    
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of PhysicalInterfaceEntityListing</returns>
        public async System.Threading.Tasks.Task<PhysicalInterfaceEntityListing> GetEdgePhysicalinterfacesAsync (string edgeId)
        {
             ApiResponse<PhysicalInterfaceEntityListing> response = await GetEdgePhysicalinterfacesAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (PhysicalInterfaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhysicalInterfaceEntityListing>> GetEdgePhysicalinterfacesAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgePhysicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhysicalInterfaceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhysicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhysicalInterfaceEntityListing)));
            
        }
        
        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>DomainPhysicalInterface</returns>
        public DomainPhysicalInterface GetEdgePhysicalinterfacesByInterfaceId (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> response = GetEdgePhysicalinterfacesByInterfaceIdWithHttpInfo(edgeId, interfaceId);
             return response.Data;
        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        public ApiResponse< DomainPhysicalInterface > GetEdgePhysicalinterfacesByInterfaceIdWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgePhysicalinterfacesByInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgePhysicalinterfacesByInterfaceId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterfacesByInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterfacesByInterfaceId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainPhysicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainPhysicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainPhysicalInterface)));
            
        }
    
        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainPhysicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainPhysicalInterface> GetEdgePhysicalinterfacesByInterfaceIdAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> response = await GetEdgePhysicalinterfacesByInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId);
             return response.Data;

        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> GetEdgePhysicalinterfacesByInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgePhysicalinterfacesByInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgePhysicalinterfacesByInterfaceId");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterfacesByInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterfacesByInterfaceId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainPhysicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainPhysicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainPhysicalInterface)));
            
        }
        
        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string CreateEdgeReboot (string edgeId)
        {
             ApiResponse<string> response = CreateEdgeRebootWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CreateEdgeRebootWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling CreateEdgeReboot");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/reboot";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateEdgeReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgeReboot: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CreateEdgeRebootAsync (string edgeId)
        {
             ApiResponse<string> response = await CreateEdgeRebootAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CreateEdgeRebootAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling CreateEdgeReboot");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/reboot";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateEdgeReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgeReboot: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        public DomainEdgeSoftwareUpdateDto GetEdgeSoftwareupdate (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> response = GetEdgeSoftwareupdateWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        public ApiResponse< DomainEdgeSoftwareUpdateDto > GetEdgeSoftwareupdateWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }
    
        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> GetEdgeSoftwareupdateAsync (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> response = await GetEdgeSoftwareupdateAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> GetEdgeSoftwareupdateAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }
        
        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void CreateEdgeSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             CreateEdgeSoftwareupdateWithHttpInfo(edgeId, body);
        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateEdgeSoftwareupdateWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling CreateEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CreateEdgeSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgeSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateEdgeSoftwareupdateAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             await CreateEdgeSoftwareupdateAsyncWithHttpInfo(edgeId, body);

        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateEdgeSoftwareupdateAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling CreateEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CreateEdgeSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgeSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string DeleteEdgeSoftwareupdate (string edgeId)
        {
             ApiResponse<string> response = DeleteEdgeSoftwareupdateWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgeSoftwareupdateWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdgeSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgeSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgeSoftwareupdateAsync (string edgeId)
        {
             ApiResponse<string> response = await DeleteEdgeSoftwareupdateAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgeSoftwareupdateAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdgeSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgeSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>DomainEdgeSoftwareVersionDto</returns>
        public DomainEdgeSoftwareVersionDto GetEdgeSoftwareversions (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareVersionDto> response = GetEdgeSoftwareversionsWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of DomainEdgeSoftwareVersionDto</returns>
        public ApiResponse< DomainEdgeSoftwareVersionDto > GetEdgeSoftwareversionsWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeSoftwareversions");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareversions";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeSoftwareversions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeSoftwareversions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEdgeSoftwareVersionDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareVersionDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareVersionDto)));
            
        }
    
        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareVersionDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareVersionDto> GetEdgeSoftwareversionsAsync (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareVersionDto> response = await GetEdgeSoftwareversionsAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareVersionDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareVersionDto>> GetEdgeSoftwareversionsAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeSoftwareversions");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareversions";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeSoftwareversions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeSoftwareversions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareVersionDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareVersionDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareVersionDto)));
            
        }
        
        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param> 
        /// <returns>string</returns>
        public string CreateEdgeUnpair (string edgeId)
        {
             ApiResponse<string> response = CreateEdgeUnpairWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CreateEdgeUnpairWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling CreateEdgeUnpair");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/unpair";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateEdgeUnpair: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgeUnpair: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CreateEdgeUnpairAsync (string edgeId)
        {
             ApiResponse<string> response = await CreateEdgeUnpairAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CreateEdgeUnpairAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling CreateEdgeUnpair");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/unpair";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateEdgeUnpair: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEdgeUnpair: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <returns>EdgeVersionReport</returns>
        public EdgeVersionReport GetEdgeversionreport ()
        {
             ApiResponse<EdgeVersionReport> response = GetEdgeversionreportWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <returns>ApiResponse of EdgeVersionReport</returns>
        public ApiResponse< EdgeVersionReport > GetEdgeversionreportWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/edgeversionreport";
    
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
                throw new ApiException (statusCode, "Error calling GetEdgeversionreport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeversionreport: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeVersionReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeVersionReport) Configuration.ApiClient.Deserialize(response, typeof(EdgeVersionReport)));
            
        }
    
        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <returns>Task of EdgeVersionReport</returns>
        public async System.Threading.Tasks.Task<EdgeVersionReport> GetEdgeversionreportAsync ()
        {
             ApiResponse<EdgeVersionReport> response = await GetEdgeversionreportAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <returns>Task of ApiResponse (EdgeVersionReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeVersionReport>> GetEdgeversionreportAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/edgeversionreport";
    
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
                throw new ApiException (statusCode, "Error calling GetEdgeversionreport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeversionreport: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeVersionReport>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeVersionReport) Configuration.ApiClient.Deserialize(response, typeof(EdgeVersionReport)));
            
        }
        
        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>EndpointEntityListing</returns>
        public EndpointEntityListing GetEndpoints (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EndpointEntityListing> response = GetEndpointsWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return response.Data;
        }

        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of EndpointEntityListing</returns>
        public ApiResponse< EndpointEntityListing > GetEndpointsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/configuration/endpoints";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEndpoints: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEndpoints: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EndpointEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EndpointEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EndpointEntityListing)));
            
        }
    
        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EndpointEntityListing</returns>
        public async System.Threading.Tasks.Task<EndpointEntityListing> GetEndpointsAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EndpointEntityListing> response = await GetEndpointsAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return response.Data;

        }

        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EndpointEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EndpointEntityListing>> GetEndpointsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/configuration/endpoints";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEndpoints: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEndpoints: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EndpointEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EndpointEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EndpointEntityListing)));
            
        }
        
        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>Endpoint</returns>
        public Endpoint CreateEndpoints (Endpoint body = null)
        {
             ApiResponse<Endpoint> response = CreateEndpointsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > CreateEndpointsWithHttpInfo (Endpoint body = null)
        {
            
    
            var path_ = "/api/v1/configuration/endpoints";
    
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
                throw new ApiException (statusCode, "Error calling CreateEndpoints: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEndpoints: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Endpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(response, typeof(Endpoint)));
            
        }
    
        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> CreateEndpointsAsync (Endpoint body = null)
        {
             ApiResponse<Endpoint> response = await CreateEndpointsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> CreateEndpointsAsyncWithHttpInfo (Endpoint body = null)
        {
            
    
            var path_ = "/api/v1/configuration/endpoints";
    
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
                throw new ApiException (statusCode, "Error calling CreateEndpoints: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEndpoints: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Endpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(response, typeof(Endpoint)));
            
        }
        
        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>Endpoint</returns>
        public Endpoint GetEndpoint (string endpointId)
        {
             ApiResponse<Endpoint> response = GetEndpointWithHttpInfo(endpointId);
             return response.Data;
        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > GetEndpointWithHttpInfo (string endpointId)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling GetEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEndpoint: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEndpoint: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Endpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(response, typeof(Endpoint)));
            
        }
    
        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> GetEndpointAsync (string endpointId)
        {
             ApiResponse<Endpoint> response = await GetEndpointAsyncWithHttpInfo(endpointId);
             return response.Data;

        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> GetEndpointAsyncWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling GetEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEndpoint: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEndpoint: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Endpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(response, typeof(Endpoint)));
            
        }
        
        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>Endpoint</returns>
        public Endpoint UpdateEndpoint (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> response = UpdateEndpointWithHttpInfo(endpointId, body);
             return response.Data;
        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > UpdateEndpointWithHttpInfo (string endpointId, Endpoint body = null)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling UpdateEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEndpoint: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEndpoint: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Endpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(response, typeof(Endpoint)));
            
        }
    
        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> UpdateEndpointAsync (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> response = await UpdateEndpointAsyncWithHttpInfo(endpointId, body);
             return response.Data;

        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> UpdateEndpointAsyncWithHttpInfo (string endpointId, Endpoint body = null)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling UpdateEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateEndpoint: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEndpoint: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Endpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(response, typeof(Endpoint)));
            
        }
        
        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>string</returns>
        public string DeleteEndpoint (string endpointId)
        {
             ApiResponse<string> response = DeleteEndpointWithHttpInfo(endpointId);
             return response.Data;
        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEndpointWithHttpInfo (string endpointId)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling DeleteEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEndpoint: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEndpoint: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEndpointAsync (string endpointId)
        {
             ApiResponse<string> response = await DeleteEndpointAsyncWithHttpInfo(endpointId);
             return response.Data;

        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEndpointAsyncWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling DeleteEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEndpoint: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEndpoint: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="number">Number</param> 
        /// <returns>ExtensionPoolEntityListing</returns>
        public ExtensionPoolEntityListing GetExtensionpools (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
             ApiResponse<ExtensionPoolEntityListing> response = GetExtensionpoolsWithHttpInfo(pageSize, pageNumber, sortBy, number);
             return response.Data;
        }

        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="number">Number</param> 
        /// <returns>ApiResponse of ExtensionPoolEntityListing</returns>
        public ApiResponse< ExtensionPoolEntityListing > GetExtensionpoolsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
            
    
            var path_ = "/api/v1/configuration/extensionpools";
    
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
            if (number != null) queryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetExtensionpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionpools: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExtensionPoolEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPoolEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPoolEntityListing)));
            
        }
    
        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>Task of ExtensionPoolEntityListing</returns>
        public async System.Threading.Tasks.Task<ExtensionPoolEntityListing> GetExtensionpoolsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
             ApiResponse<ExtensionPoolEntityListing> response = await GetExtensionpoolsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, number);
             return response.Data;

        }

        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>Task of ApiResponse (ExtensionPoolEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPoolEntityListing>> GetExtensionpoolsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
            
    
            var path_ = "/api/v1/configuration/extensionpools";
    
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
            if (number != null) queryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetExtensionpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionpools: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExtensionPoolEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPoolEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPoolEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <param name="body">ExtensionPool</param> 
        /// <returns>Extension</returns>
        public Extension CreateExtensionpools (ExtensionPool body = null)
        {
             ApiResponse<Extension> response = CreateExtensionpoolsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <param name="body">ExtensionPool</param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > CreateExtensionpoolsWithHttpInfo (ExtensionPool body = null)
        {
            
    
            var path_ = "/api/v1/configuration/extensionpools";
    
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
                throw new ApiException (statusCode, "Error calling CreateExtensionpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateExtensionpools: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
    
        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> CreateExtensionpoolsAsync (ExtensionPool body = null)
        {
             ApiResponse<Extension> response = await CreateExtensionpoolsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> CreateExtensionpoolsAsyncWithHttpInfo (ExtensionPool body = null)
        {
            
    
            var path_ = "/api/v1/configuration/extensionpools";
    
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
                throw new ApiException (statusCode, "Error calling CreateExtensionpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateExtensionpools: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
        
        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ExtensionPool</returns>
        public ExtensionPool GetExtensionPool (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> response = GetExtensionPoolWithHttpInfo(extensionPoolId);
             return response.Data;
        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > GetExtensionPoolWithHttpInfo (string extensionPoolId)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling GetExtensionPool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetExtensionPool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExtensionPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPool)));
            
        }
    
        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        public async System.Threading.Tasks.Task<ExtensionPool> GetExtensionPoolAsync (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> response = await GetExtensionPoolAsyncWithHttpInfo(extensionPoolId);
             return response.Data;

        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> GetExtensionPoolAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling GetExtensionPool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetExtensionPool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionPool: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExtensionPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPool)));
            
        }
        
        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <param name="body">ExtensionPool</param> 
        /// <returns>ExtensionPool</returns>
        public ExtensionPool UpdateExtensionPool (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> response = UpdateExtensionPoolWithHttpInfo(extensionPoolId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <param name="body">ExtensionPool</param> 
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > UpdateExtensionPoolWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling UpdateExtensionPool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateExtensionPool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateExtensionPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExtensionPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPool)));
            
        }
    
        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ExtensionPool</returns>
        public async System.Threading.Tasks.Task<ExtensionPool> UpdateExtensionPoolAsync (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> response = await UpdateExtensionPoolAsyncWithHttpInfo(extensionPoolId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> UpdateExtensionPoolAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling UpdateExtensionPool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateExtensionPool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateExtensionPool: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExtensionPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPool)));
            
        }
        
        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>string</returns>
        public string DeleteExtensionPool (string extensionPoolId)
        {
             ApiResponse<string> response = DeleteExtensionPoolWithHttpInfo(extensionPoolId);
             return response.Data;
        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteExtensionPoolWithHttpInfo (string extensionPoolId)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling DeleteExtensionPool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteExtensionPool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExtensionPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteExtensionPoolAsync (string extensionPoolId)
        {
             ApiResponse<string> response = await DeleteExtensionPoolAsyncWithHttpInfo(extensionPoolId);
             return response.Data;

        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteExtensionPoolAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling DeleteExtensionPool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteExtensionPool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExtensionPool: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="number">Filter by number</param> 
        /// <returns>ExtensionEntityListing</returns>
        public ExtensionEntityListing GetExtensions (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
             ApiResponse<ExtensionEntityListing> response = GetExtensionsWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, number);
             return response.Data;
        }

        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="number">Filter by number</param> 
        /// <returns>ApiResponse of ExtensionEntityListing</returns>
        public ApiResponse< ExtensionEntityListing > GetExtensionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
            
    
            var path_ = "/api/v1/configuration/extensions";
    
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
            if (number != null) queryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetExtensions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExtensionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ExtensionEntityListing)));
            
        }
    
        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>Task of ExtensionEntityListing</returns>
        public async System.Threading.Tasks.Task<ExtensionEntityListing> GetExtensionsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
             ApiResponse<ExtensionEntityListing> response = await GetExtensionsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, number);
             return response.Data;

        }

        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>Task of ApiResponse (ExtensionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionEntityListing>> GetExtensionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
            
    
            var path_ = "/api/v1/configuration/extensions";
    
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
            if (number != null) queryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetExtensions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExtensionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ExtensionEntityListing)));
            
        }
        
        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param> 
        /// <returns>Extension</returns>
        public Extension GetExtension (string extensionId)
        {
             ApiResponse<Extension> response = GetExtensionWithHttpInfo(extensionId);
             return response.Data;
        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > GetExtensionWithHttpInfo (string extensionId)
        {
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling GetExtension");
            
    
            var path_ = "/api/v1/configuration/extensions/{extensionId}";
    
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
            if (extensionId != null) pathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetExtension: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtension: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
    
        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> GetExtensionAsync (string extensionId)
        {
             ApiResponse<Extension> response = await GetExtensionAsyncWithHttpInfo(extensionId);
             return response.Data;

        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> GetExtensionAsyncWithHttpInfo (string extensionId)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling GetExtension");
            
    
            var path_ = "/api/v1/configuration/extensions/{extensionId}";
    
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
            if (extensionId != null) pathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetExtension: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtension: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
        
        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param> 
        /// <param name="body"></param> 
        /// <returns>Extension</returns>
        public Extension UpdateExtension (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> response = UpdateExtensionWithHttpInfo(extensionId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > UpdateExtensionWithHttpInfo (string extensionId, Extension body = null)
        {
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling UpdateExtension");
            
    
            var path_ = "/api/v1/configuration/extensions/{extensionId}";
    
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
            if (extensionId != null) pathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateExtension: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateExtension: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
    
        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> UpdateExtensionAsync (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> response = await UpdateExtensionAsyncWithHttpInfo(extensionId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> UpdateExtensionAsyncWithHttpInfo (string extensionId, Extension body = null)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling UpdateExtension");
            
    
            var path_ = "/api/v1/configuration/extensions/{extensionId}";
    
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
            if (extensionId != null) pathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateExtension: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateExtension: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
        
        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <returns>Organization</returns>
        public Organization GetOrganization ()
        {
             ApiResponse<Organization> response = GetOrganizationWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetOrganizationWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/organization";
    
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
                throw new ApiException (statusCode, "Error calling GetOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetOrganizationAsync ()
        {
             ApiResponse<Organization> response = await GetOrganizationAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/organization";
    
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
                throw new ApiException (statusCode, "Error calling GetOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>Organization</returns>
        public Organization UpdateOrganization (Organization body = null)
        {
             ApiResponse<Organization> response = UpdateOrganizationWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > UpdateOrganizationWithHttpInfo (Organization body = null)
        {
            
    
            var path_ = "/api/v1/configuration/organization";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> UpdateOrganizationAsync (Organization body = null)
        {
             ApiResponse<Organization> response = await UpdateOrganizationAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> UpdateOrganizationAsyncWithHttpInfo (Organization body = null)
        {
            
    
            var path_ = "/api/v1/configuration/organization";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>Organization</returns>
        public Organization CreateOrganizations (OrganizationCreate body = null)
        {
             ApiResponse<Organization> response = CreateOrganizationsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > CreateOrganizationsWithHttpInfo (OrganizationCreate body = null)
        {
            
    
            var path_ = "/api/v1/configuration/organizations";
    
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
                throw new ApiException (statusCode, "Error calling CreateOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateOrganizations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> CreateOrganizationsAsync (OrganizationCreate body = null)
        {
             ApiResponse<Organization> response = await CreateOrganizationsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> CreateOrganizationsAsyncWithHttpInfo (OrganizationCreate body = null)
        {
            
    
            var path_ = "/api/v1/configuration/organizations";
    
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
                throw new ApiException (statusCode, "Error calling CreateOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateOrganizations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>Organization</returns>
        public Organization GetOrganizationsOrg (string orgId)
        {
             ApiResponse<Organization> response = GetOrganizationsOrgWithHttpInfo(orgId);
             return response.Data;
        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetOrganizationsOrgWithHttpInfo (string orgId)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling GetOrganizationsOrg");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetOrganizationsOrg: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetOrganizationsOrgAsync (string orgId)
        {
             ApiResponse<Organization> response = await GetOrganizationsOrgAsyncWithHttpInfo(orgId);
             return response.Data;

        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationsOrgAsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling GetOrganizationsOrg");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetOrganizationsOrg: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsOrg: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <param name="body">Organization</param> 
        /// <returns>Organization</returns>
        public Organization UpdateOrganizationsOrg (string orgId, Organization body = null)
        {
             ApiResponse<Organization> response = UpdateOrganizationsOrgWithHttpInfo(orgId, body);
             return response.Data;
        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > UpdateOrganizationsOrgWithHttpInfo (string orgId, Organization body = null)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling UpdateOrganizationsOrg");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateOrganizationsOrg: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateOrganizationsOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> UpdateOrganizationsOrgAsync (string orgId, Organization body = null)
        {
             ApiResponse<Organization> response = await UpdateOrganizationsOrgAsyncWithHttpInfo(orgId, body);
             return response.Data;

        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> UpdateOrganizationsOrgAsyncWithHttpInfo (string orgId, Organization body = null)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling UpdateOrganizationsOrg");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateOrganizationsOrg: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateOrganizationsOrg: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>string</returns>
        public string DeleteOrganizationsOrg (string orgId)
        {
             ApiResponse<string> response = DeleteOrganizationsOrgWithHttpInfo(orgId);
             return response.Data;
        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteOrganizationsOrgWithHttpInfo (string orgId)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling DeleteOrganizationsOrg");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsOrg: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteOrganizationsOrgAsync (string orgId)
        {
             ApiResponse<string> response = await DeleteOrganizationsOrgAsyncWithHttpInfo(orgId);
             return response.Data;

        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteOrganizationsOrgAsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling DeleteOrganizationsOrg");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsOrg: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsOrg: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>EncryptionKeyEntityListing</returns>
        public EncryptionKeyEntityListing GetRecordingkeys (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> response = GetRecordingkeysWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        public ApiResponse< EncryptionKeyEntityListing > GetRecordingkeysWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys";
    
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
                throw new ApiException (statusCode, "Error calling GetRecordingkeys: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRecordingkeys: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EncryptionKeyEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKeyEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EncryptionKeyEntityListing)));
            
        }
    
        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        public async System.Threading.Tasks.Task<EncryptionKeyEntityListing> GetRecordingkeysAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> response = await GetRecordingkeysAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> GetRecordingkeysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys";
    
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
                throw new ApiException (statusCode, "Error calling GetRecordingkeys: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRecordingkeys: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EncryptionKeyEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKeyEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EncryptionKeyEntityListing)));
            
        }
        
        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <returns>EncryptionKey</returns>
        public EncryptionKey CreateRecordingkeys ()
        {
             ApiResponse<EncryptionKey> response = CreateRecordingkeysWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <returns>ApiResponse of EncryptionKey</returns>
        public ApiResponse< EncryptionKey > CreateRecordingkeysWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateRecordingkeys: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRecordingkeys: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EncryptionKey>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(response, typeof(EncryptionKey)));
            
        }
    
        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <returns>Task of EncryptionKey</returns>
        public async System.Threading.Tasks.Task<EncryptionKey> CreateRecordingkeysAsync ()
        {
             ApiResponse<EncryptionKey> response = await CreateRecordingkeysAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> CreateRecordingkeysAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateRecordingkeys: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRecordingkeys: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EncryptionKey>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(response, typeof(EncryptionKey)));
            
        }
        
        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule GetRecordingkeysRotationschedule ()
        {
             ApiResponse<KeyRotationSchedule> response = GetRecordingkeysRotationscheduleWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > GetRecordingkeysRotationscheduleWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys/rotationschedule";
    
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
                throw new ApiException (statusCode, "Error calling GetRecordingkeysRotationschedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRecordingkeysRotationschedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<KeyRotationSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(response, typeof(KeyRotationSchedule)));
            
        }
    
        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> GetRecordingkeysRotationscheduleAsync ()
        {
             ApiResponse<KeyRotationSchedule> response = await GetRecordingkeysRotationscheduleAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> GetRecordingkeysRotationscheduleAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys/rotationschedule";
    
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
                throw new ApiException (statusCode, "Error calling GetRecordingkeysRotationschedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRecordingkeysRotationschedule: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(response, typeof(KeyRotationSchedule)));
            
        }
        
        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <param name="body">KeyRotationSchedule</param> 
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule UpdateRecordingkeysRotationschedule (KeyRotationSchedule body = null)
        {
             ApiResponse<KeyRotationSchedule> response = UpdateRecordingkeysRotationscheduleWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <param name="body">KeyRotationSchedule</param> 
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > UpdateRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body = null)
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys/rotationschedule";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateRecordingkeysRotationschedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRecordingkeysRotationschedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<KeyRotationSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(response, typeof(KeyRotationSchedule)));
            
        }
    
        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> UpdateRecordingkeysRotationscheduleAsync (KeyRotationSchedule body = null)
        {
             ApiResponse<KeyRotationSchedule> response = await UpdateRecordingkeysRotationscheduleAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> UpdateRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body = null)
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys/rotationschedule";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateRecordingkeysRotationschedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRecordingkeysRotationschedule: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(response, typeof(KeyRotationSchedule)));
            
        }
        
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="name">the policy name - used for filtering results in searches.</param> 
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param> 
        /// <param name="summary">provides a less verbose response of policy lists.</param> 
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param> 
        /// <returns>PolicyEntityListing</returns>
        public PolicyEntityListing GetRetentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> response = GetRetentionpoliciesWithHttpInfo(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
             return response.Data;
        }

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="name">the policy name - used for filtering results in searches.</param> 
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param> 
        /// <param name="summary">provides a less verbose response of policy lists.</param> 
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param> 
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        public ApiResponse< PolicyEntityListing > GetRetentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
            
    
            var path_ = "/api/v1/configuration/retentionpolicies";
    
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
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            if (summary != null) queryParams.Add("summary", Configuration.ApiClient.ParameterToString(summary)); // query parameter
            if (hasErrors != null) queryParams.Add("hasErrors", Configuration.ApiClient.ParameterToString(hasErrors)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRetentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRetentionpolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PolicyEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PolicyEntityListing)));
            
        }
    
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>Task of PolicyEntityListing</returns>
        public async System.Threading.Tasks.Task<PolicyEntityListing> GetRetentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> response = await GetRetentionpoliciesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
             return response.Data;

        }

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetRetentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
            
    
            var path_ = "/api/v1/configuration/retentionpolicies";
    
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
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            if (summary != null) queryParams.Add("summary", Configuration.ApiClient.ParameterToString(summary)); // query parameter
            if (hasErrors != null) queryParams.Add("hasErrors", Configuration.ApiClient.ParameterToString(hasErrors)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRetentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRetentionpolicies: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PolicyEntityListing)));
            
        }
        
        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <param name="body">Policy</param> 
        /// <returns>Policy</returns>
        public Policy CreateRetentionpolicies (Policy body = null)
        {
             ApiResponse<Policy> response = CreateRetentionpoliciesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > CreateRetentionpoliciesWithHttpInfo (Policy body = null)
        {
            
    
            var path_ = "/api/v1/configuration/retentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling CreateRetentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRetentionpolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> CreateRetentionpoliciesAsync (Policy body = null)
        {
             ApiResponse<Policy> response = await CreateRetentionpoliciesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> CreateRetentionpoliciesAsyncWithHttpInfo (Policy body = null)
        {
            
    
            var path_ = "/api/v1/configuration/retentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling CreateRetentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRetentionpolicies: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <param name="ids"></param> 
        /// <returns>string</returns>
        public string DeleteRetentionpolicies (string ids)
        {
             ApiResponse<string> response = DeleteRetentionpoliciesWithHttpInfo(ids);
             return response.Data;
        }

        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <param name="ids"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteRetentionpoliciesWithHttpInfo (string ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling DeleteRetentionpolicies");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies";
    
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
            
            if (ids != null) queryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteRetentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRetentionpolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteRetentionpoliciesAsync (string ids)
        {
             ApiResponse<string> response = await DeleteRetentionpoliciesAsyncWithHttpInfo(ids);
             return response.Data;

        }

        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesAsyncWithHttpInfo (string ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling DeleteRetentionpolicies");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies";
    
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
            
            if (ids != null) queryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteRetentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRetentionpolicies: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>Policy</returns>
        public Policy GetRetentionpoliciesPolicy (string policyId)
        {
             ApiResponse<Policy> response = GetRetentionpoliciesPolicyWithHttpInfo(policyId);
             return response.Data;
        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > GetRetentionpoliciesPolicyWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling GetRetentionpoliciesPolicy");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRetentionpoliciesPolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRetentionpoliciesPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> GetRetentionpoliciesPolicyAsync (string policyId)
        {
             ApiResponse<Policy> response = await GetRetentionpoliciesPolicyAsyncWithHttpInfo(policyId);
             return response.Data;

        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> GetRetentionpoliciesPolicyAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling GetRetentionpoliciesPolicy");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRetentionpoliciesPolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRetentionpoliciesPolicy: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Update policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>Policy</returns>
        public Policy UpdateRetentionpoliciesPolicy (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = UpdateRetentionpoliciesPolicyWithHttpInfo(policyId, body);
             return response.Data;
        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > UpdateRetentionpoliciesPolicyWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling UpdateRetentionpoliciesPolicy");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateRetentionpoliciesPolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRetentionpoliciesPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Update policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> UpdateRetentionpoliciesPolicyAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = await UpdateRetentionpoliciesPolicyAsyncWithHttpInfo(policyId, body);
             return response.Data;

        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> UpdateRetentionpoliciesPolicyAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling UpdateRetentionpoliciesPolicy");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateRetentionpoliciesPolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRetentionpoliciesPolicy: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>string</returns>
        public string DeleteRetentionpoliciesPolicy (string policyId)
        {
             ApiResponse<string> response = DeleteRetentionpoliciesPolicyWithHttpInfo(policyId);
             return response.Data;
        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteRetentionpoliciesPolicyWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling DeleteRetentionpoliciesPolicy");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteRetentionpoliciesPolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRetentionpoliciesPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteRetentionpoliciesPolicyAsync (string policyId)
        {
             ApiResponse<string> response = await DeleteRetentionpoliciesPolicyAsyncWithHttpInfo(policyId);
             return response.Data;

        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesPolicyAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling DeleteRetentionpoliciesPolicy");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteRetentionpoliciesPolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRetentionpoliciesPolicy: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>Policy</returns>
        public Policy PatchRetentionpoliciesPolicy (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = PatchRetentionpoliciesPolicyWithHttpInfo(policyId, body);
             return response.Data;
        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PatchRetentionpoliciesPolicyWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PatchRetentionpoliciesPolicy");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchRetentionpoliciesPolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchRetentionpoliciesPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PatchRetentionpoliciesPolicyAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = await PatchRetentionpoliciesPolicyAsyncWithHttpInfo(policyId, body);
             return response.Data;

        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRetentionpoliciesPolicyAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PatchRetentionpoliciesPolicy");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchRetentionpoliciesPolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchRetentionpoliciesPolicy: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>SchemaCategoryEntityListing</returns>
        public SchemaCategoryEntityListing GetSchemasEdgesVnext (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaCategoryEntityListing> response = GetSchemasEdgesVnextWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of SchemaCategoryEntityListing</returns>
        public ApiResponse< SchemaCategoryEntityListing > GetSchemasEdgesVnextWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext";
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SchemaCategoryEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaCategoryEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SchemaCategoryEntityListing)));
            
        }
    
        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaCategoryEntityListing</returns>
        public async System.Threading.Tasks.Task<SchemaCategoryEntityListing> GetSchemasEdgesVnextAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaCategoryEntityListing> response = await GetSchemasEdgesVnextAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaCategoryEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaCategoryEntityListing>> GetSchemasEdgesVnextAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext";
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SchemaCategoryEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaCategoryEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SchemaCategoryEntityListing)));
            
        }
        
        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>SchemaReferenceEntityListing</returns>
        public SchemaReferenceEntityListing GetSchemasEdgesVnextSchemaCategory (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = GetSchemasEdgesVnextSchemaCategoryWithHttpInfo(schemaCategory, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        public ApiResponse< SchemaReferenceEntityListing > GetSchemasEdgesVnextSchemaCategoryWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemaCategory");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}";
    
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
            if (schemaCategory != null) pathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategory: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SchemaReferenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SchemaReferenceEntityListing)));
            
        }
    
        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemaCategoryAsync (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = await GetSchemasEdgesVnextSchemaCategoryAsyncWithHttpInfo(schemaCategory, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemaCategoryAsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemaCategory");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}";
    
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
            if (schemaCategory != null) pathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategory: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategory: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SchemaReferenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SchemaReferenceEntityListing)));
            
        }
        
        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>SchemaReferenceEntityListing</returns>
        public SchemaReferenceEntityListing GetSchemasEdgesVnextSchemaCategoryBySchemaType (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = GetSchemasEdgesVnextSchemaCategoryBySchemaTypeWithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        public ApiResponse< SchemaReferenceEntityListing > GetSchemasEdgesVnextSchemaCategoryBySchemaTypeWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaType");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaType");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}";
    
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
            if (schemaCategory != null) pathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) pathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaType: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaType: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SchemaReferenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SchemaReferenceEntityListing)));
            
        }
    
        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeAsync (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = await GetSchemasEdgesVnextSchemaCategoryBySchemaTypeAsyncWithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeAsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaType");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaType");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}";
    
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
            if (schemaCategory != null) pathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) pathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaType: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaType: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SchemaReferenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SchemaReferenceEntityListing)));
            
        }
        
        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <returns>Organization</returns>
        public Organization GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> response = GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdWithHttpInfo(schemaCategory, schemaType, schemaId);
             return response.Data;
        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId");
            
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}";
    
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
            if (schemaCategory != null) pathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) pathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) pathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdAsync (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> response = await GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdAsyncWithHttpInfo(schemaCategory, schemaType, schemaId);
             return response.Data;

        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}";
    
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
            if (schemaCategory != null) pathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) pathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) pathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <param name="extension">extension</param> 
        /// <param name="metadataId">Metadata ID</param> 
        /// <param name="type">Type</param> 
        /// <returns>Organization</returns>
        public Organization GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> response = GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataIdWithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
             return response.Data;
        }

        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <param name="extension">extension</param> 
        /// <param name="metadataId">Metadata ID</param> 
        /// <param name="type">Type</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            
            // verify the required parameter 'extension' is set
            if (extension == null) throw new ApiException(400, "Missing required parameter 'extension' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            
            // verify the required parameter 'metadataId' is set
            if (metadataId == null) throw new ApiException(400, "Missing required parameter 'metadataId' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId}";
    
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
            if (schemaCategory != null) pathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) pathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) pathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            if (extension != null) pathParams.Add("extension", Configuration.ApiClient.ParameterToString(extension)); // path parameter
            if (metadataId != null) pathParams.Add("metadataId", Configuration.ApiClient.ParameterToString(metadataId)); // path parameter
            
            if (type != null) queryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataIdAsync (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> response = await GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataIdAsyncWithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
             return response.Data;

        }

        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            // verify the required parameter 'extension' is set
            if (extension == null) throw new ApiException(400, "Missing required parameter 'extension' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            // verify the required parameter 'metadataId' is set
            if (metadataId == null) throw new ApiException(400, "Missing required parameter 'metadataId' when calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId}";
    
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
            if (schemaCategory != null) pathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) pathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) pathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            if (extension != null) pathParams.Add("extension", Configuration.ApiClient.ParameterToString(extension)); // path parameter
            if (metadataId != null) pathParams.Add("metadataId", Configuration.ApiClient.ParameterToString(metadataId)); // path parameter
            
            if (type != null) queryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemaCategoryBySchemaTypeBySchemaIdByExtensionByMetadataId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="name">Name</param> 
        /// <param name="locationId">Location Id</param> 
        /// <returns>SiteEntityListing</returns>
        public SiteEntityListing GetSites (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
             ApiResponse<SiteEntityListing> response = GetSitesWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, name, locationId);
             return response.Data;
        }

        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="name">Name</param> 
        /// <param name="locationId">Location Id</param> 
        /// <returns>ApiResponse of SiteEntityListing</returns>
        public ApiResponse< SiteEntityListing > GetSitesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
            
    
            var path_ = "/api/v1/configuration/sites";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (locationId != null) queryParams.Add("location.id", Configuration.ApiClient.ParameterToString(locationId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSites: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSites: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SiteEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SiteEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SiteEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>Task of SiteEntityListing</returns>
        public async System.Threading.Tasks.Task<SiteEntityListing> GetSitesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
             ApiResponse<SiteEntityListing> response = await GetSitesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, name, locationId);
             return response.Data;

        }

        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>Task of ApiResponse (SiteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SiteEntityListing>> GetSitesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
            
    
            var path_ = "/api/v1/configuration/sites";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (locationId != null) queryParams.Add("location.id", Configuration.ApiClient.ParameterToString(locationId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSites: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSites: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SiteEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SiteEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SiteEntityListing)));
            
        }
        
        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <param name="body">Site</param> 
        /// <returns>Site</returns>
        public Site CreateSites (Site body = null)
        {
             ApiResponse<Site> response = CreateSitesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <param name="body">Site</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > CreateSitesWithHttpInfo (Site body = null)
        {
            
    
            var path_ = "/api/v1/configuration/sites";
    
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
                throw new ApiException (statusCode, "Error calling CreateSites: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateSites: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Site>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(response, typeof(Site)));
            
        }
    
        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> CreateSitesAsync (Site body = null)
        {
             ApiResponse<Site> response = await CreateSitesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> CreateSitesAsyncWithHttpInfo (Site body = null)
        {
            
    
            var path_ = "/api/v1/configuration/sites";
    
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
                throw new ApiException (statusCode, "Error calling CreateSites: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateSites: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Site>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(response, typeof(Site)));
            
        }
        
        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>Site</returns>
        public Site GetSite (string siteId)
        {
             ApiResponse<Site> response = GetSiteWithHttpInfo(siteId);
             return response.Data;
        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > GetSiteWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSite: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSite: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Site>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(response, typeof(Site)));
            
        }
    
        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> GetSiteAsync (string siteId)
        {
             ApiResponse<Site> response = await GetSiteAsyncWithHttpInfo(siteId);
             return response.Data;

        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> GetSiteAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSite: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSite: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Site>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(response, typeof(Site)));
            
        }
        
        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body">Site</param> 
        /// <returns>Site</returns>
        public Site UpdateSite (string siteId, Site body = null)
        {
             ApiResponse<Site> response = UpdateSiteWithHttpInfo(siteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body">Site</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > UpdateSiteWithHttpInfo (string siteId, Site body = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling UpdateSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateSite: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateSite: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Site>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(response, typeof(Site)));
            
        }
    
        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> UpdateSiteAsync (string siteId, Site body = null)
        {
             ApiResponse<Site> response = await UpdateSiteAsyncWithHttpInfo(siteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> UpdateSiteAsyncWithHttpInfo (string siteId, Site body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling UpdateSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateSite: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateSite: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Site>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(response, typeof(Site)));
            
        }
        
        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>string</returns>
        public string DeleteSite (string siteId)
        {
             ApiResponse<string> response = DeleteSiteWithHttpInfo(siteId);
             return response.Data;
        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSiteWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling DeleteSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteSite: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSite: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSiteAsync (string siteId)
        {
             ApiResponse<string> response = await DeleteSiteAsyncWithHttpInfo(siteId);
             return response.Data;

        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSiteAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling DeleteSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteSite: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSite: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>List&lt;NumberPlan&gt;</returns>
        public List<NumberPlan> GetSiteNumberplans (string siteId)
        {
             ApiResponse<List<NumberPlan>> response = GetSiteNumberplansWithHttpInfo(siteId);
             return response.Data;
        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        public ApiResponse< List<NumberPlan> > GetSiteNumberplansWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSiteNumberplans");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSiteNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSiteNumberplans: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<NumberPlan>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(response, typeof(List<NumberPlan>)));
            
        }
    
        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<NumberPlan>> GetSiteNumberplansAsync (string siteId)
        {
             ApiResponse<List<NumberPlan>> response = await GetSiteNumberplansAsyncWithHttpInfo(siteId);
             return response.Data;

        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> GetSiteNumberplansAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSiteNumberplans");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSiteNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSiteNumberplans: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<NumberPlan>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(response, typeof(List<NumberPlan>)));
            
        }
        
        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body"></param> 
        /// <returns>List&lt;NumberPlan&gt;</returns>
        public List<NumberPlan> UpdateSiteNumberplans (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> response = UpdateSiteNumberplansWithHttpInfo(siteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        public ApiResponse< List<NumberPlan> > UpdateSiteNumberplansWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling UpdateSiteNumberplans");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateSiteNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateSiteNumberplans: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<NumberPlan>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(response, typeof(List<NumberPlan>)));
            
        }
    
        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<NumberPlan>> UpdateSiteNumberplansAsync (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> response = await UpdateSiteNumberplansAsyncWithHttpInfo(siteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> UpdateSiteNumberplansAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling UpdateSiteNumberplans");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateSiteNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateSiteNumberplans: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<NumberPlan>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(response, typeof(List<NumberPlan>)));
            
        }
        
        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="classification">Classification</param> 
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetSiteNumberplansClassifications (string siteId, string classification = null)
        {
             ApiResponse<List<string>> response = GetSiteNumberplansClassificationsWithHttpInfo(siteId, classification);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="classification">Classification</param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > GetSiteNumberplansClassificationsWithHttpInfo (string siteId, string classification = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSiteNumberplansClassifications");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans/classifications";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            if (classification != null) queryParams.Add("classification", Configuration.ApiClient.ParameterToString(classification)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSiteNumberplansClassifications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSiteNumberplansClassifications: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetSiteNumberplansClassificationsAsync (string siteId, string classification = null)
        {
             ApiResponse<List<string>> response = await GetSiteNumberplansClassificationsAsyncWithHttpInfo(siteId, classification);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> GetSiteNumberplansClassificationsAsyncWithHttpInfo (string siteId, string classification = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSiteNumberplansClassifications");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans/classifications";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            if (classification != null) queryParams.Add("classification", Configuration.ApiClient.ParameterToString(classification)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSiteNumberplansClassifications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSiteNumberplansClassifications: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="numberPlanId">Number Plan ID</param> 
        /// <returns>NumberPlan</returns>
        public NumberPlan GetSiteNumberplansByNumberPlanId (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> response = GetSiteNumberplansByNumberPlanIdWithHttpInfo(siteId, numberPlanId);
             return response.Data;
        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="numberPlanId">Number Plan ID</param> 
        /// <returns>ApiResponse of NumberPlan</returns>
        public ApiResponse< NumberPlan > GetSiteNumberplansByNumberPlanIdWithHttpInfo (string siteId, string numberPlanId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSiteNumberplansByNumberPlanId");
            
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null) throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling GetSiteNumberplansByNumberPlanId");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans/{numberPlanId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (numberPlanId != null) pathParams.Add("numberPlanId", Configuration.ApiClient.ParameterToString(numberPlanId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSiteNumberplansByNumberPlanId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSiteNumberplansByNumberPlanId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<NumberPlan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NumberPlan) Configuration.ApiClient.Deserialize(response, typeof(NumberPlan)));
            
        }
    
        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of NumberPlan</returns>
        public async System.Threading.Tasks.Task<NumberPlan> GetSiteNumberplansByNumberPlanIdAsync (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> response = await GetSiteNumberplansByNumberPlanIdAsyncWithHttpInfo(siteId, numberPlanId);
             return response.Data;

        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NumberPlan>> GetSiteNumberplansByNumberPlanIdAsyncWithHttpInfo (string siteId, string numberPlanId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSiteNumberplansByNumberPlanId");
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null) throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling GetSiteNumberplansByNumberPlanId");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans/{numberPlanId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (numberPlanId != null) pathParams.Add("numberPlanId", Configuration.ApiClient.ParameterToString(numberPlanId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSiteNumberplansByNumberPlanId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSiteNumberplansByNumberPlanId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<NumberPlan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NumberPlan) Configuration.ApiClient.Deserialize(response, typeof(NumberPlan)));
            
        }
        
        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns></returns>
        public void CreateSiteRebalance (string siteId)
        {
             CreateSiteRebalanceWithHttpInfo(siteId);
        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateSiteRebalanceWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling CreateSiteRebalance");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/rebalance";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateSiteRebalance: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateSiteRebalance: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateSiteRebalanceAsync (string siteId)
        {
             await CreateSiteRebalanceAsyncWithHttpInfo(siteId);

        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateSiteRebalanceAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling CreateSiteRebalance");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/rebalance";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateSiteRebalance: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateSiteRebalance: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
