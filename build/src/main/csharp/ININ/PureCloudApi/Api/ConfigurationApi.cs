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
        DIDPool PostDidpools (DIDPool body = null);
  
        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> PostDidpoolsWithHttpInfo (DIDPool body = null);

        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> PostDidpoolsAsync (DIDPool body = null);

        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> PostDidpoolsAsyncWithHttpInfo (DIDPool body = null);
        
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>DIDPool</returns>
        DIDPool GetDidpool (string didPoolId);
  
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> GetDidpoolWithHttpInfo (string didPoolId);

        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> GetDidpoolAsync (string didPoolId);

        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> GetDidpoolAsyncWithHttpInfo (string didPoolId);
        
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>DIDPool</returns>
        DIDPool PutDidpool (string didPoolId, DIDPool body = null);
  
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> PutDidpoolWithHttpInfo (string didPoolId, DIDPool body = null);

        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> PutDidpoolAsync (string didPoolId, DIDPool body = null);

        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> PutDidpoolAsyncWithHttpInfo (string didPoolId, DIDPool body = null);
        
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>string</returns>
        string DeleteDidpool (string didPoolId);
  
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteDidpoolWithHttpInfo (string didPoolId);

        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteDidpoolAsync (string didPoolId);

        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteDidpoolAsyncWithHttpInfo (string didPoolId);
        
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
        DID GetDid (string didId);
  
        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> GetDidWithHttpInfo (string didId);

        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> GetDidAsync (string didId);

        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> GetDidAsyncWithHttpInfo (string didId);
        
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>DID</returns>
        DID PutDid (string didId, DID body = null);
  
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> PutDidWithHttpInfo (string didId, DID body = null);

        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> PutDidAsync (string didId, DID body = null);

        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> PutDidAsyncWithHttpInfo (string didId, DID body = null);
        
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
        Edge PostEdges (Edge body = null);
  
        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Edge</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> PostEdgesWithHttpInfo (Edge body = null);

        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> PostEdgesAsync (Edge body = null);

        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> PostEdgesAsyncWithHttpInfo (Edge body = null);
        
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
        DomainCertificateAuthority PostEdgesCertificateauthorities (DomainCertificateAuthority body = null);
  
        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> PostEdgesCertificateauthoritiesWithHttpInfo (DomainCertificateAuthority body = null);

        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> PostEdgesCertificateauthoritiesAsync (DomainCertificateAuthority body = null);

        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PostEdgesCertificateauthoritiesAsyncWithHttpInfo (DomainCertificateAuthority body = null);
        
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority GetEdgesCertificateauthoritie (string certificateId);
  
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> GetEdgesCertificateauthoritieWithHttpInfo (string certificateId);

        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> GetEdgesCertificateauthoritieAsync (string certificateId);

        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> GetEdgesCertificateauthoritieAsyncWithHttpInfo (string certificateId);
        
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority PutEdgesCertificateauthoritie (string certificateId, DomainCertificateAuthority body = null);
  
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> PutEdgesCertificateauthoritieWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);

        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> PutEdgesCertificateauthoritieAsync (string certificateId, DomainCertificateAuthority body = null);

        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PutEdgesCertificateauthoritieAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);
        
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>string</returns>
        string DeleteEdgesCertificateauthoritie (string certificateId);
  
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgesCertificateauthoritieWithHttpInfo (string certificateId);

        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgesCertificateauthoritieAsync (string certificateId);

        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesCertificateauthoritieAsyncWithHttpInfo (string certificateId);
        
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
        Edge PutEdge (string edgeId, Edge body = null);
  
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> PutEdgeWithHttpInfo (string edgeId, Edge body = null);

        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> PutEdgeAsync (string edgeId, Edge body = null);

        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> PutEdgeAsyncWithHttpInfo (string edgeId, Edge body = null);
        
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
        EdgeLine GetEdgeLine (string edgeId, string lineId);
  
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        ApiResponse<EdgeLine> GetEdgeLineWithHttpInfo (string edgeId, string lineId);

        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of EdgeLine</returns>
        System.Threading.Tasks.Task<EdgeLine> GetEdgeLineAsync (string edgeId, string lineId);

        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> GetEdgeLineAsyncWithHttpInfo (string edgeId, string lineId);
        
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
        EdgeLine PutEdgeLine (string edgeId, string lineId, EdgeLine body = null);
  
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
        ApiResponse<EdgeLine> PutEdgeLineWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);

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
        System.Threading.Tasks.Task<EdgeLine> PutEdgeLineAsync (string edgeId, string lineId, EdgeLine body = null);

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
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> PutEdgeLineAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);
        
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
        DomainLogicalInterface PostEdgeLogicalinterfaces (string edgeId, DomainLogicalInterface body = null);
  
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> PostEdgeLogicalinterfacesWithHttpInfo (string edgeId, DomainLogicalInterface body = null);

        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> PostEdgeLogicalinterfacesAsync (string edgeId, DomainLogicalInterface body = null);

        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PostEdgeLogicalinterfacesAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface GetEdgeLogicalinterface (string edgeId, string interfaceId);
  
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> GetEdgeLogicalinterfaceWithHttpInfo (string edgeId, string interfaceId);

        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> GetEdgeLogicalinterfaceAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> GetEdgeLogicalinterfaceAsyncWithHttpInfo (string edgeId, string interfaceId);
        
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
        DomainLogicalInterface PutEdgeLogicalinterface (string edgeId, string interfaceId, DomainLogicalInterface body = null);
  
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
        ApiResponse<DomainLogicalInterface> PutEdgeLogicalinterfaceWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);

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
        System.Threading.Tasks.Task<DomainLogicalInterface> PutEdgeLogicalinterfaceAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null);

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
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PutEdgeLogicalinterfaceAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns></returns>
        void DeleteEdgeLogicalinterface (string edgeId, string interfaceId);
  
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteEdgeLogicalinterfaceWithHttpInfo (string edgeId, string interfaceId);

        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteEdgeLogicalinterfaceAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEdgeLogicalinterfaceAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>EdgeLogsJobResponse</returns>
        EdgeLogsJobResponse PostEdgeLogsJobs (string edgeId, EdgeLogsJobRequest body = null);
  
        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>ApiResponse of EdgeLogsJobResponse</returns>
        ApiResponse<EdgeLogsJobResponse> PostEdgeLogsJobsWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null);

        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of EdgeLogsJobResponse</returns>
        System.Threading.Tasks.Task<EdgeLogsJobResponse> PostEdgeLogsJobsAsync (string edgeId, EdgeLogsJobRequest body = null);

        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of ApiResponse (EdgeLogsJobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLogsJobResponse>> PostEdgeLogsJobsAsyncWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null);
        
        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <returns></returns>
        void GetEdgeLogsJob (string edgeId, string jobId);
  
        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetEdgeLogsJobWithHttpInfo (string edgeId, string jobId);

        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetEdgeLogsJobAsync (string edgeId, string jobId);

        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetEdgeLogsJobAsyncWithHttpInfo (string edgeId, string jobId);
        
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PostEdgeLogsJobUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);
  
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostEdgeLogsJobUploadWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostEdgeLogsJobUploadAsync (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostEdgeLogsJobUploadAsyncWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);
        
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
        DomainPhysicalInterface GetEdgePhysicalinterface (string edgeId, string interfaceId);
  
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        ApiResponse<DomainPhysicalInterface> GetEdgePhysicalinterfaceWithHttpInfo (string edgeId, string interfaceId);

        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainPhysicalInterface</returns>
        System.Threading.Tasks.Task<DomainPhysicalInterface> GetEdgePhysicalinterfaceAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> GetEdgePhysicalinterfaceAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string PostEdgeReboot (string edgeId);
  
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostEdgeRebootWithHttpInfo (string edgeId);

        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostEdgeRebootAsync (string edgeId);

        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostEdgeRebootAsyncWithHttpInfo (string edgeId);
        
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
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        DomainEdgeSoftwareUpdateDto PostEdgeSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
  
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        ApiResponse<DomainEdgeSoftwareUpdateDto> PostEdgeSoftwareupdateWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);

        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> PostEdgeSoftwareupdateAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null);

        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> PostEdgeSoftwareupdateAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
        
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
        string PostEdgeUnpair (string edgeId);
  
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostEdgeUnpairWithHttpInfo (string edgeId);

        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostEdgeUnpairAsync (string edgeId);

        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostEdgeUnpairAsyncWithHttpInfo (string edgeId);
        
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
        Endpoint PostEndpoints (Endpoint body = null);
  
        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> PostEndpointsWithHttpInfo (Endpoint body = null);

        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> PostEndpointsAsync (Endpoint body = null);

        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> PostEndpointsAsyncWithHttpInfo (Endpoint body = null);
        
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
        Endpoint PutEndpoint (string endpointId, Endpoint body = null);
  
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> PutEndpointWithHttpInfo (string endpointId, Endpoint body = null);

        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> PutEndpointAsync (string endpointId, Endpoint body = null);

        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> PutEndpointAsyncWithHttpInfo (string endpointId, Endpoint body = null);
        
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
        Extension PostExtensionpools (ExtensionPool body = null);
  
        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> PostExtensionpoolsWithHttpInfo (ExtensionPool body = null);

        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> PostExtensionpoolsAsync (ExtensionPool body = null);

        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> PostExtensionpoolsAsyncWithHttpInfo (ExtensionPool body = null);
        
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ExtensionPool</returns>
        ExtensionPool GetExtensionpool (string extensionPoolId);
  
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> GetExtensionpoolWithHttpInfo (string extensionPoolId);

        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> GetExtensionpoolAsync (string extensionPoolId);

        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> GetExtensionpoolAsyncWithHttpInfo (string extensionPoolId);
        
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ExtensionPool</returns>
        ExtensionPool PutExtensionpool (string extensionPoolId, ExtensionPool body = null);
  
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> PutExtensionpoolWithHttpInfo (string extensionPoolId, ExtensionPool body = null);

        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> PutExtensionpoolAsync (string extensionPoolId, ExtensionPool body = null);

        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> PutExtensionpoolAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null);
        
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>string</returns>
        string DeleteExtensionpool (string extensionPoolId);
  
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteExtensionpoolWithHttpInfo (string extensionPoolId);

        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteExtensionpoolAsync (string extensionPoolId);

        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteExtensionpoolAsyncWithHttpInfo (string extensionPoolId);
        
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
        Extension PutExtension (string extensionId, Extension body = null);
  
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> PutExtensionWithHttpInfo (string extensionId, Extension body = null);

        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> PutExtensionAsync (string extensionId, Extension body = null);

        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> PutExtensionAsyncWithHttpInfo (string extensionId, Extension body = null);
        
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
        Organization PutOrganization (Organization body = null);
  
        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> PutOrganizationWithHttpInfo (Organization body = null);

        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> PutOrganizationAsync (Organization body = null);

        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationAsyncWithHttpInfo (Organization body = null);
        
        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Organization</returns>
        Organization PostOrganizations (OrganizationCreate body = null);
  
        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> PostOrganizationsWithHttpInfo (OrganizationCreate body = null);

        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> PostOrganizationsAsync (OrganizationCreate body = null);

        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> PostOrganizationsAsyncWithHttpInfo (OrganizationCreate body = null);
        
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Organization</returns>
        Organization GetOrganization_0 (string orgId);
  
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetOrganization_0WithHttpInfo (string orgId);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetOrganization_0Async (string orgId);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganization_0AsyncWithHttpInfo (string orgId);
        
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Organization</returns>
        Organization PutOrganization_0 (string orgId, Organization body = null);
  
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> PutOrganization_0WithHttpInfo (string orgId, Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> PutOrganization_0Async (string orgId, Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganization_0AsyncWithHttpInfo (string orgId, Organization body = null);
        
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>string</returns>
        string DeleteOrganization (string orgId);
  
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteOrganizationWithHttpInfo (string orgId);

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteOrganizationAsync (string orgId);

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteOrganizationAsyncWithHttpInfo (string orgId);
        
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
        EncryptionKey PostRecordingkeys ();
  
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of EncryptionKey</returns>
        ApiResponse<EncryptionKey> PostRecordingkeysWithHttpInfo ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of EncryptionKey</returns>
        System.Threading.Tasks.Task<EncryptionKey> PostRecordingkeysAsync ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingkeysAsyncWithHttpInfo ();
        
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
        KeyRotationSchedule PutRecordingkeysRotationschedule (KeyRotationSchedule body = null);
  
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> PutRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body = null);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> PutRecordingkeysRotationscheduleAsync (KeyRotationSchedule body = null);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> PutRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body = null);
        
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
        Policy PostRetentionpolicies (Policy body = null);
  
        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PostRetentionpoliciesWithHttpInfo (Policy body = null);

        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PostRetentionpoliciesAsync (Policy body = null);

        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PostRetentionpoliciesAsyncWithHttpInfo (Policy body = null);
        
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
        Policy GetRetentionpolicie (string policyId);
  
        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> GetRetentionpolicieWithHttpInfo (string policyId);

        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> GetRetentionpolicieAsync (string policyId);

        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> GetRetentionpolicieAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PutRetentionpolicie (string policyId, Policy body = null);
  
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PutRetentionpolicieWithHttpInfo (string policyId, Policy body = null);

        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PutRetentionpolicieAsync (string policyId, Policy body = null);

        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PutRetentionpolicieAsyncWithHttpInfo (string policyId, Policy body = null);
        
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>string</returns>
        string DeleteRetentionpolicie (string policyId);
  
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteRetentionpolicieWithHttpInfo (string policyId);

        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteRetentionpolicieAsync (string policyId);

        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpolicieAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PatchRetentionpolicie (string policyId, Policy body = null);
  
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PatchRetentionpolicieWithHttpInfo (string policyId, Policy body = null);

        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PatchRetentionpolicieAsync (string policyId, Policy body = null);

        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRetentionpolicieAsyncWithHttpInfo (string policyId, Policy body = null);
        
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
        SchemaReferenceEntityListing GetSchemasEdgesVnext_0 (string schemaCategory, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<SchemaReferenceEntityListing> GetSchemasEdgesVnext_0WithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnext_0Async (string schemaCategory, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnext_0AsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);
        
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
        SchemaReferenceEntityListing GetSchemasEdgesVnext_1 (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<SchemaReferenceEntityListing> GetSchemasEdgesVnext_1WithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnext_1Async (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnext_1AsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
        
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
        Organization GetSchemasEdgesVnext_2 (string schemaCategory, string schemaType, string schemaId);
  
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
        ApiResponse<Organization> GetSchemasEdgesVnext_2WithHttpInfo (string schemaCategory, string schemaType, string schemaId);

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
        System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnext_2Async (string schemaCategory, string schemaType, string schemaId);

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
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnext_2AsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId);
        
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
        Organization GetSchemasEdgesVnext_3 (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
  
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
        ApiResponse<Organization> GetSchemasEdgesVnext_3WithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);

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
        System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnext_3Async (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);

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
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnext_3AsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
        
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
        Site PostSites (Site body = null);
  
        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Site</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> PostSitesWithHttpInfo (Site body = null);

        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> PostSitesAsync (Site body = null);

        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> PostSitesAsyncWithHttpInfo (Site body = null);
        
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
        Site PutSite (string siteId, Site body = null);
  
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> PutSiteWithHttpInfo (string siteId, Site body = null);

        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> PutSiteAsync (string siteId, Site body = null);

        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> PutSiteAsyncWithHttpInfo (string siteId, Site body = null);
        
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
        List<NumberPlan> PutSiteNumberplans (string siteId, List<NumberPlan> body = null);
  
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        ApiResponse<List<NumberPlan>> PutSiteNumberplansWithHttpInfo (string siteId, List<NumberPlan> body = null);

        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        System.Threading.Tasks.Task<List<NumberPlan>> PutSiteNumberplansAsync (string siteId, List<NumberPlan> body = null);

        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> PutSiteNumberplansAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null);
        
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
        NumberPlan GetSiteNumberplan (string siteId, string numberPlanId);
  
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>ApiResponse of NumberPlan</returns>
        ApiResponse<NumberPlan> GetSiteNumberplanWithHttpInfo (string siteId, string numberPlanId);

        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of NumberPlan</returns>
        System.Threading.Tasks.Task<NumberPlan> GetSiteNumberplanAsync (string siteId, string numberPlanId);

        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<NumberPlan>> GetSiteNumberplanAsyncWithHttpInfo (string siteId, string numberPlanId);
        
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns></returns>
        void PostSiteRebalance (string siteId);
  
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostSiteRebalanceWithHttpInfo (string siteId);

        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostSiteRebalanceAsync (string siteId);

        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostSiteRebalanceAsyncWithHttpInfo (string siteId);
        
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
        public DIDPool PostDidpools (DIDPool body = null)
        {
             ApiResponse<DIDPool> response = PostDidpoolsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > PostDidpoolsWithHttpInfo (DIDPool body = null)
        {
            
    
            var path_ = "/api/v1/configuration/didpools";
    
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
                throw new ApiException (statusCode, "Error calling PostDidpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDidpools: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
    
        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> PostDidpoolsAsync (DIDPool body = null)
        {
             ApiResponse<DIDPool> response = await PostDidpoolsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> PostDidpoolsAsyncWithHttpInfo (DIDPool body = null)
        {
            
    
            var path_ = "/api/v1/configuration/didpools";
    
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
                throw new ApiException (statusCode, "Error calling PostDidpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDidpools: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
        
        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>DIDPool</returns>
        public DIDPool GetDidpool (string didPoolId)
        {
             ApiResponse<DIDPool> response = GetDidpoolWithHttpInfo(didPoolId);
             return response.Data;
        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > GetDidpoolWithHttpInfo (string didPoolId)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->GetDidpool");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetDidpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidpool: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
    
        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> GetDidpoolAsync (string didPoolId)
        {
             ApiResponse<DIDPool> response = await GetDidpoolAsyncWithHttpInfo(didPoolId);
             return response.Data;

        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> GetDidpoolAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling GetDidpool");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDidpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidpool: " + response.ErrorMessage, response.ErrorMessage);

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
        public DIDPool PutDidpool (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> response = PutDidpoolWithHttpInfo(didPoolId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > PutDidpoolWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->PutDidpool");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutDidpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDidpool: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DIDPool> PutDidpoolAsync (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> response = await PutDidpoolAsyncWithHttpInfo(didPoolId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> PutDidpoolAsyncWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling PutDidpool");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutDidpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDidpool: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
        
        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>string</returns>
        public string DeleteDidpool (string didPoolId)
        {
             ApiResponse<string> response = DeleteDidpoolWithHttpInfo(didPoolId);
             return response.Data;
        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteDidpoolWithHttpInfo (string didPoolId)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->DeleteDidpool");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteDidpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDidpool: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteDidpoolAsync (string didPoolId)
        {
             ApiResponse<string> response = await DeleteDidpoolAsyncWithHttpInfo(didPoolId);
             return response.Data;

        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteDidpoolAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling DeleteDidpool");
            
    
            var path_ = "/api/v1/configuration/didpools/{didPoolId}";
    
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
            if (didPoolId != null) pathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteDidpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDidpool: " + response.ErrorMessage, response.ErrorMessage);

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
            if (phoneNumber != null) queryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            
            
            
            

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
            if (phoneNumber != null) queryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            
            
            
            

            
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
        public DID GetDid (string didId)
        {
             ApiResponse<DID> response = GetDidWithHttpInfo(didId);
             return response.Data;
        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param> 
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > GetDidWithHttpInfo (string didId)
        {
            
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->GetDid");
            
    
            var path_ = "/api/v1/configuration/dids/{didId}";
    
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
            if (didId != null) pathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetDid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDid: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DID>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(response, typeof(DID)));
            
        }
    
        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        public async System.Threading.Tasks.Task<DID> GetDidAsync (string didId)
        {
             ApiResponse<DID> response = await GetDidAsyncWithHttpInfo(didId);
             return response.Data;

        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> GetDidAsyncWithHttpInfo (string didId)
        {
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling GetDid");
            
    
            var path_ = "/api/v1/configuration/dids/{didId}";
    
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
            if (didId != null) pathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDid: " + response.ErrorMessage, response.ErrorMessage);

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
        public DID PutDid (string didId, DID body = null)
        {
             ApiResponse<DID> response = PutDidWithHttpInfo(didId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > PutDidWithHttpInfo (string didId, DID body = null)
        {
            
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->PutDid");
            
    
            var path_ = "/api/v1/configuration/dids/{didId}";
    
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
            if (didId != null) pathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutDid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDid: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DID> PutDidAsync (string didId, DID body = null)
        {
             ApiResponse<DID> response = await PutDidAsyncWithHttpInfo(didId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> PutDidAsyncWithHttpInfo (string didId, DID body = null)
        {
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling PutDid");
            
    
            var path_ = "/api/v1/configuration/dids/{didId}";
    
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
            if (didId != null) pathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutDid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDid: " + response.ErrorMessage, response.ErrorMessage);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
        public Edge PostEdges (Edge body = null)
        {
             ApiResponse<Edge> response = PostEdgesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <param name="body">Edge</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > PostEdgesWithHttpInfo (Edge body = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges";
    
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
                throw new ApiException (statusCode, "Error calling PostEdges: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdges: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Edge>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(response, typeof(Edge)));
            
        }
    
        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> PostEdgesAsync (Edge body = null)
        {
             ApiResponse<Edge> response = await PostEdgesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> PostEdgesAsyncWithHttpInfo (Edge body = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges";
    
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
                throw new ApiException (statusCode, "Error calling PostEdges: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdges: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainCertificateAuthority PostEdgesCertificateauthorities (DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = PostEdgesCertificateauthoritiesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <param name="body">CertificateAuthority</param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > PostEdgesCertificateauthoritiesWithHttpInfo (DomainCertificateAuthority body = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities";
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesCertificateauthorities: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesCertificateauthorities: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
    
        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> PostEdgesCertificateauthoritiesAsync (DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = await PostEdgesCertificateauthoritiesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PostEdgesCertificateauthoritiesAsyncWithHttpInfo (DomainCertificateAuthority body = null)
        {
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities";
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesCertificateauthorities: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesCertificateauthorities: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
        
        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority GetEdgesCertificateauthoritie (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> response = GetEdgesCertificateauthoritieWithHttpInfo(certificateId);
             return response.Data;
        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > GetEdgesCertificateauthoritieWithHttpInfo (string certificateId)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->GetEdgesCertificateauthoritie");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritie: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
    
        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> GetEdgesCertificateauthoritieAsync (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> response = await GetEdgesCertificateauthoritieAsyncWithHttpInfo(certificateId);
             return response.Data;

        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> GetEdgesCertificateauthoritieAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling GetEdgesCertificateauthoritie");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritie: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainCertificateAuthority PutEdgesCertificateauthoritie (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = PutEdgesCertificateauthoritieWithHttpInfo(certificateId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > PutEdgesCertificateauthoritieWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->PutEdgesCertificateauthoritie");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutEdgesCertificateauthoritie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesCertificateauthoritie: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> PutEdgesCertificateauthoritieAsync (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = await PutEdgesCertificateauthoritieAsyncWithHttpInfo(certificateId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PutEdgesCertificateauthoritieAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling PutEdgesCertificateauthoritie");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutEdgesCertificateauthoritie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesCertificateauthoritie: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
        
        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>string</returns>
        public string DeleteEdgesCertificateauthoritie (string certificateId)
        {
             ApiResponse<string> response = DeleteEdgesCertificateauthoritieWithHttpInfo(certificateId);
             return response.Data;
        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgesCertificateauthoritieWithHttpInfo (string certificateId)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->DeleteEdgesCertificateauthoritie");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritie: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgesCertificateauthoritieAsync (string certificateId)
        {
             ApiResponse<string> response = await DeleteEdgesCertificateauthoritieAsyncWithHttpInfo(certificateId);
             return response.Data;

        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesCertificateauthoritieAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling DeleteEdgesCertificateauthoritie");
            
    
            var path_ = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
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
            if (certificateId != null) pathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritie: " + response.ErrorMessage, response.ErrorMessage);

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
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
        public Edge PutEdge (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> response = PutEdgeWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">Edge</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > PutEdgeWithHttpInfo (string edgeId, Edge body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PutEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutEdge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdge: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Edge> PutEdgeAsync (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> response = await PutEdgeAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> PutEdgeAsyncWithHttpInfo (string edgeId, Edge body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PutEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutEdge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdge: " + response.ErrorMessage, response.ErrorMessage);

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
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->DeleteEdge");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgeLines");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
        public EdgeLine GetEdgeLine (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> response = GetEdgeLineWithHttpInfo(edgeId, lineId);
             return response.Data;
        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > GetEdgeLineWithHttpInfo (string edgeId, string lineId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgeLine");
            
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->GetEdgeLine");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) pathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetEdgeLine: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLine: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeLine> GetEdgeLineAsync (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> response = await GetEdgeLineAsyncWithHttpInfo(edgeId, lineId);
             return response.Data;

        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> GetEdgeLineAsyncWithHttpInfo (string edgeId, string lineId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLine");
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetEdgeLine");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) pathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLine: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLine: " + response.ErrorMessage, response.ErrorMessage);

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
        public EdgeLine PutEdgeLine (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> response = PutEdgeLineWithHttpInfo(edgeId, lineId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <param name="body">Line</param> 
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > PutEdgeLineWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PutEdgeLine");
            
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->PutEdgeLine");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) pathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutEdgeLine: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgeLine: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeLine> PutEdgeLineAsync (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> response = await PutEdgeLineAsyncWithHttpInfo(edgeId, lineId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> PutEdgeLineAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PutEdgeLine");
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling PutEdgeLine");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutEdgeLine: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgeLine: " + response.ErrorMessage, response.ErrorMessage);

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
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgeLogicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
        public DomainLogicalInterface PostEdgeLogicalinterfaces (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = PostEdgeLogicalinterfacesWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > PostEdgeLogicalinterfacesWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgeLogicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEdgeLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainLogicalInterface> PostEdgeLogicalinterfacesAsync (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = await PostEdgeLogicalinterfacesAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PostEdgeLogicalinterfacesAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgeLogicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEdgeLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainLogicalInterface GetEdgeLogicalinterface (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> response = GetEdgeLogicalinterfaceWithHttpInfo(edgeId, interfaceId);
             return response.Data;
        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > GetEdgeLogicalinterfaceWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgeLogicalinterface");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->GetEdgeLogicalinterface");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterface: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterface: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainLogicalInterface> GetEdgeLogicalinterfaceAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> response = await GetEdgeLogicalinterfaceAsyncWithHttpInfo(edgeId, interfaceId);
             return response.Data;

        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> GetEdgeLogicalinterfaceAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLogicalinterface");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgeLogicalinterface");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterface: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLogicalinterface: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainLogicalInterface PutEdgeLogicalinterface (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = PutEdgeLogicalinterfaceWithHttpInfo(edgeId, interfaceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > PutEdgeLogicalinterfaceWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PutEdgeLogicalinterface");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->PutEdgeLogicalinterface");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutEdgeLogicalinterface: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgeLogicalinterface: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainLogicalInterface> PutEdgeLogicalinterfaceAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = await PutEdgeLogicalinterfaceAsyncWithHttpInfo(edgeId, interfaceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PutEdgeLogicalinterfaceAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PutEdgeLogicalinterface");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling PutEdgeLogicalinterface");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutEdgeLogicalinterface: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgeLogicalinterface: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteEdgeLogicalinterface (string edgeId, string interfaceId)
        {
             DeleteEdgeLogicalinterfaceWithHttpInfo(edgeId, interfaceId);
        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteEdgeLogicalinterfaceWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->DeleteEdgeLogicalinterface");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->DeleteEdgeLogicalinterface");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteEdgeLogicalinterface: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgeLogicalinterface: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteEdgeLogicalinterfaceAsync (string edgeId, string interfaceId)
        {
             await DeleteEdgeLogicalinterfaceAsyncWithHttpInfo(edgeId, interfaceId);

        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEdgeLogicalinterfaceAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgeLogicalinterface");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling DeleteEdgeLogicalinterface");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEdgeLogicalinterface: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgeLogicalinterface: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">EdgeLogsJobRequest</param> 
        /// <returns>EdgeLogsJobResponse</returns>
        public EdgeLogsJobResponse PostEdgeLogsJobs (string edgeId, EdgeLogsJobRequest body = null)
        {
             ApiResponse<EdgeLogsJobResponse> response = PostEdgeLogsJobsWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">EdgeLogsJobRequest</param> 
        /// <returns>ApiResponse of EdgeLogsJobResponse</returns>
        public ApiResponse< EdgeLogsJobResponse > PostEdgeLogsJobsWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgeLogsJobs");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logs/jobs";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEdgeLogsJobs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeLogsJobs: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeLogsJobResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLogsJobResponse) Configuration.ApiClient.Deserialize(response, typeof(EdgeLogsJobResponse)));
            
        }
    
        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of EdgeLogsJobResponse</returns>
        public async System.Threading.Tasks.Task<EdgeLogsJobResponse> PostEdgeLogsJobsAsync (string edgeId, EdgeLogsJobRequest body = null)
        {
             ApiResponse<EdgeLogsJobResponse> response = await PostEdgeLogsJobsAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of ApiResponse (EdgeLogsJobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLogsJobResponse>> PostEdgeLogsJobsAsyncWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgeLogsJobs");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logs/jobs";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEdgeLogsJobs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeLogsJobs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeLogsJobResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLogsJobResponse) Configuration.ApiClient.Deserialize(response, typeof(EdgeLogsJobResponse)));
            
        }
        
        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId"></param> 
        /// <returns></returns>
        public void GetEdgeLogsJob (string edgeId, string jobId)
        {
             GetEdgeLogsJobWithHttpInfo(edgeId, jobId);
        }

        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetEdgeLogsJobWithHttpInfo (string edgeId, string jobId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgeLogsJob");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ConfigurationApi->GetEdgeLogsJob");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logs/jobs/{jobId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (jobId != null) pathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetEdgeLogsJob: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLogsJob: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetEdgeLogsJobAsync (string edgeId, string jobId)
        {
             await GetEdgeLogsJobAsyncWithHttpInfo(edgeId, jobId);

        }

        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetEdgeLogsJobAsyncWithHttpInfo (string edgeId, string jobId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgeLogsJob");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling GetEdgeLogsJob");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logs/jobs/{jobId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (jobId != null) pathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgeLogsJob: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgeLogsJob: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PostEdgeLogsJobUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
             PostEdgeLogsJobUploadWithHttpInfo(edgeId, jobId, body);
        }

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostEdgeLogsJobUploadWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgeLogsJobUpload");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ConfigurationApi->PostEdgeLogsJobUpload");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logs/jobs/{jobId}/upload";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (jobId != null) pathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEdgeLogsJobUpload: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeLogsJobUpload: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostEdgeLogsJobUploadAsync (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
             await PostEdgeLogsJobUploadAsyncWithHttpInfo(edgeId, jobId, body);

        }

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostEdgeLogsJobUploadAsyncWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgeLogsJobUpload");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling PostEdgeLogsJobUpload");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/logs/jobs/{jobId}/upload";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (jobId != null) pathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEdgeLogsJobUpload: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeLogsJobUpload: " + response.ErrorMessage, response.ErrorMessage);

            
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
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgePhysicalinterfaces");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
        public DomainPhysicalInterface GetEdgePhysicalinterface (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> response = GetEdgePhysicalinterfaceWithHttpInfo(edgeId, interfaceId);
             return response.Data;
        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        public ApiResponse< DomainPhysicalInterface > GetEdgePhysicalinterfaceWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgePhysicalinterface");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->GetEdgePhysicalinterface");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterface: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterface: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainPhysicalInterface> GetEdgePhysicalinterfaceAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> response = await GetEdgePhysicalinterfaceAsyncWithHttpInfo(edgeId, interfaceId);
             return response.Data;

        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> GetEdgePhysicalinterfaceAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgePhysicalinterface");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgePhysicalinterface");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces/{interfaceId}";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) pathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterface: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgePhysicalinterface: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainPhysicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainPhysicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainPhysicalInterface)));
            
        }
        
        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string PostEdgeReboot (string edgeId)
        {
             ApiResponse<string> response = PostEdgeRebootWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostEdgeRebootWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgeReboot");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/reboot";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostEdgeReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeReboot: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostEdgeRebootAsync (string edgeId)
        {
             ApiResponse<string> response = await PostEdgeRebootAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostEdgeRebootAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgeReboot");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/reboot";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostEdgeReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeReboot: " + response.ErrorMessage, response.ErrorMessage);

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
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        public DomainEdgeSoftwareUpdateDto PostEdgeSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> response = PostEdgeSoftwareupdateWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        public ApiResponse< DomainEdgeSoftwareUpdateDto > PostEdgeSoftwareupdateWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEdgeSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }
    
        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> PostEdgeSoftwareupdateAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> response = await PostEdgeSoftwareupdateAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> PostEdgeSoftwareupdateAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEdgeSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareUpdateDto)));
            
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
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->DeleteEdgeSoftwareupdate");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgeSoftwareversions");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/softwareversions";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
        public string PostEdgeUnpair (string edgeId)
        {
             ApiResponse<string> response = PostEdgeUnpairWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostEdgeUnpairWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgeUnpair");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/unpair";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostEdgeUnpair: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeUnpair: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostEdgeUnpairAsync (string edgeId)
        {
             ApiResponse<string> response = await PostEdgeUnpairAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostEdgeUnpairAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgeUnpair");
            
    
            var path_ = "/api/v1/configuration/edges/{edgeId}/unpair";
    
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
            if (edgeId != null) pathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostEdgeUnpair: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgeUnpair: " + response.ErrorMessage, response.ErrorMessage);

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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            
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
        public Endpoint PostEndpoints (Endpoint body = null)
        {
             ApiResponse<Endpoint> response = PostEndpointsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > PostEndpointsWithHttpInfo (Endpoint body = null)
        {
            
    
            var path_ = "/api/v1/configuration/endpoints";
    
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
                throw new ApiException (statusCode, "Error calling PostEndpoints: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEndpoints: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Endpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(response, typeof(Endpoint)));
            
        }
    
        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> PostEndpointsAsync (Endpoint body = null)
        {
             ApiResponse<Endpoint> response = await PostEndpointsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> PostEndpointsAsyncWithHttpInfo (Endpoint body = null)
        {
            
    
            var path_ = "/api/v1/configuration/endpoints";
    
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
                throw new ApiException (statusCode, "Error calling PostEndpoints: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEndpoints: " + response.ErrorMessage, response.ErrorMessage);

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
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->GetEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            
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
        public Endpoint PutEndpoint (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> response = PutEndpointWithHttpInfo(endpointId, body);
             return response.Data;
        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > PutEndpointWithHttpInfo (string endpointId, Endpoint body = null)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->PutEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutEndpoint: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEndpoint: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Endpoint> PutEndpointAsync (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> response = await PutEndpointAsyncWithHttpInfo(endpointId, body);
             return response.Data;

        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> PutEndpointAsyncWithHttpInfo (string endpointId, Endpoint body = null)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling PutEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutEndpoint: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEndpoint: " + response.ErrorMessage, response.ErrorMessage);

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
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->DeleteEndpoint");
            
    
            var path_ = "/api/v1/configuration/endpoints/{endpointId}";
    
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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

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
            if (endpointId != null) pathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            
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
            if (number != null) queryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

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
            if (number != null) queryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            
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
        public Extension PostExtensionpools (ExtensionPool body = null)
        {
             ApiResponse<Extension> response = PostExtensionpoolsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <param name="body">ExtensionPool</param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > PostExtensionpoolsWithHttpInfo (ExtensionPool body = null)
        {
            
    
            var path_ = "/api/v1/configuration/extensionpools";
    
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
                throw new ApiException (statusCode, "Error calling PostExtensionpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExtensionpools: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
    
        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> PostExtensionpoolsAsync (ExtensionPool body = null)
        {
             ApiResponse<Extension> response = await PostExtensionpoolsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> PostExtensionpoolsAsyncWithHttpInfo (ExtensionPool body = null)
        {
            
    
            var path_ = "/api/v1/configuration/extensionpools";
    
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
                throw new ApiException (statusCode, "Error calling PostExtensionpools: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExtensionpools: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
        
        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ExtensionPool</returns>
        public ExtensionPool GetExtensionpool (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> response = GetExtensionpoolWithHttpInfo(extensionPoolId);
             return response.Data;
        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > GetExtensionpoolWithHttpInfo (string extensionPoolId)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->GetExtensionpool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetExtensionpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionpool: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExtensionPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPool)));
            
        }
    
        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        public async System.Threading.Tasks.Task<ExtensionPool> GetExtensionpoolAsync (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> response = await GetExtensionpoolAsyncWithHttpInfo(extensionPoolId);
             return response.Data;

        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> GetExtensionpoolAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling GetExtensionpool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetExtensionpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionpool: " + response.ErrorMessage, response.ErrorMessage);

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
        public ExtensionPool PutExtensionpool (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> response = PutExtensionpoolWithHttpInfo(extensionPoolId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <param name="body">ExtensionPool</param> 
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > PutExtensionpoolWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->PutExtensionpool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutExtensionpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExtensionpool: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ExtensionPool> PutExtensionpoolAsync (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> response = await PutExtensionpoolAsyncWithHttpInfo(extensionPoolId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> PutExtensionpoolAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling PutExtensionpool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutExtensionpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExtensionpool: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExtensionPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPool)));
            
        }
        
        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>string</returns>
        public string DeleteExtensionpool (string extensionPoolId)
        {
             ApiResponse<string> response = DeleteExtensionpoolWithHttpInfo(extensionPoolId);
             return response.Data;
        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteExtensionpoolWithHttpInfo (string extensionPoolId)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->DeleteExtensionpool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteExtensionpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExtensionpool: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteExtensionpoolAsync (string extensionPoolId)
        {
             ApiResponse<string> response = await DeleteExtensionpoolAsyncWithHttpInfo(extensionPoolId);
             return response.Data;

        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteExtensionpoolAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling DeleteExtensionpool");
            
    
            var path_ = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
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
            if (extensionPoolId != null) pathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteExtensionpool: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExtensionpool: " + response.ErrorMessage, response.ErrorMessage);

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
            if (number != null) queryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

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
            if (number != null) queryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            
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
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->GetExtension");
            
    
            var path_ = "/api/v1/configuration/extensions/{extensionId}";
    
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
            if (extensionId != null) pathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

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
            if (extensionId != null) pathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

            
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
        public Extension PutExtension (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> response = PutExtensionWithHttpInfo(extensionId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > PutExtensionWithHttpInfo (string extensionId, Extension body = null)
        {
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->PutExtension");
            
    
            var path_ = "/api/v1/configuration/extensions/{extensionId}";
    
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
            if (extensionId != null) pathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutExtension: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExtension: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Extension> PutExtensionAsync (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> response = await PutExtensionAsyncWithHttpInfo(extensionId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> PutExtensionAsyncWithHttpInfo (string extensionId, Extension body = null)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling PutExtension");
            
    
            var path_ = "/api/v1/configuration/extensions/{extensionId}";
    
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
            if (extensionId != null) pathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutExtension: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExtension: " + response.ErrorMessage, response.ErrorMessage);

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
        public Organization PutOrganization (Organization body = null)
        {
             ApiResponse<Organization> response = PutOrganizationWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > PutOrganizationWithHttpInfo (Organization body = null)
        {
            
    
            var path_ = "/api/v1/configuration/organization";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> PutOrganizationAsync (Organization body = null)
        {
             ApiResponse<Organization> response = await PutOrganizationAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationAsyncWithHttpInfo (Organization body = null)
        {
            
    
            var path_ = "/api/v1/configuration/organization";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>Organization</returns>
        public Organization PostOrganizations (OrganizationCreate body = null)
        {
             ApiResponse<Organization> response = PostOrganizationsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > PostOrganizationsWithHttpInfo (OrganizationCreate body = null)
        {
            
    
            var path_ = "/api/v1/configuration/organizations";
    
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
                throw new ApiException (statusCode, "Error calling PostOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostOrganizations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> PostOrganizationsAsync (OrganizationCreate body = null)
        {
             ApiResponse<Organization> response = await PostOrganizationsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> PostOrganizationsAsyncWithHttpInfo (OrganizationCreate body = null)
        {
            
    
            var path_ = "/api/v1/configuration/organizations";
    
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
                throw new ApiException (statusCode, "Error calling PostOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostOrganizations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>Organization</returns>
        public Organization GetOrganization_0 (string orgId)
        {
             ApiResponse<Organization> response = GetOrganization_0WithHttpInfo(orgId);
             return response.Data;
        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetOrganization_0WithHttpInfo (string orgId)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->GetOrganization_0");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetOrganization_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganization_0: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetOrganization_0Async (string orgId)
        {
             ApiResponse<Organization> response = await GetOrganization_0AsyncWithHttpInfo(orgId);
             return response.Data;

        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganization_0AsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling GetOrganization_0");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetOrganization_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganization_0: " + response.ErrorMessage, response.ErrorMessage);

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
        public Organization PutOrganization_0 (string orgId, Organization body = null)
        {
             ApiResponse<Organization> response = PutOrganization_0WithHttpInfo(orgId, body);
             return response.Data;
        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > PutOrganization_0WithHttpInfo (string orgId, Organization body = null)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->PutOrganization_0");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutOrganization_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganization_0: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Organization> PutOrganization_0Async (string orgId, Organization body = null)
        {
             ApiResponse<Organization> response = await PutOrganization_0AsyncWithHttpInfo(orgId, body);
             return response.Data;

        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganization_0AsyncWithHttpInfo (string orgId, Organization body = null)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling PutOrganization_0");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutOrganization_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganization_0: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>string</returns>
        public string DeleteOrganization (string orgId)
        {
             ApiResponse<string> response = DeleteOrganizationWithHttpInfo(orgId);
             return response.Data;
        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteOrganizationWithHttpInfo (string orgId)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->DeleteOrganization");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteOrganizationAsync (string orgId)
        {
             ApiResponse<string> response = await DeleteOrganizationAsyncWithHttpInfo(orgId);
             return response.Data;

        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteOrganizationAsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling DeleteOrganization");
            
    
            var path_ = "/api/v1/configuration/organizations/{orgId}";
    
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
            if (orgId != null) pathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganization: " + response.ErrorMessage, response.ErrorMessage);

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
        public EncryptionKey PostRecordingkeys ()
        {
             ApiResponse<EncryptionKey> response = PostRecordingkeysWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <returns>ApiResponse of EncryptionKey</returns>
        public ApiResponse< EncryptionKey > PostRecordingkeysWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys";
    
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
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostRecordingkeys: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRecordingkeys: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EncryptionKey>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(response, typeof(EncryptionKey)));
            
        }
    
        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <returns>Task of EncryptionKey</returns>
        public async System.Threading.Tasks.Task<EncryptionKey> PostRecordingkeysAsync ()
        {
             ApiResponse<EncryptionKey> response = await PostRecordingkeysAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingkeysAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys";
    
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
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostRecordingkeys: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRecordingkeys: " + response.ErrorMessage, response.ErrorMessage);

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
        public KeyRotationSchedule PutRecordingkeysRotationschedule (KeyRotationSchedule body = null)
        {
             ApiResponse<KeyRotationSchedule> response = PutRecordingkeysRotationscheduleWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <param name="body">KeyRotationSchedule</param> 
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > PutRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body = null)
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys/rotationschedule";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutRecordingkeysRotationschedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRecordingkeysRotationschedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<KeyRotationSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(response, typeof(KeyRotationSchedule)));
            
        }
    
        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> PutRecordingkeysRotationscheduleAsync (KeyRotationSchedule body = null)
        {
             ApiResponse<KeyRotationSchedule> response = await PutRecordingkeysRotationscheduleAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> PutRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body = null)
        {
            
    
            var path_ = "/api/v1/configuration/recordingkeys/rotationschedule";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutRecordingkeysRotationschedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRecordingkeysRotationschedule: " + response.ErrorMessage, response.ErrorMessage);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
        public Policy PostRetentionpolicies (Policy body = null)
        {
             ApiResponse<Policy> response = PostRetentionpoliciesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PostRetentionpoliciesWithHttpInfo (Policy body = null)
        {
            
    
            var path_ = "/api/v1/configuration/retentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling PostRetentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRetentionpolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PostRetentionpoliciesAsync (Policy body = null)
        {
             ApiResponse<Policy> response = await PostRetentionpoliciesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PostRetentionpoliciesAsyncWithHttpInfo (Policy body = null)
        {
            
    
            var path_ = "/api/v1/configuration/retentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling PostRetentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRetentionpolicies: " + response.ErrorMessage, response.ErrorMessage);

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
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling ConfigurationApi->DeleteRetentionpolicies");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies";
    
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
            
            if (ids != null) queryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            

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
            
            if (ids != null) queryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            

            
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
        public Policy GetRetentionpolicie (string policyId)
        {
             ApiResponse<Policy> response = GetRetentionpolicieWithHttpInfo(policyId);
             return response.Data;
        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > GetRetentionpolicieWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->GetRetentionpolicie");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetRetentionpolicie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRetentionpolicie: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> GetRetentionpolicieAsync (string policyId)
        {
             ApiResponse<Policy> response = await GetRetentionpolicieAsyncWithHttpInfo(policyId);
             return response.Data;

        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> GetRetentionpolicieAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling GetRetentionpolicie");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetRetentionpolicie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRetentionpolicie: " + response.ErrorMessage, response.ErrorMessage);

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
        public Policy PutRetentionpolicie (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = PutRetentionpolicieWithHttpInfo(policyId, body);
             return response.Data;
        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PutRetentionpolicieWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->PutRetentionpolicie");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutRetentionpolicie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRetentionpolicie: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Policy> PutRetentionpolicieAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = await PutRetentionpolicieAsyncWithHttpInfo(policyId, body);
             return response.Data;

        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PutRetentionpolicieAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PutRetentionpolicie");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutRetentionpolicie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRetentionpolicie: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>string</returns>
        public string DeleteRetentionpolicie (string policyId)
        {
             ApiResponse<string> response = DeleteRetentionpolicieWithHttpInfo(policyId);
             return response.Data;
        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteRetentionpolicieWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->DeleteRetentionpolicie");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteRetentionpolicie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRetentionpolicie: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteRetentionpolicieAsync (string policyId)
        {
             ApiResponse<string> response = await DeleteRetentionpolicieAsyncWithHttpInfo(policyId);
             return response.Data;

        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpolicieAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling DeleteRetentionpolicie");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteRetentionpolicie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRetentionpolicie: " + response.ErrorMessage, response.ErrorMessage);

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
        public Policy PatchRetentionpolicie (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = PatchRetentionpolicieWithHttpInfo(policyId, body);
             return response.Data;
        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PatchRetentionpolicieWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->PatchRetentionpolicie");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchRetentionpolicie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchRetentionpolicie: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Policy> PatchRetentionpolicieAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = await PatchRetentionpolicieAsyncWithHttpInfo(policyId, body);
             return response.Data;

        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRetentionpolicieAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PatchRetentionpolicie");
            
    
            var path_ = "/api/v1/configuration/retentionpolicies/{policyId}";
    
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
            if (policyId != null) pathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchRetentionpolicie: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchRetentionpolicie: " + response.ErrorMessage, response.ErrorMessage);

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
        public SchemaReferenceEntityListing GetSchemasEdgesVnext_0 (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = GetSchemasEdgesVnext_0WithHttpInfo(schemaCategory, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        public ApiResponse< SchemaReferenceEntityListing > GetSchemasEdgesVnext_0WithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnext_0");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_0: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnext_0Async (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = await GetSchemasEdgesVnext_0AsyncWithHttpInfo(schemaCategory, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnext_0AsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnext_0");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_0: " + response.ErrorMessage, response.ErrorMessage);

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
        public SchemaReferenceEntityListing GetSchemasEdgesVnext_1 (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = GetSchemasEdgesVnext_1WithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
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
        public ApiResponse< SchemaReferenceEntityListing > GetSchemasEdgesVnext_1WithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnext_1");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->GetSchemasEdgesVnext_1");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_1: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_1: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnext_1Async (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = await GetSchemasEdgesVnext_1AsyncWithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
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
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnext_1AsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnext_1");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnext_1");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_1: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_1: " + response.ErrorMessage, response.ErrorMessage);

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
        public Organization GetSchemasEdgesVnext_2 (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> response = GetSchemasEdgesVnext_2WithHttpInfo(schemaCategory, schemaType, schemaId);
             return response.Data;
        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetSchemasEdgesVnext_2WithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnext_2");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->GetSchemasEdgesVnext_2");
            
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->GetSchemasEdgesVnext_2");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_2: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_2: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnext_2Async (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> response = await GetSchemasEdgesVnext_2AsyncWithHttpInfo(schemaCategory, schemaType, schemaId);
             return response.Data;

        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnext_2AsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnext_2");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnext_2");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnext_2");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_2: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_2: " + response.ErrorMessage, response.ErrorMessage);

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
        public Organization GetSchemasEdgesVnext_3 (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> response = GetSchemasEdgesVnext_3WithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
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
        public ApiResponse< Organization > GetSchemasEdgesVnext_3WithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnext_3");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->GetSchemasEdgesVnext_3");
            
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->GetSchemasEdgesVnext_3");
            
            // verify the required parameter 'extension' is set
            if (extension == null)
                throw new ApiException(400, "Missing required parameter 'extension' when calling ConfigurationApi->GetSchemasEdgesVnext_3");
            
            // verify the required parameter 'metadataId' is set
            if (metadataId == null)
                throw new ApiException(400, "Missing required parameter 'metadataId' when calling ConfigurationApi->GetSchemasEdgesVnext_3");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_3: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_3: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnext_3Async (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> response = await GetSchemasEdgesVnext_3AsyncWithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
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
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnext_3AsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnext_3");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnext_3");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnext_3");
            // verify the required parameter 'extension' is set
            if (extension == null) throw new ApiException(400, "Missing required parameter 'extension' when calling GetSchemasEdgesVnext_3");
            // verify the required parameter 'metadataId' is set
            if (metadataId == null) throw new ApiException(400, "Missing required parameter 'metadataId' when calling GetSchemasEdgesVnext_3");
            
    
            var path_ = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_3: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnext_3: " + response.ErrorMessage, response.ErrorMessage);

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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (locationId != null) queryParams.Add("location.id", Configuration.ApiClient.ParameterToString(locationId)); // query parameter
            
            
            
            

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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (locationId != null) queryParams.Add("location.id", Configuration.ApiClient.ParameterToString(locationId)); // query parameter
            
            
            
            

            
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
        public Site PostSites (Site body = null)
        {
             ApiResponse<Site> response = PostSitesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <param name="body">Site</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > PostSitesWithHttpInfo (Site body = null)
        {
            
    
            var path_ = "/api/v1/configuration/sites";
    
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
                throw new ApiException (statusCode, "Error calling PostSites: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSites: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Site>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(response, typeof(Site)));
            
        }
    
        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> PostSitesAsync (Site body = null)
        {
             ApiResponse<Site> response = await PostSitesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> PostSitesAsyncWithHttpInfo (Site body = null)
        {
            
    
            var path_ = "/api/v1/configuration/sites";
    
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
                throw new ApiException (statusCode, "Error calling PostSites: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSites: " + response.ErrorMessage, response.ErrorMessage);

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
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
        public Site PutSite (string siteId, Site body = null)
        {
             ApiResponse<Site> response = PutSiteWithHttpInfo(siteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body">Site</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > PutSiteWithHttpInfo (string siteId, Site body = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->PutSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSite: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSite: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Site> PutSiteAsync (string siteId, Site body = null)
        {
             ApiResponse<Site> response = await PutSiteAsyncWithHttpInfo(siteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> PutSiteAsyncWithHttpInfo (string siteId, Site body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling PutSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSite: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSite: " + response.ErrorMessage, response.ErrorMessage);

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
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->DeleteSite");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSiteNumberplans");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
        public List<NumberPlan> PutSiteNumberplans (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> response = PutSiteNumberplansWithHttpInfo(siteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        public ApiResponse< List<NumberPlan> > PutSiteNumberplansWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->PutSiteNumberplans");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSiteNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSiteNumberplans: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<List<NumberPlan>> PutSiteNumberplansAsync (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> response = await PutSiteNumberplansAsyncWithHttpInfo(siteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> PutSiteNumberplansAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling PutSiteNumberplans");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSiteNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSiteNumberplans: " + response.ErrorMessage, response.ErrorMessage);

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
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSiteNumberplansClassifications");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans/classifications";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            if (classification != null) queryParams.Add("classification", Configuration.ApiClient.ParameterToString(classification)); // query parameter
            
            
            
            

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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            if (classification != null) queryParams.Add("classification", Configuration.ApiClient.ParameterToString(classification)); // query parameter
            
            
            
            

            
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
        public NumberPlan GetSiteNumberplan (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> response = GetSiteNumberplanWithHttpInfo(siteId, numberPlanId);
             return response.Data;
        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="numberPlanId">Number Plan ID</param> 
        /// <returns>ApiResponse of NumberPlan</returns>
        public ApiResponse< NumberPlan > GetSiteNumberplanWithHttpInfo (string siteId, string numberPlanId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSiteNumberplan");
            
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null)
                throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling ConfigurationApi->GetSiteNumberplan");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans/{numberPlanId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (numberPlanId != null) pathParams.Add("numberPlanId", Configuration.ApiClient.ParameterToString(numberPlanId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetSiteNumberplan: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSiteNumberplan: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<NumberPlan> GetSiteNumberplanAsync (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> response = await GetSiteNumberplanAsyncWithHttpInfo(siteId, numberPlanId);
             return response.Data;

        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NumberPlan>> GetSiteNumberplanAsyncWithHttpInfo (string siteId, string numberPlanId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSiteNumberplan");
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null) throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling GetSiteNumberplan");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/numberplans/{numberPlanId}";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (numberPlanId != null) pathParams.Add("numberPlanId", Configuration.ApiClient.ParameterToString(numberPlanId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSiteNumberplan: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSiteNumberplan: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<NumberPlan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NumberPlan) Configuration.ApiClient.Deserialize(response, typeof(NumberPlan)));
            
        }
        
        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns></returns>
        public void PostSiteRebalance (string siteId)
        {
             PostSiteRebalanceWithHttpInfo(siteId);
        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostSiteRebalanceWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->PostSiteRebalance");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/rebalance";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostSiteRebalance: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSiteRebalance: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostSiteRebalanceAsync (string siteId)
        {
             await PostSiteRebalanceAsyncWithHttpInfo(siteId);

        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostSiteRebalanceAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling PostSiteRebalance");
            
    
            var path_ = "/api/v1/configuration/sites/{siteId}/rebalance";
    
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
            if (siteId != null) pathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostSiteRebalance: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSiteRebalance: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
