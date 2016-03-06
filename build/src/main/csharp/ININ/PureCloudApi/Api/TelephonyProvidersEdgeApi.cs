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
        
        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of EdgeGroupEntityListing</returns>
        ApiResponse<EdgeGroupEntityListing> GetProvidersEdgeEdgegroupsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

        /// <summary>
        /// Get the list of edge groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EdgeGroupEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroupEntityListing>> GetProvidersEdgeEdgegroupsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup PostProvidersEdgeEdgegroups (EdgeGroup body = null);
  
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> PostProvidersEdgeEdgegroupsWithHttpInfo (EdgeGroup body = null);

        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> PostProvidersEdgeEdgegroupsAsync (EdgeGroup body = null);

        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PostProvidersEdgeEdgegroupsAsyncWithHttpInfo (EdgeGroup body = null);
        
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup GetProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId);
  
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> GetProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId);

        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> GetProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId);

        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> GetProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId);
        
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> PutProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId, EdgeGroup body = null);

        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PutProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null);
        
        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId);
  
        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId);

        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId);

        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId);
        
        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of LineBaseEntityListing</returns>
        ApiResponse<LineBaseEntityListing> GetProvidersEdgeLinebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>LineBase</returns>
        LineBase GetProvidersEdgeLinebasesettingsLinebaseId (string lineBaseId);
  
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>ApiResponse of LineBase</returns>
        ApiResponse<LineBase> GetProvidersEdgeLinebasesettingsLinebaseIdWithHttpInfo (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        System.Threading.Tasks.Task<LineBase> GetProvidersEdgeLinebasesettingsLinebaseIdAsync (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineBase>> GetProvidersEdgeLinebasesettingsLinebaseIdAsyncWithHttpInfo (string lineBaseId);
        
        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>ApiResponse of LineEntityListing</returns>
        ApiResponse<LineEntityListing> GetProvidersEdgeLinesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);

        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of ApiResponse (LineEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> GetProvidersEdgeLinesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
        
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Line</returns>
        Line GetProvidersEdgeLinesTemplate (string lineBaseSettingsId);
  
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> GetProvidersEdgeLinesTemplateWithHttpInfo (string lineBaseSettingsId);

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> GetProvidersEdgeLinesTemplateAsync (string lineBaseSettingsId);

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLinesTemplateAsyncWithHttpInfo (string lineBaseSettingsId);
        
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Line</returns>
        Line GetProvidersEdgeLinesLineId (string lineId);
  
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> GetProvidersEdgeLinesLineIdWithHttpInfo (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> GetProvidersEdgeLinesLineIdAsync (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLinesLineIdAsyncWithHttpInfo (string lineId);
        
        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of OutboundRouteEntityListing</returns>
        ApiResponse<OutboundRouteEntityListing> GetProvidersEdgeOutboundroutesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);

        /// <summary>
        /// Get outbound routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (OutboundRouteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRouteEntityListing>> GetProvidersEdgeOutboundroutesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);
        
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute PostProvidersEdgeOutboundroutes (OutboundRoute body = null);
  
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> PostProvidersEdgeOutboundroutesWithHttpInfo (OutboundRoute body = null);

        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> PostProvidersEdgeOutboundroutesAsync (OutboundRoute body = null);

        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PostProvidersEdgeOutboundroutesAsyncWithHttpInfo (OutboundRoute body = null);
        
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute GetProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId);
  
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> GetProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId);

        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> GetProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId);

        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> GetProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId);
        
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> PutProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId, OutboundRoute body = null);

        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PutProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null);
        
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId);
  
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId);

        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId);

        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId);
        
        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of PhoneBaseEntityListing</returns>
        ApiResponse<PhoneBaseEntityListing> GetProvidersEdgePhonebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (PhoneBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> GetProvidersEdgePhonebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>PhoneBase</returns>
        PhoneBase PostProvidersEdgePhonebasesettings (PhoneBase body = null);
  
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> PostProvidersEdgePhonebasesettingsWithHttpInfo (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> PostProvidersEdgePhonebasesettingsAsync (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PostProvidersEdgePhonebasesettingsAsyncWithHttpInfo (PhoneBase body = null);
        
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        ApiResponse<PhoneMetaBaseEntityListing> GetProvidersEdgePhonebasesettingsAvailablemetabasesWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> GetProvidersEdgePhonebasesettingsAvailablemetabasesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>PhoneBase</returns>
        PhoneBase GetProvidersEdgePhonebasesettingsTemplate (string phoneMetabaseId);
  
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> GetProvidersEdgePhonebasesettingsTemplateWithHttpInfo (string phoneMetabaseId);

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsTemplateAsync (string phoneMetabaseId);

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsTemplateAsyncWithHttpInfo (string phoneMetabaseId);
        
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>PhoneBase</returns>
        PhoneBase GetProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId);
  
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> GetProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> PutProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PutProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null);
        
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId);
  
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Phone</returns>
        Phone PostProvidersEdgePhones (Phone body = null);
  
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> PostProvidersEdgePhonesWithHttpInfo (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> PostProvidersEdgePhonesAsync (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> PostProvidersEdgePhonesAsyncWithHttpInfo (Phone body = null);
        
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns></returns>
        void PostProvidersEdgePhonesReboot (PhonesReboot body = null);
  
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostProvidersEdgePhonesRebootWithHttpInfo (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostProvidersEdgePhonesRebootAsync (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostProvidersEdgePhonesRebootAsyncWithHttpInfo (PhonesReboot body = null);
        
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Phone</returns>
        Phone GetProvidersEdgePhonesTemplate (string phoneBaseSettingsId);
  
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> GetProvidersEdgePhonesTemplateWithHttpInfo (string phoneBaseSettingsId);

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> GetProvidersEdgePhonesTemplateAsync (string phoneBaseSettingsId);

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhonesTemplateAsyncWithHttpInfo (string phoneBaseSettingsId);
        
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Phone</returns>
        Phone GetProvidersEdgePhonesPhoneId (string phoneId);
  
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> GetProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> GetProvidersEdgePhonesPhoneIdAsync (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> PutProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> PutProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId, Phone body = null);
        
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgePhonesPhoneId (string phoneId);
  
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonesPhoneIdAsync (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns></returns>
        void PostProvidersEdgePhonesPhoneIdReboot (string phoneId);
  
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostProvidersEdgePhonesPhoneIdRebootWithHttpInfo (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostProvidersEdgePhonesPhoneIdRebootAsync (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostProvidersEdgePhonesPhoneIdRebootAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        ApiResponse<TimeZoneEntityListing> GetProvidersEdgeTimezonesWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> GetProvidersEdgeTrunkbasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>TrunkBase</returns>
        TrunkBase PostProvidersEdgeTrunkbasesettings (TrunkBase body = null);
  
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> PostProvidersEdgeTrunkbasesettingsWithHttpInfo (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> PostProvidersEdgeTrunkbasesettingsAsync (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PostProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (TrunkBase body = null);
        
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>ApiResponse of TrunkMetabaseEntityListing</returns>
        ApiResponse<TrunkMetabaseEntityListing> GetProvidersEdgeTrunkbasesettingsAvailablemetabasesWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>TrunkBase</returns>
        TrunkBase GetProvidersEdgeTrunkbasesettingsTemplate (string trunkMetabaseId);
  
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> GetProvidersEdgeTrunkbasesettingsTemplateWithHttpInfo (string trunkMetabaseId);

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTemplateAsync (string trunkMetabaseId);

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTemplateAsyncWithHttpInfo (string trunkMetabaseId);
        
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>TrunkBase</returns>
        TrunkBase GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId);
  
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId);
        
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId);
  
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId);
        
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
        /// Get the list of edge groups. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>EdgeGroupEntityListing</returns>
        public EdgeGroupEntityListing GetProvidersEdgeEdgegroups (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EdgeGroupEntityListing> response = GetProvidersEdgeEdgegroupsWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return response.Data;
        }

        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of EdgeGroupEntityListing</returns>
        public ApiResponse< EdgeGroupEntityListing > GetProvidersEdgeEdgegroupsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeGroupEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroupEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroupEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EdgeGroupEntityListing</returns>
        public async System.Threading.Tasks.Task<EdgeGroupEntityListing> GetProvidersEdgeEdgegroupsAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EdgeGroupEntityListing> response = await GetProvidersEdgeEdgegroupsAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return response.Data;

        }

        /// <summary>
        /// Get the list of edge groups. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EdgeGroupEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroupEntityListing>> GetProvidersEdgeEdgegroupsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeGroupEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroupEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroupEntityListing)));
            
        }
        
        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param> 
        /// <returns>EdgeGroup</returns>
        public EdgeGroup PostProvidersEdgeEdgegroups (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = PostProvidersEdgeEdgegroupsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > PostProvidersEdgeEdgegroupsWithHttpInfo (EdgeGroup body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
    
        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> PostProvidersEdgeEdgegroupsAsync (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = await PostProvidersEdgeEdgegroupsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PostProvidersEdgeEdgegroupsAsyncWithHttpInfo (EdgeGroup body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>EdgeGroup</returns>
        public EdgeGroup GetProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> response = GetProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo(edgeGroupId);
             return response.Data;
        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > GetProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeEdgegroupsEdgegroupId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgegroupsEdgegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgegroupsEdgegroupId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
    
        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> GetProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> response = await GetProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo(edgeGroupId);
             return response.Data;

        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> GetProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling GetProvidersEdgeEdgegroupsEdgegroupId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgegroupsEdgegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgegroupsEdgegroupId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <param name="body">EdgeGroup</param> 
        /// <returns>EdgeGroup</returns>
        public EdgeGroup PutProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = PutProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo(edgeGroupId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <param name="body">EdgeGroup</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > PutProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgeEdgegroupsEdgegroupId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeEdgegroupsEdgegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeEdgegroupsEdgegroupId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
    
        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> PutProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = await PutProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo(edgeGroupId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PutProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling PutProvidersEdgeEdgegroupsEdgegroupId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeEdgegroupsEdgegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeEdgegroupsEdgegroupId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgeEdgegroupsEdgegroupId (string edgeGroupId)
        {
             ApiResponse<string> response = DeleteProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo(edgeGroupId);
             return response.Data;
        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgeEdgegroupsEdgegroupIdWithHttpInfo (string edgeGroupId)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgeEdgegroupsEdgegroupId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeEdgegroupsEdgegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeEdgegroupsEdgegroupId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgeEdgegroupsEdgegroupIdAsync (string edgeGroupId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo(edgeGroupId);
             return response.Data;

        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeEdgegroupsEdgegroupIdAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling DeleteProvidersEdgeEdgegroupsEdgegroupId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeEdgegroupsEdgegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeEdgegroupsEdgegroupId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>LineBaseEntityListing</returns>
        public LineBaseEntityListing GetProvidersEdgeLinebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> response = GetProvidersEdgeLinebasesettingsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of LineBaseEntityListing</returns>
        public ApiResponse< LineBaseEntityListing > GetProvidersEdgeLinebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LineBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineBaseEntityListing)));
            
        }
    
        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of LineBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<LineBaseEntityListing> GetProvidersEdgeLinebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> response = await GetProvidersEdgeLinebasesettingsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (LineBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBaseEntityListing>> GetProvidersEdgeLinebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LineBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param> 
        /// <returns>LineBase</returns>
        public LineBase GetProvidersEdgeLinebasesettingsLinebaseId (string lineBaseId)
        {
             ApiResponse<LineBase> response = GetProvidersEdgeLinebasesettingsLinebaseIdWithHttpInfo(lineBaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param> 
        /// <returns>ApiResponse of LineBase</returns>
        public ApiResponse< LineBase > GetProvidersEdgeLinebasesettingsLinebaseIdWithHttpInfo (string lineBaseId)
        {
            
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeLinebasesettingsLinebaseId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings/{lineBaseId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (lineBaseId != null) pathParams.Add("lineBaseId", Configuration.ApiClient.ParameterToString(lineBaseId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettingsLinebaseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettingsLinebaseId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LineBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBase) Configuration.ApiClient.Deserialize(response, typeof(LineBase)));
            
        }
    
        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        public async System.Threading.Tasks.Task<LineBase> GetProvidersEdgeLinebasesettingsLinebaseIdAsync (string lineBaseId)
        {
             ApiResponse<LineBase> response = await GetProvidersEdgeLinebasesettingsLinebaseIdAsyncWithHttpInfo(lineBaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBase>> GetProvidersEdgeLinebasesettingsLinebaseIdAsyncWithHttpInfo (string lineBaseId)
        {
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null) throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling GetProvidersEdgeLinebasesettingsLinebaseId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings/{lineBaseId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (lineBaseId != null) pathParams.Add("lineBaseId", Configuration.ApiClient.ParameterToString(lineBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettingsLinebaseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettingsLinebaseId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LineBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBase) Configuration.ApiClient.Deserialize(response, typeof(LineBase)));
            
        }
        
        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <returns>LineEntityListing</returns>
        public LineEntityListing GetProvidersEdgeLines (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> response = GetProvidersEdgeLinesWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <returns>ApiResponse of LineEntityListing</returns>
        public ApiResponse< LineEntityListing > GetProvidersEdgeLinesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLines: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLines: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LineEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of LineEntityListing</returns>
        public async System.Threading.Tasks.Task<LineEntityListing> GetProvidersEdgeLinesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> response = await GetProvidersEdgeLinesAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of ApiResponse (LineEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> GetProvidersEdgeLinesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLines: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLines: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LineEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param> 
        /// <returns>Line</returns>
        public Line GetProvidersEdgeLinesTemplate (string lineBaseSettingsId)
        {
             ApiResponse<Line> response = GetProvidersEdgeLinesTemplateWithHttpInfo(lineBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param> 
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > GetProvidersEdgeLinesTemplateWithHttpInfo (string lineBaseSettingsId)
        {
            
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeLinesTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/template";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (lineBaseSettingsId != null) queryParams.Add("lineBaseSettingsId", Configuration.ApiClient.ParameterToString(lineBaseSettingsId)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinesTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinesTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
    
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of Line</returns>
        public async System.Threading.Tasks.Task<Line> GetProvidersEdgeLinesTemplateAsync (string lineBaseSettingsId)
        {
             ApiResponse<Line> response = await GetProvidersEdgeLinesTemplateAsyncWithHttpInfo(lineBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLinesTemplateAsyncWithHttpInfo (string lineBaseSettingsId)
        {
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling GetProvidersEdgeLinesTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/template";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (lineBaseSettingsId != null) queryParams.Add("lineBaseSettingsId", Configuration.ApiClient.ParameterToString(lineBaseSettingsId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinesTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinesTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
        
        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param> 
        /// <returns>Line</returns>
        public Line GetProvidersEdgeLinesLineId (string lineId)
        {
             ApiResponse<Line> response = GetProvidersEdgeLinesLineIdWithHttpInfo(lineId);
             return response.Data;
        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param> 
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > GetProvidersEdgeLinesLineIdWithHttpInfo (string lineId)
        {
            
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeLinesLineId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/{lineId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinesLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinesLineId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
    
        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        public async System.Threading.Tasks.Task<Line> GetProvidersEdgeLinesLineIdAsync (string lineId)
        {
             ApiResponse<Line> response = await GetProvidersEdgeLinesLineIdAsyncWithHttpInfo(lineId);
             return response.Data;

        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLinesLineIdAsyncWithHttpInfo (string lineId)
        {
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetProvidersEdgeLinesLineId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/{lineId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinesLineId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinesLineId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
        
        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>OutboundRouteEntityListing</returns>
        public OutboundRouteEntityListing GetProvidersEdgeOutboundroutes (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
             ApiResponse<OutboundRouteEntityListing> response = GetProvidersEdgeOutboundroutesWithHttpInfo(pageSize, pageNumber, name, siteId, sortBy);
             return response.Data;
        }

        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of OutboundRouteEntityListing</returns>
        public ApiResponse< OutboundRouteEntityListing > GetProvidersEdgeOutboundroutesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutboundRouteEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRouteEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OutboundRouteEntityListing)));
            
        }
    
        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of OutboundRouteEntityListing</returns>
        public async System.Threading.Tasks.Task<OutboundRouteEntityListing> GetProvidersEdgeOutboundroutesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
             ApiResponse<OutboundRouteEntityListing> response = await GetProvidersEdgeOutboundroutesAsyncWithHttpInfo(pageSize, pageNumber, name, siteId, sortBy);
             return response.Data;

        }

        /// <summary>
        /// Get outbound routes 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (OutboundRouteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRouteEntityListing>> GetProvidersEdgeOutboundroutesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutboundRouteEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRouteEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OutboundRouteEntityListing)));
            
        }
        
        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param> 
        /// <returns>OutboundRoute</returns>
        public OutboundRoute PostProvidersEdgeOutboundroutes (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = PostProvidersEdgeOutboundroutesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > PostProvidersEdgeOutboundroutesWithHttpInfo (OutboundRoute body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
    
        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> PostProvidersEdgeOutboundroutesAsync (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = await PostProvidersEdgeOutboundroutesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PostProvidersEdgeOutboundroutesAsyncWithHttpInfo (OutboundRoute body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>OutboundRoute</returns>
        public OutboundRoute GetProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> response = GetProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo(outboundRouteId);
             return response.Data;
        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > GetProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeOutboundroutesOutboundrouteId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundroutesOutboundrouteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundroutesOutboundrouteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
    
        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> GetProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> response = await GetProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo(outboundRouteId);
             return response.Data;

        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> GetProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling GetProvidersEdgeOutboundroutesOutboundrouteId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundroutesOutboundrouteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundroutesOutboundrouteId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <param name="body">OutboundRoute</param> 
        /// <returns>OutboundRoute</returns>
        public OutboundRoute PutProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = PutProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo(outboundRouteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <param name="body">OutboundRoute</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > PutProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgeOutboundroutesOutboundrouteId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeOutboundroutesOutboundrouteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeOutboundroutesOutboundrouteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
    
        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> PutProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = await PutProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo(outboundRouteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PutProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling PutProvidersEdgeOutboundroutesOutboundrouteId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeOutboundroutesOutboundrouteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeOutboundroutesOutboundrouteId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgeOutboundroutesOutboundrouteId (string outboundRouteId)
        {
             ApiResponse<string> response = DeleteProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo(outboundRouteId);
             return response.Data;
        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgeOutboundroutesOutboundrouteIdWithHttpInfo (string outboundRouteId)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgeOutboundroutesOutboundrouteId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeOutboundroutesOutboundrouteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeOutboundroutesOutboundrouteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsync (string outboundRouteId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo(outboundRouteId);
             return response.Data;

        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeOutboundroutesOutboundrouteIdAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling DeleteProvidersEdgeOutboundroutesOutboundrouteId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeOutboundroutesOutboundrouteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeOutboundroutesOutboundrouteId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>PhoneBaseEntityListing</returns>
        public PhoneBaseEntityListing GetProvidersEdgePhonebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> response = GetProvidersEdgePhonebasesettingsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of PhoneBaseEntityListing</returns>
        public ApiResponse< PhoneBaseEntityListing > GetProvidersEdgePhonebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneBaseEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of PhoneBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneBaseEntityListing> GetProvidersEdgePhonebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> response = await GetProvidersEdgePhonebasesettingsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (PhoneBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> GetProvidersEdgePhonebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase PostProvidersEdgePhonebasesettings (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = PostProvidersEdgePhonebasesettingsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > PostProvidersEdgePhonebasesettingsWithHttpInfo (PhoneBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> PostProvidersEdgePhonebasesettingsAsync (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = await PostProvidersEdgePhonebasesettingsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PostProvidersEdgePhonebasesettingsAsyncWithHttpInfo (PhoneBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>PhoneMetaBaseEntityListing</returns>
        public PhoneMetaBaseEntityListing GetProvidersEdgePhonebasesettingsAvailablemetabases (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> response = GetProvidersEdgePhonebasesettingsAvailablemetabasesWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        public ApiResponse< PhoneMetaBaseEntityListing > GetProvidersEdgePhonebasesettingsAvailablemetabasesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/availablemetabases";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsAvailablemetabases: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsAvailablemetabases: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneMetaBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneMetaBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneMetaBaseEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of PhoneMetaBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneMetaBaseEntityListing> GetProvidersEdgePhonebasesettingsAvailablemetabasesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> response = await GetProvidersEdgePhonebasesettingsAvailablemetabasesAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> GetProvidersEdgePhonebasesettingsAvailablemetabasesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/availablemetabases";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsAvailablemetabases: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsAvailablemetabases: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneMetaBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneMetaBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneMetaBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase GetProvidersEdgePhonebasesettingsTemplate (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> response = GetProvidersEdgePhonebasesettingsTemplateWithHttpInfo(phoneMetabaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > GetProvidersEdgePhonebasesettingsTemplateWithHttpInfo (string phoneMetabaseId)
        {
            
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgePhonebasesettingsTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/template";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (phoneMetabaseId != null) queryParams.Add("phoneMetabaseId", Configuration.ApiClient.ParameterToString(phoneMetabaseId)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsTemplateAsync (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> response = await GetProvidersEdgePhonebasesettingsTemplateAsyncWithHttpInfo(phoneMetabaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsTemplateAsyncWithHttpInfo (string phoneMetabaseId)
        {
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null) throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling GetProvidersEdgePhonebasesettingsTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/template";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (phoneMetabaseId != null) queryParams.Add("phoneMetabaseId", Configuration.ApiClient.ParameterToString(phoneMetabaseId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase GetProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId)
        {
             ApiResponse<PhoneBase> response = GetProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo(phoneBaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > GetProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgePhonebasesettingsPhonebaseId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsPhonebaseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsPhonebaseId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId)
        {
             ApiResponse<PhoneBase> response = await GetProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo(phoneBaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling GetProvidersEdgePhonebasesettingsPhonebaseId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsPhonebaseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsPhonebaseId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <param name="body"></param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase PutProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = PutProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo(phoneBaseId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > PutProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgePhonebasesettingsPhonebaseId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgePhonebasesettingsPhonebaseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgePhonebasesettingsPhonebaseId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> PutProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = await PutProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo(phoneBaseId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PutProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling PutProvidersEdgePhonebasesettingsPhonebaseId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgePhonebasesettingsPhonebaseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgePhonebasesettingsPhonebaseId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgePhonebasesettingsPhonebaseId (string phoneBaseId)
        {
             ApiResponse<string> response = DeleteProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo(phoneBaseId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgePhonebasesettingsPhonebaseIdWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgePhonebasesettingsPhonebaseId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhonebaseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhonebaseId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsync (string phoneBaseId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo(phoneBaseId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonebasesettingsPhonebaseIdAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling DeleteProvidersEdgePhonebasesettingsPhonebaseId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhonebaseId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhonebaseId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
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
             ApiResponse<PhoneEntityListing> response = GetProvidersEdgePhonesWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
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
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (siteId != null) queryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettings.id", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            if (phoneHardwareId != null) queryParams.Add("phone_hardwareId", Configuration.ApiClient.ParameterToString(phoneHardwareId)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (fields != null) queryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
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
             ApiResponse<PhoneEntityListing> response = await GetProvidersEdgePhonesAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
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
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (siteId != null) queryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettings.id", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            if (phoneHardwareId != null) queryParams.Add("phone_hardwareId", Configuration.ApiClient.ParameterToString(phoneHardwareId)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (fields != null) queryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Phone</returns>
        public Phone PostProvidersEdgePhones (Phone body = null)
        {
             ApiResponse<Phone> response = PostProvidersEdgePhonesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > PostProvidersEdgePhonesWithHttpInfo (Phone body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> PostProvidersEdgePhonesAsync (Phone body = null)
        {
             ApiResponse<Phone> response = await PostProvidersEdgePhonesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> PostProvidersEdgePhonesAsyncWithHttpInfo (Phone body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param> 
        /// <returns></returns>
        public void PostProvidersEdgePhonesReboot (PhonesReboot body = null)
        {
             PostProvidersEdgePhonesRebootWithHttpInfo(body);
        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostProvidersEdgePhonesRebootWithHttpInfo (PhonesReboot body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/reboot";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonesReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonesReboot: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostProvidersEdgePhonesRebootAsync (PhonesReboot body = null)
        {
             await PostProvidersEdgePhonesRebootAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostProvidersEdgePhonesRebootAsyncWithHttpInfo (PhonesReboot body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/reboot";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonesReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonesReboot: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param> 
        /// <returns>Phone</returns>
        public Phone GetProvidersEdgePhonesTemplate (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> response = GetProvidersEdgePhonesTemplateWithHttpInfo(phoneBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > GetProvidersEdgePhonesTemplateWithHttpInfo (string phoneBaseSettingsId)
        {
            
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgePhonesTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/template";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettingsId", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonesTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonesTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> GetProvidersEdgePhonesTemplateAsync (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> response = await GetProvidersEdgePhonesTemplateAsyncWithHttpInfo(phoneBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhonesTemplateAsyncWithHttpInfo (string phoneBaseSettingsId)
        {
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling GetProvidersEdgePhonesTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/template";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettingsId", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonesTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonesTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>Phone</returns>
        public Phone GetProvidersEdgePhonesPhoneId (string phoneId)
        {
             ApiResponse<Phone> response = GetProvidersEdgePhonesPhoneIdWithHttpInfo(phoneId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > GetProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgePhonesPhoneId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonesPhoneId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonesPhoneId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> GetProvidersEdgePhonesPhoneIdAsync (string phoneId)
        {
             ApiResponse<Phone> response = await GetProvidersEdgePhonesPhoneIdAsyncWithHttpInfo(phoneId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling GetProvidersEdgePhonesPhoneId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonesPhoneId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonesPhoneId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <param name="body"></param> 
        /// <returns>Phone</returns>
        public Phone PutProvidersEdgePhonesPhoneId (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> response = PutProvidersEdgePhonesPhoneIdWithHttpInfo(phoneId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > PutProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId, Phone body = null)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgePhonesPhoneId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgePhonesPhoneId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgePhonesPhoneId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> PutProvidersEdgePhonesPhoneIdAsync (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> response = await PutProvidersEdgePhonesPhoneIdAsyncWithHttpInfo(phoneId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> PutProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId, Phone body = null)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling PutProvidersEdgePhonesPhoneId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgePhonesPhoneId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgePhonesPhoneId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgePhonesPhoneId (string phoneId)
        {
             ApiResponse<string> response = DeleteProvidersEdgePhonesPhoneIdWithHttpInfo(phoneId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgePhonesPhoneIdWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgePhonesPhoneId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonesPhoneId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonesPhoneId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonesPhoneIdAsync (string phoneId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgePhonesPhoneIdAsyncWithHttpInfo(phoneId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonesPhoneIdAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling DeleteProvidersEdgePhonesPhoneId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonesPhoneId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonesPhoneId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param> 
        /// <returns></returns>
        public void PostProvidersEdgePhonesPhoneIdReboot (string phoneId)
        {
             PostProvidersEdgePhonesPhoneIdRebootWithHttpInfo(phoneId);
        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostProvidersEdgePhonesPhoneIdRebootWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->PostProvidersEdgePhonesPhoneIdReboot");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}/reboot";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonesPhoneIdReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonesPhoneIdReboot: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostProvidersEdgePhonesPhoneIdRebootAsync (string phoneId)
        {
             await PostProvidersEdgePhonesPhoneIdRebootAsyncWithHttpInfo(phoneId);

        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostProvidersEdgePhonesPhoneIdRebootAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling PostProvidersEdgePhonesPhoneIdReboot");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}/reboot";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonesPhoneIdReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgePhonesPhoneIdReboot: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>TimeZoneEntityListing</returns>
        public TimeZoneEntityListing GetProvidersEdgeTimezones (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = GetProvidersEdgeTimezonesWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        public ApiResponse< TimeZoneEntityListing > GetProvidersEdgeTimezonesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/timezones";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTimezones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTimezones: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TimeZoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TimeZoneEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        public async System.Threading.Tasks.Task<TimeZoneEntityListing> GetProvidersEdgeTimezonesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = await GetProvidersEdgeTimezonesAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> GetProvidersEdgeTimezonesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/timezones";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTimezones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTimezones: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TimeZoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TimeZoneEntityListing)));
            
        }
        
        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase GetProvidersEdgeTrunkbasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> response = GetProvidersEdgeTrunkbasesettingsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > GetProvidersEdgeTrunkbasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> response = await GetProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase PostProvidersEdgeTrunkbasesettings (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = PostProvidersEdgeTrunkbasesettingsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > PostProvidersEdgeTrunkbasesettingsWithHttpInfo (TrunkBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> PostProvidersEdgeTrunkbasesettingsAsync (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = await PostProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PostProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (TrunkBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param> 
        /// <param name="pageSize"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>TrunkMetabaseEntityListing</returns>
        public TrunkMetabaseEntityListing GetProvidersEdgeTrunkbasesettingsAvailablemetabases (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> response = GetProvidersEdgeTrunkbasesettingsAvailablemetabasesWithHttpInfo(type, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param> 
        /// <param name="pageSize"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>ApiResponse of TrunkMetabaseEntityListing</returns>
        public ApiResponse< TrunkMetabaseEntityListing > GetProvidersEdgeTrunkbasesettingsAvailablemetabasesWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/availablemetabases";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (type != null) queryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsAvailablemetabases: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsAvailablemetabases: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkMetabaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkMetabaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TrunkMetabaseEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of TrunkMetabaseEntityListing</returns>
        public async System.Threading.Tasks.Task<TrunkMetabaseEntityListing> GetProvidersEdgeTrunkbasesettingsAvailablemetabasesAsync (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> response = await GetProvidersEdgeTrunkbasesettingsAvailablemetabasesAsyncWithHttpInfo(type, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (TrunkMetabaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkMetabaseEntityListing>> GetProvidersEdgeTrunkbasesettingsAvailablemetabasesAsyncWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/availablemetabases";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (type != null) queryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsAvailablemetabases: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsAvailablemetabases: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkMetabaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkMetabaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TrunkMetabaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase GetProvidersEdgeTrunkbasesettingsTemplate (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> response = GetProvidersEdgeTrunkbasesettingsTemplateWithHttpInfo(trunkMetabaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > GetProvidersEdgeTrunkbasesettingsTemplateWithHttpInfo (string trunkMetabaseId)
        {
            
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeTrunkbasesettingsTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/template";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (trunkMetabaseId != null) queryParams.Add("trunkMetabaseId", Configuration.ApiClient.ParameterToString(trunkMetabaseId)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTemplateAsync (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> response = await GetProvidersEdgeTrunkbasesettingsTemplateAsyncWithHttpInfo(trunkMetabaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTemplateAsyncWithHttpInfo (string trunkMetabaseId)
        {
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null) throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling GetProvidersEdgeTrunkbasesettingsTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/template";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (trunkMetabaseId != null) queryParams.Add("trunkMetabaseId", Configuration.ApiClient.ParameterToString(trunkMetabaseId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> response = GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo(trunkBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> response = await GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo(trunkBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <param name="body"></param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo(trunkBaseSettingsId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = await PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo(trunkBaseSettingsId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId)
        {
             ApiResponse<string> response = DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo(trunkBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsync (string trunkBaseSettingsId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo(trunkBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
