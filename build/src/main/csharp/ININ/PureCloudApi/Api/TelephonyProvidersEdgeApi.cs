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
        EdgeGroup CreateProvidersEdgeEdgegroups (EdgeGroup body = null);
  
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> CreateProvidersEdgeEdgegroupsWithHttpInfo (EdgeGroup body = null);

        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> CreateProvidersEdgeEdgegroupsAsync (EdgeGroup body = null);

        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> CreateProvidersEdgeEdgegroupsAsyncWithHttpInfo (EdgeGroup body = null);
        
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup GetProvidersEdgeEdgeGroup (string edgeGroupId);
  
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> GetProvidersEdgeEdgeGroupWithHttpInfo (string edgeGroupId);

        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> GetProvidersEdgeEdgeGroupAsync (string edgeGroupId);

        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> GetProvidersEdgeEdgeGroupAsyncWithHttpInfo (string edgeGroupId);
        
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup UpdateProvidersEdgeEdgeGroup (string edgeGroupId, EdgeGroup body = null);
  
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> UpdateProvidersEdgeEdgeGroupWithHttpInfo (string edgeGroupId, EdgeGroup body = null);

        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> UpdateProvidersEdgeEdgeGroupAsync (string edgeGroupId, EdgeGroup body = null);

        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> UpdateProvidersEdgeEdgeGroupAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null);
        
        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgeEdgeGroup (string edgeGroupId);
  
        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgeEdgeGroupWithHttpInfo (string edgeGroupId);

        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgeEdgeGroupAsync (string edgeGroupId);

        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeEdgeGroupAsyncWithHttpInfo (string edgeGroupId);
        
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
        LineBase GetProvidersEdgeLinebasesettingsLineBase (string lineBaseId);
  
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>ApiResponse of LineBase</returns>
        ApiResponse<LineBase> GetProvidersEdgeLinebasesettingsLineBaseWithHttpInfo (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        System.Threading.Tasks.Task<LineBase> GetProvidersEdgeLinebasesettingsLineBaseAsync (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineBase>> GetProvidersEdgeLinebasesettingsLineBaseAsyncWithHttpInfo (string lineBaseId);
        
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
        Line GetProvidersEdgeLine (string lineId);
  
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> GetProvidersEdgeLineWithHttpInfo (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> GetProvidersEdgeLineAsync (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLineAsyncWithHttpInfo (string lineId);
        
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
        OutboundRoute CreateProvidersEdgeOutboundroutes (OutboundRoute body = null);
  
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> CreateProvidersEdgeOutboundroutesWithHttpInfo (OutboundRoute body = null);

        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> CreateProvidersEdgeOutboundroutesAsync (OutboundRoute body = null);

        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> CreateProvidersEdgeOutboundroutesAsyncWithHttpInfo (OutboundRoute body = null);
        
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute GetProvidersEdgeOutboundRoute (string outboundRouteId);
  
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> GetProvidersEdgeOutboundRouteWithHttpInfo (string outboundRouteId);

        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> GetProvidersEdgeOutboundRouteAsync (string outboundRouteId);

        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> GetProvidersEdgeOutboundRouteAsyncWithHttpInfo (string outboundRouteId);
        
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute UpdateProvidersEdgeOutboundRoute (string outboundRouteId, OutboundRoute body = null);
  
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> UpdateProvidersEdgeOutboundRouteWithHttpInfo (string outboundRouteId, OutboundRoute body = null);

        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> UpdateProvidersEdgeOutboundRouteAsync (string outboundRouteId, OutboundRoute body = null);

        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> UpdateProvidersEdgeOutboundRouteAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null);
        
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgeOutboundRoute (string outboundRouteId);
  
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgeOutboundRouteWithHttpInfo (string outboundRouteId);

        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgeOutboundRouteAsync (string outboundRouteId);

        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeOutboundRouteAsyncWithHttpInfo (string outboundRouteId);
        
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
        PhoneBase CreateProvidersEdgePhonebasesettings (PhoneBase body = null);
  
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> CreateProvidersEdgePhonebasesettingsWithHttpInfo (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> CreateProvidersEdgePhonebasesettingsAsync (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> CreateProvidersEdgePhonebasesettingsAsyncWithHttpInfo (PhoneBase body = null);
        
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
        PhoneBase GetProvidersEdgePhonebasesettingsPhoneBase (string phoneBaseId);
  
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> GetProvidersEdgePhonebasesettingsPhoneBaseWithHttpInfo (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsPhoneBaseAsync (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsPhoneBaseAsyncWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>PhoneBase</returns>
        PhoneBase UpdateProvidersEdgePhonebasesettingsPhoneBase (string phoneBaseId, PhoneBase body = null);
  
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> UpdateProvidersEdgePhonebasesettingsPhoneBaseWithHttpInfo (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> UpdateProvidersEdgePhonebasesettingsPhoneBaseAsync (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> UpdateProvidersEdgePhonebasesettingsPhoneBaseAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null);
        
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgePhonebasesettingsPhoneBase (string phoneBaseId);
  
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgePhonebasesettingsPhoneBaseWithHttpInfo (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonebasesettingsPhoneBaseAsync (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonebasesettingsPhoneBaseAsyncWithHttpInfo (string phoneBaseId);
        
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
        Phone CreateProvidersEdgePhones (Phone body = null);
  
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> CreateProvidersEdgePhonesWithHttpInfo (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> CreateProvidersEdgePhonesAsync (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> CreateProvidersEdgePhonesAsyncWithHttpInfo (Phone body = null);
        
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns></returns>
        void CreateProvidersEdgePhonesReboot (PhonesReboot body = null);
  
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateProvidersEdgePhonesRebootWithHttpInfo (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateProvidersEdgePhonesRebootAsync (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateProvidersEdgePhonesRebootAsyncWithHttpInfo (PhonesReboot body = null);
        
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
        Phone GetProvidersEdgePhone (string phoneId);
  
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> GetProvidersEdgePhoneWithHttpInfo (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> GetProvidersEdgePhoneAsync (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhoneAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Phone</returns>
        Phone UpdateProvidersEdgePhone (string phoneId, Phone body = null);
  
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> UpdateProvidersEdgePhoneWithHttpInfo (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> UpdateProvidersEdgePhoneAsync (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> UpdateProvidersEdgePhoneAsyncWithHttpInfo (string phoneId, Phone body = null);
        
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgePhone (string phoneId);
  
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgePhoneWithHttpInfo (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgePhoneAsync (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhoneAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns></returns>
        void CreateProvidersEdgePhoneReboot (string phoneId);
  
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateProvidersEdgePhoneRebootWithHttpInfo (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateProvidersEdgePhoneRebootAsync (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateProvidersEdgePhoneRebootAsyncWithHttpInfo (string phoneId);
        
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
        TrunkBase CreateProvidersEdgeTrunkbasesettings (TrunkBase body = null);
  
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> CreateProvidersEdgeTrunkbasesettingsWithHttpInfo (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> CreateProvidersEdgeTrunkbasesettingsAsync (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> CreateProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (TrunkBase body = null);
        
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
        TrunkBase GetProvidersEdgeTrunkbasesettingsTrunkBaseSettings (string trunkBaseSettingsId);
  
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> GetProvidersEdgeTrunkbasesettingsTrunkBaseSettingsWithHttpInfo (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsyncWithHttpInfo (string trunkBaseSettingsId);
        
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>TrunkBase</returns>
        TrunkBase UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettings (string trunkBaseSettingsId, TrunkBase body = null);
  
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettingsWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsync (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>string</returns>
        string DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettings (string trunkBaseSettingsId);
  
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettingsWithHttpInfo (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsyncWithHttpInfo (string trunkBaseSettingsId);
        
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
        public EdgeGroup CreateProvidersEdgeEdgegroups (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = CreateProvidersEdgeEdgegroupsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > CreateProvidersEdgeEdgegroupsWithHttpInfo (EdgeGroup body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
    
        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> CreateProvidersEdgeEdgegroupsAsync (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = await CreateProvidersEdgeEdgegroupsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> CreateProvidersEdgeEdgegroupsAsyncWithHttpInfo (EdgeGroup body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>EdgeGroup</returns>
        public EdgeGroup GetProvidersEdgeEdgeGroup (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> response = GetProvidersEdgeEdgeGroupWithHttpInfo(edgeGroupId);
             return response.Data;
        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > GetProvidersEdgeEdgeGroupWithHttpInfo (string edgeGroupId)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling GetProvidersEdgeEdgeGroup");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
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
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgeGroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgeGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
    
        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> GetProvidersEdgeEdgeGroupAsync (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> response = await GetProvidersEdgeEdgeGroupAsyncWithHttpInfo(edgeGroupId);
             return response.Data;

        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> GetProvidersEdgeEdgeGroupAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling GetProvidersEdgeEdgeGroup");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
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
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgeGroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeEdgeGroup: " + response.ErrorMessage, response.ErrorMessage);

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
        public EdgeGroup UpdateProvidersEdgeEdgeGroup (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = UpdateProvidersEdgeEdgeGroupWithHttpInfo(edgeGroupId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <param name="body">EdgeGroup</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > UpdateProvidersEdgeEdgeGroupWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling UpdateProvidersEdgeEdgeGroup");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
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
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeEdgeGroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeEdgeGroup: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeGroup> UpdateProvidersEdgeEdgeGroupAsync (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = await UpdateProvidersEdgeEdgeGroupAsyncWithHttpInfo(edgeGroupId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> UpdateProvidersEdgeEdgeGroupAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling UpdateProvidersEdgeEdgeGroup");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
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
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeEdgeGroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeEdgeGroup: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgeEdgeGroup (string edgeGroupId)
        {
             ApiResponse<string> response = DeleteProvidersEdgeEdgeGroupWithHttpInfo(edgeGroupId);
             return response.Data;
        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgeEdgeGroupWithHttpInfo (string edgeGroupId)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling DeleteProvidersEdgeEdgeGroup");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
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
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeEdgeGroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeEdgeGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgeEdgeGroupAsync (string edgeGroupId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgeEdgeGroupAsyncWithHttpInfo(edgeGroupId);
             return response.Data;

        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeEdgeGroupAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling DeleteProvidersEdgeEdgeGroup");
            
    
            var path_ = "/api/v1/telephony/providers/edge/edgegroups/{edgeGroupId}";
    
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
            if (edgeGroupId != null) pathParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeEdgeGroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeEdgeGroup: " + response.ErrorMessage, response.ErrorMessage);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
        public LineBase GetProvidersEdgeLinebasesettingsLineBase (string lineBaseId)
        {
             ApiResponse<LineBase> response = GetProvidersEdgeLinebasesettingsLineBaseWithHttpInfo(lineBaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param> 
        /// <returns>ApiResponse of LineBase</returns>
        public ApiResponse< LineBase > GetProvidersEdgeLinebasesettingsLineBaseWithHttpInfo (string lineBaseId)
        {
            
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null) throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling GetProvidersEdgeLinebasesettingsLineBase");
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings/{lineBaseId}";
    
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
            if (lineBaseId != null) pathParams.Add("lineBaseId", Configuration.ApiClient.ParameterToString(lineBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettingsLineBase: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettingsLineBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LineBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBase) Configuration.ApiClient.Deserialize(response, typeof(LineBase)));
            
        }
    
        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        public async System.Threading.Tasks.Task<LineBase> GetProvidersEdgeLinebasesettingsLineBaseAsync (string lineBaseId)
        {
             ApiResponse<LineBase> response = await GetProvidersEdgeLinebasesettingsLineBaseAsyncWithHttpInfo(lineBaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBase>> GetProvidersEdgeLinebasesettingsLineBaseAsyncWithHttpInfo (string lineBaseId)
        {
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null) throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling GetProvidersEdgeLinebasesettingsLineBase");
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings/{lineBaseId}";
    
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
            if (lineBaseId != null) pathParams.Add("lineBaseId", Configuration.ApiClient.ParameterToString(lineBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettingsLineBase: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLinebasesettingsLineBase: " + response.ErrorMessage, response.ErrorMessage);

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
            if (lineBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling GetProvidersEdgeLinesTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/template";
    
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
            
            if (lineBaseSettingsId != null) queryParams.Add("lineBaseSettingsId", Configuration.ApiClient.ParameterToString(lineBaseSettingsId)); // query parameter
            
            
            
            

            
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
            
            if (lineBaseSettingsId != null) queryParams.Add("lineBaseSettingsId", Configuration.ApiClient.ParameterToString(lineBaseSettingsId)); // query parameter
            
            
            
            

            
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
        public Line GetProvidersEdgeLine (string lineId)
        {
             ApiResponse<Line> response = GetProvidersEdgeLineWithHttpInfo(lineId);
             return response.Data;
        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param> 
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > GetProvidersEdgeLineWithHttpInfo (string lineId)
        {
            
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetProvidersEdgeLine");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/{lineId}";
    
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLine: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLine: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
    
        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        public async System.Threading.Tasks.Task<Line> GetProvidersEdgeLineAsync (string lineId)
        {
             ApiResponse<Line> response = await GetProvidersEdgeLineAsyncWithHttpInfo(lineId);
             return response.Data;

        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> GetProvidersEdgeLineAsyncWithHttpInfo (string lineId)
        {
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetProvidersEdgeLine");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/{lineId}";
    
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLine: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeLine: " + response.ErrorMessage, response.ErrorMessage);

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
        public OutboundRoute CreateProvidersEdgeOutboundroutes (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = CreateProvidersEdgeOutboundroutesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > CreateProvidersEdgeOutboundroutesWithHttpInfo (OutboundRoute body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
    
        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> CreateProvidersEdgeOutboundroutesAsync (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = await CreateProvidersEdgeOutboundroutesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> CreateProvidersEdgeOutboundroutesAsyncWithHttpInfo (OutboundRoute body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>OutboundRoute</returns>
        public OutboundRoute GetProvidersEdgeOutboundRoute (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> response = GetProvidersEdgeOutboundRouteWithHttpInfo(outboundRouteId);
             return response.Data;
        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > GetProvidersEdgeOutboundRouteWithHttpInfo (string outboundRouteId)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling GetProvidersEdgeOutboundRoute");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
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
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundRoute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundRoute: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
    
        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> GetProvidersEdgeOutboundRouteAsync (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> response = await GetProvidersEdgeOutboundRouteAsyncWithHttpInfo(outboundRouteId);
             return response.Data;

        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> GetProvidersEdgeOutboundRouteAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling GetProvidersEdgeOutboundRoute");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
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
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundRoute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeOutboundRoute: " + response.ErrorMessage, response.ErrorMessage);

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
        public OutboundRoute UpdateProvidersEdgeOutboundRoute (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = UpdateProvidersEdgeOutboundRouteWithHttpInfo(outboundRouteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <param name="body">OutboundRoute</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > UpdateProvidersEdgeOutboundRouteWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling UpdateProvidersEdgeOutboundRoute");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
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
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeOutboundRoute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeOutboundRoute: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OutboundRoute> UpdateProvidersEdgeOutboundRouteAsync (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = await UpdateProvidersEdgeOutboundRouteAsyncWithHttpInfo(outboundRouteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> UpdateProvidersEdgeOutboundRouteAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling UpdateProvidersEdgeOutboundRoute");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
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
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeOutboundRoute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeOutboundRoute: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgeOutboundRoute (string outboundRouteId)
        {
             ApiResponse<string> response = DeleteProvidersEdgeOutboundRouteWithHttpInfo(outboundRouteId);
             return response.Data;
        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgeOutboundRouteWithHttpInfo (string outboundRouteId)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling DeleteProvidersEdgeOutboundRoute");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
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
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeOutboundRoute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeOutboundRoute: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgeOutboundRouteAsync (string outboundRouteId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgeOutboundRouteAsyncWithHttpInfo(outboundRouteId);
             return response.Data;

        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeOutboundRouteAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling DeleteProvidersEdgeOutboundRoute");
            
    
            var path_ = "/api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId}";
    
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
            if (outboundRouteId != null) pathParams.Add("outboundRouteId", Configuration.ApiClient.ParameterToString(outboundRouteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeOutboundRoute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeOutboundRoute: " + response.ErrorMessage, response.ErrorMessage);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
        public PhoneBase CreateProvidersEdgePhonebasesettings (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = CreateProvidersEdgePhonebasesettingsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > CreateProvidersEdgePhonebasesettingsWithHttpInfo (PhoneBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> CreateProvidersEdgePhonebasesettingsAsync (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = await CreateProvidersEdgePhonebasesettingsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> CreateProvidersEdgePhonebasesettingsAsyncWithHttpInfo (PhoneBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);

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
            if (phoneMetabaseId == null) throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling GetProvidersEdgePhonebasesettingsTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/template";
    
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
            
            if (phoneMetabaseId != null) queryParams.Add("phoneMetabaseId", Configuration.ApiClient.ParameterToString(phoneMetabaseId)); // query parameter
            
            
            
            

            
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
            
            if (phoneMetabaseId != null) queryParams.Add("phoneMetabaseId", Configuration.ApiClient.ParameterToString(phoneMetabaseId)); // query parameter
            
            
            
            

            
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
        public PhoneBase GetProvidersEdgePhonebasesettingsPhoneBase (string phoneBaseId)
        {
             ApiResponse<PhoneBase> response = GetProvidersEdgePhonebasesettingsPhoneBaseWithHttpInfo(phoneBaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > GetProvidersEdgePhonebasesettingsPhoneBaseWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling GetProvidersEdgePhonebasesettingsPhoneBase");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsPhoneBase: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsPhoneBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> GetProvidersEdgePhonebasesettingsPhoneBaseAsync (string phoneBaseId)
        {
             ApiResponse<PhoneBase> response = await GetProvidersEdgePhonebasesettingsPhoneBaseAsyncWithHttpInfo(phoneBaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetProvidersEdgePhonebasesettingsPhoneBaseAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling GetProvidersEdgePhonebasesettingsPhoneBase");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsPhoneBase: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhonebasesettingsPhoneBase: " + response.ErrorMessage, response.ErrorMessage);

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
        public PhoneBase UpdateProvidersEdgePhonebasesettingsPhoneBase (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = UpdateProvidersEdgePhonebasesettingsPhoneBaseWithHttpInfo(phoneBaseId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > UpdateProvidersEdgePhonebasesettingsPhoneBaseWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling UpdateProvidersEdgePhonebasesettingsPhoneBase");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgePhonebasesettingsPhoneBase: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgePhonebasesettingsPhoneBase: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PhoneBase> UpdateProvidersEdgePhonebasesettingsPhoneBaseAsync (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = await UpdateProvidersEdgePhonebasesettingsPhoneBaseAsyncWithHttpInfo(phoneBaseId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> UpdateProvidersEdgePhonebasesettingsPhoneBaseAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling UpdateProvidersEdgePhonebasesettingsPhoneBase");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgePhonebasesettingsPhoneBase: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgePhonebasesettingsPhoneBase: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgePhonebasesettingsPhoneBase (string phoneBaseId)
        {
             ApiResponse<string> response = DeleteProvidersEdgePhonebasesettingsPhoneBaseWithHttpInfo(phoneBaseId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgePhonebasesettingsPhoneBaseWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling DeleteProvidersEdgePhonebasesettingsPhoneBase");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhoneBase: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhoneBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgePhonebasesettingsPhoneBaseAsync (string phoneBaseId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgePhonebasesettingsPhoneBaseAsyncWithHttpInfo(phoneBaseId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhonebasesettingsPhoneBaseAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling DeleteProvidersEdgePhonebasesettingsPhoneBase");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhoneBase: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhonebasesettingsPhoneBase: " + response.ErrorMessage, response.ErrorMessage);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
        public Phone CreateProvidersEdgePhones (Phone body = null)
        {
             ApiResponse<Phone> response = CreateProvidersEdgePhonesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > CreateProvidersEdgePhonesWithHttpInfo (Phone body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> CreateProvidersEdgePhonesAsync (Phone body = null)
        {
             ApiResponse<Phone> response = await CreateProvidersEdgePhonesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> CreateProvidersEdgePhonesAsyncWithHttpInfo (Phone body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param> 
        /// <returns></returns>
        public void CreateProvidersEdgePhonesReboot (PhonesReboot body = null)
        {
             CreateProvidersEdgePhonesRebootWithHttpInfo(body);
        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateProvidersEdgePhonesRebootWithHttpInfo (PhonesReboot body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/reboot";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhonesReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhonesReboot: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateProvidersEdgePhonesRebootAsync (PhonesReboot body = null)
        {
             await CreateProvidersEdgePhonesRebootAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateProvidersEdgePhonesRebootAsyncWithHttpInfo (PhonesReboot body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/reboot";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhonesReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhonesReboot: " + response.ErrorMessage, response.ErrorMessage);

            
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
            if (phoneBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling GetProvidersEdgePhonesTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/template";
    
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
            
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettingsId", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            
            
            
            

            
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
            
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettingsId", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            
            
            
            

            
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
        public Phone GetProvidersEdgePhone (string phoneId)
        {
             ApiResponse<Phone> response = GetProvidersEdgePhoneWithHttpInfo(phoneId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > GetProvidersEdgePhoneWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling GetProvidersEdgePhone");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> GetProvidersEdgePhoneAsync (string phoneId)
        {
             ApiResponse<Phone> response = await GetProvidersEdgePhoneAsyncWithHttpInfo(phoneId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> GetProvidersEdgePhoneAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling GetProvidersEdgePhone");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);

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
        public Phone UpdateProvidersEdgePhone (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> response = UpdateProvidersEdgePhoneWithHttpInfo(phoneId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > UpdateProvidersEdgePhoneWithHttpInfo (string phoneId, Phone body = null)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling UpdateProvidersEdgePhone");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Phone> UpdateProvidersEdgePhoneAsync (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> response = await UpdateProvidersEdgePhoneAsyncWithHttpInfo(phoneId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> UpdateProvidersEdgePhoneAsyncWithHttpInfo (string phoneId, Phone body = null)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling UpdateProvidersEdgePhone");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgePhone (string phoneId)
        {
             ApiResponse<string> response = DeleteProvidersEdgePhoneWithHttpInfo(phoneId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgePhoneWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling DeleteProvidersEdgePhone");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgePhoneAsync (string phoneId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgePhoneAsyncWithHttpInfo(phoneId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgePhoneAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling DeleteProvidersEdgePhone");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param> 
        /// <returns></returns>
        public void CreateProvidersEdgePhoneReboot (string phoneId)
        {
             CreateProvidersEdgePhoneRebootWithHttpInfo(phoneId);
        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateProvidersEdgePhoneRebootWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling CreateProvidersEdgePhoneReboot");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}/reboot";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhoneReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhoneReboot: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateProvidersEdgePhoneRebootAsync (string phoneId)
        {
             await CreateProvidersEdgePhoneRebootAsyncWithHttpInfo(phoneId);

        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateProvidersEdgePhoneRebootAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling CreateProvidersEdgePhoneReboot");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}/reboot";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhoneReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgePhoneReboot: " + response.ErrorMessage, response.ErrorMessage);

            
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
        public TrunkBase CreateProvidersEdgeTrunkbasesettings (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = CreateProvidersEdgeTrunkbasesettingsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > CreateProvidersEdgeTrunkbasesettingsWithHttpInfo (TrunkBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> CreateProvidersEdgeTrunkbasesettingsAsync (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = await CreateProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> CreateProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (TrunkBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
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
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

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
            if (trunkMetabaseId == null) throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling GetProvidersEdgeTrunkbasesettingsTemplate");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/template";
    
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
            
            if (trunkMetabaseId != null) queryParams.Add("trunkMetabaseId", Configuration.ApiClient.ParameterToString(trunkMetabaseId)); // query parameter
            
            
            
            

            
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
            
            if (trunkMetabaseId != null) queryParams.Add("trunkMetabaseId", Configuration.ApiClient.ParameterToString(trunkMetabaseId)); // query parameter
            
            
            
            

            
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
        public TrunkBase GetProvidersEdgeTrunkbasesettingsTrunkBaseSettings (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> response = GetProvidersEdgeTrunkbasesettingsTrunkBaseSettingsWithHttpInfo(trunkBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > GetProvidersEdgeTrunkbasesettingsTrunkBaseSettingsWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling GetProvidersEdgeTrunkbasesettingsTrunkBaseSettings");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> GetProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsync (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> response = await GetProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsyncWithHttpInfo(trunkBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling GetProvidersEdgeTrunkbasesettingsTrunkBaseSettings");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.ErrorMessage, response.ErrorMessage);

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
        public TrunkBase UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettings (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettingsWithHttpInfo(trunkBaseSettingsId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettingsWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettings");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TrunkBase> UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsync (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = await UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsyncWithHttpInfo(trunkBaseSettingsId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettings");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>string</returns>
        public string DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettings (string trunkBaseSettingsId)
        {
             ApiResponse<string> response = DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettingsWithHttpInfo(trunkBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettingsWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettings");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsync (string trunkBaseSettingsId)
        {
             ApiResponse<string> response = await DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsyncWithHttpInfo(trunkBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettingsAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettings");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteProvidersEdgeTrunkbasesettingsTrunkBaseSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
