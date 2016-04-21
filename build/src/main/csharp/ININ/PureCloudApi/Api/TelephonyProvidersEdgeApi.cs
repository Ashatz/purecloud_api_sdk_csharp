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
    public interface ITelephonyProvidersEdgeApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>string</returns>
        string TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete (string edgeGroupId);

        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TelephonyProvidersEdgeEdgegroupsEdgegroupidDeleteWithHttpInfo (string edgeGroupId);
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup TelephonyProvidersEdgeEdgegroupsEdgegroupidGet (string edgeGroupId);

        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> TelephonyProvidersEdgeEdgegroupsEdgegroupidGetWithHttpInfo (string edgeGroupId);
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup TelephonyProvidersEdgeEdgegroupsEdgegroupidPut (string edgeGroupId, EdgeGroup body = null);

        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> TelephonyProvidersEdgeEdgegroupsEdgegroupidPutWithHttpInfo (string edgeGroupId, EdgeGroup body = null);
        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>EdgeGroupEntityListing</returns>
        EdgeGroupEntityListing TelephonyProvidersEdgeEdgegroupsGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of EdgeGroupEntityListing</returns>
        ApiResponse<EdgeGroupEntityListing> TelephonyProvidersEdgeEdgegroupsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup TelephonyProvidersEdgeEdgegroupsPost (EdgeGroup body = null);

        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> TelephonyProvidersEdgeEdgegroupsPostWithHttpInfo (EdgeGroup body = null);
        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>LineBaseEntityListing</returns>
        LineBaseEntityListing TelephonyProvidersEdgeLinebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of LineBaseEntityListing</returns>
        ApiResponse<LineBaseEntityListing> TelephonyProvidersEdgeLinebasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>LineBase</returns>
        LineBase TelephonyProvidersEdgeLinebasesettingsLinebaseidGet (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>ApiResponse of LineBase</returns>
        ApiResponse<LineBase> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetWithHttpInfo (string lineBaseId);
        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <returns>LineEntityListing</returns>
        LineEntityListing TelephonyProvidersEdgeLinesGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);

        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <returns>ApiResponse of LineEntityListing</returns>
        ApiResponse<LineEntityListing> TelephonyProvidersEdgeLinesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Line</returns>
        Line TelephonyProvidersEdgeLinesLineidGet (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> TelephonyProvidersEdgeLinesLineidGetWithHttpInfo (string lineId);
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Line</returns>
        Line TelephonyProvidersEdgeLinesTemplateGet (string lineBaseSettingsId);

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> TelephonyProvidersEdgeLinesTemplateGetWithHttpInfo (string lineBaseSettingsId);
        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>OutboundRouteEntityListing</returns>
        OutboundRouteEntityListing TelephonyProvidersEdgeOutboundroutesGet (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);

        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of OutboundRouteEntityListing</returns>
        ApiResponse<OutboundRouteEntityListing> TelephonyProvidersEdgeOutboundroutesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>string</returns>
        string TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete (string outboundRouteId);

        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TelephonyProvidersEdgeOutboundroutesOutboundrouteidDeleteWithHttpInfo (string outboundRouteId);
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet (string outboundRouteId);

        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> TelephonyProvidersEdgeOutboundroutesOutboundrouteidGetWithHttpInfo (string outboundRouteId);
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut (string outboundRouteId, OutboundRoute body = null);

        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> TelephonyProvidersEdgeOutboundroutesOutboundrouteidPutWithHttpInfo (string outboundRouteId, OutboundRoute body = null);
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute TelephonyProvidersEdgeOutboundroutesPost (OutboundRoute body = null);

        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> TelephonyProvidersEdgeOutboundroutesPostWithHttpInfo (OutboundRoute body = null);
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>PhoneMetaBaseEntityListing</returns>
        PhoneMetaBaseEntityListing TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        ApiResponse<PhoneMetaBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>PhoneBaseEntityListing</returns>
        PhoneBaseEntityListing TelephonyProvidersEdgePhonebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of PhoneBaseEntityListing</returns>
        ApiResponse<PhoneBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>string</returns>
        string TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteWithHttpInfo (string phoneBaseId);
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>PhoneBase</returns>
        PhoneBase TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetWithHttpInfo (string phoneBaseId);
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>PhoneBase</returns>
        PhoneBase TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutWithHttpInfo (string phoneBaseId, PhoneBase body = null);
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PhoneBase</returns>
        PhoneBase TelephonyProvidersEdgePhonebasesettingsPost (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPostWithHttpInfo (PhoneBase body = null);
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>PhoneBase</returns>
        PhoneBase TelephonyProvidersEdgePhonebasesettingsTemplateGet (string phoneMetabaseId);

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> TelephonyProvidersEdgePhonebasesettingsTemplateGetWithHttpInfo (string phoneMetabaseId);
        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id (optional)</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId (optional)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <param name="fields">Fields under properties to get, comma-separated (optional)</param>
        /// <returns>PhoneEntityListing</returns>
        PhoneEntityListing TelephonyProvidersEdgePhonesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);

        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id (optional)</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId (optional)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <param name="fields">Fields under properties to get, comma-separated (optional)</param>
        /// <returns>ApiResponse of PhoneEntityListing</returns>
        ApiResponse<PhoneEntityListing> TelephonyProvidersEdgePhonesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>string</returns>
        string TelephonyProvidersEdgePhonesPhoneidDelete (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TelephonyProvidersEdgePhonesPhoneidDeleteWithHttpInfo (string phoneId);
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Phone</returns>
        Phone TelephonyProvidersEdgePhonesPhoneidGet (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> TelephonyProvidersEdgePhonesPhoneidGetWithHttpInfo (string phoneId);
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Phone</returns>
        Phone TelephonyProvidersEdgePhonesPhoneidPut (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> TelephonyProvidersEdgePhonesPhoneidPutWithHttpInfo (string phoneId, Phone body = null);
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns></returns>
        void TelephonyProvidersEdgePhonesPhoneidRebootPost (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyProvidersEdgePhonesPhoneidRebootPostWithHttpInfo (string phoneId);
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Phone</returns>
        Phone TelephonyProvidersEdgePhonesPost (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> TelephonyProvidersEdgePhonesPostWithHttpInfo (Phone body = null);
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns></returns>
        void TelephonyProvidersEdgePhonesRebootPost (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyProvidersEdgePhonesRebootPostWithHttpInfo (PhonesReboot body = null);
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Phone</returns>
        Phone TelephonyProvidersEdgePhonesTemplateGet (string phoneBaseSettingsId);

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> TelephonyProvidersEdgePhonesTemplateGetWithHttpInfo (string phoneBaseSettingsId);
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 1000)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>TimeZoneEntityListing</returns>
        TimeZoneEntityListing TelephonyProvidersEdgeTimezonesGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 1000)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        ApiResponse<TimeZoneEntityListing> TelephonyProvidersEdgeTimezonesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"> (optional)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>TrunkMetabaseEntityListing</returns>
        TrunkMetabaseEntityListing TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet (string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"> (optional)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>ApiResponse of TrunkMetabaseEntityListing</returns>
        ApiResponse<TrunkMetabaseEntityListing> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsPost (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsPostWithHttpInfo (TrunkBase body = null);
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTemplateGet (string trunkMetabaseId);

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetWithHttpInfo (string trunkMetabaseId);
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>string</returns>
        string TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteWithHttpInfo (string trunkBaseSettingsId);
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetWithHttpInfo (string trunkBaseSettingsId);
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TelephonyProvidersEdgeEdgegroupsEdgegroupidDeleteAsync (string edgeGroupId);

        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgeEdgegroupsEdgegroupidDeleteAsyncWithHttpInfo (string edgeGroupId);
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> TelephonyProvidersEdgeEdgegroupsEdgegroupidGetAsync (string edgeGroupId);

        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> TelephonyProvidersEdgeEdgegroupsEdgegroupidGetAsyncWithHttpInfo (string edgeGroupId);
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> TelephonyProvidersEdgeEdgegroupsEdgegroupidPutAsync (string edgeGroupId, EdgeGroup body = null);

        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> TelephonyProvidersEdgeEdgegroupsEdgegroupidPutAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null);
        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of EdgeGroupEntityListing</returns>
        System.Threading.Tasks.Task<EdgeGroupEntityListing> TelephonyProvidersEdgeEdgegroupsGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (EdgeGroupEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroupEntityListing>> TelephonyProvidersEdgeEdgegroupsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> TelephonyProvidersEdgeEdgegroupsPostAsync (EdgeGroup body = null);

        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> TelephonyProvidersEdgeEdgegroupsPostAsyncWithHttpInfo (EdgeGroup body = null);
        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of LineBaseEntityListing</returns>
        System.Threading.Tasks.Task<LineBaseEntityListing> TelephonyProvidersEdgeLinebasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (LineBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineBaseEntityListing>> TelephonyProvidersEdgeLinebasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        System.Threading.Tasks.Task<LineBase> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsync (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineBase>> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsyncWithHttpInfo (string lineBaseId);
        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <returns>Task of LineEntityListing</returns>
        System.Threading.Tasks.Task<LineEntityListing> TelephonyProvidersEdgeLinesGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);

        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (LineEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> TelephonyProvidersEdgeLinesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> TelephonyProvidersEdgeLinesLineidGetAsync (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> TelephonyProvidersEdgeLinesLineidGetAsyncWithHttpInfo (string lineId);
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> TelephonyProvidersEdgeLinesTemplateGetAsync (string lineBaseSettingsId);

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> TelephonyProvidersEdgeLinesTemplateGetAsyncWithHttpInfo (string lineBaseSettingsId);
        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of OutboundRouteEntityListing</returns>
        System.Threading.Tasks.Task<OutboundRouteEntityListing> TelephonyProvidersEdgeOutboundroutesGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);

        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (OutboundRouteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRouteEntityListing>> TelephonyProvidersEdgeOutboundroutesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TelephonyProvidersEdgeOutboundroutesOutboundrouteidDeleteAsync (string outboundRouteId);

        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgeOutboundroutesOutboundrouteidDeleteAsyncWithHttpInfo (string outboundRouteId);
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> TelephonyProvidersEdgeOutboundroutesOutboundrouteidGetAsync (string outboundRouteId);

        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> TelephonyProvidersEdgeOutboundroutesOutboundrouteidGetAsyncWithHttpInfo (string outboundRouteId);
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> TelephonyProvidersEdgeOutboundroutesOutboundrouteidPutAsync (string outboundRouteId, OutboundRoute body = null);

        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> TelephonyProvidersEdgeOutboundroutesOutboundrouteidPutAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null);
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> TelephonyProvidersEdgeOutboundroutesPostAsync (OutboundRoute body = null);

        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> TelephonyProvidersEdgeOutboundroutesPostAsyncWithHttpInfo (OutboundRoute body = null);
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of PhoneMetaBaseEntityListing</returns>
        System.Threading.Tasks.Task<PhoneMetaBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of PhoneBaseEntityListing</returns>
        System.Threading.Tasks.Task<PhoneBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (PhoneBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> TelephonyProvidersEdgePhonebasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsync (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsyncWithHttpInfo (string phoneBaseId);
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsync (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsyncWithHttpInfo (string phoneBaseId);
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsync (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null);
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPostAsync (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPostAsyncWithHttpInfo (PhoneBase body = null);
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsTemplateGetAsync (string phoneMetabaseId);

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsTemplateGetAsyncWithHttpInfo (string phoneMetabaseId);
        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id (optional)</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId (optional)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <param name="fields">Fields under properties to get, comma-separated (optional)</param>
        /// <returns>Task of PhoneEntityListing</returns>
        System.Threading.Tasks.Task<PhoneEntityListing> TelephonyProvidersEdgePhonesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);

        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id (optional)</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId (optional)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <param name="fields">Fields under properties to get, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (PhoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneEntityListing>> TelephonyProvidersEdgePhonesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TelephonyProvidersEdgePhonesPhoneidDeleteAsync (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgePhonesPhoneidDeleteAsyncWithHttpInfo (string phoneId);
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPhoneidGetAsync (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPhoneidGetAsyncWithHttpInfo (string phoneId);
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPhoneidPutAsync (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPhoneidPutAsyncWithHttpInfo (string phoneId, Phone body = null);
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyProvidersEdgePhonesPhoneidRebootPostAsync (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyProvidersEdgePhonesPhoneidRebootPostAsyncWithHttpInfo (string phoneId);
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPostAsync (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPostAsyncWithHttpInfo (Phone body = null);
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyProvidersEdgePhonesRebootPostAsync (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyProvidersEdgePhonesRebootPostAsyncWithHttpInfo (PhonesReboot body = null);
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesTemplateGetAsync (string phoneBaseSettingsId);

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesTemplateGetAsyncWithHttpInfo (string phoneBaseSettingsId);
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 1000)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        System.Threading.Tasks.Task<TimeZoneEntityListing> TelephonyProvidersEdgeTimezonesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 1000)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> TelephonyProvidersEdgeTimezonesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"> (optional)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>Task of TrunkMetabaseEntityListing</returns>
        System.Threading.Tasks.Task<TrunkMetabaseEntityListing> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsync (string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"> (optional)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (TrunkMetabaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkMetabaseEntityListing>> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsyncWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsPostAsync (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsPostAsyncWithHttpInfo (TrunkBase body = null);
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsync (string trunkMetabaseId);

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsyncWithHttpInfo (string trunkMetabaseId);
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsyncWithHttpInfo (string trunkBaseSettingsId);
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsyncWithHttpInfo (string trunkBaseSettingsId);
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsync (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TelephonyProvidersEdgeApi : ITelephonyProvidersEdgeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyProvidersEdgeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TelephonyProvidersEdgeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyProvidersEdgeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TelephonyProvidersEdgeApi(Configuration configuration = null)
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
        /// Delete an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>string</returns>
        public string TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete (string edgeGroupId)
        {
             ApiResponse<string> localVarResponse = TelephonyProvidersEdgeEdgegroupsEdgegroupidDeleteWithHttpInfo(edgeGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TelephonyProvidersEdgeEdgegroupsEdgegroupidDeleteWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeGroupId != null) localVarPathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TelephonyProvidersEdgeEdgegroupsEdgegroupidDeleteAsync (string edgeGroupId)
        {
             ApiResponse<string> localVarResponse = await TelephonyProvidersEdgeEdgegroupsEdgegroupidDeleteAsyncWithHttpInfo(edgeGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgeEdgegroupsEdgegroupidDeleteAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeGroupId != null) localVarPathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>EdgeGroup</returns>
        public EdgeGroup TelephonyProvidersEdgeEdgegroupsEdgegroupidGet (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> localVarResponse = TelephonyProvidersEdgeEdgegroupsEdgegroupidGetWithHttpInfo(edgeGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > TelephonyProvidersEdgeEdgegroupsEdgegroupidGetWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeEdgegroupsEdgegroupidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeGroupId != null) localVarPathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> TelephonyProvidersEdgeEdgegroupsEdgegroupidGetAsync (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> localVarResponse = await TelephonyProvidersEdgeEdgegroupsEdgegroupidGetAsyncWithHttpInfo(edgeGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> TelephonyProvidersEdgeEdgegroupsEdgegroupidGetAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeEdgegroupsEdgegroupidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeGroupId != null) localVarPathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>EdgeGroup</returns>
        public EdgeGroup TelephonyProvidersEdgeEdgegroupsEdgegroupidPut (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> localVarResponse = TelephonyProvidersEdgeEdgegroupsEdgegroupidPutWithHttpInfo(edgeGroupId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > TelephonyProvidersEdgeEdgegroupsEdgegroupidPutWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeEdgegroupsEdgegroupidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeGroupId != null) localVarPathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> TelephonyProvidersEdgeEdgegroupsEdgegroupidPutAsync (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> localVarResponse = await TelephonyProvidersEdgeEdgegroupsEdgegroupidPutAsyncWithHttpInfo(edgeGroupId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> TelephonyProvidersEdgeEdgegroupsEdgegroupidPutAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeEdgegroupsEdgegroupidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeGroupId != null) localVarPathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsEdgegroupidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }

        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>EdgeGroupEntityListing</returns>
        public EdgeGroupEntityListing TelephonyProvidersEdgeEdgegroupsGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EdgeGroupEntityListing> localVarResponse = TelephonyProvidersEdgeEdgegroupsGetWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of EdgeGroupEntityListing</returns>
        public ApiResponse< EdgeGroupEntityListing > TelephonyProvidersEdgeEdgegroupsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroupEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroupEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroupEntityListing)));
            
        }

        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of EdgeGroupEntityListing</returns>
        public async System.Threading.Tasks.Task<EdgeGroupEntityListing> TelephonyProvidersEdgeEdgegroupsGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EdgeGroupEntityListing> localVarResponse = await TelephonyProvidersEdgeEdgegroupsGetAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (EdgeGroupEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroupEntityListing>> TelephonyProvidersEdgeEdgegroupsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroupEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroupEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroupEntityListing)));
            
        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>EdgeGroup</returns>
        public EdgeGroup TelephonyProvidersEdgeEdgegroupsPost (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> localVarResponse = TelephonyProvidersEdgeEdgegroupsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > TelephonyProvidersEdgeEdgegroupsPostWithHttpInfo (EdgeGroup body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> TelephonyProvidersEdgeEdgegroupsPostAsync (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> localVarResponse = await TelephonyProvidersEdgeEdgegroupsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup (optional)</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> TelephonyProvidersEdgeEdgegroupsPostAsyncWithHttpInfo (EdgeGroup body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/edgegroups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeEdgegroupsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>LineBaseEntityListing</returns>
        public LineBaseEntityListing TelephonyProvidersEdgeLinebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> localVarResponse = TelephonyProvidersEdgeLinebasesettingsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of LineBaseEntityListing</returns>
        public ApiResponse< LineBaseEntityListing > TelephonyProvidersEdgeLinebasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/linebasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineBaseEntityListing)));
            
        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of LineBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<LineBaseEntityListing> TelephonyProvidersEdgeLinebasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> localVarResponse = await TelephonyProvidersEdgeLinebasesettingsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (LineBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBaseEntityListing>> TelephonyProvidersEdgeLinebasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/linebasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineBaseEntityListing)));
            
        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>LineBase</returns>
        public LineBase TelephonyProvidersEdgeLinebasesettingsLinebaseidGet (string lineBaseId)
        {
             ApiResponse<LineBase> localVarResponse = TelephonyProvidersEdgeLinebasesettingsLinebaseidGetWithHttpInfo(lineBaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>ApiResponse of LineBase</returns>
        public ApiResponse< LineBase > TelephonyProvidersEdgeLinebasesettingsLinebaseidGetWithHttpInfo (string lineBaseId)
        {
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeLinebasesettingsLinebaseidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/linebasesettings/{lineBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (lineBaseId != null) localVarPathParams.Add("lineBaseId", Configuration.ApiClient.ParameterToString(lineBaseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineBase)));
            
        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        public async System.Threading.Tasks.Task<LineBase> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsync (string lineBaseId)
        {
             ApiResponse<LineBase> localVarResponse = await TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsyncWithHttpInfo(lineBaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBase>> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsyncWithHttpInfo (string lineBaseId)
        {
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeLinebasesettingsLinebaseidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/linebasesettings/{lineBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (lineBaseId != null) localVarPathParams.Add("lineBaseId", Configuration.ApiClient.ParameterToString(lineBaseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineBase)));
            
        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <returns>LineEntityListing</returns>
        public LineEntityListing TelephonyProvidersEdgeLinesGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> localVarResponse = TelephonyProvidersEdgeLinesGetWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <returns>ApiResponse of LineEntityListing</returns>
        public ApiResponse< LineEntityListing > TelephonyProvidersEdgeLinesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/lines";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineEntityListing)));
            
        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <returns>Task of LineEntityListing</returns>
        public async System.Threading.Tasks.Task<LineEntityListing> TelephonyProvidersEdgeLinesGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> localVarResponse = await TelephonyProvidersEdgeLinesGetAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (LineEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> TelephonyProvidersEdgeLinesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/lines";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineEntityListing)));
            
        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Line</returns>
        public Line TelephonyProvidersEdgeLinesLineidGet (string lineId)
        {
             ApiResponse<Line> localVarResponse = TelephonyProvidersEdgeLinesLineidGetWithHttpInfo(lineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > TelephonyProvidersEdgeLinesLineidGetWithHttpInfo (string lineId)
        {
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeLinesLineidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/lines/{lineId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesLineidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesLineidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Line>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Line)));
            
        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        public async System.Threading.Tasks.Task<Line> TelephonyProvidersEdgeLinesLineidGetAsync (string lineId)
        {
             ApiResponse<Line> localVarResponse = await TelephonyProvidersEdgeLinesLineidGetAsyncWithHttpInfo(lineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> TelephonyProvidersEdgeLinesLineidGetAsyncWithHttpInfo (string lineId)
        {
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeLinesLineidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/lines/{lineId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesLineidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesLineidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Line>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Line)));
            
        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Line</returns>
        public Line TelephonyProvidersEdgeLinesTemplateGet (string lineBaseSettingsId)
        {
             ApiResponse<Line> localVarResponse = TelephonyProvidersEdgeLinesTemplateGetWithHttpInfo(lineBaseSettingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > TelephonyProvidersEdgeLinesTemplateGetWithHttpInfo (string lineBaseSettingsId)
        {
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeLinesTemplateGet");

            var localVarPath = "/api/v1/telephony/providers/edge/lines/template";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (lineBaseSettingsId != null) localVarQueryParams.Add("lineBaseSettingsId", Configuration.ApiClient.ParameterToString(lineBaseSettingsId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesTemplateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesTemplateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Line>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Line)));
            
        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of Line</returns>
        public async System.Threading.Tasks.Task<Line> TelephonyProvidersEdgeLinesTemplateGetAsync (string lineBaseSettingsId)
        {
             ApiResponse<Line> localVarResponse = await TelephonyProvidersEdgeLinesTemplateGetAsyncWithHttpInfo(lineBaseSettingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> TelephonyProvidersEdgeLinesTemplateGetAsyncWithHttpInfo (string lineBaseSettingsId)
        {
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeLinesTemplateGet");

            var localVarPath = "/api/v1/telephony/providers/edge/lines/template";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (lineBaseSettingsId != null) localVarQueryParams.Add("lineBaseSettingsId", Configuration.ApiClient.ParameterToString(lineBaseSettingsId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesTemplateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeLinesTemplateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Line>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Line)));
            
        }

        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>OutboundRouteEntityListing</returns>
        public OutboundRouteEntityListing TelephonyProvidersEdgeOutboundroutesGet (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
             ApiResponse<OutboundRouteEntityListing> localVarResponse = TelephonyProvidersEdgeOutboundroutesGetWithHttpInfo(pageSize, pageNumber, name, siteId, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of OutboundRouteEntityListing</returns>
        public ApiResponse< OutboundRouteEntityListing > TelephonyProvidersEdgeOutboundroutesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRouteEntityListing)));
            
        }

        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of OutboundRouteEntityListing</returns>
        public async System.Threading.Tasks.Task<OutboundRouteEntityListing> TelephonyProvidersEdgeOutboundroutesGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
             ApiResponse<OutboundRouteEntityListing> localVarResponse = await TelephonyProvidersEdgeOutboundroutesGetAsyncWithHttpInfo(pageSize, pageNumber, name, siteId, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (OutboundRouteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRouteEntityListing>> TelephonyProvidersEdgeOutboundroutesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRouteEntityListing)));
            
        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>string</returns>
        public string TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete (string outboundRouteId)
        {
             ApiResponse<string> localVarResponse = TelephonyProvidersEdgeOutboundroutesOutboundrouteidDeleteWithHttpInfo(outboundRouteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TelephonyProvidersEdgeOutboundroutesOutboundrouteidDeleteWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (outboundRouteId != null) localVarPathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TelephonyProvidersEdgeOutboundroutesOutboundrouteidDeleteAsync (string outboundRouteId)
        {
             ApiResponse<string> localVarResponse = await TelephonyProvidersEdgeOutboundroutesOutboundrouteidDeleteAsyncWithHttpInfo(outboundRouteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgeOutboundroutesOutboundrouteidDeleteAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (outboundRouteId != null) localVarPathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>OutboundRoute</returns>
        public OutboundRoute TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> localVarResponse = TelephonyProvidersEdgeOutboundroutesOutboundrouteidGetWithHttpInfo(outboundRouteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > TelephonyProvidersEdgeOutboundroutesOutboundrouteidGetWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (outboundRouteId != null) localVarPathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> TelephonyProvidersEdgeOutboundroutesOutboundrouteidGetAsync (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> localVarResponse = await TelephonyProvidersEdgeOutboundroutesOutboundrouteidGetAsyncWithHttpInfo(outboundRouteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> TelephonyProvidersEdgeOutboundroutesOutboundrouteidGetAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (outboundRouteId != null) localVarPathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>OutboundRoute</returns>
        public OutboundRoute TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> localVarResponse = TelephonyProvidersEdgeOutboundroutesOutboundrouteidPutWithHttpInfo(outboundRouteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > TelephonyProvidersEdgeOutboundroutesOutboundrouteidPutWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (outboundRouteId != null) localVarPathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> TelephonyProvidersEdgeOutboundroutesOutboundrouteidPutAsync (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> localVarResponse = await TelephonyProvidersEdgeOutboundroutesOutboundrouteidPutAsyncWithHttpInfo(outboundRouteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> TelephonyProvidersEdgeOutboundroutesOutboundrouteidPutAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (outboundRouteId != null) localVarPathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>OutboundRoute</returns>
        public OutboundRoute TelephonyProvidersEdgeOutboundroutesPost (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> localVarResponse = TelephonyProvidersEdgeOutboundroutesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > TelephonyProvidersEdgeOutboundroutesPostWithHttpInfo (OutboundRoute body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> TelephonyProvidersEdgeOutboundroutesPostAsync (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> localVarResponse = await TelephonyProvidersEdgeOutboundroutesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute (optional)</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> TelephonyProvidersEdgeOutboundroutesPostAsyncWithHttpInfo (OutboundRoute body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/outboundroutes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeOutboundroutesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>PhoneMetaBaseEntityListing</returns>
        public PhoneMetaBaseEntityListing TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> localVarResponse = TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        public ApiResponse< PhoneMetaBaseEntityListing > TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/availablemetabases";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneMetaBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneMetaBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneMetaBaseEntityListing)));
            
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of PhoneMetaBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneMetaBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> localVarResponse = await TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/availablemetabases";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneMetaBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneMetaBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneMetaBaseEntityListing)));
            
        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>PhoneBaseEntityListing</returns>
        public PhoneBaseEntityListing TelephonyProvidersEdgePhonebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> localVarResponse = TelephonyProvidersEdgePhonebasesettingsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of PhoneBaseEntityListing</returns>
        public ApiResponse< PhoneBaseEntityListing > TelephonyProvidersEdgePhonebasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBaseEntityListing)));
            
        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of PhoneBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> localVarResponse = await TelephonyProvidersEdgePhonebasesettingsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (PhoneBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> TelephonyProvidersEdgePhonebasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBaseEntityListing)));
            
        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>string</returns>
        public string TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete (string phoneBaseId)
        {
             ApiResponse<string> localVarResponse = TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteWithHttpInfo(phoneBaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneBaseId != null) localVarPathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsync (string phoneBaseId)
        {
             ApiResponse<string> localVarResponse = await TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsyncWithHttpInfo(phoneBaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneBaseId != null) localVarPathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>PhoneBase</returns>
        public PhoneBase TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet (string phoneBaseId)
        {
             ApiResponse<PhoneBase> localVarResponse = TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetWithHttpInfo(phoneBaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneBaseId != null) localVarPathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsync (string phoneBaseId)
        {
             ApiResponse<PhoneBase> localVarResponse = await TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsyncWithHttpInfo(phoneBaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneBaseId != null) localVarPathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>PhoneBase</returns>
        public PhoneBase TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> localVarResponse = TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutWithHttpInfo(phoneBaseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneBaseId != null) localVarPathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsync (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> localVarResponse = await TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsyncWithHttpInfo(phoneBaseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneBaseId != null) localVarPathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>PhoneBase</returns>
        public PhoneBase TelephonyProvidersEdgePhonebasesettingsPost (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> localVarResponse = TelephonyProvidersEdgePhonebasesettingsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > TelephonyProvidersEdgePhonebasesettingsPostWithHttpInfo (PhoneBase body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPostAsync (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> localVarResponse = await TelephonyProvidersEdgePhonebasesettingsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPostAsyncWithHttpInfo (PhoneBase body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>PhoneBase</returns>
        public PhoneBase TelephonyProvidersEdgePhonebasesettingsTemplateGet (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> localVarResponse = TelephonyProvidersEdgePhonebasesettingsTemplateGetWithHttpInfo(phoneMetabaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > TelephonyProvidersEdgePhonebasesettingsTemplateGetWithHttpInfo (string phoneMetabaseId)
        {
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonebasesettingsTemplateGet");

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/template";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneMetabaseId != null) localVarQueryParams.Add("phoneMetabaseId", Configuration.ApiClient.ParameterToString(phoneMetabaseId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsTemplateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsTemplateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsTemplateGetAsync (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> localVarResponse = await TelephonyProvidersEdgePhonebasesettingsTemplateGetAsyncWithHttpInfo(phoneMetabaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsTemplateGetAsyncWithHttpInfo (string phoneMetabaseId)
        {
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonebasesettingsTemplateGet");

            var localVarPath = "/api/v1/telephony/providers/edge/phonebasesettings/template";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneMetabaseId != null) localVarQueryParams.Add("phoneMetabaseId", Configuration.ApiClient.ParameterToString(phoneMetabaseId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsTemplateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsTemplateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id (optional)</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId (optional)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <param name="fields">Fields under properties to get, comma-separated (optional)</param>
        /// <returns>PhoneEntityListing</returns>
        public PhoneEntityListing TelephonyProvidersEdgePhonesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
             ApiResponse<PhoneEntityListing> localVarResponse = TelephonyProvidersEdgePhonesGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id (optional)</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId (optional)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <param name="fields">Fields under properties to get, comma-separated (optional)</param>
        /// <returns>ApiResponse of PhoneEntityListing</returns>
        public ApiResponse< PhoneEntityListing > TelephonyProvidersEdgePhonesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phones";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (siteId != null) localVarQueryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (phoneBaseSettingsId != null) localVarQueryParams.Add("phoneBaseSettings.id", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            if (phoneHardwareId != null) localVarQueryParams.Add("phone_hardwareId", Configuration.ApiClient.ParameterToString(phoneHardwareId)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneEntityListing)));
            
        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id (optional)</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId (optional)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <param name="fields">Fields under properties to get, comma-separated (optional)</param>
        /// <returns>Task of PhoneEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneEntityListing> TelephonyProvidersEdgePhonesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
             ApiResponse<PhoneEntityListing> localVarResponse = await TelephonyProvidersEdgePhonesGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="siteId">Filter by site.id (optional)</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id (optional)</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId (optional)</param>
        /// <param name="expand">Fields to expand in the response, comma-separated (optional)</param>
        /// <param name="fields">Fields under properties to get, comma-separated (optional)</param>
        /// <returns>Task of ApiResponse (PhoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneEntityListing>> TelephonyProvidersEdgePhonesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phones";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (siteId != null) localVarQueryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (phoneBaseSettingsId != null) localVarQueryParams.Add("phoneBaseSettings.id", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            if (phoneHardwareId != null) localVarQueryParams.Add("phone_hardwareId", Configuration.ApiClient.ParameterToString(phoneHardwareId)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneEntityListing)));
            
        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>string</returns>
        public string TelephonyProvidersEdgePhonesPhoneidDelete (string phoneId)
        {
             ApiResponse<string> localVarResponse = TelephonyProvidersEdgePhonesPhoneidDeleteWithHttpInfo(phoneId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TelephonyProvidersEdgePhonesPhoneidDeleteWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesPhoneidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/{phoneId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneId != null) localVarPathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TelephonyProvidersEdgePhonesPhoneidDeleteAsync (string phoneId)
        {
             ApiResponse<string> localVarResponse = await TelephonyProvidersEdgePhonesPhoneidDeleteAsyncWithHttpInfo(phoneId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgePhonesPhoneidDeleteAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesPhoneidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/{phoneId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneId != null) localVarPathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Phone</returns>
        public Phone TelephonyProvidersEdgePhonesPhoneidGet (string phoneId)
        {
             ApiResponse<Phone> localVarResponse = TelephonyProvidersEdgePhonesPhoneidGetWithHttpInfo(phoneId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > TelephonyProvidersEdgePhonesPhoneidGetWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesPhoneidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/{phoneId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneId != null) localVarPathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPhoneidGetAsync (string phoneId)
        {
             ApiResponse<Phone> localVarResponse = await TelephonyProvidersEdgePhonesPhoneidGetAsyncWithHttpInfo(phoneId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPhoneidGetAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesPhoneidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/{phoneId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneId != null) localVarPathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Phone</returns>
        public Phone TelephonyProvidersEdgePhonesPhoneidPut (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> localVarResponse = TelephonyProvidersEdgePhonesPhoneidPutWithHttpInfo(phoneId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > TelephonyProvidersEdgePhonesPhoneidPutWithHttpInfo (string phoneId, Phone body = null)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesPhoneidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/{phoneId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneId != null) localVarPathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPhoneidPutAsync (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> localVarResponse = await TelephonyProvidersEdgePhonesPhoneidPutAsyncWithHttpInfo(phoneId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPhoneidPutAsyncWithHttpInfo (string phoneId, Phone body = null)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesPhoneidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/{phoneId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneId != null) localVarPathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns></returns>
        public void TelephonyProvidersEdgePhonesPhoneidRebootPost (string phoneId)
        {
             TelephonyProvidersEdgePhonesPhoneidRebootPostWithHttpInfo(phoneId);
        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyProvidersEdgePhonesPhoneidRebootPostWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesPhoneidRebootPost");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/{phoneId}/reboot";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneId != null) localVarPathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidRebootPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidRebootPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyProvidersEdgePhonesPhoneidRebootPostAsync (string phoneId)
        {
             await TelephonyProvidersEdgePhonesPhoneidRebootPostAsyncWithHttpInfo(phoneId);

        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyProvidersEdgePhonesPhoneidRebootPostAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesPhoneidRebootPost");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/{phoneId}/reboot";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneId != null) localVarPathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidRebootPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidRebootPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Phone</returns>
        public Phone TelephonyProvidersEdgePhonesPost (Phone body = null)
        {
             ApiResponse<Phone> localVarResponse = TelephonyProvidersEdgePhonesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > TelephonyProvidersEdgePhonesPostWithHttpInfo (Phone body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phones";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPostAsync (Phone body = null)
        {
             ApiResponse<Phone> localVarResponse = await TelephonyProvidersEdgePhonesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPostAsyncWithHttpInfo (Phone body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phones";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns></returns>
        public void TelephonyProvidersEdgePhonesRebootPost (PhonesReboot body = null)
        {
             TelephonyProvidersEdgePhonesRebootPostWithHttpInfo(body);
        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyProvidersEdgePhonesRebootPostWithHttpInfo (PhonesReboot body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phones/reboot";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesRebootPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesRebootPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyProvidersEdgePhonesRebootPostAsync (PhonesReboot body = null)
        {
             await TelephonyProvidersEdgePhonesRebootPostAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyProvidersEdgePhonesRebootPostAsyncWithHttpInfo (PhonesReboot body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/phones/reboot";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesRebootPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesRebootPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Phone</returns>
        public Phone TelephonyProvidersEdgePhonesTemplateGet (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> localVarResponse = TelephonyProvidersEdgePhonesTemplateGetWithHttpInfo(phoneBaseSettingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > TelephonyProvidersEdgePhonesTemplateGetWithHttpInfo (string phoneBaseSettingsId)
        {
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesTemplateGet");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/template";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneBaseSettingsId != null) localVarQueryParams.Add("phoneBaseSettingsId", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesTemplateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesTemplateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesTemplateGetAsync (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> localVarResponse = await TelephonyProvidersEdgePhonesTemplateGetAsyncWithHttpInfo(phoneBaseSettingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesTemplateGetAsyncWithHttpInfo (string phoneBaseSettingsId)
        {
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgePhonesTemplateGet");

            var localVarPath = "/api/v1/telephony/providers/edge/phones/template";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneBaseSettingsId != null) localVarQueryParams.Add("phoneBaseSettingsId", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesTemplateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgePhonesTemplateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 1000)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>TimeZoneEntityListing</returns>
        public TimeZoneEntityListing TelephonyProvidersEdgeTimezonesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> localVarResponse = TelephonyProvidersEdgeTimezonesGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 1000)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        public ApiResponse< TimeZoneEntityListing > TelephonyProvidersEdgeTimezonesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/timezones";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTimezonesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTimezonesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeZoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeZoneEntityListing)));
            
        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 1000)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        public async System.Threading.Tasks.Task<TimeZoneEntityListing> TelephonyProvidersEdgeTimezonesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> localVarResponse = await TelephonyProvidersEdgeTimezonesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 1000)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> TelephonyProvidersEdgeTimezonesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/timezones";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTimezonesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTimezonesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeZoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeZoneEntityListing)));
            
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"> (optional)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>TrunkMetabaseEntityListing</returns>
        public TrunkMetabaseEntityListing TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> localVarResponse = TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetWithHttpInfo(type, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"> (optional)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>ApiResponse of TrunkMetabaseEntityListing</returns>
        public ApiResponse< TrunkMetabaseEntityListing > TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/availablemetabases";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkMetabaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkMetabaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkMetabaseEntityListing)));
            
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"> (optional)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>Task of TrunkMetabaseEntityListing</returns>
        public async System.Threading.Tasks.Task<TrunkMetabaseEntityListing> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsync (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> localVarResponse = await TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsyncWithHttpInfo(type, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"> (optional)</param>
        /// <param name="pageSize"> (optional, default to 25)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (TrunkMetabaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkMetabaseEntityListing>> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsyncWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/availablemetabases";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkMetabaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkMetabaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkMetabaseEntityListing)));
            
        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> localVarResponse = TelephonyProvidersEdgeTrunkbasesettingsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> localVarResponse = await TelephonyProvidersEdgeTrunkbasesettingsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Value by which to sort (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsPost (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> localVarResponse = TelephonyProvidersEdgeTrunkbasesettingsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsPostWithHttpInfo (TrunkBase body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsPostAsync (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> localVarResponse = await TelephonyProvidersEdgeTrunkbasesettingsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsPostAsyncWithHttpInfo (TrunkBase body = null)
        {

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTemplateGet (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> localVarResponse = TelephonyProvidersEdgeTrunkbasesettingsTemplateGetWithHttpInfo(trunkMetabaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsTemplateGetWithHttpInfo (string trunkMetabaseId)
        {
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeTrunkbasesettingsTemplateGet");

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/template";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (trunkMetabaseId != null) localVarQueryParams.Add("trunkMetabaseId", Configuration.ApiClient.ParameterToString(trunkMetabaseId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsync (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> localVarResponse = await TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsyncWithHttpInfo(trunkMetabaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsyncWithHttpInfo (string trunkMetabaseId)
        {
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeTrunkbasesettingsTemplateGet");

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/template";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (trunkMetabaseId != null) localVarQueryParams.Add("trunkMetabaseId", Configuration.ApiClient.ParameterToString(trunkMetabaseId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>string</returns>
        public string TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete (string trunkBaseSettingsId)
        {
             ApiResponse<string> localVarResponse = TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteWithHttpInfo(trunkBaseSettingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) localVarPathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsync (string trunkBaseSettingsId)
        {
             ApiResponse<string> localVarResponse = await TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsyncWithHttpInfo(trunkBaseSettingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete");

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) localVarPathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> localVarResponse = TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetWithHttpInfo(trunkBaseSettingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) localVarPathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsync (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> localVarResponse = await TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsyncWithHttpInfo(trunkBaseSettingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet");

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) localVarPathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> localVarResponse = TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutWithHttpInfo(trunkBaseSettingsId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) localVarPathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsync (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> localVarResponse = await TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsyncWithHttpInfo(trunkBaseSettingsId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut");

            var localVarPath = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) localVarPathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

    }
}
