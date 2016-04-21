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
    public interface IConfigurationApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>string</returns>
        string ConfigurationDidpoolsDidpoolidDelete (string didPoolId);

        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationDidpoolsDidpoolidDeleteWithHttpInfo (string didPoolId);
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>DIDPool</returns>
        DIDPool ConfigurationDidpoolsDidpoolidGet (string didPoolId);

        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> ConfigurationDidpoolsDidpoolidGetWithHttpInfo (string didPoolId);
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DIDPool</returns>
        DIDPool ConfigurationDidpoolsDidpoolidPut (string didPoolId, DIDPool body = null);

        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> ConfigurationDidpoolsDidpoolidPutWithHttpInfo (string didPoolId, DIDPool body = null);
        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <returns>DIDPoolEntityListing</returns>
        DIDPoolEntityListing ConfigurationDidpoolsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <returns>ApiResponse of DIDPoolEntityListing</returns>
        ApiResponse<DIDPoolEntityListing> ConfigurationDidpoolsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>DIDPool</returns>
        DIDPool ConfigurationDidpoolsPost (DIDPool body = null);

        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> ConfigurationDidpoolsPostWithHttpInfo (DIDPool body = null);
        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>DID</returns>
        DID ConfigurationDidsDididGet (string didId);

        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> ConfigurationDidsDididGetWithHttpInfo (string didId);
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DID</returns>
        DID ConfigurationDidsDididPut (string didId, DID body = null);

        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> ConfigurationDidsDididPutWithHttpInfo (string didId, DID body = null);
        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="phoneNumber">Filter by phoneNumber (optional)</param>
        /// <returns>DIDEntityListing</returns>
        DIDEntityListing ConfigurationDidsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);

        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="phoneNumber">Filter by phoneNumber (optional)</param>
        /// <returns>ApiResponse of DIDEntityListing</returns>
        ApiResponse<DIDEntityListing> ConfigurationDidsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>string</returns>
        string ConfigurationEdgesCertificateauthoritiesCertificateidDelete (string certificateId);

        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationEdgesCertificateauthoritiesCertificateidDeleteWithHttpInfo (string certificateId);
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority ConfigurationEdgesCertificateauthoritiesCertificateidGet (string certificateId);

        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> ConfigurationEdgesCertificateauthoritiesCertificateidGetWithHttpInfo (string certificateId);
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority ConfigurationEdgesCertificateauthoritiesCertificateidPut (string certificateId, DomainCertificateAuthority body = null);

        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> ConfigurationEdgesCertificateauthoritiesCertificateidPutWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);
        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CertificateAuthorityEntityListing</returns>
        CertificateAuthorityEntityListing ConfigurationEdgesCertificateauthoritiesGet ();

        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CertificateAuthorityEntityListing</returns>
        ApiResponse<CertificateAuthorityEntityListing> ConfigurationEdgesCertificateauthoritiesGetWithHttpInfo ();
        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority (optional)</param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority ConfigurationEdgesCertificateauthoritiesPost (DomainCertificateAuthority body = null);

        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority (optional)</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> ConfigurationEdgesCertificateauthoritiesPostWithHttpInfo (DomainCertificateAuthority body = null);
        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string ConfigurationEdgesEdgeidDelete (string edgeId);

        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationEdgesEdgeidDeleteWithHttpInfo (string edgeId);
        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Edge</returns>
        Edge ConfigurationEdgesEdgeidGet (string edgeId);

        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> ConfigurationEdgesEdgeidGetWithHttpInfo (string edgeId);
        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EdgeLineEntityListing</returns>
        EdgeLineEntityListing ConfigurationEdgesEdgeidLinesGet (string edgeId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EdgeLineEntityListing</returns>
        ApiResponse<EdgeLineEntityListing> ConfigurationEdgesEdgeidLinesGetWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>EdgeLine</returns>
        EdgeLine ConfigurationEdgesEdgeidLinesLineidGet (string edgeId, string lineId);

        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        ApiResponse<EdgeLine> ConfigurationEdgesEdgeidLinesLineidGetWithHttpInfo (string edgeId, string lineId);
        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line (optional)</param>
        /// <returns>EdgeLine</returns>
        EdgeLine ConfigurationEdgesEdgeidLinesLineidPut (string edgeId, string lineId, EdgeLine body = null);

        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line (optional)</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        ApiResponse<EdgeLine> ConfigurationEdgesEdgeidLinesLineidPutWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);
        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>LogicalInterfaceEntityListing</returns>
        LogicalInterfaceEntityListing ConfigurationEdgesEdgeidLogicalinterfacesGet (string edgeId);

        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of LogicalInterfaceEntityListing</returns>
        ApiResponse<LogicalInterfaceEntityListing> ConfigurationEdgesEdgeidLogicalinterfacesGetWithHttpInfo (string edgeId);
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns></returns>
        void ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete (string edgeId, string interfaceId);

        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDeleteWithHttpInfo (string edgeId, string interfaceId);
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet (string edgeId, string interfaceId);

        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGetWithHttpInfo (string edgeId, string interfaceId);
        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut (string edgeId, string interfaceId, DomainLogicalInterface body = null);

        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPutWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface ConfigurationEdgesEdgeidLogicalinterfacesPost (string edgeId, DomainLogicalInterface body = null);

        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> ConfigurationEdgesEdgeidLogicalinterfacesPostWithHttpInfo (string edgeId, DomainLogicalInterface body = null);
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>PhysicalInterfaceEntityListing</returns>
        PhysicalInterfaceEntityListing ConfigurationEdgesEdgeidPhysicalinterfacesGet (string edgeId);

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of PhysicalInterfaceEntityListing</returns>
        ApiResponse<PhysicalInterfaceEntityListing> ConfigurationEdgesEdgeidPhysicalinterfacesGetWithHttpInfo (string edgeId);
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainPhysicalInterface</returns>
        DomainPhysicalInterface ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet (string edgeId, string interfaceId);

        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        ApiResponse<DomainPhysicalInterface> ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGetWithHttpInfo (string edgeId, string interfaceId);
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Edge</returns>
        Edge ConfigurationEdgesEdgeidPut (string edgeId, Edge body = null);

        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge (optional)</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> ConfigurationEdgesEdgeidPutWithHttpInfo (string edgeId, Edge body = null);
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string ConfigurationEdgesEdgeidRebootPost (string edgeId);

        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationEdgesEdgeidRebootPostWithHttpInfo (string edgeId);
        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string ConfigurationEdgesEdgeidSoftwareupdateDelete (string edgeId);

        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationEdgesEdgeidSoftwareupdateDeleteWithHttpInfo (string edgeId);
        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        DomainEdgeSoftwareUpdateDto ConfigurationEdgesEdgeidSoftwareupdateGet (string edgeId);

        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        ApiResponse<DomainEdgeSoftwareUpdateDto> ConfigurationEdgesEdgeidSoftwareupdateGetWithHttpInfo (string edgeId);
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void ConfigurationEdgesEdgeidSoftwareupdatePost (string edgeId, DomainEdgeSoftwareUpdateDto body = null);

        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConfigurationEdgesEdgeidSoftwareupdatePostWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareVersionDto</returns>
        DomainEdgeSoftwareVersionDto ConfigurationEdgesEdgeidSoftwareversionsGet (string edgeId);

        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareVersionDto</returns>
        ApiResponse<DomainEdgeSoftwareVersionDto> ConfigurationEdgesEdgeidSoftwareversionsGetWithHttpInfo (string edgeId);
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>string</returns>
        string ConfigurationEdgesEdgeidUnpairPost (string edgeId);

        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationEdgesEdgeidUnpairPostWithHttpInfo (string edgeId);
        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>EdgeEntityListing</returns>
        EdgeEntityListing ConfigurationEdgesGet (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);

        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of EdgeEntityListing</returns>
        ApiResponse<EdgeEntityListing> ConfigurationEdgesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);
        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Edge</returns>
        Edge ConfigurationEdgesPost (Edge body = null);

        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge (optional)</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> ConfigurationEdgesPostWithHttpInfo (Edge body = null);
        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EdgeVersionReport</returns>
        EdgeVersionReport ConfigurationEdgeversionreportGet ();

        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EdgeVersionReport</returns>
        ApiResponse<EdgeVersionReport> ConfigurationEdgeversionreportGetWithHttpInfo ();
        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>string</returns>
        string ConfigurationEndpointsEndpointidDelete (string endpointId);

        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationEndpointsEndpointidDeleteWithHttpInfo (string endpointId);
        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Endpoint</returns>
        Endpoint ConfigurationEndpointsEndpointidGet (string endpointId);

        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> ConfigurationEndpointsEndpointidGetWithHttpInfo (string endpointId);
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Endpoint</returns>
        Endpoint ConfigurationEndpointsEndpointidPut (string endpointId, Endpoint body = null);

        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> ConfigurationEndpointsEndpointidPutWithHttpInfo (string endpointId, Endpoint body = null);
        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>EndpointEntityListing</returns>
        EndpointEntityListing ConfigurationEndpointsGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of EndpointEntityListing</returns>
        ApiResponse<EndpointEntityListing> ConfigurationEndpointsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Endpoint</returns>
        Endpoint ConfigurationEndpointsPost (Endpoint body = null);

        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> ConfigurationEndpointsPostWithHttpInfo (Endpoint body = null);
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>string</returns>
        string ConfigurationExtensionpoolsExtensionpoolidDelete (string extensionPoolId);

        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationExtensionpoolsExtensionpoolidDeleteWithHttpInfo (string extensionPoolId);
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ExtensionPool</returns>
        ExtensionPool ConfigurationExtensionpoolsExtensionpoolidGet (string extensionPoolId);

        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> ConfigurationExtensionpoolsExtensionpoolidGetWithHttpInfo (string extensionPoolId);
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>ExtensionPool</returns>
        ExtensionPool ConfigurationExtensionpoolsExtensionpoolidPut (string extensionPoolId, ExtensionPool body = null);

        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> ConfigurationExtensionpoolsExtensionpoolidPutWithHttpInfo (string extensionPoolId, ExtensionPool body = null);
        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to startNumber)</param>
        /// <param name="number">Number (optional)</param>
        /// <returns>ExtensionPoolEntityListing</returns>
        ExtensionPoolEntityListing ConfigurationExtensionpoolsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);

        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to startNumber)</param>
        /// <param name="number">Number (optional)</param>
        /// <returns>ApiResponse of ExtensionPoolEntityListing</returns>
        ApiResponse<ExtensionPoolEntityListing> ConfigurationExtensionpoolsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);
        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Extension</returns>
        Extension ConfigurationExtensionpoolsPost (ExtensionPool body = null);

        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> ConfigurationExtensionpoolsPostWithHttpInfo (ExtensionPool body = null);
        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Extension</returns>
        Extension ConfigurationExtensionsExtensionidGet (string extensionId);

        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> ConfigurationExtensionsExtensionidGetWithHttpInfo (string extensionId);
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Extension</returns>
        Extension ConfigurationExtensionsExtensionidPut (string extensionId, Extension body = null);

        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> ConfigurationExtensionsExtensionidPutWithHttpInfo (string extensionId, Extension body = null);
        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="number">Filter by number (optional)</param>
        /// <returns>ExtensionEntityListing</returns>
        ExtensionEntityListing ConfigurationExtensionsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);

        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="number">Filter by number (optional)</param>
        /// <returns>ApiResponse of ExtensionEntityListing</returns>
        ApiResponse<ExtensionEntityListing> ConfigurationExtensionsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);
        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Organization</returns>
        Organization ConfigurationOrganizationGet ();

        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> ConfigurationOrganizationGetWithHttpInfo ();
        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Organization</returns>
        Organization ConfigurationOrganizationPut (Organization body = null);

        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> ConfigurationOrganizationPutWithHttpInfo (Organization body = null);
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>string</returns>
        string ConfigurationOrganizationsOrgidDelete (string orgId);

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationOrganizationsOrgidDeleteWithHttpInfo (string orgId);
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Organization</returns>
        Organization ConfigurationOrganizationsOrgidGet (string orgId);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> ConfigurationOrganizationsOrgidGetWithHttpInfo (string orgId);
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Organization</returns>
        Organization ConfigurationOrganizationsOrgidPut (string orgId, Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> ConfigurationOrganizationsOrgidPutWithHttpInfo (string orgId, Organization body = null);
        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Organization</returns>
        Organization ConfigurationOrganizationsPost (OrganizationCreate body = null);

        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> ConfigurationOrganizationsPostWithHttpInfo (OrganizationCreate body = null);
        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EncryptionKeyEntityListing</returns>
        EncryptionKeyEntityListing ConfigurationRecordingkeysGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        ApiResponse<EncryptionKeyEntityListing> ConfigurationRecordingkeysGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EncryptionKey</returns>
        EncryptionKey ConfigurationRecordingkeysPost ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EncryptionKey</returns>
        ApiResponse<EncryptionKey> ConfigurationRecordingkeysPostWithHttpInfo ();
        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule ConfigurationRecordingkeysRotationscheduleGet ();

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> ConfigurationRecordingkeysRotationscheduleGetWithHttpInfo ();
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule (optional)</param>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule ConfigurationRecordingkeysRotationschedulePut (KeyRotationSchedule body = null);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule (optional)</param>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> ConfigurationRecordingkeysRotationschedulePutWithHttpInfo (KeyRotationSchedule body = null);
        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>string</returns>
        string ConfigurationRetentionpoliciesDelete (string ids);

        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationRetentionpoliciesDeleteWithHttpInfo (string ids);
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary&#x3D;true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>PolicyEntityListing</returns>
        PolicyEntityListing ConfigurationRetentionpoliciesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary&#x3D;true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        ApiResponse<PolicyEntityListing> ConfigurationRetentionpoliciesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>string</returns>
        string ConfigurationRetentionpoliciesPolicyidDelete (string policyId);

        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationRetentionpoliciesPolicyidDeleteWithHttpInfo (string policyId);
        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Policy</returns>
        Policy ConfigurationRetentionpoliciesPolicyidGet (string policyId);

        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> ConfigurationRetentionpoliciesPolicyidGetWithHttpInfo (string policyId);
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Policy</returns>
        Policy ConfigurationRetentionpoliciesPolicyidPatch (string policyId, Policy body = null);

        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> ConfigurationRetentionpoliciesPolicyidPatchWithHttpInfo (string policyId, Policy body = null);
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Policy</returns>
        Policy ConfigurationRetentionpoliciesPolicyidPut (string policyId, Policy body = null);

        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> ConfigurationRetentionpoliciesPolicyidPutWithHttpInfo (string policyId, Policy body = null);
        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Policy</returns>
        Policy ConfigurationRetentionpoliciesPost (Policy body = null);

        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> ConfigurationRetentionpoliciesPostWithHttpInfo (Policy body = null);
        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SchemaCategoryEntityListing</returns>
        SchemaCategoryEntityListing ConfigurationSchemasEdgesVnextGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SchemaCategoryEntityListing</returns>
        ApiResponse<SchemaCategoryEntityListing> ConfigurationSchemasEdgesVnextGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SchemaReferenceEntityListing</returns>
        SchemaReferenceEntityListing ConfigurationSchemasEdgesVnextSchemacategoryGet (string schemaCategory, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        ApiResponse<SchemaReferenceEntityListing> ConfigurationSchemasEdgesVnextSchemacategoryGetWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SchemaReferenceEntityListing</returns>
        SchemaReferenceEntityListing ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        ApiResponse<SchemaReferenceEntityListing> ConfigurationSchemasEdgesVnextSchemacategorySchematypeGetWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type (optional)</param>
        /// <returns>Organization</returns>
        Organization ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);

        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGetWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Organization</returns>
        Organization ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet (string schemaCategory, string schemaType, string schemaId);

        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGetWithHttpInfo (string schemaCategory, string schemaType, string schemaId);
        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="locationId">Location Id (optional)</param>
        /// <returns>SiteEntityListing</returns>
        SiteEntityListing ConfigurationSitesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);

        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="locationId">Location Id (optional)</param>
        /// <returns>ApiResponse of SiteEntityListing</returns>
        ApiResponse<SiteEntityListing> ConfigurationSitesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);
        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site (optional)</param>
        /// <returns>Site</returns>
        Site ConfigurationSitesPost (Site body = null);

        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site (optional)</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> ConfigurationSitesPostWithHttpInfo (Site body = null);
        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>string</returns>
        string ConfigurationSitesSiteidDelete (string siteId);

        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfigurationSitesSiteidDeleteWithHttpInfo (string siteId);
        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Site</returns>
        Site ConfigurationSitesSiteidGet (string siteId);

        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> ConfigurationSitesSiteidGetWithHttpInfo (string siteId);
        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ConfigurationSitesSiteidNumberplansClassificationsGet (string siteId, string classification = null);

        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> ConfigurationSitesSiteidNumberplansClassificationsGetWithHttpInfo (string siteId, string classification = null);
        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        List<NumberPlan> ConfigurationSitesSiteidNumberplansGet (string siteId);

        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        ApiResponse<List<NumberPlan>> ConfigurationSitesSiteidNumberplansGetWithHttpInfo (string siteId);
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>NumberPlan</returns>
        NumberPlan ConfigurationSitesSiteidNumberplansNumberplanidGet (string siteId, string numberPlanId);

        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>ApiResponse of NumberPlan</returns>
        ApiResponse<NumberPlan> ConfigurationSitesSiteidNumberplansNumberplanidGetWithHttpInfo (string siteId, string numberPlanId);
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        List<NumberPlan> ConfigurationSitesSiteidNumberplansPut (string siteId, List<NumberPlan> body = null);

        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        ApiResponse<List<NumberPlan>> ConfigurationSitesSiteidNumberplansPutWithHttpInfo (string siteId, List<NumberPlan> body = null);
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site (optional)</param>
        /// <returns>Site</returns>
        Site ConfigurationSitesSiteidPut (string siteId, Site body = null);

        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site (optional)</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> ConfigurationSitesSiteidPutWithHttpInfo (string siteId, Site body = null);
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns></returns>
        void ConfigurationSitesSiteidRebalancePost (string siteId);

        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConfigurationSitesSiteidRebalancePostWithHttpInfo (string siteId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationDidpoolsDidpoolidDeleteAsync (string didPoolId);

        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationDidpoolsDidpoolidDeleteAsyncWithHttpInfo (string didPoolId);
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> ConfigurationDidpoolsDidpoolidGetAsync (string didPoolId);

        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> ConfigurationDidpoolsDidpoolidGetAsyncWithHttpInfo (string didPoolId);
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> ConfigurationDidpoolsDidpoolidPutAsync (string didPoolId, DIDPool body = null);

        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> ConfigurationDidpoolsDidpoolidPutAsyncWithHttpInfo (string didPoolId, DIDPool body = null);
        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <returns>Task of DIDPoolEntityListing</returns>
        System.Threading.Tasks.Task<DIDPoolEntityListing> ConfigurationDidpoolsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <returns>Task of ApiResponse (DIDPoolEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPoolEntityListing>> ConfigurationDidpoolsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> ConfigurationDidpoolsPostAsync (DIDPool body = null);

        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> ConfigurationDidpoolsPostAsyncWithHttpInfo (DIDPool body = null);
        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> ConfigurationDidsDididGetAsync (string didId);

        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> ConfigurationDidsDididGetAsyncWithHttpInfo (string didId);
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> ConfigurationDidsDididPutAsync (string didId, DID body = null);

        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> ConfigurationDidsDididPutAsyncWithHttpInfo (string didId, DID body = null);
        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="phoneNumber">Filter by phoneNumber (optional)</param>
        /// <returns>Task of DIDEntityListing</returns>
        System.Threading.Tasks.Task<DIDEntityListing> ConfigurationDidsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);

        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="phoneNumber">Filter by phoneNumber (optional)</param>
        /// <returns>Task of ApiResponse (DIDEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDEntityListing>> ConfigurationDidsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationEdgesCertificateauthoritiesCertificateidDeleteAsync (string certificateId);

        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesCertificateauthoritiesCertificateidDeleteAsyncWithHttpInfo (string certificateId);
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> ConfigurationEdgesCertificateauthoritiesCertificateidGetAsync (string certificateId);

        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> ConfigurationEdgesCertificateauthoritiesCertificateidGetAsyncWithHttpInfo (string certificateId);
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> ConfigurationEdgesCertificateauthoritiesCertificateidPutAsync (string certificateId, DomainCertificateAuthority body = null);

        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> ConfigurationEdgesCertificateauthoritiesCertificateidPutAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);
        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CertificateAuthorityEntityListing</returns>
        System.Threading.Tasks.Task<CertificateAuthorityEntityListing> ConfigurationEdgesCertificateauthoritiesGetAsync ();

        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CertificateAuthorityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CertificateAuthorityEntityListing>> ConfigurationEdgesCertificateauthoritiesGetAsyncWithHttpInfo ();
        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority (optional)</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> ConfigurationEdgesCertificateauthoritiesPostAsync (DomainCertificateAuthority body = null);

        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority (optional)</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> ConfigurationEdgesCertificateauthoritiesPostAsyncWithHttpInfo (DomainCertificateAuthority body = null);
        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationEdgesEdgeidDeleteAsync (string edgeId);

        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesEdgeidDeleteAsyncWithHttpInfo (string edgeId);
        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> ConfigurationEdgesEdgeidGetAsync (string edgeId);

        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> ConfigurationEdgesEdgeidGetAsyncWithHttpInfo (string edgeId);
        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EdgeLineEntityListing</returns>
        System.Threading.Tasks.Task<EdgeLineEntityListing> ConfigurationEdgesEdgeidLinesGetAsync (string edgeId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EdgeLineEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLineEntityListing>> ConfigurationEdgesEdgeidLinesGetAsyncWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of EdgeLine</returns>
        System.Threading.Tasks.Task<EdgeLine> ConfigurationEdgesEdgeidLinesLineidGetAsync (string edgeId, string lineId);

        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> ConfigurationEdgesEdgeidLinesLineidGetAsyncWithHttpInfo (string edgeId, string lineId);
        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line (optional)</param>
        /// <returns>Task of EdgeLine</returns>
        System.Threading.Tasks.Task<EdgeLine> ConfigurationEdgesEdgeidLinesLineidPutAsync (string edgeId, string lineId, EdgeLine body = null);

        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line (optional)</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> ConfigurationEdgesEdgeidLinesLineidPutAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);
        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of LogicalInterfaceEntityListing</returns>
        System.Threading.Tasks.Task<LogicalInterfaceEntityListing> ConfigurationEdgesEdgeidLogicalinterfacesGetAsync (string edgeId);

        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (LogicalInterfaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LogicalInterfaceEntityListing>> ConfigurationEdgesEdgeidLogicalinterfacesGetAsyncWithHttpInfo (string edgeId);
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDeleteAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDeleteAsyncWithHttpInfo (string edgeId, string interfaceId);
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGetAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGetAsyncWithHttpInfo (string edgeId, string interfaceId);
        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPutAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null);

        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPutAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> ConfigurationEdgesEdgeidLogicalinterfacesPostAsync (string edgeId, DomainLogicalInterface body = null);

        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> ConfigurationEdgesEdgeidLogicalinterfacesPostAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null);
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of PhysicalInterfaceEntityListing</returns>
        System.Threading.Tasks.Task<PhysicalInterfaceEntityListing> ConfigurationEdgesEdgeidPhysicalinterfacesGetAsync (string edgeId);

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (PhysicalInterfaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhysicalInterfaceEntityListing>> ConfigurationEdgesEdgeidPhysicalinterfacesGetAsyncWithHttpInfo (string edgeId);
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainPhysicalInterface</returns>
        System.Threading.Tasks.Task<DomainPhysicalInterface> ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGetAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGetAsyncWithHttpInfo (string edgeId, string interfaceId);
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> ConfigurationEdgesEdgeidPutAsync (string edgeId, Edge body = null);

        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> ConfigurationEdgesEdgeidPutAsyncWithHttpInfo (string edgeId, Edge body = null);
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationEdgesEdgeidRebootPostAsync (string edgeId);

        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesEdgeidRebootPostAsyncWithHttpInfo (string edgeId);
        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationEdgesEdgeidSoftwareupdateDeleteAsync (string edgeId);

        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesEdgeidSoftwareupdateDeleteAsyncWithHttpInfo (string edgeId);
        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> ConfigurationEdgesEdgeidSoftwareupdateGetAsync (string edgeId);

        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> ConfigurationEdgesEdgeidSoftwareupdateGetAsyncWithHttpInfo (string edgeId);
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConfigurationEdgesEdgeidSoftwareupdatePostAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null);

        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConfigurationEdgesEdgeidSoftwareupdatePostAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareVersionDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareVersionDto> ConfigurationEdgesEdgeidSoftwareversionsGetAsync (string edgeId);

        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareVersionDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareVersionDto>> ConfigurationEdgesEdgeidSoftwareversionsGetAsyncWithHttpInfo (string edgeId);
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationEdgesEdgeidUnpairPostAsync (string edgeId);

        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesEdgeidUnpairPostAsyncWithHttpInfo (string edgeId);
        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of EdgeEntityListing</returns>
        System.Threading.Tasks.Task<EdgeEntityListing> ConfigurationEdgesGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);

        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (EdgeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeEntityListing>> ConfigurationEdgesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);
        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> ConfigurationEdgesPostAsync (Edge body = null);

        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> ConfigurationEdgesPostAsyncWithHttpInfo (Edge body = null);
        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EdgeVersionReport</returns>
        System.Threading.Tasks.Task<EdgeVersionReport> ConfigurationEdgeversionreportGetAsync ();

        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EdgeVersionReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeVersionReport>> ConfigurationEdgeversionreportGetAsyncWithHttpInfo ();
        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationEndpointsEndpointidDeleteAsync (string endpointId);

        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEndpointsEndpointidDeleteAsyncWithHttpInfo (string endpointId);
        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> ConfigurationEndpointsEndpointidGetAsync (string endpointId);

        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> ConfigurationEndpointsEndpointidGetAsyncWithHttpInfo (string endpointId);
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> ConfigurationEndpointsEndpointidPutAsync (string endpointId, Endpoint body = null);

        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> ConfigurationEndpointsEndpointidPutAsyncWithHttpInfo (string endpointId, Endpoint body = null);
        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of EndpointEntityListing</returns>
        System.Threading.Tasks.Task<EndpointEntityListing> ConfigurationEndpointsGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (EndpointEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EndpointEntityListing>> ConfigurationEndpointsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> ConfigurationEndpointsPostAsync (Endpoint body = null);

        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> ConfigurationEndpointsPostAsyncWithHttpInfo (Endpoint body = null);
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationExtensionpoolsExtensionpoolidDeleteAsync (string extensionPoolId);

        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationExtensionpoolsExtensionpoolidDeleteAsyncWithHttpInfo (string extensionPoolId);
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> ConfigurationExtensionpoolsExtensionpoolidGetAsync (string extensionPoolId);

        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> ConfigurationExtensionpoolsExtensionpoolidGetAsyncWithHttpInfo (string extensionPoolId);
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> ConfigurationExtensionpoolsExtensionpoolidPutAsync (string extensionPoolId, ExtensionPool body = null);

        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> ConfigurationExtensionpoolsExtensionpoolidPutAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null);
        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to startNumber)</param>
        /// <param name="number">Number (optional)</param>
        /// <returns>Task of ExtensionPoolEntityListing</returns>
        System.Threading.Tasks.Task<ExtensionPoolEntityListing> ConfigurationExtensionpoolsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);

        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to startNumber)</param>
        /// <param name="number">Number (optional)</param>
        /// <returns>Task of ApiResponse (ExtensionPoolEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPoolEntityListing>> ConfigurationExtensionpoolsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);
        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> ConfigurationExtensionpoolsPostAsync (ExtensionPool body = null);

        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> ConfigurationExtensionpoolsPostAsyncWithHttpInfo (ExtensionPool body = null);
        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> ConfigurationExtensionsExtensionidGetAsync (string extensionId);

        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> ConfigurationExtensionsExtensionidGetAsyncWithHttpInfo (string extensionId);
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> ConfigurationExtensionsExtensionidPutAsync (string extensionId, Extension body = null);

        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> ConfigurationExtensionsExtensionidPutAsyncWithHttpInfo (string extensionId, Extension body = null);
        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="number">Filter by number (optional)</param>
        /// <returns>Task of ExtensionEntityListing</returns>
        System.Threading.Tasks.Task<ExtensionEntityListing> ConfigurationExtensionsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);

        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="number">Filter by number (optional)</param>
        /// <returns>Task of ApiResponse (ExtensionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionEntityListing>> ConfigurationExtensionsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);
        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> ConfigurationOrganizationGetAsync ();

        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationGetAsyncWithHttpInfo ();
        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> ConfigurationOrganizationPutAsync (Organization body = null);

        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationPutAsyncWithHttpInfo (Organization body = null);
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationOrganizationsOrgidDeleteAsync (string orgId);

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationOrganizationsOrgidDeleteAsyncWithHttpInfo (string orgId);
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> ConfigurationOrganizationsOrgidGetAsync (string orgId);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationsOrgidGetAsyncWithHttpInfo (string orgId);
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> ConfigurationOrganizationsOrgidPutAsync (string orgId, Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationsOrgidPutAsyncWithHttpInfo (string orgId, Organization body = null);
        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> ConfigurationOrganizationsPostAsync (OrganizationCreate body = null);

        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationsPostAsyncWithHttpInfo (OrganizationCreate body = null);
        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        System.Threading.Tasks.Task<EncryptionKeyEntityListing> ConfigurationRecordingkeysGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> ConfigurationRecordingkeysGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EncryptionKey</returns>
        System.Threading.Tasks.Task<EncryptionKey> ConfigurationRecordingkeysPostAsync ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> ConfigurationRecordingkeysPostAsyncWithHttpInfo ();
        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> ConfigurationRecordingkeysRotationscheduleGetAsync ();

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> ConfigurationRecordingkeysRotationscheduleGetAsyncWithHttpInfo ();
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule (optional)</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> ConfigurationRecordingkeysRotationschedulePutAsync (KeyRotationSchedule body = null);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule (optional)</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> ConfigurationRecordingkeysRotationschedulePutAsyncWithHttpInfo (KeyRotationSchedule body = null);
        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationRetentionpoliciesDeleteAsync (string ids);

        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationRetentionpoliciesDeleteAsyncWithHttpInfo (string ids);
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary&#x3D;true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>Task of PolicyEntityListing</returns>
        System.Threading.Tasks.Task<PolicyEntityListing> ConfigurationRetentionpoliciesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary&#x3D;true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> ConfigurationRetentionpoliciesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationRetentionpoliciesPolicyidDeleteAsync (string policyId);

        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationRetentionpoliciesPolicyidDeleteAsyncWithHttpInfo (string policyId);
        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> ConfigurationRetentionpoliciesPolicyidGetAsync (string policyId);

        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> ConfigurationRetentionpoliciesPolicyidGetAsyncWithHttpInfo (string policyId);
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> ConfigurationRetentionpoliciesPolicyidPatchAsync (string policyId, Policy body = null);

        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> ConfigurationRetentionpoliciesPolicyidPatchAsyncWithHttpInfo (string policyId, Policy body = null);
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> ConfigurationRetentionpoliciesPolicyidPutAsync (string policyId, Policy body = null);

        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> ConfigurationRetentionpoliciesPolicyidPutAsyncWithHttpInfo (string policyId, Policy body = null);
        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> ConfigurationRetentionpoliciesPostAsync (Policy body = null);

        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> ConfigurationRetentionpoliciesPostAsyncWithHttpInfo (Policy body = null);
        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SchemaCategoryEntityListing</returns>
        System.Threading.Tasks.Task<SchemaCategoryEntityListing> ConfigurationSchemasEdgesVnextGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SchemaCategoryEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaCategoryEntityListing>> ConfigurationSchemasEdgesVnextGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> ConfigurationSchemasEdgesVnextSchemacategoryGetAsync (string schemaCategory, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> ConfigurationSchemasEdgesVnextSchemacategoryGetAsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> ConfigurationSchemasEdgesVnextSchemacategorySchematypeGetAsync (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> ConfigurationSchemasEdgesVnextSchemacategorySchematypeGetAsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type (optional)</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGetAsync (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);

        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGetAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGetAsync (string schemaCategory, string schemaType, string schemaId);

        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGetAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId);
        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="locationId">Location Id (optional)</param>
        /// <returns>Task of SiteEntityListing</returns>
        System.Threading.Tasks.Task<SiteEntityListing> ConfigurationSitesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);

        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="locationId">Location Id (optional)</param>
        /// <returns>Task of ApiResponse (SiteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SiteEntityListing>> ConfigurationSitesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);
        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site (optional)</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> ConfigurationSitesPostAsync (Site body = null);

        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site (optional)</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> ConfigurationSitesPostAsyncWithHttpInfo (Site body = null);
        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfigurationSitesSiteidDeleteAsync (string siteId);

        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationSitesSiteidDeleteAsyncWithHttpInfo (string siteId);
        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> ConfigurationSitesSiteidGetAsync (string siteId);

        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> ConfigurationSitesSiteidGetAsyncWithHttpInfo (string siteId);
        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> ConfigurationSitesSiteidNumberplansClassificationsGetAsync (string siteId, string classification = null);

        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> ConfigurationSitesSiteidNumberplansClassificationsGetAsyncWithHttpInfo (string siteId, string classification = null);
        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        System.Threading.Tasks.Task<List<NumberPlan>> ConfigurationSitesSiteidNumberplansGetAsync (string siteId);

        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> ConfigurationSitesSiteidNumberplansGetAsyncWithHttpInfo (string siteId);
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of NumberPlan</returns>
        System.Threading.Tasks.Task<NumberPlan> ConfigurationSitesSiteidNumberplansNumberplanidGetAsync (string siteId, string numberPlanId);

        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<NumberPlan>> ConfigurationSitesSiteidNumberplansNumberplanidGetAsyncWithHttpInfo (string siteId, string numberPlanId);
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        System.Threading.Tasks.Task<List<NumberPlan>> ConfigurationSitesSiteidNumberplansPutAsync (string siteId, List<NumberPlan> body = null);

        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> ConfigurationSitesSiteidNumberplansPutAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null);
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site (optional)</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> ConfigurationSitesSiteidPutAsync (string siteId, Site body = null);

        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site (optional)</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> ConfigurationSitesSiteidPutAsyncWithHttpInfo (string siteId, Site body = null);
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConfigurationSitesSiteidRebalancePostAsync (string siteId);

        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConfigurationSitesSiteidRebalancePostAsyncWithHttpInfo (string siteId);
        #endregion Asynchronous Operations
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>string</returns>
        public string ConfigurationDidpoolsDidpoolidDelete (string didPoolId)
        {
             ApiResponse<string> localVarResponse = ConfigurationDidpoolsDidpoolidDeleteWithHttpInfo(didPoolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationDidpoolsDidpoolidDeleteWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->ConfigurationDidpoolsDidpoolidDelete");

            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
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
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationDidpoolsDidpoolidDeleteAsync (string didPoolId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationDidpoolsDidpoolidDeleteAsyncWithHttpInfo(didPoolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationDidpoolsDidpoolidDeleteAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->ConfigurationDidpoolsDidpoolidDelete");

            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
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
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>DIDPool</returns>
        public DIDPool ConfigurationDidpoolsDidpoolidGet (string didPoolId)
        {
             ApiResponse<DIDPool> localVarResponse = ConfigurationDidpoolsDidpoolidGetWithHttpInfo(didPoolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > ConfigurationDidpoolsDidpoolidGetWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->ConfigurationDidpoolsDidpoolidGet");

            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
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
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> ConfigurationDidpoolsDidpoolidGetAsync (string didPoolId)
        {
             ApiResponse<DIDPool> localVarResponse = await ConfigurationDidpoolsDidpoolidGetAsyncWithHttpInfo(didPoolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> ConfigurationDidpoolsDidpoolidGetAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->ConfigurationDidpoolsDidpoolidGet");

            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
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
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DIDPool</returns>
        public DIDPool ConfigurationDidpoolsDidpoolidPut (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> localVarResponse = ConfigurationDidpoolsDidpoolidPutWithHttpInfo(didPoolId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > ConfigurationDidpoolsDidpoolidPutWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->ConfigurationDidpoolsDidpoolidPut");

            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
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
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> ConfigurationDidpoolsDidpoolidPutAsync (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> localVarResponse = await ConfigurationDidpoolsDidpoolidPutAsyncWithHttpInfo(didPoolId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> ConfigurationDidpoolsDidpoolidPutAsyncWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->ConfigurationDidpoolsDidpoolidPut");

            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
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
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsDidpoolidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }

        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <returns>DIDPoolEntityListing</returns>
        public DIDPoolEntityListing ConfigurationDidpoolsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<DIDPoolEntityListing> localVarResponse = ConfigurationDidpoolsGetWithHttpInfo(pageSize, pageNumber, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <returns>ApiResponse of DIDPoolEntityListing</returns>
        public ApiResponse< DIDPoolEntityListing > ConfigurationDidpoolsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/configuration/didpools";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPoolEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPoolEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPoolEntityListing)));
            
        }

        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <returns>Task of DIDPoolEntityListing</returns>
        public async System.Threading.Tasks.Task<DIDPoolEntityListing> ConfigurationDidpoolsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<DIDPoolEntityListing> localVarResponse = await ConfigurationDidpoolsGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <returns>Task of ApiResponse (DIDPoolEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPoolEntityListing>> ConfigurationDidpoolsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/configuration/didpools";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPoolEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPoolEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPoolEntityListing)));
            
        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>DIDPool</returns>
        public DIDPool ConfigurationDidpoolsPost (DIDPool body = null)
        {
             ApiResponse<DIDPool> localVarResponse = ConfigurationDidpoolsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > ConfigurationDidpoolsPostWithHttpInfo (DIDPool body = null)
        {

            var localVarPath = "/api/v1/configuration/didpools";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> ConfigurationDidpoolsPostAsync (DIDPool body = null)
        {
             ApiResponse<DIDPool> localVarResponse = await ConfigurationDidpoolsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> ConfigurationDidpoolsPostAsyncWithHttpInfo (DIDPool body = null)
        {

            var localVarPath = "/api/v1/configuration/didpools";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidpoolsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>DID</returns>
        public DID ConfigurationDidsDididGet (string didId)
        {
             ApiResponse<DID> localVarResponse = ConfigurationDidsDididGetWithHttpInfo(didId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > ConfigurationDidsDididGetWithHttpInfo (string didId)
        {
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->ConfigurationDidsDididGet");

            var localVarPath = "/api/v1/configuration/dids/{didId}";
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
            if (didId != null) localVarPathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsDididGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsDididGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DID>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DID)));
            
        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        public async System.Threading.Tasks.Task<DID> ConfigurationDidsDididGetAsync (string didId)
        {
             ApiResponse<DID> localVarResponse = await ConfigurationDidsDididGetAsyncWithHttpInfo(didId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> ConfigurationDidsDididGetAsyncWithHttpInfo (string didId)
        {
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->ConfigurationDidsDididGet");

            var localVarPath = "/api/v1/configuration/dids/{didId}";
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
            if (didId != null) localVarPathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsDididGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsDididGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DID>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DID)));
            
        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DID</returns>
        public DID ConfigurationDidsDididPut (string didId, DID body = null)
        {
             ApiResponse<DID> localVarResponse = ConfigurationDidsDididPutWithHttpInfo(didId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > ConfigurationDidsDididPutWithHttpInfo (string didId, DID body = null)
        {
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->ConfigurationDidsDididPut");

            var localVarPath = "/api/v1/configuration/dids/{didId}";
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
            if (didId != null) localVarPathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsDididPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsDididPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DID>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DID)));
            
        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DID</returns>
        public async System.Threading.Tasks.Task<DID> ConfigurationDidsDididPutAsync (string didId, DID body = null)
        {
             ApiResponse<DID> localVarResponse = await ConfigurationDidsDididPutAsyncWithHttpInfo(didId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> ConfigurationDidsDididPutAsyncWithHttpInfo (string didId, DID body = null)
        {
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->ConfigurationDidsDididPut");

            var localVarPath = "/api/v1/configuration/dids/{didId}";
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
            if (didId != null) localVarPathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsDididPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsDididPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DID>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DID)));
            
        }

        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="phoneNumber">Filter by phoneNumber (optional)</param>
        /// <returns>DIDEntityListing</returns>
        public DIDEntityListing ConfigurationDidsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
             ApiResponse<DIDEntityListing> localVarResponse = ConfigurationDidsGetWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="phoneNumber">Filter by phoneNumber (optional)</param>
        /// <returns>ApiResponse of DIDEntityListing</returns>
        public ApiResponse< DIDEntityListing > ConfigurationDidsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {

            var localVarPath = "/api/v1/configuration/dids";
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
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDEntityListing)));
            
        }

        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="phoneNumber">Filter by phoneNumber (optional)</param>
        /// <returns>Task of DIDEntityListing</returns>
        public async System.Threading.Tasks.Task<DIDEntityListing> ConfigurationDidsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
             ApiResponse<DIDEntityListing> localVarResponse = await ConfigurationDidsGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="phoneNumber">Filter by phoneNumber (optional)</param>
        /// <returns>Task of ApiResponse (DIDEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDEntityListing>> ConfigurationDidsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {

            var localVarPath = "/api/v1/configuration/dids";
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
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationDidsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDEntityListing)));
            
        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>string</returns>
        public string ConfigurationEdgesCertificateauthoritiesCertificateidDelete (string certificateId)
        {
             ApiResponse<string> localVarResponse = ConfigurationEdgesCertificateauthoritiesCertificateidDeleteWithHttpInfo(certificateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationEdgesCertificateauthoritiesCertificateidDeleteWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->ConfigurationEdgesCertificateauthoritiesCertificateidDelete");

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
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
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationEdgesCertificateauthoritiesCertificateidDeleteAsync (string certificateId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationEdgesCertificateauthoritiesCertificateidDeleteAsyncWithHttpInfo(certificateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesCertificateauthoritiesCertificateidDeleteAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->ConfigurationEdgesCertificateauthoritiesCertificateidDelete");

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
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
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority ConfigurationEdgesCertificateauthoritiesCertificateidGet (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = ConfigurationEdgesCertificateauthoritiesCertificateidGetWithHttpInfo(certificateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > ConfigurationEdgesCertificateauthoritiesCertificateidGetWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->ConfigurationEdgesCertificateauthoritiesCertificateidGet");

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
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
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> ConfigurationEdgesCertificateauthoritiesCertificateidGetAsync (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = await ConfigurationEdgesCertificateauthoritiesCertificateidGetAsyncWithHttpInfo(certificateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> ConfigurationEdgesCertificateauthoritiesCertificateidGetAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->ConfigurationEdgesCertificateauthoritiesCertificateidGet");

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
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
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority ConfigurationEdgesCertificateauthoritiesCertificateidPut (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = ConfigurationEdgesCertificateauthoritiesCertificateidPutWithHttpInfo(certificateId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > ConfigurationEdgesCertificateauthoritiesCertificateidPutWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->ConfigurationEdgesCertificateauthoritiesCertificateidPut");

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
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
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> ConfigurationEdgesCertificateauthoritiesCertificateidPutAsync (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = await ConfigurationEdgesCertificateauthoritiesCertificateidPutAsyncWithHttpInfo(certificateId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> ConfigurationEdgesCertificateauthoritiesCertificateidPutAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->ConfigurationEdgesCertificateauthoritiesCertificateidPut");

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
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
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesCertificateidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }

        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CertificateAuthorityEntityListing</returns>
        public CertificateAuthorityEntityListing ConfigurationEdgesCertificateauthoritiesGet ()
        {
             ApiResponse<CertificateAuthorityEntityListing> localVarResponse = ConfigurationEdgesCertificateauthoritiesGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CertificateAuthorityEntityListing</returns>
        public ApiResponse< CertificateAuthorityEntityListing > ConfigurationEdgesCertificateauthoritiesGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CertificateAuthorityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CertificateAuthorityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CertificateAuthorityEntityListing)));
            
        }

        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CertificateAuthorityEntityListing</returns>
        public async System.Threading.Tasks.Task<CertificateAuthorityEntityListing> ConfigurationEdgesCertificateauthoritiesGetAsync ()
        {
             ApiResponse<CertificateAuthorityEntityListing> localVarResponse = await ConfigurationEdgesCertificateauthoritiesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CertificateAuthorityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CertificateAuthorityEntityListing>> ConfigurationEdgesCertificateauthoritiesGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CertificateAuthorityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CertificateAuthorityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CertificateAuthorityEntityListing)));
            
        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority (optional)</param>
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority ConfigurationEdgesCertificateauthoritiesPost (DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = ConfigurationEdgesCertificateauthoritiesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority (optional)</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > ConfigurationEdgesCertificateauthoritiesPostWithHttpInfo (DomainCertificateAuthority body = null)
        {

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority (optional)</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> ConfigurationEdgesCertificateauthoritiesPostAsync (DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = await ConfigurationEdgesCertificateauthoritiesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority (optional)</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> ConfigurationEdgesCertificateauthoritiesPostAsyncWithHttpInfo (DomainCertificateAuthority body = null)
        {

            var localVarPath = "/api/v1/configuration/edges/certificateauthorities";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesCertificateauthoritiesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        public string ConfigurationEdgesEdgeidDelete (string edgeId)
        {
             ApiResponse<string> localVarResponse = ConfigurationEdgesEdgeidDeleteWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationEdgesEdgeidDeleteWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidDelete");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationEdgesEdgeidDeleteAsync (string edgeId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationEdgesEdgeidDeleteAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesEdgeidDeleteAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidDelete");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Edge</returns>
        public Edge ConfigurationEdgesEdgeidGet (string edgeId)
        {
             ApiResponse<Edge> localVarResponse = ConfigurationEdgesEdgeidGetWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > ConfigurationEdgesEdgeidGetWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> ConfigurationEdgesEdgeidGetAsync (string edgeId)
        {
             ApiResponse<Edge> localVarResponse = await ConfigurationEdgesEdgeidGetAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> ConfigurationEdgesEdgeidGetAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EdgeLineEntityListing</returns>
        public EdgeLineEntityListing ConfigurationEdgesEdgeidLinesGet (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EdgeLineEntityListing> localVarResponse = ConfigurationEdgesEdgeidLinesGetWithHttpInfo(edgeId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EdgeLineEntityListing</returns>
        public ApiResponse< EdgeLineEntityListing > ConfigurationEdgesEdgeidLinesGetWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLineEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLineEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLineEntityListing)));
            
        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EdgeLineEntityListing</returns>
        public async System.Threading.Tasks.Task<EdgeLineEntityListing> ConfigurationEdgesEdgeidLinesGetAsync (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EdgeLineEntityListing> localVarResponse = await ConfigurationEdgesEdgeidLinesGetAsyncWithHttpInfo(edgeId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EdgeLineEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLineEntityListing>> ConfigurationEdgesEdgeidLinesGetAsyncWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLineEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLineEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLineEntityListing)));
            
        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>EdgeLine</returns>
        public EdgeLine ConfigurationEdgesEdgeidLinesLineidGet (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> localVarResponse = ConfigurationEdgesEdgeidLinesLineidGetWithHttpInfo(edgeId, lineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > ConfigurationEdgesEdgeidLinesLineidGetWithHttpInfo (string edgeId, string lineId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesLineidGet");
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesLineidGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) localVarPathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesLineidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesLineidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLine)));
            
        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of EdgeLine</returns>
        public async System.Threading.Tasks.Task<EdgeLine> ConfigurationEdgesEdgeidLinesLineidGetAsync (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> localVarResponse = await ConfigurationEdgesEdgeidLinesLineidGetAsyncWithHttpInfo(edgeId, lineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> ConfigurationEdgesEdgeidLinesLineidGetAsyncWithHttpInfo (string edgeId, string lineId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesLineidGet");
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesLineidGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) localVarPathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesLineidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesLineidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLine)));
            
        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line (optional)</param>
        /// <returns>EdgeLine</returns>
        public EdgeLine ConfigurationEdgesEdgeidLinesLineidPut (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> localVarResponse = ConfigurationEdgesEdgeidLinesLineidPutWithHttpInfo(edgeId, lineId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line (optional)</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > ConfigurationEdgesEdgeidLinesLineidPutWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesLineidPut");
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesLineidPut");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) localVarPathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesLineidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesLineidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLine)));
            
        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line (optional)</param>
        /// <returns>Task of EdgeLine</returns>
        public async System.Threading.Tasks.Task<EdgeLine> ConfigurationEdgesEdgeidLinesLineidPutAsync (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> localVarResponse = await ConfigurationEdgesEdgeidLinesLineidPutAsyncWithHttpInfo(edgeId, lineId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line (optional)</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> ConfigurationEdgesEdgeidLinesLineidPutAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesLineidPut");
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLinesLineidPut");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) localVarPathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesLineidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLinesLineidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLine)));
            
        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>LogicalInterfaceEntityListing</returns>
        public LogicalInterfaceEntityListing ConfigurationEdgesEdgeidLogicalinterfacesGet (string edgeId)
        {
             ApiResponse<LogicalInterfaceEntityListing> localVarResponse = ConfigurationEdgesEdgeidLogicalinterfacesGetWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of LogicalInterfaceEntityListing</returns>
        public ApiResponse< LogicalInterfaceEntityListing > ConfigurationEdgesEdgeidLogicalinterfacesGetWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogicalInterfaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogicalInterfaceEntityListing)));
            
        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of LogicalInterfaceEntityListing</returns>
        public async System.Threading.Tasks.Task<LogicalInterfaceEntityListing> ConfigurationEdgesEdgeidLogicalinterfacesGetAsync (string edgeId)
        {
             ApiResponse<LogicalInterfaceEntityListing> localVarResponse = await ConfigurationEdgesEdgeidLogicalinterfacesGetAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (LogicalInterfaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LogicalInterfaceEntityListing>> ConfigurationEdgesEdgeidLogicalinterfacesGetAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogicalInterfaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogicalInterfaceEntityListing)));
            
        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns></returns>
        public void ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete (string edgeId, string interfaceId)
        {
             ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDeleteWithHttpInfo(edgeId, interfaceId);
        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDeleteWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDeleteAsync (string edgeId, string interfaceId)
        {
             await ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDeleteAsyncWithHttpInfo(edgeId, interfaceId);

        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDeleteAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainLogicalInterface</returns>
        public DomainLogicalInterface ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGetWithHttpInfo(edgeId, interfaceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGetWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainLogicalInterface> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGetAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = await ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGetAsyncWithHttpInfo(edgeId, interfaceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGetAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainLogicalInterface</returns>
        public DomainLogicalInterface ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPutWithHttpInfo(edgeId, interfaceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPutWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainLogicalInterface> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPutAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = await ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPutAsyncWithHttpInfo(edgeId, interfaceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPutAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesInterfaceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DomainLogicalInterface</returns>
        public DomainLogicalInterface ConfigurationEdgesEdgeidLogicalinterfacesPost (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = ConfigurationEdgesEdgeidLogicalinterfacesPostWithHttpInfo(edgeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > ConfigurationEdgesEdgeidLogicalinterfacesPostWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesPost");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainLogicalInterface> ConfigurationEdgesEdgeidLogicalinterfacesPostAsync (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = await ConfigurationEdgesEdgeidLogicalinterfacesPostAsyncWithHttpInfo(edgeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> ConfigurationEdgesEdgeidLogicalinterfacesPostAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidLogicalinterfacesPost");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidLogicalinterfacesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>PhysicalInterfaceEntityListing</returns>
        public PhysicalInterfaceEntityListing ConfigurationEdgesEdgeidPhysicalinterfacesGet (string edgeId)
        {
             ApiResponse<PhysicalInterfaceEntityListing> localVarResponse = ConfigurationEdgesEdgeidPhysicalinterfacesGetWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of PhysicalInterfaceEntityListing</returns>
        public ApiResponse< PhysicalInterfaceEntityListing > ConfigurationEdgesEdgeidPhysicalinterfacesGetWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidPhysicalinterfacesGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPhysicalinterfacesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPhysicalinterfacesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhysicalInterfaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhysicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhysicalInterfaceEntityListing)));
            
        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of PhysicalInterfaceEntityListing</returns>
        public async System.Threading.Tasks.Task<PhysicalInterfaceEntityListing> ConfigurationEdgesEdgeidPhysicalinterfacesGetAsync (string edgeId)
        {
             ApiResponse<PhysicalInterfaceEntityListing> localVarResponse = await ConfigurationEdgesEdgeidPhysicalinterfacesGetAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (PhysicalInterfaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhysicalInterfaceEntityListing>> ConfigurationEdgesEdgeidPhysicalinterfacesGetAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidPhysicalinterfacesGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPhysicalinterfacesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPhysicalinterfacesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhysicalInterfaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhysicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhysicalInterfaceEntityListing)));
            
        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainPhysicalInterface</returns>
        public DomainPhysicalInterface ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> localVarResponse = ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGetWithHttpInfo(edgeId, interfaceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        public ApiResponse< DomainPhysicalInterface > ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGetWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces/{interfaceId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainPhysicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainPhysicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainPhysicalInterface)));
            
        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainPhysicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainPhysicalInterface> ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGetAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> localVarResponse = await ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGetAsyncWithHttpInfo(edgeId, interfaceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGetAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces/{interfaceId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPhysicalinterfacesInterfaceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainPhysicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainPhysicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainPhysicalInterface)));
            
        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Edge</returns>
        public Edge ConfigurationEdgesEdgeidPut (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> localVarResponse = ConfigurationEdgesEdgeidPutWithHttpInfo(edgeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge (optional)</param>
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > ConfigurationEdgesEdgeidPutWithHttpInfo (string edgeId, Edge body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidPut");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> ConfigurationEdgesEdgeidPutAsync (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> localVarResponse = await ConfigurationEdgesEdgeidPutAsyncWithHttpInfo(edgeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> ConfigurationEdgesEdgeidPutAsyncWithHttpInfo (string edgeId, Edge body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidPut");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        public string ConfigurationEdgesEdgeidRebootPost (string edgeId)
        {
             ApiResponse<string> localVarResponse = ConfigurationEdgesEdgeidRebootPostWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationEdgesEdgeidRebootPostWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidRebootPost");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/reboot";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidRebootPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidRebootPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationEdgesEdgeidRebootPostAsync (string edgeId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationEdgesEdgeidRebootPostAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesEdgeidRebootPostAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidRebootPost");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/reboot";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidRebootPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidRebootPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        public string ConfigurationEdgesEdgeidSoftwareupdateDelete (string edgeId)
        {
             ApiResponse<string> localVarResponse = ConfigurationEdgesEdgeidSoftwareupdateDeleteWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationEdgesEdgeidSoftwareupdateDeleteWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidSoftwareupdateDelete");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdateDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdateDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationEdgesEdgeidSoftwareupdateDeleteAsync (string edgeId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationEdgesEdgeidSoftwareupdateDeleteAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesEdgeidSoftwareupdateDeleteAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidSoftwareupdateDelete");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdateDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdateDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        public DomainEdgeSoftwareUpdateDto ConfigurationEdgesEdgeidSoftwareupdateGet (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> localVarResponse = ConfigurationEdgesEdgeidSoftwareupdateGetWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        public ApiResponse< DomainEdgeSoftwareUpdateDto > ConfigurationEdgesEdgeidSoftwareupdateGetWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidSoftwareupdateGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> ConfigurationEdgesEdgeidSoftwareupdateGetAsync (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> localVarResponse = await ConfigurationEdgesEdgeidSoftwareupdateGetAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> ConfigurationEdgesEdgeidSoftwareupdateGetAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidSoftwareupdateGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void ConfigurationEdgesEdgeidSoftwareupdatePost (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             ConfigurationEdgesEdgeidSoftwareupdatePostWithHttpInfo(edgeId, body);
        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConfigurationEdgesEdgeidSoftwareupdatePostWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidSoftwareupdatePost");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConfigurationEdgesEdgeidSoftwareupdatePostAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             await ConfigurationEdgesEdgeidSoftwareupdatePostAsyncWithHttpInfo(edgeId, body);

        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConfigurationEdgesEdgeidSoftwareupdatePostAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidSoftwareupdatePost");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdatePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareupdatePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareVersionDto</returns>
        public DomainEdgeSoftwareVersionDto ConfigurationEdgesEdgeidSoftwareversionsGet (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareVersionDto> localVarResponse = ConfigurationEdgesEdgeidSoftwareversionsGetWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareVersionDto</returns>
        public ApiResponse< DomainEdgeSoftwareVersionDto > ConfigurationEdgesEdgeidSoftwareversionsGetWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidSoftwareversionsGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareversions";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareversionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareversionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareVersionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareVersionDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareVersionDto)));
            
        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareVersionDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareVersionDto> ConfigurationEdgesEdgeidSoftwareversionsGetAsync (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareVersionDto> localVarResponse = await ConfigurationEdgesEdgeidSoftwareversionsGetAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareVersionDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareVersionDto>> ConfigurationEdgesEdgeidSoftwareversionsGetAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidSoftwareversionsGet");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareversions";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareversionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidSoftwareversionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareVersionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareVersionDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareVersionDto)));
            
        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>string</returns>
        public string ConfigurationEdgesEdgeidUnpairPost (string edgeId)
        {
             ApiResponse<string> localVarResponse = ConfigurationEdgesEdgeidUnpairPostWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationEdgesEdgeidUnpairPostWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidUnpairPost");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/unpair";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidUnpairPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidUnpairPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationEdgesEdgeidUnpairPostAsync (string edgeId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationEdgesEdgeidUnpairPostAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEdgesEdgeidUnpairPostAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->ConfigurationEdgesEdgeidUnpairPost");

            var localVarPath = "/api/v1/configuration/edges/{edgeId}/unpair";
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
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidUnpairPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesEdgeidUnpairPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>EdgeEntityListing</returns>
        public EdgeEntityListing ConfigurationEdgesGet (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
             ApiResponse<EdgeEntityListing> localVarResponse = ConfigurationEdgesGetWithHttpInfo(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of EdgeEntityListing</returns>
        public ApiResponse< EdgeEntityListing > ConfigurationEdgesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/configuration/edges";
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
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (siteId != null) localVarQueryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (edgeGroupId != null) localVarQueryParams.Add("edgeGroup.id", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeEntityListing)));
            
        }

        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of EdgeEntityListing</returns>
        public async System.Threading.Tasks.Task<EdgeEntityListing> ConfigurationEdgesGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
             ApiResponse<EdgeEntityListing> localVarResponse = await ConfigurationEdgesGetAsyncWithHttpInfo(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (EdgeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeEntityListing>> ConfigurationEdgesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/configuration/edges";
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
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (siteId != null) localVarQueryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (edgeGroupId != null) localVarQueryParams.Add("edgeGroup.id", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeEntityListing)));
            
        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Edge</returns>
        public Edge ConfigurationEdgesPost (Edge body = null)
        {
             ApiResponse<Edge> localVarResponse = ConfigurationEdgesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge (optional)</param>
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > ConfigurationEdgesPostWithHttpInfo (Edge body = null)
        {

            var localVarPath = "/api/v1/configuration/edges";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> ConfigurationEdgesPostAsync (Edge body = null)
        {
             ApiResponse<Edge> localVarResponse = await ConfigurationEdgesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge (optional)</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> ConfigurationEdgesPostAsyncWithHttpInfo (Edge body = null)
        {

            var localVarPath = "/api/v1/configuration/edges";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }

        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EdgeVersionReport</returns>
        public EdgeVersionReport ConfigurationEdgeversionreportGet ()
        {
             ApiResponse<EdgeVersionReport> localVarResponse = ConfigurationEdgeversionreportGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EdgeVersionReport</returns>
        public ApiResponse< EdgeVersionReport > ConfigurationEdgeversionreportGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/edgeversionreport";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgeversionreportGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgeversionreportGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeVersionReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeVersionReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeVersionReport)));
            
        }

        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EdgeVersionReport</returns>
        public async System.Threading.Tasks.Task<EdgeVersionReport> ConfigurationEdgeversionreportGetAsync ()
        {
             ApiResponse<EdgeVersionReport> localVarResponse = await ConfigurationEdgeversionreportGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EdgeVersionReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeVersionReport>> ConfigurationEdgeversionreportGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/edgeversionreport";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgeversionreportGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEdgeversionreportGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeVersionReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeVersionReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeVersionReport)));
            
        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>string</returns>
        public string ConfigurationEndpointsEndpointidDelete (string endpointId)
        {
             ApiResponse<string> localVarResponse = ConfigurationEndpointsEndpointidDeleteWithHttpInfo(endpointId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationEndpointsEndpointidDeleteWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->ConfigurationEndpointsEndpointidDelete");

            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
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
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationEndpointsEndpointidDeleteAsync (string endpointId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationEndpointsEndpointidDeleteAsyncWithHttpInfo(endpointId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationEndpointsEndpointidDeleteAsyncWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->ConfigurationEndpointsEndpointidDelete");

            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
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
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Endpoint</returns>
        public Endpoint ConfigurationEndpointsEndpointidGet (string endpointId)
        {
             ApiResponse<Endpoint> localVarResponse = ConfigurationEndpointsEndpointidGetWithHttpInfo(endpointId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > ConfigurationEndpointsEndpointidGetWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->ConfigurationEndpointsEndpointidGet");

            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
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
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> ConfigurationEndpointsEndpointidGetAsync (string endpointId)
        {
             ApiResponse<Endpoint> localVarResponse = await ConfigurationEndpointsEndpointidGetAsyncWithHttpInfo(endpointId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> ConfigurationEndpointsEndpointidGetAsyncWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->ConfigurationEndpointsEndpointidGet");

            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
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
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Endpoint</returns>
        public Endpoint ConfigurationEndpointsEndpointidPut (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> localVarResponse = ConfigurationEndpointsEndpointidPutWithHttpInfo(endpointId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > ConfigurationEndpointsEndpointidPutWithHttpInfo (string endpointId, Endpoint body = null)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->ConfigurationEndpointsEndpointidPut");

            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
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
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> ConfigurationEndpointsEndpointidPutAsync (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> localVarResponse = await ConfigurationEndpointsEndpointidPutAsyncWithHttpInfo(endpointId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> ConfigurationEndpointsEndpointidPutAsyncWithHttpInfo (string endpointId, Endpoint body = null)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->ConfigurationEndpointsEndpointidPut");

            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
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
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsEndpointidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }

        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>EndpointEntityListing</returns>
        public EndpointEntityListing ConfigurationEndpointsGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EndpointEntityListing> localVarResponse = ConfigurationEndpointsGetWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of EndpointEntityListing</returns>
        public ApiResponse< EndpointEntityListing > ConfigurationEndpointsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/configuration/endpoints";
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
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EndpointEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EndpointEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EndpointEntityListing)));
            
        }

        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of EndpointEntityListing</returns>
        public async System.Threading.Tasks.Task<EndpointEntityListing> ConfigurationEndpointsGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EndpointEntityListing> localVarResponse = await ConfigurationEndpointsGetAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (EndpointEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EndpointEntityListing>> ConfigurationEndpointsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/configuration/endpoints";
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
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EndpointEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EndpointEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EndpointEntityListing)));
            
        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Endpoint</returns>
        public Endpoint ConfigurationEndpointsPost (Endpoint body = null)
        {
             ApiResponse<Endpoint> localVarResponse = ConfigurationEndpointsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > ConfigurationEndpointsPostWithHttpInfo (Endpoint body = null)
        {

            var localVarPath = "/api/v1/configuration/endpoints";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> ConfigurationEndpointsPostAsync (Endpoint body = null)
        {
             ApiResponse<Endpoint> localVarResponse = await ConfigurationEndpointsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate (optional)</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> ConfigurationEndpointsPostAsyncWithHttpInfo (Endpoint body = null)
        {

            var localVarPath = "/api/v1/configuration/endpoints";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationEndpointsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>string</returns>
        public string ConfigurationExtensionpoolsExtensionpoolidDelete (string extensionPoolId)
        {
             ApiResponse<string> localVarResponse = ConfigurationExtensionpoolsExtensionpoolidDeleteWithHttpInfo(extensionPoolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationExtensionpoolsExtensionpoolidDeleteWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->ConfigurationExtensionpoolsExtensionpoolidDelete");

            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
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
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationExtensionpoolsExtensionpoolidDeleteAsync (string extensionPoolId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationExtensionpoolsExtensionpoolidDeleteAsyncWithHttpInfo(extensionPoolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationExtensionpoolsExtensionpoolidDeleteAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->ConfigurationExtensionpoolsExtensionpoolidDelete");

            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
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
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ExtensionPool</returns>
        public ExtensionPool ConfigurationExtensionpoolsExtensionpoolidGet (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> localVarResponse = ConfigurationExtensionpoolsExtensionpoolidGetWithHttpInfo(extensionPoolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > ConfigurationExtensionpoolsExtensionpoolidGetWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->ConfigurationExtensionpoolsExtensionpoolidGet");

            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
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
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPool)));
            
        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        public async System.Threading.Tasks.Task<ExtensionPool> ConfigurationExtensionpoolsExtensionpoolidGetAsync (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> localVarResponse = await ConfigurationExtensionpoolsExtensionpoolidGetAsyncWithHttpInfo(extensionPoolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> ConfigurationExtensionpoolsExtensionpoolidGetAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->ConfigurationExtensionpoolsExtensionpoolidGet");

            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
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
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPool)));
            
        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>ExtensionPool</returns>
        public ExtensionPool ConfigurationExtensionpoolsExtensionpoolidPut (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> localVarResponse = ConfigurationExtensionpoolsExtensionpoolidPutWithHttpInfo(extensionPoolId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > ConfigurationExtensionpoolsExtensionpoolidPutWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->ConfigurationExtensionpoolsExtensionpoolidPut");

            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
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
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPool)));
            
        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Task of ExtensionPool</returns>
        public async System.Threading.Tasks.Task<ExtensionPool> ConfigurationExtensionpoolsExtensionpoolidPutAsync (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> localVarResponse = await ConfigurationExtensionpoolsExtensionpoolidPutAsyncWithHttpInfo(extensionPoolId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> ConfigurationExtensionpoolsExtensionpoolidPutAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->ConfigurationExtensionpoolsExtensionpoolidPut");

            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
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
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsExtensionpoolidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPool)));
            
        }

        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to startNumber)</param>
        /// <param name="number">Number (optional)</param>
        /// <returns>ExtensionPoolEntityListing</returns>
        public ExtensionPoolEntityListing ConfigurationExtensionpoolsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
             ApiResponse<ExtensionPoolEntityListing> localVarResponse = ConfigurationExtensionpoolsGetWithHttpInfo(pageSize, pageNumber, sortBy, number);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to startNumber)</param>
        /// <param name="number">Number (optional)</param>
        /// <returns>ApiResponse of ExtensionPoolEntityListing</returns>
        public ApiResponse< ExtensionPoolEntityListing > ConfigurationExtensionpoolsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {

            var localVarPath = "/api/v1/configuration/extensionpools";
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
            if (number != null) localVarQueryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionPoolEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPoolEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPoolEntityListing)));
            
        }

        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to startNumber)</param>
        /// <param name="number">Number (optional)</param>
        /// <returns>Task of ExtensionPoolEntityListing</returns>
        public async System.Threading.Tasks.Task<ExtensionPoolEntityListing> ConfigurationExtensionpoolsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
             ApiResponse<ExtensionPoolEntityListing> localVarResponse = await ConfigurationExtensionpoolsGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, number);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to startNumber)</param>
        /// <param name="number">Number (optional)</param>
        /// <returns>Task of ApiResponse (ExtensionPoolEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPoolEntityListing>> ConfigurationExtensionpoolsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {

            var localVarPath = "/api/v1/configuration/extensionpools";
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
            if (number != null) localVarQueryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionPoolEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPoolEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPoolEntityListing)));
            
        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Extension</returns>
        public Extension ConfigurationExtensionpoolsPost (ExtensionPool body = null)
        {
             ApiResponse<Extension> localVarResponse = ConfigurationExtensionpoolsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > ConfigurationExtensionpoolsPostWithHttpInfo (ExtensionPool body = null)
        {

            var localVarPath = "/api/v1/configuration/extensionpools";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> ConfigurationExtensionpoolsPostAsync (ExtensionPool body = null)
        {
             ApiResponse<Extension> localVarResponse = await ConfigurationExtensionpoolsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool (optional)</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> ConfigurationExtensionpoolsPostAsyncWithHttpInfo (ExtensionPool body = null)
        {

            var localVarPath = "/api/v1/configuration/extensionpools";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionpoolsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Extension</returns>
        public Extension ConfigurationExtensionsExtensionidGet (string extensionId)
        {
             ApiResponse<Extension> localVarResponse = ConfigurationExtensionsExtensionidGetWithHttpInfo(extensionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > ConfigurationExtensionsExtensionidGetWithHttpInfo (string extensionId)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->ConfigurationExtensionsExtensionidGet");

            var localVarPath = "/api/v1/configuration/extensions/{extensionId}";
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
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsExtensionidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsExtensionidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> ConfigurationExtensionsExtensionidGetAsync (string extensionId)
        {
             ApiResponse<Extension> localVarResponse = await ConfigurationExtensionsExtensionidGetAsyncWithHttpInfo(extensionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> ConfigurationExtensionsExtensionidGetAsyncWithHttpInfo (string extensionId)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->ConfigurationExtensionsExtensionidGet");

            var localVarPath = "/api/v1/configuration/extensions/{extensionId}";
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
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsExtensionidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsExtensionidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Extension</returns>
        public Extension ConfigurationExtensionsExtensionidPut (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> localVarResponse = ConfigurationExtensionsExtensionidPutWithHttpInfo(extensionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > ConfigurationExtensionsExtensionidPutWithHttpInfo (string extensionId, Extension body = null)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->ConfigurationExtensionsExtensionidPut");

            var localVarPath = "/api/v1/configuration/extensions/{extensionId}";
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
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsExtensionidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsExtensionidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> ConfigurationExtensionsExtensionidPutAsync (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> localVarResponse = await ConfigurationExtensionsExtensionidPutAsyncWithHttpInfo(extensionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> ConfigurationExtensionsExtensionidPutAsyncWithHttpInfo (string extensionId, Extension body = null)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->ConfigurationExtensionsExtensionidPut");

            var localVarPath = "/api/v1/configuration/extensions/{extensionId}";
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
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsExtensionidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsExtensionidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }

        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="number">Filter by number (optional)</param>
        /// <returns>ExtensionEntityListing</returns>
        public ExtensionEntityListing ConfigurationExtensionsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
             ApiResponse<ExtensionEntityListing> localVarResponse = ConfigurationExtensionsGetWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, number);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="number">Filter by number (optional)</param>
        /// <returns>ApiResponse of ExtensionEntityListing</returns>
        public ApiResponse< ExtensionEntityListing > ConfigurationExtensionsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {

            var localVarPath = "/api/v1/configuration/extensions";
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
            if (number != null) localVarQueryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionEntityListing)));
            
        }

        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="number">Filter by number (optional)</param>
        /// <returns>Task of ExtensionEntityListing</returns>
        public async System.Threading.Tasks.Task<ExtensionEntityListing> ConfigurationExtensionsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
             ApiResponse<ExtensionEntityListing> localVarResponse = await ConfigurationExtensionsGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, number);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to number)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="number">Filter by number (optional)</param>
        /// <returns>Task of ApiResponse (ExtensionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionEntityListing>> ConfigurationExtensionsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {

            var localVarPath = "/api/v1/configuration/extensions";
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
            if (number != null) localVarQueryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationExtensionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionEntityListing)));
            
        }

        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Organization</returns>
        public Organization ConfigurationOrganizationGet ()
        {
             ApiResponse<Organization> localVarResponse = ConfigurationOrganizationGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > ConfigurationOrganizationGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/organization";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> ConfigurationOrganizationGetAsync ()
        {
             ApiResponse<Organization> localVarResponse = await ConfigurationOrganizationGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/organization";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Organization</returns>
        public Organization ConfigurationOrganizationPut (Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = ConfigurationOrganizationPutWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > ConfigurationOrganizationPutWithHttpInfo (Organization body = null)
        {

            var localVarPath = "/api/v1/configuration/organization";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> ConfigurationOrganizationPutAsync (Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = await ConfigurationOrganizationPutAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationPutAsyncWithHttpInfo (Organization body = null)
        {

            var localVarPath = "/api/v1/configuration/organization";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>string</returns>
        public string ConfigurationOrganizationsOrgidDelete (string orgId)
        {
             ApiResponse<string> localVarResponse = ConfigurationOrganizationsOrgidDeleteWithHttpInfo(orgId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationOrganizationsOrgidDeleteWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->ConfigurationOrganizationsOrgidDelete");

            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
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
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationOrganizationsOrgidDeleteAsync (string orgId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationOrganizationsOrgidDeleteAsyncWithHttpInfo(orgId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationOrganizationsOrgidDeleteAsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->ConfigurationOrganizationsOrgidDelete");

            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
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
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Organization</returns>
        public Organization ConfigurationOrganizationsOrgidGet (string orgId)
        {
             ApiResponse<Organization> localVarResponse = ConfigurationOrganizationsOrgidGetWithHttpInfo(orgId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > ConfigurationOrganizationsOrgidGetWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->ConfigurationOrganizationsOrgidGet");

            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
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
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> ConfigurationOrganizationsOrgidGetAsync (string orgId)
        {
             ApiResponse<Organization> localVarResponse = await ConfigurationOrganizationsOrgidGetAsyncWithHttpInfo(orgId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationsOrgidGetAsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->ConfigurationOrganizationsOrgidGet");

            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
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
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Organization</returns>
        public Organization ConfigurationOrganizationsOrgidPut (string orgId, Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = ConfigurationOrganizationsOrgidPutWithHttpInfo(orgId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > ConfigurationOrganizationsOrgidPutWithHttpInfo (string orgId, Organization body = null)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->ConfigurationOrganizationsOrgidPut");

            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
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
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> ConfigurationOrganizationsOrgidPutAsync (string orgId, Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = await ConfigurationOrganizationsOrgidPutAsyncWithHttpInfo(orgId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationsOrgidPutAsyncWithHttpInfo (string orgId, Organization body = null)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->ConfigurationOrganizationsOrgidPut");

            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
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
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsOrgidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Organization</returns>
        public Organization ConfigurationOrganizationsPost (OrganizationCreate body = null)
        {
             ApiResponse<Organization> localVarResponse = ConfigurationOrganizationsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > ConfigurationOrganizationsPostWithHttpInfo (OrganizationCreate body = null)
        {

            var localVarPath = "/api/v1/configuration/organizations";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> ConfigurationOrganizationsPostAsync (OrganizationCreate body = null)
        {
             ApiResponse<Organization> localVarResponse = await ConfigurationOrganizationsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationOrganizationsPostAsyncWithHttpInfo (OrganizationCreate body = null)
        {

            var localVarPath = "/api/v1/configuration/organizations";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationOrganizationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EncryptionKeyEntityListing</returns>
        public EncryptionKeyEntityListing ConfigurationRecordingkeysGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> localVarResponse = ConfigurationRecordingkeysGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        public ApiResponse< EncryptionKeyEntityListing > ConfigurationRecordingkeysGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/configuration/recordingkeys";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKeyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKeyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKeyEntityListing)));
            
        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        public async System.Threading.Tasks.Task<EncryptionKeyEntityListing> ConfigurationRecordingkeysGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> localVarResponse = await ConfigurationRecordingkeysGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> ConfigurationRecordingkeysGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/configuration/recordingkeys";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKeyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKeyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKeyEntityListing)));
            
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EncryptionKey</returns>
        public EncryptionKey ConfigurationRecordingkeysPost ()
        {
             ApiResponse<EncryptionKey> localVarResponse = ConfigurationRecordingkeysPostWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EncryptionKey</returns>
        public ApiResponse< EncryptionKey > ConfigurationRecordingkeysPostWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/recordingkeys";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)));
            
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EncryptionKey</returns>
        public async System.Threading.Tasks.Task<EncryptionKey> ConfigurationRecordingkeysPostAsync ()
        {
             ApiResponse<EncryptionKey> localVarResponse = await ConfigurationRecordingkeysPostAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> ConfigurationRecordingkeysPostAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/recordingkeys";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)));
            
        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule ConfigurationRecordingkeysRotationscheduleGet ()
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = ConfigurationRecordingkeysRotationscheduleGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > ConfigurationRecordingkeysRotationscheduleGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/recordingkeys/rotationschedule";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysRotationscheduleGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysRotationscheduleGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> ConfigurationRecordingkeysRotationscheduleGetAsync ()
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = await ConfigurationRecordingkeysRotationscheduleGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> ConfigurationRecordingkeysRotationscheduleGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/recordingkeys/rotationschedule";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysRotationscheduleGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysRotationscheduleGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule (optional)</param>
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule ConfigurationRecordingkeysRotationschedulePut (KeyRotationSchedule body = null)
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = ConfigurationRecordingkeysRotationschedulePutWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule (optional)</param>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > ConfigurationRecordingkeysRotationschedulePutWithHttpInfo (KeyRotationSchedule body = null)
        {

            var localVarPath = "/api/v1/configuration/recordingkeys/rotationschedule";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysRotationschedulePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysRotationschedulePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule (optional)</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> ConfigurationRecordingkeysRotationschedulePutAsync (KeyRotationSchedule body = null)
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = await ConfigurationRecordingkeysRotationschedulePutAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule (optional)</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> ConfigurationRecordingkeysRotationschedulePutAsyncWithHttpInfo (KeyRotationSchedule body = null)
        {

            var localVarPath = "/api/v1/configuration/recordingkeys/rotationschedule";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysRotationschedulePut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRecordingkeysRotationschedulePut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>string</returns>
        public string ConfigurationRetentionpoliciesDelete (string ids)
        {
             ApiResponse<string> localVarResponse = ConfigurationRetentionpoliciesDeleteWithHttpInfo(ids);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationRetentionpoliciesDeleteWithHttpInfo (string ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling ConfigurationApi->ConfigurationRetentionpoliciesDelete");

            var localVarPath = "/api/v1/configuration/retentionpolicies";
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
            if (ids != null) localVarQueryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationRetentionpoliciesDeleteAsync (string ids)
        {
             ApiResponse<string> localVarResponse = await ConfigurationRetentionpoliciesDeleteAsyncWithHttpInfo(ids);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationRetentionpoliciesDeleteAsyncWithHttpInfo (string ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling ConfigurationApi->ConfigurationRetentionpoliciesDelete");

            var localVarPath = "/api/v1/configuration/retentionpolicies";
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
            if (ids != null) localVarQueryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary&#x3D;true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>PolicyEntityListing</returns>
        public PolicyEntityListing ConfigurationRetentionpoliciesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = ConfigurationRetentionpoliciesGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary&#x3D;true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        public ApiResponse< PolicyEntityListing > ConfigurationRetentionpoliciesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {

            var localVarPath = "/api/v1/configuration/retentionpolicies";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            if (summary != null) localVarQueryParams.Add("summary", Configuration.ApiClient.ParameterToString(summary)); // query parameter
            if (hasErrors != null) localVarQueryParams.Add("hasErrors", Configuration.ApiClient.ParameterToString(hasErrors)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)));
            
        }

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary&#x3D;true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>Task of PolicyEntityListing</returns>
        public async System.Threading.Tasks.Task<PolicyEntityListing> ConfigurationRetentionpoliciesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = await ConfigurationRetentionpoliciesGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary&#x3D;true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> ConfigurationRetentionpoliciesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {

            var localVarPath = "/api/v1/configuration/retentionpolicies";
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
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            if (summary != null) localVarQueryParams.Add("summary", Configuration.ApiClient.ParameterToString(summary)); // query parameter
            if (hasErrors != null) localVarQueryParams.Add("hasErrors", Configuration.ApiClient.ParameterToString(hasErrors)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)));
            
        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>string</returns>
        public string ConfigurationRetentionpoliciesPolicyidDelete (string policyId)
        {
             ApiResponse<string> localVarResponse = ConfigurationRetentionpoliciesPolicyidDeleteWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationRetentionpoliciesPolicyidDeleteWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->ConfigurationRetentionpoliciesPolicyidDelete");

            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationRetentionpoliciesPolicyidDeleteAsync (string policyId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationRetentionpoliciesPolicyidDeleteAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationRetentionpoliciesPolicyidDeleteAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->ConfigurationRetentionpoliciesPolicyidDelete");

            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Policy</returns>
        public Policy ConfigurationRetentionpoliciesPolicyidGet (string policyId)
        {
             ApiResponse<Policy> localVarResponse = ConfigurationRetentionpoliciesPolicyidGetWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > ConfigurationRetentionpoliciesPolicyidGetWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->ConfigurationRetentionpoliciesPolicyidGet");

            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> ConfigurationRetentionpoliciesPolicyidGetAsync (string policyId)
        {
             ApiResponse<Policy> localVarResponse = await ConfigurationRetentionpoliciesPolicyidGetAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> ConfigurationRetentionpoliciesPolicyidGetAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->ConfigurationRetentionpoliciesPolicyidGet");

            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Policy</returns>
        public Policy ConfigurationRetentionpoliciesPolicyidPatch (string policyId, Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = ConfigurationRetentionpoliciesPolicyidPatchWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > ConfigurationRetentionpoliciesPolicyidPatchWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->ConfigurationRetentionpoliciesPolicyidPatch");

            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> ConfigurationRetentionpoliciesPolicyidPatchAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = await ConfigurationRetentionpoliciesPolicyidPatchAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> ConfigurationRetentionpoliciesPolicyidPatchAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->ConfigurationRetentionpoliciesPolicyidPatch");

            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Policy</returns>
        public Policy ConfigurationRetentionpoliciesPolicyidPut (string policyId, Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = ConfigurationRetentionpoliciesPolicyidPutWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > ConfigurationRetentionpoliciesPolicyidPutWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->ConfigurationRetentionpoliciesPolicyidPut");

            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> ConfigurationRetentionpoliciesPolicyidPutAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = await ConfigurationRetentionpoliciesPolicyidPutAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> ConfigurationRetentionpoliciesPolicyidPutAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->ConfigurationRetentionpoliciesPolicyidPut");

            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPolicyidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Policy</returns>
        public Policy ConfigurationRetentionpoliciesPost (Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = ConfigurationRetentionpoliciesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > ConfigurationRetentionpoliciesPostWithHttpInfo (Policy body = null)
        {

            var localVarPath = "/api/v1/configuration/retentionpolicies";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> ConfigurationRetentionpoliciesPostAsync (Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = await ConfigurationRetentionpoliciesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> ConfigurationRetentionpoliciesPostAsyncWithHttpInfo (Policy body = null)
        {

            var localVarPath = "/api/v1/configuration/retentionpolicies";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationRetentionpoliciesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SchemaCategoryEntityListing</returns>
        public SchemaCategoryEntityListing ConfigurationSchemasEdgesVnextGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaCategoryEntityListing> localVarResponse = ConfigurationSchemasEdgesVnextGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SchemaCategoryEntityListing</returns>
        public ApiResponse< SchemaCategoryEntityListing > ConfigurationSchemasEdgesVnextGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaCategoryEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaCategoryEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaCategoryEntityListing)));
            
        }

        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SchemaCategoryEntityListing</returns>
        public async System.Threading.Tasks.Task<SchemaCategoryEntityListing> ConfigurationSchemasEdgesVnextGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaCategoryEntityListing> localVarResponse = await ConfigurationSchemasEdgesVnextGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SchemaCategoryEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaCategoryEntityListing>> ConfigurationSchemasEdgesVnextGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaCategoryEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaCategoryEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaCategoryEntityListing)));
            
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SchemaReferenceEntityListing</returns>
        public SchemaReferenceEntityListing ConfigurationSchemasEdgesVnextSchemacategoryGet (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> localVarResponse = ConfigurationSchemasEdgesVnextSchemacategoryGetWithHttpInfo(schemaCategory, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        public ApiResponse< SchemaReferenceEntityListing > ConfigurationSchemasEdgesVnextSchemacategoryGetWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategoryGet");

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}";
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
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategoryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategoryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaReferenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaReferenceEntityListing)));
            
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> ConfigurationSchemasEdgesVnextSchemacategoryGetAsync (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> localVarResponse = await ConfigurationSchemasEdgesVnextSchemacategoryGetAsyncWithHttpInfo(schemaCategory, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> ConfigurationSchemasEdgesVnextSchemacategoryGetAsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategoryGet");

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}";
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
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategoryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategoryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaReferenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaReferenceEntityListing)));
            
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SchemaReferenceEntityListing</returns>
        public SchemaReferenceEntityListing ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> localVarResponse = ConfigurationSchemasEdgesVnextSchemacategorySchematypeGetWithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        public ApiResponse< SchemaReferenceEntityListing > ConfigurationSchemasEdgesVnextSchemacategorySchematypeGetWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet");

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}";
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
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaReferenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaReferenceEntityListing)));
            
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> ConfigurationSchemasEdgesVnextSchemacategorySchematypeGetAsync (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> localVarResponse = await ConfigurationSchemasEdgesVnextSchemacategorySchematypeGetAsyncWithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> ConfigurationSchemasEdgesVnextSchemacategorySchematypeGetAsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet");

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}";
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
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaReferenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaReferenceEntityListing)));
            
        }

        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type (optional)</param>
        /// <returns>Organization</returns>
        public Organization ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> localVarResponse = ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGetWithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGetWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");
            // verify the required parameter 'extension' is set
            if (extension == null)
                throw new ApiException(400, "Missing required parameter 'extension' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");
            // verify the required parameter 'metadataId' is set
            if (metadataId == null)
                throw new ApiException(400, "Missing required parameter 'metadataId' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId}";
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
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) localVarPathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            if (extension != null) localVarPathParams.Add("extension", Configuration.ApiClient.ParameterToString(extension)); // path parameter
            if (metadataId != null) localVarPathParams.Add("metadataId", Configuration.ApiClient.ParameterToString(metadataId)); // path parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type (optional)</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGetAsync (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> localVarResponse = await ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGetAsyncWithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type (optional)</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGetAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");
            // verify the required parameter 'extension' is set
            if (extension == null)
                throw new ApiException(400, "Missing required parameter 'extension' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");
            // verify the required parameter 'metadataId' is set
            if (metadataId == null)
                throw new ApiException(400, "Missing required parameter 'metadataId' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet");

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId}";
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
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) localVarPathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            if (extension != null) localVarPathParams.Add("extension", Configuration.ApiClient.ParameterToString(extension)); // path parameter
            if (metadataId != null) localVarPathParams.Add("metadataId", Configuration.ApiClient.ParameterToString(metadataId)); // path parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidExtensionMetadataidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Organization</returns>
        public Organization ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> localVarResponse = ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGetWithHttpInfo(schemaCategory, schemaType, schemaId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGetWithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet");

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}";
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
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) localVarPathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGetAsync (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> localVarResponse = await ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGetAsyncWithHttpInfo(schemaCategory, schemaType, schemaId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGetAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet");

            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}";
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
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) localVarPathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSchemasEdgesVnextSchemacategorySchematypeSchemaidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="locationId">Location Id (optional)</param>
        /// <returns>SiteEntityListing</returns>
        public SiteEntityListing ConfigurationSitesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
             ApiResponse<SiteEntityListing> localVarResponse = ConfigurationSitesGetWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, name, locationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="locationId">Location Id (optional)</param>
        /// <returns>ApiResponse of SiteEntityListing</returns>
        public ApiResponse< SiteEntityListing > ConfigurationSitesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {

            var localVarPath = "/api/v1/configuration/sites";
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
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (locationId != null) localVarQueryParams.Add("location.id", Configuration.ApiClient.ParameterToString(locationId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SiteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SiteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SiteEntityListing)));
            
        }

        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="locationId">Location Id (optional)</param>
        /// <returns>Task of SiteEntityListing</returns>
        public async System.Threading.Tasks.Task<SiteEntityListing> ConfigurationSitesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
             ApiResponse<SiteEntityListing> localVarResponse = await ConfigurationSitesGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, name, locationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="locationId">Location Id (optional)</param>
        /// <returns>Task of ApiResponse (SiteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SiteEntityListing>> ConfigurationSitesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {

            var localVarPath = "/api/v1/configuration/sites";
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
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (locationId != null) localVarQueryParams.Add("location.id", Configuration.ApiClient.ParameterToString(locationId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SiteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SiteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SiteEntityListing)));
            
        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site (optional)</param>
        /// <returns>Site</returns>
        public Site ConfigurationSitesPost (Site body = null)
        {
             ApiResponse<Site> localVarResponse = ConfigurationSitesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site (optional)</param>
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > ConfigurationSitesPostWithHttpInfo (Site body = null)
        {

            var localVarPath = "/api/v1/configuration/sites";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site (optional)</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> ConfigurationSitesPostAsync (Site body = null)
        {
             ApiResponse<Site> localVarResponse = await ConfigurationSitesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site (optional)</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> ConfigurationSitesPostAsyncWithHttpInfo (Site body = null)
        {

            var localVarPath = "/api/v1/configuration/sites";
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>string</returns>
        public string ConfigurationSitesSiteidDelete (string siteId)
        {
             ApiResponse<string> localVarResponse = ConfigurationSitesSiteidDeleteWithHttpInfo(siteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfigurationSitesSiteidDeleteWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidDelete");

            var localVarPath = "/api/v1/configuration/sites/{siteId}";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfigurationSitesSiteidDeleteAsync (string siteId)
        {
             ApiResponse<string> localVarResponse = await ConfigurationSitesSiteidDeleteAsyncWithHttpInfo(siteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfigurationSitesSiteidDeleteAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidDelete");

            var localVarPath = "/api/v1/configuration/sites/{siteId}";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Site</returns>
        public Site ConfigurationSitesSiteidGet (string siteId)
        {
             ApiResponse<Site> localVarResponse = ConfigurationSitesSiteidGetWithHttpInfo(siteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > ConfigurationSitesSiteidGetWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidGet");

            var localVarPath = "/api/v1/configuration/sites/{siteId}";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> ConfigurationSitesSiteidGetAsync (string siteId)
        {
             ApiResponse<Site> localVarResponse = await ConfigurationSitesSiteidGetAsyncWithHttpInfo(siteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> ConfigurationSitesSiteidGetAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidGet");

            var localVarPath = "/api/v1/configuration/sites/{siteId}";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ConfigurationSitesSiteidNumberplansClassificationsGet (string siteId, string classification = null)
        {
             ApiResponse<List<string>> localVarResponse = ConfigurationSitesSiteidNumberplansClassificationsGetWithHttpInfo(siteId, classification);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > ConfigurationSitesSiteidNumberplansClassificationsGetWithHttpInfo (string siteId, string classification = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansClassificationsGet");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans/classifications";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (classification != null) localVarQueryParams.Add("classification", Configuration.ApiClient.ParameterToString(classification)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansClassificationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansClassificationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> ConfigurationSitesSiteidNumberplansClassificationsGetAsync (string siteId, string classification = null)
        {
             ApiResponse<List<string>> localVarResponse = await ConfigurationSitesSiteidNumberplansClassificationsGetAsyncWithHttpInfo(siteId, classification);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> ConfigurationSitesSiteidNumberplansClassificationsGetAsyncWithHttpInfo (string siteId, string classification = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansClassificationsGet");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans/classifications";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (classification != null) localVarQueryParams.Add("classification", Configuration.ApiClient.ParameterToString(classification)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansClassificationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansClassificationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        public List<NumberPlan> ConfigurationSitesSiteidNumberplansGet (string siteId)
        {
             ApiResponse<List<NumberPlan>> localVarResponse = ConfigurationSitesSiteidNumberplansGetWithHttpInfo(siteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        public ApiResponse< List<NumberPlan> > ConfigurationSitesSiteidNumberplansGetWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansGet");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<NumberPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NumberPlan>)));
            
        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<NumberPlan>> ConfigurationSitesSiteidNumberplansGetAsync (string siteId)
        {
             ApiResponse<List<NumberPlan>> localVarResponse = await ConfigurationSitesSiteidNumberplansGetAsyncWithHttpInfo(siteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> ConfigurationSitesSiteidNumberplansGetAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansGet");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<NumberPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NumberPlan>)));
            
        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>NumberPlan</returns>
        public NumberPlan ConfigurationSitesSiteidNumberplansNumberplanidGet (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> localVarResponse = ConfigurationSitesSiteidNumberplansNumberplanidGetWithHttpInfo(siteId, numberPlanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>ApiResponse of NumberPlan</returns>
        public ApiResponse< NumberPlan > ConfigurationSitesSiteidNumberplansNumberplanidGetWithHttpInfo (string siteId, string numberPlanId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansNumberplanidGet");
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null)
                throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansNumberplanidGet");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans/{numberPlanId}";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (numberPlanId != null) localVarPathParams.Add("numberPlanId", Configuration.ApiClient.ParameterToString(numberPlanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansNumberplanidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansNumberplanidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NumberPlan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NumberPlan) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NumberPlan)));
            
        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of NumberPlan</returns>
        public async System.Threading.Tasks.Task<NumberPlan> ConfigurationSitesSiteidNumberplansNumberplanidGetAsync (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> localVarResponse = await ConfigurationSitesSiteidNumberplansNumberplanidGetAsyncWithHttpInfo(siteId, numberPlanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NumberPlan>> ConfigurationSitesSiteidNumberplansNumberplanidGetAsyncWithHttpInfo (string siteId, string numberPlanId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansNumberplanidGet");
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null)
                throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansNumberplanidGet");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans/{numberPlanId}";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (numberPlanId != null) localVarPathParams.Add("numberPlanId", Configuration.ApiClient.ParameterToString(numberPlanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansNumberplanidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansNumberplanidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NumberPlan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NumberPlan) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NumberPlan)));
            
        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        public List<NumberPlan> ConfigurationSitesSiteidNumberplansPut (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> localVarResponse = ConfigurationSitesSiteidNumberplansPutWithHttpInfo(siteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        public ApiResponse< List<NumberPlan> > ConfigurationSitesSiteidNumberplansPutWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansPut");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<NumberPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NumberPlan>)));
            
        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<NumberPlan>> ConfigurationSitesSiteidNumberplansPutAsync (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> localVarResponse = await ConfigurationSitesSiteidNumberplansPutAsyncWithHttpInfo(siteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> ConfigurationSitesSiteidNumberplansPutAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidNumberplansPut");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidNumberplansPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<NumberPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NumberPlan>)));
            
        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site (optional)</param>
        /// <returns>Site</returns>
        public Site ConfigurationSitesSiteidPut (string siteId, Site body = null)
        {
             ApiResponse<Site> localVarResponse = ConfigurationSitesSiteidPutWithHttpInfo(siteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site (optional)</param>
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > ConfigurationSitesSiteidPutWithHttpInfo (string siteId, Site body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidPut");

            var localVarPath = "/api/v1/configuration/sites/{siteId}";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site (optional)</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> ConfigurationSitesSiteidPutAsync (string siteId, Site body = null)
        {
             ApiResponse<Site> localVarResponse = await ConfigurationSitesSiteidPutAsyncWithHttpInfo(siteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site (optional)</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> ConfigurationSitesSiteidPutAsyncWithHttpInfo (string siteId, Site body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidPut");

            var localVarPath = "/api/v1/configuration/sites/{siteId}";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns></returns>
        public void ConfigurationSitesSiteidRebalancePost (string siteId)
        {
             ConfigurationSitesSiteidRebalancePostWithHttpInfo(siteId);
        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConfigurationSitesSiteidRebalancePostWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidRebalancePost");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/rebalance";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidRebalancePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidRebalancePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConfigurationSitesSiteidRebalancePostAsync (string siteId)
        {
             await ConfigurationSitesSiteidRebalancePostAsyncWithHttpInfo(siteId);

        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConfigurationSitesSiteidRebalancePostAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->ConfigurationSitesSiteidRebalancePost");

            var localVarPath = "/api/v1/configuration/sites/{siteId}/rebalance";
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
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidRebalancePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationSitesSiteidRebalancePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
