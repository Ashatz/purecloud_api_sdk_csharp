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
        string DeleteProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId);
  
        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId);
        
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId);
  
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId);
        
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId);
  
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgePhonesPhoneId (string phoneId);
  
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId);
  
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId);
        
        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>EdgeGroupEntityListing</returns>
        EdgeGroupEntityListing GetProvidersEdgeEdgegroups (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
  
        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of EdgeGroupEntityListing</returns>
        ApiResponse<EdgeGroupEntityListing> GetProvidersEdgeEdgegroupsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup GetProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId);
  
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> GetProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId);
        
        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>LineBaseEntityListing</returns>
        LineBaseEntityListing GetProvidersEdgeLinebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of LineBaseEntityListing</returns>
        ApiResponse<LineBaseEntityListing> GetProvidersEdgeLinebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>LineBase</returns>
        LineBase GetProvidersEdgeLinebasesettingsLinebaseId (string lineBaseId);
  
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>ApiResponse of LineBase</returns>
        ApiResponse<LineBase> GetProvidersEdgeLinebasesettingsLinebaseIdWithHttpInfo (string lineBaseId);
        
        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>LineEntityListing</returns>
        LineEntityListing GetProvidersEdgeLines (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
  
        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>ApiResponse of LineEntityListing</returns>
        ApiResponse<LineEntityListing> GetProvidersEdgeLinesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
        
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Line</returns>
        Line GetProvidersEdgeLinesLineId (string lineId);
  
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> GetProvidersEdgeLinesLineIdWithHttpInfo (string lineId);
        
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Line</returns>
        Line GetProvidersEdgeLinesTemplate (string lineBaseSettingsId);
  
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> GetProvidersEdgeLinesTemplateWithHttpInfo (string lineBaseSettingsId);
        
        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>OutboundRouteEntityListing</returns>
        OutboundRouteEntityListing GetProvidersEdgeOutboundroutes (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);
  
        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of OutboundRouteEntityListing</returns>
        ApiResponse<OutboundRouteEntityListing> GetProvidersEdgeOutboundroutesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);
        
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute GetProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId);
  
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> GetProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId);
        
        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>PhoneBaseEntityListing</returns>
        PhoneBaseEntityListing GetProvidersEdgePhonebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of PhoneBaseEntityListing</returns>
        ApiResponse<PhoneBaseEntityListing> GetProvidersEdgePhonebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>PhoneMetaBaseEntityListing</returns>
        PhoneMetaBaseEntityListing GetProvidersEdgePhonebasesettingsAvailablemetabases (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        ApiResponse<PhoneMetaBaseEntityListing> GetProvidersEdgePhonebasesettingsAvailablemetabasesWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>PhoneBase</returns>
        PhoneBase GetProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId);
  
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> GetProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>PhoneBase</returns>
        PhoneBase GetProvidersEdgePhonebasesettingsTemplate (string phoneMetabaseId);
  
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> GetProvidersEdgePhonebasesettingsTemplateWithHttpInfo (string phoneMetabaseId);
        
        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>PhoneEntityListing</returns>
        PhoneEntityListing GetProvidersEdgePhones (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);
  
        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>ApiResponse of PhoneEntityListing</returns>
        ApiResponse<PhoneEntityListing> GetProvidersEdgePhonesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);
        
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Phone</returns>
        Phone GetProvidersEdgePhonesPhoneId (string phoneId);
  
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> GetProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Phone</returns>
        Phone GetProvidersEdgePhonesTemplate (string phoneBaseSettingsId);
  
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> GetProvidersEdgePhonesTemplateWithHttpInfo (string phoneBaseSettingsId);
        
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>TimeZoneEntityListing</returns>
        TimeZoneEntityListing GetProvidersEdgeTimezones (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        ApiResponse<TimeZoneEntityListing> GetProvidersEdgeTimezonesWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>TrunkBase</returns>
        TrunkBase GetProvidersEdgeTrunkbasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> GetProvidersEdgeTrunkbasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>TrunkMetabaseEntityListing</returns>
        TrunkMetabaseEntityListing GetProvidersEdgeTrunkbasesettingsAvailablemetabases (string type = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>ApiResponse of TrunkMetabaseEntityListing</returns>
        ApiResponse<TrunkMetabaseEntityListing> GetProvidersEdgeTrunkbasesettingsAvailablemetabasesWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>TrunkBase</returns>
        TrunkBase GetProvidersEdgeTrunkbasesettingsTemplate (string trunkMetabaseId);
  
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> GetProvidersEdgeTrunkbasesettingsTemplateWithHttpInfo (string trunkMetabaseId);
        
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>TrunkBase</returns>
        TrunkBase GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId);
  
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId);
        
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup PostProvidersEdgeEdgegroups (EdgeGroup body = null);
  
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> PostProvidersEdgeEdgegroupsWithHttpInfo (EdgeGroup body = null);
        
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute PostProvidersEdgeOutboundroutes (OutboundRoute body = null);
  
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> PostProvidersEdgeOutboundroutesWithHttpInfo (OutboundRoute body = null);
        
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>PhoneBase</returns>
        PhoneBase PostProvidersEdgePhonebasesettings (PhoneBase body = null);
  
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> PostProvidersEdgePhonebasesettingsWithHttpInfo (PhoneBase body = null);
        
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Phone</returns>
        Phone PostProvidersEdgePhones (Phone body = null);
  
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> PostProvidersEdgePhonesWithHttpInfo (Phone body = null);
        
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns></returns>
        void PostProvidersEdgePhonesPhoneIdReboot (string phoneId);
  
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostProvidersEdgePhonesPhoneIdRebootWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body</param>
        /// <returns></returns>
        void PostProvidersEdgePhonesReboot (PhonesReboot body = null);
  
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostProvidersEdgePhonesRebootWithHttpInfo (PhonesReboot body = null);
        
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>TrunkBase</returns>
        TrunkBase PostProvidersEdgeTrunkbasesettings (TrunkBase body = null);
  
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> PostProvidersEdgeTrunkbasesettingsWithHttpInfo (TrunkBase body = null);
        
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup PutProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId, EdgeGroup body = null);
  
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> PutProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId, EdgeGroup body = null);
        
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute PutProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId, OutboundRoute body = null);
  
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> PutProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId, OutboundRoute body = null);
        
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>PhoneBase</returns>
        PhoneBase PutProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId, PhoneBase body = null);
  
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> PutProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId, PhoneBase body = null);
        
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Phone</returns>
        Phone PutProvidersEdgePhonesPhoneId (string phoneId, Phone body = null);
  
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> PutProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId, Phone body = null);
        
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>TrunkBase</returns>
        TrunkBase PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId, TrunkBase body = null);
  
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);
        
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
        System.Threading.Tasks.Task<string> DeleteProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId);

        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId);
        
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId);

        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId);
        
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonesPhoneIdAsync (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId);
        
        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EdgeGroupEntityListing</returns>
        System.Threading.Tasks.Task<EdgeGroupEntityListing> GetProvidersEdgeEdgegroupsAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EdgeGroupEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroupEntityListing>> GetProvidersEdgeEdgegroupsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> GetProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId);

        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> GetProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId);
        
        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of LineBaseEntityListing</returns>
        System.Threading.Tasks.Task<LineBaseEntityListing> GetProvidersEdgeLinebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (LineBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineBaseEntityListing>> GetProvidersEdgeLinebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        System.Threading.Tasks.Task<LineBase> GetProvidersEdgeLinebasesettingsLinebaseIdAsync (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineBase>> GetProvidersEdgeLinebasesettingsLinebaseIdAsyncWithHttpInfo (string lineBaseId);
        
        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of LineEntityListing</returns>
        System.Threading.Tasks.Task<LineEntityListing> GetProvidersEdgeLinesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);

        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of ApiResponse (LineEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> GetProvidersEdgeLinesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
        
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> GetProvidersEdgeLinesLineIdAsync (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLinesLineIdAsyncWithHttpInfo (string lineId);
        
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> GetProvidersEdgeLinesTemplateAsync (string lineBaseSettingsId);

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLinesTemplateAsyncWithHttpInfo (string lineBaseSettingsId);
        
        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of OutboundRouteEntityListing</returns>
        System.Threading.Tasks.Task<OutboundRouteEntityListing> GetProvidersEdgeOutboundroutesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);

        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (OutboundRouteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRouteEntityListing>> GetProvidersEdgeOutboundroutesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);
        
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> GetProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId);

        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> GetProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId);
        
        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of PhoneBaseEntityListing</returns>
        System.Threading.Tasks.Task<PhoneBaseEntityListing> GetProvidersEdgePhonebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (PhoneBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> GetProvidersEdgePhonebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of PhoneMetaBaseEntityListing</returns>
        System.Threading.Tasks.Task<PhoneMetaBaseEntityListing> GetProvidersEdgePhonebasesettingsAvailablemetabasesAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> GetProvidersEdgePhonebasesettingsAvailablemetabasesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsTemplateAsync (string phoneMetabaseId);

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsTemplateAsyncWithHttpInfo (string phoneMetabaseId);
        
        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>Task of PhoneEntityListing</returns>
        System.Threading.Tasks.Task<PhoneEntityListing> GetProvidersEdgePhonesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);

        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>Task of ApiResponse (PhoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneEntityListing>> GetProvidersEdgePhonesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);
        
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> GetProvidersEdgePhonesPhoneIdAsync (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> GetProvidersEdgePhonesTemplateAsync (string phoneBaseSettingsId);

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhonesTemplateAsyncWithHttpInfo (string phoneBaseSettingsId);
        
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        System.Threading.Tasks.Task<TimeZoneEntityListing> GetProvidersEdgeTimezonesAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> GetProvidersEdgeTimezonesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of TrunkMetabaseEntityListing</returns>
        System.Threading.Tasks.Task<TrunkMetabaseEntityListing> GetProvidersEdgeTrunkbasesettingsAvailablemetabasesAsync (string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (TrunkMetabaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkMetabaseEntityListing>> GetProvidersEdgeTrunkbasesettingsAvailablemetabasesAsyncWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTemplateAsync (string trunkMetabaseId);

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTemplateAsyncWithHttpInfo (string trunkMetabaseId);
        
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId);
        
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> PostProvidersEdgeEdgegroupsAsync (EdgeGroup body = null);

        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PostProvidersEdgeEdgegroupsAsyncWithHttpInfo (EdgeGroup body = null);
        
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> PostProvidersEdgeOutboundroutesAsync (OutboundRoute body = null);

        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PostProvidersEdgeOutboundroutesAsyncWithHttpInfo (OutboundRoute body = null);
        
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> PostProvidersEdgePhonebasesettingsAsync (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PostProvidersEdgePhonebasesettingsAsyncWithHttpInfo (PhoneBase body = null);
        
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> PostProvidersEdgePhonesAsync (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> PostProvidersEdgePhonesAsyncWithHttpInfo (Phone body = null);
        
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostProvidersEdgePhonesPhoneIdRebootAsync (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostProvidersEdgePhonesPhoneIdRebootAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostProvidersEdgePhonesRebootAsync (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostProvidersEdgePhonesRebootAsyncWithHttpInfo (PhonesReboot body = null);
        
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> PostProvidersEdgeTrunkbasesettingsAsync (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PostProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (TrunkBase body = null);
        
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> PutProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId, EdgeGroup body = null);

        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PutProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null);
        
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> PutProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId, OutboundRoute body = null);

        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PutProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null);
        
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> PutProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PutProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null);
        
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> PutProvidersEdgePhonesPhoneIdAsync (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> PutProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId, Phone body = null);
        
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);
        
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
        public string DeleteProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId)
        {
             ApiResponse<string> localVarResponse = DeleteProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo(edgeGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgeEdgegroupsEdgegroupId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId)
        {
             ApiResponse<string> localVarResponse = await DeleteProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo(edgeGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling DeleteProvidersEdgeEdgegroupsEdgegroupId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId)
        {
             ApiResponse<string> localVarResponse = DeleteProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo(outboundRouteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgeOutboundroutesOutboundrouteId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId)
        {
             ApiResponse<string> localVarResponse = await DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo(outboundRouteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling DeleteProvidersEdgeOutboundroutesOutboundrouteId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId)
        {
             ApiResponse<string> localVarResponse = DeleteProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo(phoneBaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgePhonebasesettingsPhonebaseId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId)
        {
             ApiResponse<string> localVarResponse = await DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo(phoneBaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling DeleteProvidersEdgePhonebasesettingsPhonebaseId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgePhonesPhoneId (string phoneId)
        {
             ApiResponse<string> localVarResponse = DeleteProvidersEdgePhonesPhoneIdWithHttpInfo(phoneId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgePhonesPhoneId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgePhonesPhoneId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgePhonesPhoneId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonesPhoneIdAsync (string phoneId)
        {
             ApiResponse<string> localVarResponse = await DeleteProvidersEdgePhonesPhoneIdAsyncWithHttpInfo(phoneId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling DeleteProvidersEdgePhonesPhoneId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgePhonesPhoneId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgePhonesPhoneId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId)
        {
             ApiResponse<string> localVarResponse = DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo(trunkBaseSettingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId)
        {
             ApiResponse<string> localVarResponse = await DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo(trunkBaseSettingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>EdgeGroupEntityListing</returns>
        public EdgeGroupEntityListing GetProvidersEdgeEdgegroups (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EdgeGroupEntityListing> localVarResponse = GetProvidersEdgeEdgegroupsWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of EdgeGroupEntityListing</returns>
        public ApiResponse< EdgeGroupEntityListing > GetProvidersEdgeEdgegroupsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeEdgegroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeEdgegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeGroupEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroupEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroupEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EdgeGroupEntityListing</returns>
        public async System.Threading.Tasks.Task<EdgeGroupEntityListing> GetProvidersEdgeEdgegroupsAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EdgeGroupEntityListing> localVarResponse = await GetProvidersEdgeEdgegroupsAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EdgeGroupEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroupEntityListing>> GetProvidersEdgeEdgegroupsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeEdgegroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeEdgegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroupEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroupEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroupEntityListing)));
            
        }
        
        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>EdgeGroup</returns>
        public EdgeGroup GetProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> localVarResponse = GetProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo(edgeGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > GetProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeEdgegroupsEdgegroupId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeGroup> GetProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> localVarResponse = await GetProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo(edgeGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> GetProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling GetProvidersEdgeEdgegroupsEdgegroupId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>LineBaseEntityListing</returns>
        public LineBaseEntityListing GetProvidersEdgeLinebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> localVarResponse = GetProvidersEdgeLinebasesettingsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of LineBaseEntityListing</returns>
        public ApiResponse< LineBaseEntityListing > GetProvidersEdgeLinebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinebasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinebasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LineBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineBaseEntityListing)));
            
        }

        
        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of LineBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<LineBaseEntityListing> GetProvidersEdgeLinebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> localVarResponse = await GetProvidersEdgeLinebasesettingsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (LineBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBaseEntityListing>> GetProvidersEdgeLinebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinebasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinebasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public LineBase GetProvidersEdgeLinebasesettingsLinebaseId (string lineBaseId)
        {
             ApiResponse<LineBase> localVarResponse = GetProvidersEdgeLinebasesettingsLinebaseIdWithHttpInfo(lineBaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param> 
        /// <returns>ApiResponse of LineBase</returns>
        public ApiResponse< LineBase > GetProvidersEdgeLinebasesettingsLinebaseIdWithHttpInfo (string lineBaseId)
        {
            
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeLinebasesettingsLinebaseId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinebasesettingsLinebaseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinebasesettingsLinebaseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<LineBase> GetProvidersEdgeLinebasesettingsLinebaseIdAsync (string lineBaseId)
        {
             ApiResponse<LineBase> localVarResponse = await GetProvidersEdgeLinebasesettingsLinebaseIdAsyncWithHttpInfo(lineBaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBase>> GetProvidersEdgeLinebasesettingsLinebaseIdAsyncWithHttpInfo (string lineBaseId)
        {
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null) throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling GetProvidersEdgeLinebasesettingsLinebaseId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinebasesettingsLinebaseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinebasesettingsLinebaseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineBase)));
            
        }
        
        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <returns>LineEntityListing</returns>
        public LineEntityListing GetProvidersEdgeLines (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> localVarResponse = GetProvidersEdgeLinesWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <returns>ApiResponse of LineEntityListing</returns>
        public ApiResponse< LineEntityListing > GetProvidersEdgeLinesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLines: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LineEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of LineEntityListing</returns>
        public async System.Threading.Tasks.Task<LineEntityListing> GetProvidersEdgeLinesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> localVarResponse = await GetProvidersEdgeLinesAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of ApiResponse (LineEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> GetProvidersEdgeLinesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLines: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public Line GetProvidersEdgeLinesLineId (string lineId)
        {
             ApiResponse<Line> localVarResponse = GetProvidersEdgeLinesLineIdWithHttpInfo(lineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param> 
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > GetProvidersEdgeLinesLineIdWithHttpInfo (string lineId)
        {
            
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeLinesLineId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinesLineId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinesLineId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Line> GetProvidersEdgeLinesLineIdAsync (string lineId)
        {
             ApiResponse<Line> localVarResponse = await GetProvidersEdgeLinesLineIdAsyncWithHttpInfo(lineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLinesLineIdAsyncWithHttpInfo (string lineId)
        {
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetProvidersEdgeLinesLineId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinesLineId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinesLineId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public Line GetProvidersEdgeLinesTemplate (string lineBaseSettingsId)
        {
             ApiResponse<Line> localVarResponse = GetProvidersEdgeLinesTemplateWithHttpInfo(lineBaseSettingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param> 
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > GetProvidersEdgeLinesTemplateWithHttpInfo (string lineBaseSettingsId)
        {
            
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeLinesTemplate");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinesTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinesTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Line> GetProvidersEdgeLinesTemplateAsync (string lineBaseSettingsId)
        {
             ApiResponse<Line> localVarResponse = await GetProvidersEdgeLinesTemplateAsyncWithHttpInfo(lineBaseSettingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLinesTemplateAsyncWithHttpInfo (string lineBaseSettingsId)
        {
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling GetProvidersEdgeLinesTemplate");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinesTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeLinesTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Line>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Line)));
            
        }
        
        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>OutboundRouteEntityListing</returns>
        public OutboundRouteEntityListing GetProvidersEdgeOutboundroutes (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
             ApiResponse<OutboundRouteEntityListing> localVarResponse = GetProvidersEdgeOutboundroutesWithHttpInfo(pageSize, pageNumber, name, siteId, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of OutboundRouteEntityListing</returns>
        public ApiResponse< OutboundRouteEntityListing > GetProvidersEdgeOutboundroutesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeOutboundroutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeOutboundroutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OutboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRouteEntityListing)));
            
        }

        
        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of OutboundRouteEntityListing</returns>
        public async System.Threading.Tasks.Task<OutboundRouteEntityListing> GetProvidersEdgeOutboundroutesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
             ApiResponse<OutboundRouteEntityListing> localVarResponse = await GetProvidersEdgeOutboundroutesAsyncWithHttpInfo(pageSize, pageNumber, name, siteId, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (OutboundRouteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRouteEntityListing>> GetProvidersEdgeOutboundroutesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeOutboundroutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeOutboundroutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRouteEntityListing)));
            
        }
        
        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>OutboundRoute</returns>
        public OutboundRoute GetProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> localVarResponse = GetProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo(outboundRouteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > GetProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeOutboundroutesOutboundrouteId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OutboundRoute> GetProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> localVarResponse = await GetProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo(outboundRouteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> GetProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling GetProvidersEdgeOutboundroutesOutboundrouteId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>PhoneBaseEntityListing</returns>
        public PhoneBaseEntityListing GetProvidersEdgePhonebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> localVarResponse = GetProvidersEdgePhonebasesettingsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of PhoneBaseEntityListing</returns>
        public ApiResponse< PhoneBaseEntityListing > GetProvidersEdgePhonebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PhoneBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBaseEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of PhoneBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneBaseEntityListing> GetProvidersEdgePhonebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> localVarResponse = await GetProvidersEdgePhonebasesettingsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (PhoneBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> GetProvidersEdgePhonebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>PhoneMetaBaseEntityListing</returns>
        public PhoneMetaBaseEntityListing GetProvidersEdgePhonebasesettingsAvailablemetabases (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> localVarResponse = GetProvidersEdgePhonebasesettingsAvailablemetabasesWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        public ApiResponse< PhoneMetaBaseEntityListing > GetProvidersEdgePhonebasesettingsAvailablemetabasesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsAvailablemetabases: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsAvailablemetabases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PhoneMetaBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneMetaBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneMetaBaseEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of PhoneMetaBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneMetaBaseEntityListing> GetProvidersEdgePhonebasesettingsAvailablemetabasesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> localVarResponse = await GetProvidersEdgePhonebasesettingsAvailablemetabasesAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> GetProvidersEdgePhonebasesettingsAvailablemetabasesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsAvailablemetabases: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsAvailablemetabases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneMetaBaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneMetaBaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneMetaBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase GetProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId)
        {
             ApiResponse<PhoneBase> localVarResponse = GetProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo(phoneBaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > GetProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgePhonebasesettingsPhonebaseId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId)
        {
             ApiResponse<PhoneBase> localVarResponse = await GetProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo(phoneBaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling GetProvidersEdgePhonebasesettingsPhonebaseId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public PhoneBase GetProvidersEdgePhonebasesettingsTemplate (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> localVarResponse = GetProvidersEdgePhonebasesettingsTemplateWithHttpInfo(phoneMetabaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > GetProvidersEdgePhonebasesettingsTemplateWithHttpInfo (string phoneMetabaseId)
        {
            
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgePhonebasesettingsTemplate");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsTemplateAsync (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> localVarResponse = await GetProvidersEdgePhonebasesettingsTemplateAsyncWithHttpInfo(phoneMetabaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsTemplateAsyncWithHttpInfo (string phoneMetabaseId)
        {
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null) throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling GetProvidersEdgePhonebasesettingsTemplate");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonebasesettingsTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param> 
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <param name="fields">Fields under properties to get, comma-separated</param> 
        /// <returns>PhoneEntityListing</returns>
        public PhoneEntityListing GetProvidersEdgePhones (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
             ApiResponse<PhoneEntityListing> localVarResponse = GetProvidersEdgePhonesWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param> 
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <param name="fields">Fields under properties to get, comma-separated</param> 
        /// <returns>ApiResponse of PhoneEntityListing</returns>
        public ApiResponse< PhoneEntityListing > GetProvidersEdgePhonesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PhoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>Task of PhoneEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneEntityListing> GetProvidersEdgePhonesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
             ApiResponse<PhoneEntityListing> localVarResponse = await GetProvidersEdgePhonesAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>Task of ApiResponse (PhoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneEntityListing>> GetProvidersEdgePhonesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>Phone</returns>
        public Phone GetProvidersEdgePhonesPhoneId (string phoneId)
        {
             ApiResponse<Phone> localVarResponse = GetProvidersEdgePhonesPhoneIdWithHttpInfo(phoneId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > GetProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgePhonesPhoneId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonesPhoneId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonesPhoneId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Phone> GetProvidersEdgePhonesPhoneIdAsync (string phoneId)
        {
             ApiResponse<Phone> localVarResponse = await GetProvidersEdgePhonesPhoneIdAsyncWithHttpInfo(phoneId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling GetProvidersEdgePhonesPhoneId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonesPhoneId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonesPhoneId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param> 
        /// <returns>Phone</returns>
        public Phone GetProvidersEdgePhonesTemplate (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> localVarResponse = GetProvidersEdgePhonesTemplateWithHttpInfo(phoneBaseSettingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > GetProvidersEdgePhonesTemplateWithHttpInfo (string phoneBaseSettingsId)
        {
            
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgePhonesTemplate");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonesTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonesTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Phone> GetProvidersEdgePhonesTemplateAsync (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> localVarResponse = await GetProvidersEdgePhonesTemplateAsyncWithHttpInfo(phoneBaseSettingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhonesTemplateAsyncWithHttpInfo (string phoneBaseSettingsId)
        {
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling GetProvidersEdgePhonesTemplate");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonesTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgePhonesTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>TimeZoneEntityListing</returns>
        public TimeZoneEntityListing GetProvidersEdgeTimezones (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> localVarResponse = GetProvidersEdgeTimezonesWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        public ApiResponse< TimeZoneEntityListing > GetProvidersEdgeTimezonesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTimezones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTimezones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TimeZoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeZoneEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        public async System.Threading.Tasks.Task<TimeZoneEntityListing> GetProvidersEdgeTimezonesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> localVarResponse = await GetProvidersEdgeTimezonesAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> GetProvidersEdgeTimezonesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTimezones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTimezones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeZoneEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeZoneEntityListing)));
            
        }
        
        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase GetProvidersEdgeTrunkbasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> localVarResponse = GetProvidersEdgeTrunkbasesettingsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > GetProvidersEdgeTrunkbasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        
        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> localVarResponse = await GetProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param> 
        /// <param name="pageSize"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>TrunkMetabaseEntityListing</returns>
        public TrunkMetabaseEntityListing GetProvidersEdgeTrunkbasesettingsAvailablemetabases (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> localVarResponse = GetProvidersEdgeTrunkbasesettingsAvailablemetabasesWithHttpInfo(type, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param> 
        /// <param name="pageSize"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>ApiResponse of TrunkMetabaseEntityListing</returns>
        public ApiResponse< TrunkMetabaseEntityListing > GetProvidersEdgeTrunkbasesettingsAvailablemetabasesWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsAvailablemetabases: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsAvailablemetabases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TrunkMetabaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkMetabaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkMetabaseEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of TrunkMetabaseEntityListing</returns>
        public async System.Threading.Tasks.Task<TrunkMetabaseEntityListing> GetProvidersEdgeTrunkbasesettingsAvailablemetabasesAsync (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> localVarResponse = await GetProvidersEdgeTrunkbasesettingsAvailablemetabasesAsyncWithHttpInfo(type, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (TrunkMetabaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkMetabaseEntityListing>> GetProvidersEdgeTrunkbasesettingsAvailablemetabasesAsyncWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsAvailablemetabases: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsAvailablemetabases: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkMetabaseEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkMetabaseEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkMetabaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase GetProvidersEdgeTrunkbasesettingsTemplate (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> localVarResponse = GetProvidersEdgeTrunkbasesettingsTemplateWithHttpInfo(trunkMetabaseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > GetProvidersEdgeTrunkbasesettingsTemplateWithHttpInfo (string trunkMetabaseId)
        {
            
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeTrunkbasesettingsTemplate");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTemplateAsync (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> localVarResponse = await GetProvidersEdgeTrunkbasesettingsTemplateAsyncWithHttpInfo(trunkMetabaseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTemplateAsyncWithHttpInfo (string trunkMetabaseId)
        {
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null) throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling GetProvidersEdgeTrunkbasesettingsTemplate");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> localVarResponse = GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo(trunkBaseSettingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> localVarResponse = await GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo(trunkBaseSettingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup</param> 
        /// <returns>EdgeGroup</returns>
        public EdgeGroup PostProvidersEdgeEdgegroups (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> localVarResponse = PostProvidersEdgeEdgegroupsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > PostProvidersEdgeEdgegroupsWithHttpInfo (EdgeGroup body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeEdgegroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeEdgegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }

        
        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> PostProvidersEdgeEdgegroupsAsync (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> localVarResponse = await PostProvidersEdgeEdgegroupsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PostProvidersEdgeEdgegroupsAsyncWithHttpInfo (EdgeGroup body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeEdgegroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeEdgegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute</param> 
        /// <returns>OutboundRoute</returns>
        public OutboundRoute PostProvidersEdgeOutboundroutes (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> localVarResponse = PostProvidersEdgeOutboundroutesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > PostProvidersEdgeOutboundroutesWithHttpInfo (OutboundRoute body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeOutboundroutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeOutboundroutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }

        
        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> PostProvidersEdgeOutboundroutesAsync (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> localVarResponse = await PostProvidersEdgeOutboundroutesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PostProvidersEdgeOutboundroutesAsyncWithHttpInfo (OutboundRoute body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeOutboundroutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeOutboundroutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase PostProvidersEdgePhonebasesettings (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> localVarResponse = PostProvidersEdgePhonebasesettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > PostProvidersEdgePhonebasesettingsWithHttpInfo (PhoneBase body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonebasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonebasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        
        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> PostProvidersEdgePhonebasesettingsAsync (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> localVarResponse = await PostProvidersEdgePhonebasesettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PostProvidersEdgePhonebasesettingsAsyncWithHttpInfo (PhoneBase body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonebasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonebasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>Phone</returns>
        public Phone PostProvidersEdgePhones (Phone body = null)
        {
             ApiResponse<Phone> localVarResponse = PostProvidersEdgePhonesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > PostProvidersEdgePhonesWithHttpInfo (Phone body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        
        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> PostProvidersEdgePhonesAsync (Phone body = null)
        {
             ApiResponse<Phone> localVarResponse = await PostProvidersEdgePhonesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> PostProvidersEdgePhonesAsyncWithHttpInfo (Phone body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public void PostProvidersEdgePhonesPhoneIdReboot (string phoneId)
        {
             PostProvidersEdgePhonesPhoneIdRebootWithHttpInfo(phoneId);
        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostProvidersEdgePhonesPhoneIdRebootWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->PostProvidersEdgePhonesPhoneIdReboot");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonesPhoneIdReboot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonesPhoneIdReboot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task PostProvidersEdgePhonesPhoneIdRebootAsync (string phoneId)
        {
             await PostProvidersEdgePhonesPhoneIdRebootAsyncWithHttpInfo(phoneId);

        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostProvidersEdgePhonesPhoneIdRebootAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling PostProvidersEdgePhonesPhoneIdReboot");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonesPhoneIdReboot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonesPhoneIdReboot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body</param> 
        /// <returns></returns>
        public void PostProvidersEdgePhonesReboot (PhonesReboot body = null)
        {
             PostProvidersEdgePhonesRebootWithHttpInfo(body);
        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostProvidersEdgePhonesRebootWithHttpInfo (PhonesReboot body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonesReboot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonesReboot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostProvidersEdgePhonesRebootAsync (PhonesReboot body = null)
        {
             await PostProvidersEdgePhonesRebootAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostProvidersEdgePhonesRebootAsyncWithHttpInfo (PhonesReboot body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonesReboot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgePhonesReboot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase PostProvidersEdgeTrunkbasesettings (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> localVarResponse = PostProvidersEdgeTrunkbasesettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > PostProvidersEdgeTrunkbasesettingsWithHttpInfo (TrunkBase body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeTrunkbasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeTrunkbasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        
        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> PostProvidersEdgeTrunkbasesettingsAsync (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> localVarResponse = await PostProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PostProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (TrunkBase body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeTrunkbasesettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProvidersEdgeTrunkbasesettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <param name="body">EdgeGroup</param> 
        /// <returns>EdgeGroup</returns>
        public EdgeGroup PutProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> localVarResponse = PutProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo(edgeGroupId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <param name="body">EdgeGroup</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > PutProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgeEdgegroupsEdgegroupId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }

        
        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> PutProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> localVarResponse = await PutProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo(edgeGroupId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PutProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling PutProvidersEdgeEdgegroupsEdgegroupId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeEdgegroupsEdgegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <param name="body">OutboundRoute</param> 
        /// <returns>OutboundRoute</returns>
        public OutboundRoute PutProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> localVarResponse = PutProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo(outboundRouteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <param name="body">OutboundRoute</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > PutProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgeOutboundroutesOutboundrouteId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }

        
        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> PutProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> localVarResponse = await PutProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo(outboundRouteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PutProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling PutProvidersEdgeOutboundroutesOutboundrouteId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeOutboundroutesOutboundrouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OutboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <param name="body"></param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase PutProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> localVarResponse = PutProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo(phoneBaseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > PutProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgePhonebasesettingsPhonebaseId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }

        
        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> PutProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> localVarResponse = await PutProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo(phoneBaseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PutProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling PutProvidersEdgePhonebasesettingsPhonebaseId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgePhonebasesettingsPhonebaseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param> 
        /// <param name="body"></param> 
        /// <returns>Phone</returns>
        public Phone PutProvidersEdgePhonesPhoneId (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> localVarResponse = PutProvidersEdgePhonesPhoneIdWithHttpInfo(phoneId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > PutProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId, Phone body = null)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgePhonesPhoneId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgePhonesPhoneId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgePhonesPhoneId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }

        
        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> PutProvidersEdgePhonesPhoneIdAsync (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> localVarResponse = await PutProvidersEdgePhonesPhoneIdAsyncWithHttpInfo(phoneId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> PutProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId, Phone body = null)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling PutProvidersEdgePhonesPhoneId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgePhonesPhoneId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgePhonesPhoneId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Phone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <param name="body"></param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> localVarResponse = PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo(trunkBaseSettingsId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }

        
        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> localVarResponse = await PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo(trunkBaseSettingsId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TrunkBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrunkBase)));
            
        }
        
    }
    
}
