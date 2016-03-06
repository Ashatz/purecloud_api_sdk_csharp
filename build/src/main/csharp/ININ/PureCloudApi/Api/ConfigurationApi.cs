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
        DIDPool GetDidpoolsDidpoolId (string didPoolId);
  
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> GetDidpoolsDidpoolIdWithHttpInfo (string didPoolId);

        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> GetDidpoolsDidpoolIdAsync (string didPoolId);

        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> GetDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId);
        
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>DIDPool</returns>
        DIDPool PutDidpoolsDidpoolId (string didPoolId, DIDPool body = null);
  
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> PutDidpoolsDidpoolIdWithHttpInfo (string didPoolId, DIDPool body = null);

        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> PutDidpoolsDidpoolIdAsync (string didPoolId, DIDPool body = null);

        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> PutDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId, DIDPool body = null);
        
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>string</returns>
        string DeleteDidpoolsDidpoolId (string didPoolId);
  
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteDidpoolsDidpoolIdWithHttpInfo (string didPoolId);

        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteDidpoolsDidpoolIdAsync (string didPoolId);

        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId);
        
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
        DID GetDidsDidId (string didId);
  
        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> GetDidsDidIdWithHttpInfo (string didId);

        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> GetDidsDidIdAsync (string didId);

        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> GetDidsDidIdAsyncWithHttpInfo (string didId);
        
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>DID</returns>
        DID PutDidsDidId (string didId, DID body = null);
  
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> PutDidsDidIdWithHttpInfo (string didId, DID body = null);

        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> PutDidsDidIdAsync (string didId, DID body = null);

        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> PutDidsDidIdAsyncWithHttpInfo (string didId, DID body = null);
        
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
        DomainCertificateAuthority GetEdgesCertificateauthoritiesCertificateId (string certificateId);
  
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> GetEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId);

        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> GetEdgesCertificateauthoritiesCertificateIdAsync (string certificateId);

        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> GetEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId);
        
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority PutEdgesCertificateauthoritiesCertificateId (string certificateId, DomainCertificateAuthority body = null);
  
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> PutEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);

        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> PutEdgesCertificateauthoritiesCertificateIdAsync (string certificateId, DomainCertificateAuthority body = null);

        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PutEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);
        
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>string</returns>
        string DeleteEdgesCertificateauthoritiesCertificateId (string certificateId);
  
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId);

        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgesCertificateauthoritiesCertificateIdAsync (string certificateId);

        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId);
        
        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Edge</returns>
        Edge GetEdgesEdgeId (string edgeId);
  
        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> GetEdgesEdgeIdWithHttpInfo (string edgeId);

        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> GetEdgesEdgeIdAsync (string edgeId);

        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> GetEdgesEdgeIdAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Edge</returns>
        Edge PutEdgesEdgeId (string edgeId, Edge body = null);
  
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> PutEdgesEdgeIdWithHttpInfo (string edgeId, Edge body = null);

        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> PutEdgesEdgeIdAsync (string edgeId, Edge body = null);

        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> PutEdgesEdgeIdAsyncWithHttpInfo (string edgeId, Edge body = null);
        
        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string DeleteEdgesEdgeId (string edgeId);
  
        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgesEdgeIdWithHttpInfo (string edgeId);

        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgesEdgeIdAsync (string edgeId);

        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesEdgeIdAsyncWithHttpInfo (string edgeId);
        
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
        EdgeLineEntityListing GetEdgesEdgeIdLines (string edgeId, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<EdgeLineEntityListing> GetEdgesEdgeIdLinesWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<EdgeLineEntityListing> GetEdgesEdgeIdLinesAsync (string edgeId, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<EdgeLineEntityListing>> GetEdgesEdgeIdLinesAsyncWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>EdgeLine</returns>
        EdgeLine GetEdgesEdgeIdLinesLineId (string edgeId, string lineId);
  
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        ApiResponse<EdgeLine> GetEdgesEdgeIdLinesLineIdWithHttpInfo (string edgeId, string lineId);

        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of EdgeLine</returns>
        System.Threading.Tasks.Task<EdgeLine> GetEdgesEdgeIdLinesLineIdAsync (string edgeId, string lineId);

        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> GetEdgesEdgeIdLinesLineIdAsyncWithHttpInfo (string edgeId, string lineId);
        
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
        EdgeLine PutEdgesEdgeIdLinesLineId (string edgeId, string lineId, EdgeLine body = null);
  
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
        ApiResponse<EdgeLine> PutEdgesEdgeIdLinesLineIdWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);

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
        System.Threading.Tasks.Task<EdgeLine> PutEdgesEdgeIdLinesLineIdAsync (string edgeId, string lineId, EdgeLine body = null);

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
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> PutEdgesEdgeIdLinesLineIdAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);
        
        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>LogicalInterfaceEntityListing</returns>
        LogicalInterfaceEntityListing GetEdgesEdgeIdLogicalinterfaces (string edgeId);
  
        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of LogicalInterfaceEntityListing</returns>
        ApiResponse<LogicalInterfaceEntityListing> GetEdgesEdgeIdLogicalinterfacesWithHttpInfo (string edgeId);

        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of LogicalInterfaceEntityListing</returns>
        System.Threading.Tasks.Task<LogicalInterfaceEntityListing> GetEdgesEdgeIdLogicalinterfacesAsync (string edgeId);

        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (LogicalInterfaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LogicalInterfaceEntityListing>> GetEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface PostEdgesEdgeIdLogicalinterfaces (string edgeId, DomainLogicalInterface body = null);
  
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> PostEdgesEdgeIdLogicalinterfacesWithHttpInfo (string edgeId, DomainLogicalInterface body = null);

        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> PostEdgesEdgeIdLogicalinterfacesAsync (string edgeId, DomainLogicalInterface body = null);

        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PostEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface GetEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId);
  
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> GetEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId);

        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId);
        
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
        DomainLogicalInterface PutEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId, DomainLogicalInterface body = null);
  
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
        ApiResponse<DomainLogicalInterface> PutEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);

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
        System.Threading.Tasks.Task<DomainLogicalInterface> PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null);

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
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns></returns>
        void DeleteEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId);
  
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId);

        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>EdgeLogsJobResponse</returns>
        EdgeLogsJobResponse PostEdgesEdgeIdLogsJobs (string edgeId, EdgeLogsJobRequest body = null);
  
        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>ApiResponse of EdgeLogsJobResponse</returns>
        ApiResponse<EdgeLogsJobResponse> PostEdgesEdgeIdLogsJobsWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null);

        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of EdgeLogsJobResponse</returns>
        System.Threading.Tasks.Task<EdgeLogsJobResponse> PostEdgesEdgeIdLogsJobsAsync (string edgeId, EdgeLogsJobRequest body = null);

        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of ApiResponse (EdgeLogsJobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLogsJobResponse>> PostEdgesEdgeIdLogsJobsAsyncWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null);
        
        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>EdgeLogsJob</returns>
        EdgeLogsJob GetEdgesEdgeIdLogsJobsJobId (string edgeId, string jobId);
  
        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of EdgeLogsJob</returns>
        ApiResponse<EdgeLogsJob> GetEdgesEdgeIdLogsJobsJobIdWithHttpInfo (string edgeId, string jobId);

        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of EdgeLogsJob</returns>
        System.Threading.Tasks.Task<EdgeLogsJob> GetEdgesEdgeIdLogsJobsJobIdAsync (string edgeId, string jobId);

        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (EdgeLogsJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLogsJob>> GetEdgesEdgeIdLogsJobsJobIdAsyncWithHttpInfo (string edgeId, string jobId);
        
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PostEdgesEdgeIdLogsJobsJobIdUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);
  
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostEdgesEdgeIdLogsJobsJobIdUploadWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostEdgesEdgeIdLogsJobsJobIdUploadAsync (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostEdgesEdgeIdLogsJobsJobIdUploadAsyncWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);
        
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>PhysicalInterfaceEntityListing</returns>
        PhysicalInterfaceEntityListing GetEdgesEdgeIdPhysicalinterfaces (string edgeId);
  
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of PhysicalInterfaceEntityListing</returns>
        ApiResponse<PhysicalInterfaceEntityListing> GetEdgesEdgeIdPhysicalinterfacesWithHttpInfo (string edgeId);

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of PhysicalInterfaceEntityListing</returns>
        System.Threading.Tasks.Task<PhysicalInterfaceEntityListing> GetEdgesEdgeIdPhysicalinterfacesAsync (string edgeId);

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (PhysicalInterfaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhysicalInterfaceEntityListing>> GetEdgesEdgeIdPhysicalinterfacesAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainPhysicalInterface</returns>
        DomainPhysicalInterface GetEdgesEdgeIdPhysicalinterfacesInterfaceId (string edgeId, string interfaceId);
  
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        ApiResponse<DomainPhysicalInterface> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId);

        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainPhysicalInterface</returns>
        System.Threading.Tasks.Task<DomainPhysicalInterface> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string PostEdgesEdgeIdReboot (string edgeId);
  
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostEdgesEdgeIdRebootWithHttpInfo (string edgeId);

        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostEdgesEdgeIdRebootAsync (string edgeId);

        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostEdgesEdgeIdRebootAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        DomainEdgeSoftwareUpdateDto GetEdgesEdgeIdSoftwareupdate (string edgeId);
  
        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        ApiResponse<DomainEdgeSoftwareUpdateDto> GetEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId);

        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> GetEdgesEdgeIdSoftwareupdateAsync (string edgeId);

        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> GetEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        DomainEdgeSoftwareUpdateDto PostEdgesEdgeIdSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
  
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        ApiResponse<DomainEdgeSoftwareUpdateDto> PostEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);

        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> PostEdgesEdgeIdSoftwareupdateAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null);

        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> PostEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
        
        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string DeleteEdgesEdgeIdSoftwareupdate (string edgeId);
  
        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId);

        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgesEdgeIdSoftwareupdateAsync (string edgeId);

        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareVersionDto</returns>
        DomainEdgeSoftwareVersionDto GetEdgesEdgeIdSoftwareversions (string edgeId);
  
        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareVersionDto</returns>
        ApiResponse<DomainEdgeSoftwareVersionDto> GetEdgesEdgeIdSoftwareversionsWithHttpInfo (string edgeId);

        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareVersionDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareVersionDto> GetEdgesEdgeIdSoftwareversionsAsync (string edgeId);

        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareVersionDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareVersionDto>> GetEdgesEdgeIdSoftwareversionsAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>string</returns>
        string PostEdgesEdgeIdUnpair (string edgeId);
  
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostEdgesEdgeIdUnpairWithHttpInfo (string edgeId);

        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostEdgesEdgeIdUnpairAsync (string edgeId);

        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostEdgesEdgeIdUnpairAsyncWithHttpInfo (string edgeId);
        
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
        Endpoint GetEndpointsEndpointId (string endpointId);
  
        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> GetEndpointsEndpointIdWithHttpInfo (string endpointId);

        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> GetEndpointsEndpointIdAsync (string endpointId);

        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> GetEndpointsEndpointIdAsyncWithHttpInfo (string endpointId);
        
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Endpoint</returns>
        Endpoint PutEndpointsEndpointId (string endpointId, Endpoint body = null);
  
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> PutEndpointsEndpointIdWithHttpInfo (string endpointId, Endpoint body = null);

        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> PutEndpointsEndpointIdAsync (string endpointId, Endpoint body = null);

        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> PutEndpointsEndpointIdAsyncWithHttpInfo (string endpointId, Endpoint body = null);
        
        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>string</returns>
        string DeleteEndpointsEndpointId (string endpointId);
  
        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEndpointsEndpointIdWithHttpInfo (string endpointId);

        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEndpointsEndpointIdAsync (string endpointId);

        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEndpointsEndpointIdAsyncWithHttpInfo (string endpointId);
        
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
        ExtensionPool GetExtensionpoolsExtensionpoolId (string extensionPoolId);
  
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> GetExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId);

        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> GetExtensionpoolsExtensionpoolIdAsync (string extensionPoolId);

        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> GetExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId);
        
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ExtensionPool</returns>
        ExtensionPool PutExtensionpoolsExtensionpoolId (string extensionPoolId, ExtensionPool body = null);
  
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> PutExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId, ExtensionPool body = null);

        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> PutExtensionpoolsExtensionpoolIdAsync (string extensionPoolId, ExtensionPool body = null);

        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> PutExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null);
        
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>string</returns>
        string DeleteExtensionpoolsExtensionpoolId (string extensionPoolId);
  
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId);

        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteExtensionpoolsExtensionpoolIdAsync (string extensionPoolId);

        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId);
        
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
        Extension GetExtensionsExtensionId (string extensionId);
  
        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> GetExtensionsExtensionIdWithHttpInfo (string extensionId);

        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> GetExtensionsExtensionIdAsync (string extensionId);

        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> GetExtensionsExtensionIdAsyncWithHttpInfo (string extensionId);
        
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Extension</returns>
        Extension PutExtensionsExtensionId (string extensionId, Extension body = null);
  
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> PutExtensionsExtensionIdWithHttpInfo (string extensionId, Extension body = null);

        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> PutExtensionsExtensionIdAsync (string extensionId, Extension body = null);

        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> PutExtensionsExtensionIdAsyncWithHttpInfo (string extensionId, Extension body = null);
        
        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
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
        PolicyEntityListing GetMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
  
        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
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
        ApiResponse<PolicyEntityListing> GetMediaretentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
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
        System.Threading.Tasks.Task<PolicyEntityListing> GetMediaretentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
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
        System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetMediaretentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
        
        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PostMediaretentionpolicies (Policy body = null);
  
        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PostMediaretentionpoliciesWithHttpInfo (Policy body = null);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PostMediaretentionpoliciesAsync (Policy body = null);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PostMediaretentionpoliciesAsyncWithHttpInfo (Policy body = null);
        
        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <param name="ids"></param>
        /// <returns>string</returns>
        string DeleteMediaretentionpolicies (string ids);
  
        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteMediaretentionpoliciesWithHttpInfo (string ids);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMediaretentionpoliciesAsync (string ids);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMediaretentionpoliciesAsyncWithHttpInfo (string ids);
        
        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Policy</returns>
        Policy GetMediaretentionpoliciesPolicyId (string policyId);
  
        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> GetMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> GetMediaretentionpoliciesPolicyIdAsync (string policyId);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> GetMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PutMediaretentionpoliciesPolicyId (string policyId, Policy body = null);
  
        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PutMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PutMediaretentionpoliciesPolicyIdAsync (string policyId, Policy body = null);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PutMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null);
        
        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>string</returns>
        string DeleteMediaretentionpoliciesPolicyId (string policyId);
  
        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMediaretentionpoliciesPolicyIdAsync (string policyId);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PatchMediaretentionpoliciesPolicyId (string policyId, Policy body = null);
  
        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PatchMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PatchMediaretentionpoliciesPolicyIdAsync (string policyId, Policy body = null);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PatchMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null);
        
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
        Organization GetOrganizationsOrgId (string orgId);
  
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetOrganizationsOrgIdWithHttpInfo (string orgId);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetOrganizationsOrgIdAsync (string orgId);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationsOrgIdAsyncWithHttpInfo (string orgId);
        
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Organization</returns>
        Organization PutOrganizationsOrgId (string orgId, Organization body = null);
  
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> PutOrganizationsOrgIdWithHttpInfo (string orgId, Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> PutOrganizationsOrgIdAsync (string orgId, Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationsOrgIdAsyncWithHttpInfo (string orgId, Organization body = null);
        
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>string</returns>
        string DeleteOrganizationsOrgId (string orgId);
  
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteOrganizationsOrgIdWithHttpInfo (string orgId);

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteOrganizationsOrgIdAsync (string orgId);

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteOrganizationsOrgIdAsyncWithHttpInfo (string orgId);
        
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
        Policy GetRetentionpoliciesPolicyId (string policyId);
  
        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> GetRetentionpoliciesPolicyIdWithHttpInfo (string policyId);

        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> GetRetentionpoliciesPolicyIdAsync (string policyId);

        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> GetRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PutRetentionpoliciesPolicyId (string policyId, Policy body = null);
  
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PutRetentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null);

        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PutRetentionpoliciesPolicyIdAsync (string policyId, Policy body = null);

        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PutRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null);
        
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>string</returns>
        string DeleteRetentionpoliciesPolicyId (string policyId);
  
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteRetentionpoliciesPolicyIdWithHttpInfo (string policyId);

        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteRetentionpoliciesPolicyIdAsync (string policyId);

        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PatchRetentionpoliciesPolicyId (string policyId, Policy body = null);
  
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PatchRetentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null);

        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PatchRetentionpoliciesPolicyIdAsync (string policyId, Policy body = null);

        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null);
        
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
        SchemaReferenceEntityListing GetSchemasEdgesVnextSchemacategory (string schemaCategory, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategoryWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategoryAsync (string schemaCategory, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemacategoryAsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);
        
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
        SchemaReferenceEntityListing GetSchemasEdgesVnextSchemacategorySchematype (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategorySchematypeWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategorySchematypeAsync (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemacategorySchematypeAsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
        
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
        Organization GetSchemasEdgesVnextSchemacategorySchematypeSchemaId (string schemaCategory, string schemaType, string schemaId);
  
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
        ApiResponse<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId);

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
        System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsync (string schemaCategory, string schemaType, string schemaId);

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
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId);
        
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
        Organization GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
  
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
        ApiResponse<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);

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
        System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsync (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);

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
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
        
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
        Site GetSitesSiteId (string siteId);
  
        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> GetSitesSiteIdWithHttpInfo (string siteId);

        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> GetSitesSiteIdAsync (string siteId);

        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> GetSitesSiteIdAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Site</returns>
        Site PutSitesSiteId (string siteId, Site body = null);
  
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> PutSitesSiteIdWithHttpInfo (string siteId, Site body = null);

        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> PutSitesSiteIdAsync (string siteId, Site body = null);

        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> PutSitesSiteIdAsyncWithHttpInfo (string siteId, Site body = null);
        
        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>string</returns>
        string DeleteSitesSiteId (string siteId);
  
        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSitesSiteIdWithHttpInfo (string siteId);

        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSitesSiteIdAsync (string siteId);

        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSitesSiteIdAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        List<NumberPlan> GetSitesSiteIdNumberplans (string siteId);
  
        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        ApiResponse<List<NumberPlan>> GetSitesSiteIdNumberplansWithHttpInfo (string siteId);

        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        System.Threading.Tasks.Task<List<NumberPlan>> GetSitesSiteIdNumberplansAsync (string siteId);

        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> GetSitesSiteIdNumberplansAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        List<NumberPlan> PutSitesSiteIdNumberplans (string siteId, List<NumberPlan> body = null);
  
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        ApiResponse<List<NumberPlan>> PutSitesSiteIdNumberplansWithHttpInfo (string siteId, List<NumberPlan> body = null);

        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        System.Threading.Tasks.Task<List<NumberPlan>> PutSitesSiteIdNumberplansAsync (string siteId, List<NumberPlan> body = null);

        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> PutSitesSiteIdNumberplansAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null);
        
        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetSitesSiteIdNumberplansClassifications (string siteId, string classification = null);
  
        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetSitesSiteIdNumberplansClassificationsWithHttpInfo (string siteId, string classification = null);

        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetSitesSiteIdNumberplansClassificationsAsync (string siteId, string classification = null);

        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetSitesSiteIdNumberplansClassificationsAsyncWithHttpInfo (string siteId, string classification = null);
        
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>NumberPlan</returns>
        NumberPlan GetSitesSiteIdNumberplansNumberplanId (string siteId, string numberPlanId);
  
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>ApiResponse of NumberPlan</returns>
        ApiResponse<NumberPlan> GetSitesSiteIdNumberplansNumberplanIdWithHttpInfo (string siteId, string numberPlanId);

        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of NumberPlan</returns>
        System.Threading.Tasks.Task<NumberPlan> GetSitesSiteIdNumberplansNumberplanIdAsync (string siteId, string numberPlanId);

        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<NumberPlan>> GetSitesSiteIdNumberplansNumberplanIdAsyncWithHttpInfo (string siteId, string numberPlanId);
        
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns></returns>
        void PostSitesSiteIdRebalance (string siteId);
  
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostSitesSiteIdRebalanceWithHttpInfo (string siteId);

        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostSitesSiteIdRebalanceAsync (string siteId);

        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostSitesSiteIdRebalanceAsyncWithHttpInfo (string siteId);
        
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
        public DIDPool GetDidpoolsDidpoolId (string didPoolId)
        {
             ApiResponse<DIDPool> response = GetDidpoolsDidpoolIdWithHttpInfo(didPoolId);
             return response.Data;
        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > GetDidpoolsDidpoolIdWithHttpInfo (string didPoolId)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->GetDidpoolsDidpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetDidpoolsDidpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidpoolsDidpoolId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
    
        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> GetDidpoolsDidpoolIdAsync (string didPoolId)
        {
             ApiResponse<DIDPool> response = await GetDidpoolsDidpoolIdAsyncWithHttpInfo(didPoolId);
             return response.Data;

        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> GetDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling GetDidpoolsDidpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetDidpoolsDidpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidpoolsDidpoolId: " + response.ErrorMessage, response.ErrorMessage);

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
        public DIDPool PutDidpoolsDidpoolId (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> response = PutDidpoolsDidpoolIdWithHttpInfo(didPoolId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > PutDidpoolsDidpoolIdWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->PutDidpoolsDidpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutDidpoolsDidpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDidpoolsDidpoolId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DIDPool> PutDidpoolsDidpoolIdAsync (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> response = await PutDidpoolsDidpoolIdAsyncWithHttpInfo(didPoolId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> PutDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling PutDidpoolsDidpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutDidpoolsDidpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDidpoolsDidpoolId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DIDPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(response, typeof(DIDPool)));
            
        }
        
        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>string</returns>
        public string DeleteDidpoolsDidpoolId (string didPoolId)
        {
             ApiResponse<string> response = DeleteDidpoolsDidpoolIdWithHttpInfo(didPoolId);
             return response.Data;
        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteDidpoolsDidpoolIdWithHttpInfo (string didPoolId)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->DeleteDidpoolsDidpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteDidpoolsDidpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDidpoolsDidpoolId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteDidpoolsDidpoolIdAsync (string didPoolId)
        {
             ApiResponse<string> response = await DeleteDidpoolsDidpoolIdAsyncWithHttpInfo(didPoolId);
             return response.Data;

        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling DeleteDidpoolsDidpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteDidpoolsDidpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDidpoolsDidpoolId: " + response.ErrorMessage, response.ErrorMessage);

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
        public DID GetDidsDidId (string didId)
        {
             ApiResponse<DID> response = GetDidsDidIdWithHttpInfo(didId);
             return response.Data;
        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param> 
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > GetDidsDidIdWithHttpInfo (string didId)
        {
            
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->GetDidsDidId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetDidsDidId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidsDidId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DID>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(response, typeof(DID)));
            
        }
    
        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        public async System.Threading.Tasks.Task<DID> GetDidsDidIdAsync (string didId)
        {
             ApiResponse<DID> response = await GetDidsDidIdAsyncWithHttpInfo(didId);
             return response.Data;

        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> GetDidsDidIdAsyncWithHttpInfo (string didId)
        {
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling GetDidsDidId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetDidsDidId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDidsDidId: " + response.ErrorMessage, response.ErrorMessage);

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
        public DID PutDidsDidId (string didId, DID body = null)
        {
             ApiResponse<DID> response = PutDidsDidIdWithHttpInfo(didId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > PutDidsDidIdWithHttpInfo (string didId, DID body = null)
        {
            
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->PutDidsDidId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutDidsDidId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDidsDidId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DID> PutDidsDidIdAsync (string didId, DID body = null)
        {
             ApiResponse<DID> response = await PutDidsDidIdAsyncWithHttpInfo(didId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> PutDidsDidIdAsyncWithHttpInfo (string didId, DID body = null)
        {
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling PutDidsDidId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutDidsDidId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDidsDidId: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainCertificateAuthority GetEdgesCertificateauthoritiesCertificateId (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> response = GetEdgesCertificateauthoritiesCertificateIdWithHttpInfo(certificateId);
             return response.Data;
        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > GetEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->GetEdgesCertificateauthoritiesCertificateId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritiesCertificateId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritiesCertificateId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
    
        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> GetEdgesCertificateauthoritiesCertificateIdAsync (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> response = await GetEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo(certificateId);
             return response.Data;

        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> GetEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling GetEdgesCertificateauthoritiesCertificateId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritiesCertificateId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesCertificateauthoritiesCertificateId: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainCertificateAuthority PutEdgesCertificateauthoritiesCertificateId (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = PutEdgesCertificateauthoritiesCertificateIdWithHttpInfo(certificateId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > PutEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->PutEdgesCertificateauthoritiesCertificateId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEdgesCertificateauthoritiesCertificateId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesCertificateauthoritiesCertificateId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> PutEdgesCertificateauthoritiesCertificateIdAsync (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> response = await PutEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo(certificateId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PutEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling PutEdgesCertificateauthoritiesCertificateId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEdgesCertificateauthoritiesCertificateId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesCertificateauthoritiesCertificateId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(response, typeof(DomainCertificateAuthority)));
            
        }
        
        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>string</returns>
        public string DeleteEdgesCertificateauthoritiesCertificateId (string certificateId)
        {
             ApiResponse<string> response = DeleteEdgesCertificateauthoritiesCertificateIdWithHttpInfo(certificateId);
             return response.Data;
        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->DeleteEdgesCertificateauthoritiesCertificateId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificateId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificateId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgesCertificateauthoritiesCertificateIdAsync (string certificateId)
        {
             ApiResponse<string> response = await DeleteEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo(certificateId);
             return response.Data;

        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling DeleteEdgesCertificateauthoritiesCertificateId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificateId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificateId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>Edge</returns>
        public Edge GetEdgesEdgeId (string edgeId)
        {
             ApiResponse<Edge> response = GetEdgesEdgeIdWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > GetEdgesEdgeIdWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Edge>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(response, typeof(Edge)));
            
        }
    
        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> GetEdgesEdgeIdAsync (string edgeId)
        {
             ApiResponse<Edge> response = await GetEdgesEdgeIdAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> GetEdgesEdgeIdAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Edge PutEdgesEdgeId (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> response = PutEdgesEdgeIdWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">Edge</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > PutEdgesEdgeIdWithHttpInfo (string edgeId, Edge body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PutEdgesEdgeId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Edge> PutEdgesEdgeIdAsync (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> response = await PutEdgesEdgeIdAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> PutEdgesEdgeIdAsyncWithHttpInfo (string edgeId, Edge body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PutEdgesEdgeId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Edge>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(response, typeof(Edge)));
            
        }
        
        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string DeleteEdgesEdgeId (string edgeId)
        {
             ApiResponse<string> response = DeleteEdgesEdgeIdWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgesEdgeIdWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->DeleteEdgesEdgeId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgesEdgeIdAsync (string edgeId)
        {
             ApiResponse<string> response = await DeleteEdgesEdgeIdAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesEdgeIdAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgesEdgeId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeId: " + response.ErrorMessage, response.ErrorMessage);

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
        public EdgeLineEntityListing GetEdgesEdgeIdLines (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EdgeLineEntityListing> response = GetEdgesEdgeIdLinesWithHttpInfo(edgeId, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of EdgeLineEntityListing</returns>
        public ApiResponse< EdgeLineEntityListing > GetEdgesEdgeIdLinesWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLines");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLines: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLines: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeLineEntityListing> GetEdgesEdgeIdLinesAsync (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EdgeLineEntityListing> response = await GetEdgesEdgeIdLinesAsyncWithHttpInfo(edgeId, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EdgeLineEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLineEntityListing>> GetEdgesEdgeIdLinesAsyncWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLines");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLines: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLines: " + response.ErrorMessage, response.ErrorMessage);

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
        public EdgeLine GetEdgesEdgeIdLinesLineId (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> response = GetEdgesEdgeIdLinesLineIdWithHttpInfo(edgeId, lineId);
             return response.Data;
        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > GetEdgesEdgeIdLinesLineIdWithHttpInfo (string edgeId, string lineId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLinesLineId");
            
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->GetEdgesEdgeIdLinesLineId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLinesLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLinesLineId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeLine> GetEdgesEdgeIdLinesLineIdAsync (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> response = await GetEdgesEdgeIdLinesLineIdAsyncWithHttpInfo(edgeId, lineId);
             return response.Data;

        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> GetEdgesEdgeIdLinesLineIdAsyncWithHttpInfo (string edgeId, string lineId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLinesLineId");
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetEdgesEdgeIdLinesLineId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLinesLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLinesLineId: " + response.ErrorMessage, response.ErrorMessage);

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
        public EdgeLine PutEdgesEdgeIdLinesLineId (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> response = PutEdgesEdgeIdLinesLineIdWithHttpInfo(edgeId, lineId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <param name="body">Line</param> 
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > PutEdgesEdgeIdLinesLineIdWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PutEdgesEdgeIdLinesLineId");
            
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->PutEdgesEdgeIdLinesLineId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeIdLinesLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeIdLinesLineId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeLine> PutEdgesEdgeIdLinesLineIdAsync (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> response = await PutEdgesEdgeIdLinesLineIdAsyncWithHttpInfo(edgeId, lineId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> PutEdgesEdgeIdLinesLineIdAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PutEdgesEdgeIdLinesLineId");
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling PutEdgesEdgeIdLinesLineId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeIdLinesLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeIdLinesLineId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeLine>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(response, typeof(EdgeLine)));
            
        }
        
        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>LogicalInterfaceEntityListing</returns>
        public LogicalInterfaceEntityListing GetEdgesEdgeIdLogicalinterfaces (string edgeId)
        {
             ApiResponse<LogicalInterfaceEntityListing> response = GetEdgesEdgeIdLogicalinterfacesWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of LogicalInterfaceEntityListing</returns>
        public ApiResponse< LogicalInterfaceEntityListing > GetEdgesEdgeIdLogicalinterfacesWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLogicalinterfaces");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LogicalInterfaceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LogicalInterfaceEntityListing)));
            
        }
    
        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of LogicalInterfaceEntityListing</returns>
        public async System.Threading.Tasks.Task<LogicalInterfaceEntityListing> GetEdgesEdgeIdLogicalinterfacesAsync (string edgeId)
        {
             ApiResponse<LogicalInterfaceEntityListing> response = await GetEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (LogicalInterfaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LogicalInterfaceEntityListing>> GetEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLogicalinterfaces");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainLogicalInterface PostEdgesEdgeIdLogicalinterfaces (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = PostEdgesEdgeIdLogicalinterfacesWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > PostEdgesEdgeIdLogicalinterfacesWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdLogicalinterfaces");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainLogicalInterface> PostEdgesEdgeIdLogicalinterfacesAsync (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = await PostEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PostEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdLogicalinterfaces");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainLogicalInterface GetEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> response = GetEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo(edgeId, interfaceId);
             return response.Data;
        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > GetEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLogicalinterfacesInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->GetEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainLogicalInterface> GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> response = await GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId);
             return response.Data;

        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLogicalinterfacesInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainLogicalInterface PutEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = PutEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo(edgeId, interfaceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > PutEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PutEdgesEdgeIdLogicalinterfacesInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->PutEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainLogicalInterface> PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> response = await PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PutEdgesEdgeIdLogicalinterfacesInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling PutEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId)
        {
             DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo(edgeId, interfaceId);
        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->DeleteEdgesEdgeIdLogicalinterfacesInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->DeleteEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId)
        {
             await DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId);

        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public EdgeLogsJobResponse PostEdgesEdgeIdLogsJobs (string edgeId, EdgeLogsJobRequest body = null)
        {
             ApiResponse<EdgeLogsJobResponse> response = PostEdgesEdgeIdLogsJobsWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">EdgeLogsJobRequest</param> 
        /// <returns>ApiResponse of EdgeLogsJobResponse</returns>
        public ApiResponse< EdgeLogsJobResponse > PostEdgesEdgeIdLogsJobsWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdLogsJobs");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogsJobs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogsJobs: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeLogsJobResponse> PostEdgesEdgeIdLogsJobsAsync (string edgeId, EdgeLogsJobRequest body = null)
        {
             ApiResponse<EdgeLogsJobResponse> response = await PostEdgesEdgeIdLogsJobsAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of ApiResponse (EdgeLogsJobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLogsJobResponse>> PostEdgesEdgeIdLogsJobsAsyncWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdLogsJobs");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogsJobs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogsJobs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeLogsJobResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLogsJobResponse) Configuration.ApiClient.Deserialize(response, typeof(EdgeLogsJobResponse)));
            
        }
        
        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId">Job ID</param> 
        /// <returns>EdgeLogsJob</returns>
        public EdgeLogsJob GetEdgesEdgeIdLogsJobsJobId (string edgeId, string jobId)
        {
             ApiResponse<EdgeLogsJob> response = GetEdgesEdgeIdLogsJobsJobIdWithHttpInfo(edgeId, jobId);
             return response.Data;
        }

        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId">Job ID</param> 
        /// <returns>ApiResponse of EdgeLogsJob</returns>
        public ApiResponse< EdgeLogsJob > GetEdgesEdgeIdLogsJobsJobIdWithHttpInfo (string edgeId, string jobId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLogsJobsJobId");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ConfigurationApi->GetEdgesEdgeIdLogsJobsJobId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogsJobsJobId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogsJobsJobId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeLogsJob>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLogsJob) Configuration.ApiClient.Deserialize(response, typeof(EdgeLogsJob)));
            
        }
    
        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of EdgeLogsJob</returns>
        public async System.Threading.Tasks.Task<EdgeLogsJob> GetEdgesEdgeIdLogsJobsJobIdAsync (string edgeId, string jobId)
        {
             ApiResponse<EdgeLogsJob> response = await GetEdgesEdgeIdLogsJobsJobIdAsyncWithHttpInfo(edgeId, jobId);
             return response.Data;

        }

        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (EdgeLogsJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLogsJob>> GetEdgesEdgeIdLogsJobsJobIdAsyncWithHttpInfo (string edgeId, string jobId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLogsJobsJobId");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling GetEdgesEdgeIdLogsJobsJobId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogsJobsJobId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdLogsJobsJobId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeLogsJob>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLogsJob) Configuration.ApiClient.Deserialize(response, typeof(EdgeLogsJob)));
            
        }
        
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId">Job ID</param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PostEdgesEdgeIdLogsJobsJobIdUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
             PostEdgesEdgeIdLogsJobsJobIdUploadWithHttpInfo(edgeId, jobId, body);
        }

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId">Job ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostEdgesEdgeIdLogsJobsJobIdUploadWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdLogsJobsJobIdUpload");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ConfigurationApi->PostEdgesEdgeIdLogsJobsJobIdUpload");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogsJobsJobIdUpload: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogsJobsJobIdUpload: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostEdgesEdgeIdLogsJobsJobIdUploadAsync (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
             await PostEdgesEdgeIdLogsJobsJobIdUploadAsyncWithHttpInfo(edgeId, jobId, body);

        }

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostEdgesEdgeIdLogsJobsJobIdUploadAsyncWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdLogsJobsJobIdUpload");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling PostEdgesEdgeIdLogsJobsJobIdUpload");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogsJobsJobIdUpload: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdLogsJobsJobIdUpload: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>PhysicalInterfaceEntityListing</returns>
        public PhysicalInterfaceEntityListing GetEdgesEdgeIdPhysicalinterfaces (string edgeId)
        {
             ApiResponse<PhysicalInterfaceEntityListing> response = GetEdgesEdgeIdPhysicalinterfacesWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of PhysicalInterfaceEntityListing</returns>
        public ApiResponse< PhysicalInterfaceEntityListing > GetEdgesEdgeIdPhysicalinterfacesWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdPhysicalinterfaces");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdPhysicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdPhysicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhysicalInterfaceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhysicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhysicalInterfaceEntityListing)));
            
        }
    
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of PhysicalInterfaceEntityListing</returns>
        public async System.Threading.Tasks.Task<PhysicalInterfaceEntityListing> GetEdgesEdgeIdPhysicalinterfacesAsync (string edgeId)
        {
             ApiResponse<PhysicalInterfaceEntityListing> response = await GetEdgesEdgeIdPhysicalinterfacesAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (PhysicalInterfaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhysicalInterfaceEntityListing>> GetEdgesEdgeIdPhysicalinterfacesAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdPhysicalinterfaces");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdPhysicalinterfaces: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdPhysicalinterfaces: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainPhysicalInterface GetEdgesEdgeIdPhysicalinterfacesInterfaceId (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> response = GetEdgesEdgeIdPhysicalinterfacesInterfaceIdWithHttpInfo(edgeId, interfaceId);
             return response.Data;
        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        public ApiResponse< DomainPhysicalInterface > GetEdgesEdgeIdPhysicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdPhysicalinterfacesInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->GetEdgesEdgeIdPhysicalinterfacesInterfaceId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainPhysicalInterface> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> response = await GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId);
             return response.Data;

        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainPhysicalInterface>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainPhysicalInterface) Configuration.ApiClient.Deserialize(response, typeof(DomainPhysicalInterface)));
            
        }
        
        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string PostEdgesEdgeIdReboot (string edgeId)
        {
             ApiResponse<string> response = PostEdgesEdgeIdRebootWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostEdgesEdgeIdRebootWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdReboot");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdReboot: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostEdgesEdgeIdRebootAsync (string edgeId)
        {
             ApiResponse<string> response = await PostEdgesEdgeIdRebootAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostEdgesEdgeIdRebootAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdReboot");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdReboot: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        public DomainEdgeSoftwareUpdateDto GetEdgesEdgeIdSoftwareupdate (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> response = GetEdgesEdgeIdSoftwareupdateWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        public ApiResponse< DomainEdgeSoftwareUpdateDto > GetEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdSoftwareupdate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }
    
        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> GetEdgesEdgeIdSoftwareupdateAsync (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> response = await GetEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> GetEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdSoftwareupdate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);

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
        public DomainEdgeSoftwareUpdateDto PostEdgesEdgeIdSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> response = PostEdgesEdgeIdSoftwareupdateWithHttpInfo(edgeId, body);
             return response.Data;
        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        public ApiResponse< DomainEdgeSoftwareUpdateDto > PostEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdSoftwareupdate");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> PostEdgesEdgeIdSoftwareupdateAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> response = await PostEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo(edgeId, body);
             return response.Data;

        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> PostEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdSoftwareupdate");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }
        
        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string DeleteEdgesEdgeIdSoftwareupdate (string edgeId)
        {
             ApiResponse<string> response = DeleteEdgesEdgeIdSoftwareupdateWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->DeleteEdgesEdgeIdSoftwareupdate");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeIdSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeIdSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgesEdgeIdSoftwareupdateAsync (string edgeId)
        {
             ApiResponse<string> response = await DeleteEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgesEdgeIdSoftwareupdate");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeIdSoftwareupdate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEdgesEdgeIdSoftwareupdate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>DomainEdgeSoftwareVersionDto</returns>
        public DomainEdgeSoftwareVersionDto GetEdgesEdgeIdSoftwareversions (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareVersionDto> response = GetEdgesEdgeIdSoftwareversionsWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of DomainEdgeSoftwareVersionDto</returns>
        public ApiResponse< DomainEdgeSoftwareVersionDto > GetEdgesEdgeIdSoftwareversionsWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdSoftwareversions");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdSoftwareversions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdSoftwareversions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEdgeSoftwareVersionDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareVersionDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareVersionDto)));
            
        }
    
        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareVersionDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareVersionDto> GetEdgesEdgeIdSoftwareversionsAsync (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareVersionDto> response = await GetEdgesEdgeIdSoftwareversionsAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareVersionDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareVersionDto>> GetEdgesEdgeIdSoftwareversionsAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdSoftwareversions");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdSoftwareversions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEdgesEdgeIdSoftwareversions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareVersionDto>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareVersionDto) Configuration.ApiClient.Deserialize(response, typeof(DomainEdgeSoftwareVersionDto)));
            
        }
        
        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param> 
        /// <returns>string</returns>
        public string PostEdgesEdgeIdUnpair (string edgeId)
        {
             ApiResponse<string> response = PostEdgesEdgeIdUnpairWithHttpInfo(edgeId);
             return response.Data;
        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostEdgesEdgeIdUnpairWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdUnpair");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdUnpair: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdUnpair: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostEdgesEdgeIdUnpairAsync (string edgeId)
        {
             ApiResponse<string> response = await PostEdgesEdgeIdUnpairAsyncWithHttpInfo(edgeId);
             return response.Data;

        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostEdgesEdgeIdUnpairAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdUnpair");
            
    
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
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdUnpair: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEdgesEdgeIdUnpair: " + response.ErrorMessage, response.ErrorMessage);

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
        public Endpoint GetEndpointsEndpointId (string endpointId)
        {
             ApiResponse<Endpoint> response = GetEndpointsEndpointIdWithHttpInfo(endpointId);
             return response.Data;
        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > GetEndpointsEndpointIdWithHttpInfo (string endpointId)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->GetEndpointsEndpointId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEndpointsEndpointId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEndpointsEndpointId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Endpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(response, typeof(Endpoint)));
            
        }
    
        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> GetEndpointsEndpointIdAsync (string endpointId)
        {
             ApiResponse<Endpoint> response = await GetEndpointsEndpointIdAsyncWithHttpInfo(endpointId);
             return response.Data;

        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> GetEndpointsEndpointIdAsyncWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling GetEndpointsEndpointId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetEndpointsEndpointId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEndpointsEndpointId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Endpoint PutEndpointsEndpointId (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> response = PutEndpointsEndpointIdWithHttpInfo(endpointId, body);
             return response.Data;
        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > PutEndpointsEndpointIdWithHttpInfo (string endpointId, Endpoint body = null)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->PutEndpointsEndpointId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEndpointsEndpointId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEndpointsEndpointId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Endpoint> PutEndpointsEndpointIdAsync (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> response = await PutEndpointsEndpointIdAsyncWithHttpInfo(endpointId, body);
             return response.Data;

        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> PutEndpointsEndpointIdAsyncWithHttpInfo (string endpointId, Endpoint body = null)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling PutEndpointsEndpointId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutEndpointsEndpointId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEndpointsEndpointId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Endpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(response, typeof(Endpoint)));
            
        }
        
        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>string</returns>
        public string DeleteEndpointsEndpointId (string endpointId)
        {
             ApiResponse<string> response = DeleteEndpointsEndpointIdWithHttpInfo(endpointId);
             return response.Data;
        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEndpointsEndpointIdWithHttpInfo (string endpointId)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->DeleteEndpointsEndpointId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEndpointsEndpointId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEndpointsEndpointId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEndpointsEndpointIdAsync (string endpointId)
        {
             ApiResponse<string> response = await DeleteEndpointsEndpointIdAsyncWithHttpInfo(endpointId);
             return response.Data;

        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEndpointsEndpointIdAsyncWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling DeleteEndpointsEndpointId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteEndpointsEndpointId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEndpointsEndpointId: " + response.ErrorMessage, response.ErrorMessage);

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
        public ExtensionPool GetExtensionpoolsExtensionpoolId (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> response = GetExtensionpoolsExtensionpoolIdWithHttpInfo(extensionPoolId);
             return response.Data;
        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > GetExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->GetExtensionpoolsExtensionpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExtensionpoolsExtensionpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionpoolsExtensionpoolId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExtensionPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPool)));
            
        }
    
        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        public async System.Threading.Tasks.Task<ExtensionPool> GetExtensionpoolsExtensionpoolIdAsync (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> response = await GetExtensionpoolsExtensionpoolIdAsyncWithHttpInfo(extensionPoolId);
             return response.Data;

        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> GetExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling GetExtensionpoolsExtensionpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExtensionpoolsExtensionpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionpoolsExtensionpoolId: " + response.ErrorMessage, response.ErrorMessage);

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
        public ExtensionPool PutExtensionpoolsExtensionpoolId (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> response = PutExtensionpoolsExtensionpoolIdWithHttpInfo(extensionPoolId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <param name="body">ExtensionPool</param> 
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > PutExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->PutExtensionpoolsExtensionpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExtensionpoolsExtensionpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExtensionpoolsExtensionpoolId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ExtensionPool> PutExtensionpoolsExtensionpoolIdAsync (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> response = await PutExtensionpoolsExtensionpoolIdAsyncWithHttpInfo(extensionPoolId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> PutExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling PutExtensionpoolsExtensionpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExtensionpoolsExtensionpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExtensionpoolsExtensionpoolId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExtensionPool>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(response, typeof(ExtensionPool)));
            
        }
        
        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>string</returns>
        public string DeleteExtensionpoolsExtensionpoolId (string extensionPoolId)
        {
             ApiResponse<string> response = DeleteExtensionpoolsExtensionpoolIdWithHttpInfo(extensionPoolId);
             return response.Data;
        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->DeleteExtensionpoolsExtensionpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExtensionpoolsExtensionpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExtensionpoolsExtensionpoolId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteExtensionpoolsExtensionpoolIdAsync (string extensionPoolId)
        {
             ApiResponse<string> response = await DeleteExtensionpoolsExtensionpoolIdAsyncWithHttpInfo(extensionPoolId);
             return response.Data;

        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling DeleteExtensionpoolsExtensionpoolId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExtensionpoolsExtensionpoolId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExtensionpoolsExtensionpoolId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Extension GetExtensionsExtensionId (string extensionId)
        {
             ApiResponse<Extension> response = GetExtensionsExtensionIdWithHttpInfo(extensionId);
             return response.Data;
        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > GetExtensionsExtensionIdWithHttpInfo (string extensionId)
        {
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->GetExtensionsExtensionId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExtensionsExtensionId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionsExtensionId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
    
        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> GetExtensionsExtensionIdAsync (string extensionId)
        {
             ApiResponse<Extension> response = await GetExtensionsExtensionIdAsyncWithHttpInfo(extensionId);
             return response.Data;

        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> GetExtensionsExtensionIdAsyncWithHttpInfo (string extensionId)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling GetExtensionsExtensionId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExtensionsExtensionId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExtensionsExtensionId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Extension PutExtensionsExtensionId (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> response = PutExtensionsExtensionIdWithHttpInfo(extensionId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > PutExtensionsExtensionIdWithHttpInfo (string extensionId, Extension body = null)
        {
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->PutExtensionsExtensionId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExtensionsExtensionId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExtensionsExtensionId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Extension> PutExtensionsExtensionIdAsync (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> response = await PutExtensionsExtensionIdAsyncWithHttpInfo(extensionId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> PutExtensionsExtensionIdAsyncWithHttpInfo (string extensionId, Extension body = null)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling PutExtensionsExtensionId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExtensionsExtensionId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExtensionsExtensionId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Extension>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(response, typeof(Extension)));
            
        }
        
        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
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
        public PolicyEntityListing GetMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> response = GetMediaretentionpoliciesWithHttpInfo(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
             return response.Data;
        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
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
        public ApiResponse< PolicyEntityListing > GetMediaretentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling GetMediaretentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMediaretentionpolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PolicyEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PolicyEntityListing)));
            
        }
    
        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
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
        public async System.Threading.Tasks.Task<PolicyEntityListing> GetMediaretentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> response = await GetMediaretentionpoliciesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
             return response.Data;

        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
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
        public async System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetMediaretentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling GetMediaretentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMediaretentionpolicies: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PolicyEntityListing)));
            
        }
        
        /// <summary>
        /// Create media retention policy 
        /// </summary>
        /// <param name="body">Policy</param> 
        /// <returns>Policy</returns>
        public Policy PostMediaretentionpolicies (Policy body = null)
        {
             ApiResponse<Policy> response = PostMediaretentionpoliciesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create media retention policy 
        /// </summary>
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PostMediaretentionpoliciesWithHttpInfo (Policy body = null)
        {
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling PostMediaretentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostMediaretentionpolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Create media retention policy 
        /// </summary>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PostMediaretentionpoliciesAsync (Policy body = null)
        {
             ApiResponse<Policy> response = await PostMediaretentionpoliciesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create media retention policy 
        /// </summary>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PostMediaretentionpoliciesAsyncWithHttpInfo (Policy body = null)
        {
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling PostMediaretentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostMediaretentionpolicies: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <param name="ids"></param> 
        /// <returns>string</returns>
        public string DeleteMediaretentionpolicies (string ids)
        {
             ApiResponse<string> response = DeleteMediaretentionpoliciesWithHttpInfo(ids);
             return response.Data;
        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <param name="ids"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMediaretentionpoliciesWithHttpInfo (string ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling ConfigurationApi->DeleteMediaretentionpolicies");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling DeleteMediaretentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteMediaretentionpolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMediaretentionpoliciesAsync (string ids)
        {
             ApiResponse<string> response = await DeleteMediaretentionpoliciesAsyncWithHttpInfo(ids);
             return response.Data;

        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMediaretentionpoliciesAsyncWithHttpInfo (string ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling DeleteMediaretentionpolicies");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies";
    
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
                throw new ApiException (statusCode, "Error calling DeleteMediaretentionpolicies: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteMediaretentionpolicies: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>Policy</returns>
        public Policy GetMediaretentionpoliciesPolicyId (string policyId)
        {
             ApiResponse<Policy> response = GetMediaretentionpoliciesPolicyIdWithHttpInfo(policyId);
             return response.Data;
        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > GetMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->GetMediaretentionpoliciesPolicyId");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies/{policyId}";
    
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
                throw new ApiException (statusCode, "Error calling GetMediaretentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMediaretentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> GetMediaretentionpoliciesPolicyIdAsync (string policyId)
        {
             ApiResponse<Policy> response = await GetMediaretentionpoliciesPolicyIdAsyncWithHttpInfo(policyId);
             return response.Data;

        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> GetMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling GetMediaretentionpoliciesPolicyId");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies/{policyId}";
    
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
                throw new ApiException (statusCode, "Error calling GetMediaretentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMediaretentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Update a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>Policy</returns>
        public Policy PutMediaretentionpoliciesPolicyId (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = PutMediaretentionpoliciesPolicyIdWithHttpInfo(policyId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PutMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->PutMediaretentionpoliciesPolicyId");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies/{policyId}";
    
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
                throw new ApiException (statusCode, "Error calling PutMediaretentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutMediaretentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Update a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PutMediaretentionpoliciesPolicyIdAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = await PutMediaretentionpoliciesPolicyIdAsyncWithHttpInfo(policyId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PutMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PutMediaretentionpoliciesPolicyId");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies/{policyId}";
    
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
                throw new ApiException (statusCode, "Error calling PutMediaretentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutMediaretentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>string</returns>
        public string DeleteMediaretentionpoliciesPolicyId (string policyId)
        {
             ApiResponse<string> response = DeleteMediaretentionpoliciesPolicyIdWithHttpInfo(policyId);
             return response.Data;
        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->DeleteMediaretentionpoliciesPolicyId");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies/{policyId}";
    
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
                throw new ApiException (statusCode, "Error calling DeleteMediaretentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteMediaretentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMediaretentionpoliciesPolicyIdAsync (string policyId)
        {
             ApiResponse<string> response = await DeleteMediaretentionpoliciesPolicyIdAsyncWithHttpInfo(policyId);
             return response.Data;

        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling DeleteMediaretentionpoliciesPolicyId");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies/{policyId}";
    
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
                throw new ApiException (statusCode, "Error calling DeleteMediaretentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteMediaretentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>Policy</returns>
        public Policy PatchMediaretentionpoliciesPolicyId (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = PatchMediaretentionpoliciesPolicyIdWithHttpInfo(policyId, body);
             return response.Data;
        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PatchMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->PatchMediaretentionpoliciesPolicyId");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies/{policyId}";
    
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
                throw new ApiException (statusCode, "Error calling PatchMediaretentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchMediaretentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PatchMediaretentionpoliciesPolicyIdAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = await PatchMediaretentionpoliciesPolicyIdAsyncWithHttpInfo(policyId, body);
             return response.Data;

        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PatchMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PatchMediaretentionpoliciesPolicyId");
            
    
            var path_ = "/api/v1/configuration/mediaretentionpolicies/{policyId}";
    
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
                throw new ApiException (statusCode, "Error calling PatchMediaretentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchMediaretentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
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
        public Organization GetOrganizationsOrgId (string orgId)
        {
             ApiResponse<Organization> response = GetOrganizationsOrgIdWithHttpInfo(orgId);
             return response.Data;
        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetOrganizationsOrgIdWithHttpInfo (string orgId)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->GetOrganizationsOrgId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetOrganizationsOrgId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsOrgId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
    
        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetOrganizationsOrgIdAsync (string orgId)
        {
             ApiResponse<Organization> response = await GetOrganizationsOrgIdAsyncWithHttpInfo(orgId);
             return response.Data;

        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationsOrgIdAsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling GetOrganizationsOrgId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetOrganizationsOrgId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsOrgId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Organization PutOrganizationsOrgId (string orgId, Organization body = null)
        {
             ApiResponse<Organization> response = PutOrganizationsOrgIdWithHttpInfo(orgId, body);
             return response.Data;
        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > PutOrganizationsOrgIdWithHttpInfo (string orgId, Organization body = null)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->PutOrganizationsOrgId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutOrganizationsOrgId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganizationsOrgId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Organization> PutOrganizationsOrgIdAsync (string orgId, Organization body = null)
        {
             ApiResponse<Organization> response = await PutOrganizationsOrgIdAsyncWithHttpInfo(orgId, body);
             return response.Data;

        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationsOrgIdAsyncWithHttpInfo (string orgId, Organization body = null)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling PutOrganizationsOrgId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutOrganizationsOrgId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganizationsOrgId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Organization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(response, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>string</returns>
        public string DeleteOrganizationsOrgId (string orgId)
        {
             ApiResponse<string> response = DeleteOrganizationsOrgIdWithHttpInfo(orgId);
             return response.Data;
        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteOrganizationsOrgIdWithHttpInfo (string orgId)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->DeleteOrganizationsOrgId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsOrgId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsOrgId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteOrganizationsOrgIdAsync (string orgId)
        {
             ApiResponse<string> response = await DeleteOrganizationsOrgIdAsyncWithHttpInfo(orgId);
             return response.Data;

        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteOrganizationsOrgIdAsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling DeleteOrganizationsOrgId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsOrgId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsOrgId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Policy GetRetentionpoliciesPolicyId (string policyId)
        {
             ApiResponse<Policy> response = GetRetentionpoliciesPolicyIdWithHttpInfo(policyId);
             return response.Data;
        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > GetRetentionpoliciesPolicyIdWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->GetRetentionpoliciesPolicyId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetRetentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRetentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
    
        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> GetRetentionpoliciesPolicyIdAsync (string policyId)
        {
             ApiResponse<Policy> response = await GetRetentionpoliciesPolicyIdAsyncWithHttpInfo(policyId);
             return response.Data;

        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> GetRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling GetRetentionpoliciesPolicyId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetRetentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRetentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Policy PutRetentionpoliciesPolicyId (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = PutRetentionpoliciesPolicyIdWithHttpInfo(policyId, body);
             return response.Data;
        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PutRetentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->PutRetentionpoliciesPolicyId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutRetentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRetentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Policy> PutRetentionpoliciesPolicyIdAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = await PutRetentionpoliciesPolicyIdAsyncWithHttpInfo(policyId, body);
             return response.Data;

        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PutRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PutRetentionpoliciesPolicyId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutRetentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRetentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Policy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(response, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>string</returns>
        public string DeleteRetentionpoliciesPolicyId (string policyId)
        {
             ApiResponse<string> response = DeleteRetentionpoliciesPolicyIdWithHttpInfo(policyId);
             return response.Data;
        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteRetentionpoliciesPolicyIdWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->DeleteRetentionpoliciesPolicyId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteRetentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRetentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteRetentionpoliciesPolicyIdAsync (string policyId)
        {
             ApiResponse<string> response = await DeleteRetentionpoliciesPolicyIdAsyncWithHttpInfo(policyId);
             return response.Data;

        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling DeleteRetentionpoliciesPolicyId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteRetentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRetentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Policy PatchRetentionpoliciesPolicyId (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = PatchRetentionpoliciesPolicyIdWithHttpInfo(policyId, body);
             return response.Data;
        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PatchRetentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->PatchRetentionpoliciesPolicyId");
            
    
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
                throw new ApiException (statusCode, "Error calling PatchRetentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchRetentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Policy> PatchRetentionpoliciesPolicyIdAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> response = await PatchRetentionpoliciesPolicyIdAsyncWithHttpInfo(policyId, body);
             return response.Data;

        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PatchRetentionpoliciesPolicyId");
            
    
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
                throw new ApiException (statusCode, "Error calling PatchRetentionpoliciesPolicyId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchRetentionpoliciesPolicyId: " + response.ErrorMessage, response.ErrorMessage);

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
        public SchemaReferenceEntityListing GetSchemasEdgesVnextSchemacategory (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = GetSchemasEdgesVnextSchemacategoryWithHttpInfo(schemaCategory, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        public ApiResponse< SchemaReferenceEntityListing > GetSchemasEdgesVnextSchemacategoryWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategory");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategory: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategory: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategoryAsync (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = await GetSchemasEdgesVnextSchemacategoryAsyncWithHttpInfo(schemaCategory, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemacategoryAsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemacategory");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategory: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategory: " + response.ErrorMessage, response.ErrorMessage);

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
        public SchemaReferenceEntityListing GetSchemasEdgesVnextSchemacategorySchematype (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = GetSchemasEdgesVnextSchemacategorySchematypeWithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
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
        public ApiResponse< SchemaReferenceEntityListing > GetSchemasEdgesVnextSchemacategorySchematypeWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematype");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematype");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematype: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematype: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategorySchematypeAsync (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> response = await GetSchemasEdgesVnextSchemacategorySchematypeAsyncWithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
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
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemacategorySchematypeAsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemacategorySchematype");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemacategorySchematype");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematype: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematype: " + response.ErrorMessage, response.ErrorMessage);

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
        public Organization GetSchemasEdgesVnextSchemacategorySchematypeSchemaId (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> response = GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdWithHttpInfo(schemaCategory, schemaType, schemaId);
             return response.Data;
        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsync (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> response = await GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsyncWithHttpInfo(schemaCategory, schemaType, schemaId);
             return response.Data;

        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Organization GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> response = GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdWithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
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
        public ApiResponse< Organization > GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
            // verify the required parameter 'extension' is set
            if (extension == null)
                throw new ApiException(400, "Missing required parameter 'extension' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
            // verify the required parameter 'metadataId' is set
            if (metadataId == null)
                throw new ApiException(400, "Missing required parameter 'metadataId' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsync (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> response = await GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsyncWithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
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
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            // verify the required parameter 'extension' is set
            if (extension == null) throw new ApiException(400, "Missing required parameter 'extension' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            // verify the required parameter 'metadataId' is set
            if (metadataId == null) throw new ApiException(400, "Missing required parameter 'metadataId' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Site GetSitesSiteId (string siteId)
        {
             ApiResponse<Site> response = GetSitesSiteIdWithHttpInfo(siteId);
             return response.Data;
        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > GetSitesSiteIdWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSitesSiteId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSitesSiteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSitesSiteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Site>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(response, typeof(Site)));
            
        }
    
        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> GetSitesSiteIdAsync (string siteId)
        {
             ApiResponse<Site> response = await GetSitesSiteIdAsyncWithHttpInfo(siteId);
             return response.Data;

        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> GetSitesSiteIdAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSitesSiteId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSitesSiteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSitesSiteId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Site PutSitesSiteId (string siteId, Site body = null)
        {
             ApiResponse<Site> response = PutSitesSiteIdWithHttpInfo(siteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body">Site</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > PutSitesSiteIdWithHttpInfo (string siteId, Site body = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->PutSitesSiteId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutSitesSiteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSitesSiteId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Site> PutSitesSiteIdAsync (string siteId, Site body = null)
        {
             ApiResponse<Site> response = await PutSitesSiteIdAsyncWithHttpInfo(siteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> PutSitesSiteIdAsyncWithHttpInfo (string siteId, Site body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling PutSitesSiteId");
            
    
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
                throw new ApiException (statusCode, "Error calling PutSitesSiteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSitesSiteId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Site>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(response, typeof(Site)));
            
        }
        
        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>string</returns>
        public string DeleteSitesSiteId (string siteId)
        {
             ApiResponse<string> response = DeleteSitesSiteIdWithHttpInfo(siteId);
             return response.Data;
        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSitesSiteIdWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->DeleteSitesSiteId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteSitesSiteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSitesSiteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSitesSiteIdAsync (string siteId)
        {
             ApiResponse<string> response = await DeleteSitesSiteIdAsyncWithHttpInfo(siteId);
             return response.Data;

        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSitesSiteIdAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling DeleteSitesSiteId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteSitesSiteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSitesSiteId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>List&lt;NumberPlan&gt;</returns>
        public List<NumberPlan> GetSitesSiteIdNumberplans (string siteId)
        {
             ApiResponse<List<NumberPlan>> response = GetSitesSiteIdNumberplansWithHttpInfo(siteId);
             return response.Data;
        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        public ApiResponse< List<NumberPlan> > GetSitesSiteIdNumberplansWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSitesSiteIdNumberplans");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplans: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<NumberPlan>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(response, typeof(List<NumberPlan>)));
            
        }
    
        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<NumberPlan>> GetSitesSiteIdNumberplansAsync (string siteId)
        {
             ApiResponse<List<NumberPlan>> response = await GetSitesSiteIdNumberplansAsyncWithHttpInfo(siteId);
             return response.Data;

        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> GetSitesSiteIdNumberplansAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSitesSiteIdNumberplans");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplans: " + response.ErrorMessage, response.ErrorMessage);

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
        public List<NumberPlan> PutSitesSiteIdNumberplans (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> response = PutSitesSiteIdNumberplansWithHttpInfo(siteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        public ApiResponse< List<NumberPlan> > PutSitesSiteIdNumberplansWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->PutSitesSiteIdNumberplans");
            
    
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
                throw new ApiException (statusCode, "Error calling PutSitesSiteIdNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSitesSiteIdNumberplans: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<List<NumberPlan>> PutSitesSiteIdNumberplansAsync (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> response = await PutSitesSiteIdNumberplansAsyncWithHttpInfo(siteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> PutSitesSiteIdNumberplansAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling PutSitesSiteIdNumberplans");
            
    
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
                throw new ApiException (statusCode, "Error calling PutSitesSiteIdNumberplans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSitesSiteIdNumberplans: " + response.ErrorMessage, response.ErrorMessage);

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
        public List<string> GetSitesSiteIdNumberplansClassifications (string siteId, string classification = null)
        {
             ApiResponse<List<string>> response = GetSitesSiteIdNumberplansClassificationsWithHttpInfo(siteId, classification);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="classification">Classification</param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > GetSitesSiteIdNumberplansClassificationsWithHttpInfo (string siteId, string classification = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSitesSiteIdNumberplansClassifications");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplansClassifications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplansClassifications: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<List<string>> GetSitesSiteIdNumberplansClassificationsAsync (string siteId, string classification = null)
        {
             ApiResponse<List<string>> response = await GetSitesSiteIdNumberplansClassificationsAsyncWithHttpInfo(siteId, classification);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> GetSitesSiteIdNumberplansClassificationsAsyncWithHttpInfo (string siteId, string classification = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSitesSiteIdNumberplansClassifications");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplansClassifications: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplansClassifications: " + response.ErrorMessage, response.ErrorMessage);

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
        public NumberPlan GetSitesSiteIdNumberplansNumberplanId (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> response = GetSitesSiteIdNumberplansNumberplanIdWithHttpInfo(siteId, numberPlanId);
             return response.Data;
        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <param name="numberPlanId">Number Plan ID</param> 
        /// <returns>ApiResponse of NumberPlan</returns>
        public ApiResponse< NumberPlan > GetSitesSiteIdNumberplansNumberplanIdWithHttpInfo (string siteId, string numberPlanId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSitesSiteIdNumberplansNumberplanId");
            
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null)
                throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling ConfigurationApi->GetSitesSiteIdNumberplansNumberplanId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplansNumberplanId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplansNumberplanId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<NumberPlan> GetSitesSiteIdNumberplansNumberplanIdAsync (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> response = await GetSitesSiteIdNumberplansNumberplanIdAsyncWithHttpInfo(siteId, numberPlanId);
             return response.Data;

        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NumberPlan>> GetSitesSiteIdNumberplansNumberplanIdAsyncWithHttpInfo (string siteId, string numberPlanId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSitesSiteIdNumberplansNumberplanId");
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null) throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling GetSitesSiteIdNumberplansNumberplanId");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplansNumberplanId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSitesSiteIdNumberplansNumberplanId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<NumberPlan>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NumberPlan) Configuration.ApiClient.Deserialize(response, typeof(NumberPlan)));
            
        }
        
        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns></returns>
        public void PostSitesSiteIdRebalance (string siteId)
        {
             PostSitesSiteIdRebalanceWithHttpInfo(siteId);
        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostSitesSiteIdRebalanceWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->PostSitesSiteIdRebalance");
            
    
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
                throw new ApiException (statusCode, "Error calling PostSitesSiteIdRebalance: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSitesSiteIdRebalance: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostSitesSiteIdRebalanceAsync (string siteId)
        {
             await PostSitesSiteIdRebalanceAsyncWithHttpInfo(siteId);

        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostSitesSiteIdRebalanceAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling PostSitesSiteIdRebalance");
            
    
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
                throw new ApiException (statusCode, "Error calling PostSitesSiteIdRebalance: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSitesSiteIdRebalance: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
