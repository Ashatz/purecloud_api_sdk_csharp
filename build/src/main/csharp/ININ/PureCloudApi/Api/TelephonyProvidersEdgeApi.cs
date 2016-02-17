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
        EdgeGroupEntityListing GetTelephonyProvidersEdgeEdgegroups (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
  
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
        ApiResponse<EdgeGroupEntityListing> GetTelephonyProvidersEdgeEdgegroupsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

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
        System.Threading.Tasks.Task<EdgeGroupEntityListing> GetTelephonyProvidersEdgeEdgegroupsAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

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
        System.Threading.Tasks.Task<ApiResponse<EdgeGroupEntityListing>> GetTelephonyProvidersEdgeEdgegroupsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup PostTelephonyProvidersEdgeEdgegroups (EdgeGroup body = null);
  
        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> PostTelephonyProvidersEdgeEdgegroupsWithHttpInfo (EdgeGroup body = null);

        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> PostTelephonyProvidersEdgeEdgegroupsAsync (EdgeGroup body = null);

        /// <summary>
        /// Create an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PostTelephonyProvidersEdgeEdgegroupsAsyncWithHttpInfo (EdgeGroup body = null);
        
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup GetTelephonyProvidersEdgeEdgegroup (string edgeGroupId);
  
        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> GetTelephonyProvidersEdgeEdgegroupWithHttpInfo (string edgeGroupId);

        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> GetTelephonyProvidersEdgeEdgegroupAsync (string edgeGroupId);

        /// <summary>
        /// Get edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> GetTelephonyProvidersEdgeEdgegroupAsyncWithHttpInfo (string edgeGroupId);
        
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>EdgeGroup</returns>
        EdgeGroup PutTelephonyProvidersEdgeEdgegroup (string edgeGroupId, EdgeGroup body = null);
  
        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>ApiResponse of EdgeGroup</returns>
        ApiResponse<EdgeGroup> PutTelephonyProvidersEdgeEdgegroupWithHttpInfo (string edgeGroupId, EdgeGroup body = null);

        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        System.Threading.Tasks.Task<EdgeGroup> PutTelephonyProvidersEdgeEdgegroupAsync (string edgeGroupId, EdgeGroup body = null);

        /// <summary>
        /// Update an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PutTelephonyProvidersEdgeEdgegroupAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null);
        
        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>string</returns>
        string DeleteTelephonyProvidersEdgeEdgegroup (string edgeGroupId);
  
        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteTelephonyProvidersEdgeEdgegroupWithHttpInfo (string edgeGroupId);

        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgeEdgegroupAsync (string edgeGroupId);

        /// <summary>
        /// Delete an edge group.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgeEdgegroupAsyncWithHttpInfo (string edgeGroupId);
        
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
        LineBaseEntityListing GetTelephonyProvidersEdgeLinebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<LineBaseEntityListing> GetTelephonyProvidersEdgeLinebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<LineBaseEntityListing> GetTelephonyProvidersEdgeLinebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<LineBaseEntityListing>> GetTelephonyProvidersEdgeLinebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>LineBase</returns>
        LineBase GetTelephonyProvidersEdgeLinebasesetting (string lineBaseId);
  
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>ApiResponse of LineBase</returns>
        ApiResponse<LineBase> GetTelephonyProvidersEdgeLinebasesettingWithHttpInfo (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        System.Threading.Tasks.Task<LineBase> GetTelephonyProvidersEdgeLinebasesettingAsync (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineBase>> GetTelephonyProvidersEdgeLinebasesettingAsyncWithHttpInfo (string lineBaseId);
        
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
        LineEntityListing GetTelephonyProvidersEdgeLines (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
  
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
        ApiResponse<LineEntityListing> GetTelephonyProvidersEdgeLinesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);

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
        System.Threading.Tasks.Task<LineEntityListing> GetTelephonyProvidersEdgeLinesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> GetTelephonyProvidersEdgeLinesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
        
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Line</returns>
        Line GetTelephonyProvidersEdgeLinesTemplate (string lineBaseSettingsId);
  
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> GetTelephonyProvidersEdgeLinesTemplateWithHttpInfo (string lineBaseSettingsId);

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> GetTelephonyProvidersEdgeLinesTemplateAsync (string lineBaseSettingsId);

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> GetTelephonyProvidersEdgeLinesTemplateAsyncWithHttpInfo (string lineBaseSettingsId);
        
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Line</returns>
        Line GetTelephonyProvidersEdgeLine (string lineId);
  
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> GetTelephonyProvidersEdgeLineWithHttpInfo (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> GetTelephonyProvidersEdgeLineAsync (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> GetTelephonyProvidersEdgeLineAsyncWithHttpInfo (string lineId);
        
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
        OutboundRouteEntityListing GetTelephonyProvidersEdgeOutboundroutes (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);
  
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
        ApiResponse<OutboundRouteEntityListing> GetTelephonyProvidersEdgeOutboundroutesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);

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
        System.Threading.Tasks.Task<OutboundRouteEntityListing> GetTelephonyProvidersEdgeOutboundroutesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);

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
        System.Threading.Tasks.Task<ApiResponse<OutboundRouteEntityListing>> GetTelephonyProvidersEdgeOutboundroutesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null);
        
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute PostTelephonyProvidersEdgeOutboundroutes (OutboundRoute body = null);
  
        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> PostTelephonyProvidersEdgeOutboundroutesWithHttpInfo (OutboundRoute body = null);

        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> PostTelephonyProvidersEdgeOutboundroutesAsync (OutboundRoute body = null);

        /// <summary>
        /// Create outbound rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PostTelephonyProvidersEdgeOutboundroutesAsyncWithHttpInfo (OutboundRoute body = null);
        
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute GetTelephonyProvidersEdgeOutboundroute (string outboundRouteId);
  
        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> GetTelephonyProvidersEdgeOutboundrouteWithHttpInfo (string outboundRouteId);

        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> GetTelephonyProvidersEdgeOutboundrouteAsync (string outboundRouteId);

        /// <summary>
        /// Get outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> GetTelephonyProvidersEdgeOutboundrouteAsyncWithHttpInfo (string outboundRouteId);
        
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>OutboundRoute</returns>
        OutboundRoute PutTelephonyProvidersEdgeOutboundroute (string outboundRouteId, OutboundRoute body = null);
  
        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>ApiResponse of OutboundRoute</returns>
        ApiResponse<OutboundRoute> PutTelephonyProvidersEdgeOutboundrouteWithHttpInfo (string outboundRouteId, OutboundRoute body = null);

        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        System.Threading.Tasks.Task<OutboundRoute> PutTelephonyProvidersEdgeOutboundrouteAsync (string outboundRouteId, OutboundRoute body = null);

        /// <summary>
        /// Update outbound route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PutTelephonyProvidersEdgeOutboundrouteAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null);
        
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>string</returns>
        string DeleteTelephonyProvidersEdgeOutboundroute (string outboundRouteId);
  
        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteTelephonyProvidersEdgeOutboundrouteWithHttpInfo (string outboundRouteId);

        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgeOutboundrouteAsync (string outboundRouteId);

        /// <summary>
        /// Delete Outbound Route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgeOutboundrouteAsyncWithHttpInfo (string outboundRouteId);
        
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
        PhoneBaseEntityListing GetTelephonyProvidersEdgePhonebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<PhoneBaseEntityListing> GetTelephonyProvidersEdgePhonebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<PhoneBaseEntityListing> GetTelephonyProvidersEdgePhonebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> GetTelephonyProvidersEdgePhonebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>PhoneBase</returns>
        PhoneBase PostTelephonyProvidersEdgePhonebasesettings (PhoneBase body = null);
  
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> PostTelephonyProvidersEdgePhonebasesettingsWithHttpInfo (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> PostTelephonyProvidersEdgePhonebasesettingsAsync (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PostTelephonyProvidersEdgePhonebasesettingsAsyncWithHttpInfo (PhoneBase body = null);
        
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>PhoneMetaBaseEntityListing</returns>
        PhoneMetaBaseEntityListing GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabases (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        ApiResponse<PhoneMetaBaseEntityListing> GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabasesWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of PhoneMetaBaseEntityListing</returns>
        System.Threading.Tasks.Task<PhoneMetaBaseEntityListing> GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabasesAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabasesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>PhoneBase</returns>
        PhoneBase GetTelephonyProvidersEdgePhonebasesettingsTemplate (string phoneMetabaseId);
  
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> GetTelephonyProvidersEdgePhonebasesettingsTemplateWithHttpInfo (string phoneMetabaseId);

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> GetTelephonyProvidersEdgePhonebasesettingsTemplateAsync (string phoneMetabaseId);

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetTelephonyProvidersEdgePhonebasesettingsTemplateAsyncWithHttpInfo (string phoneMetabaseId);
        
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>PhoneBase</returns>
        PhoneBase GetTelephonyProvidersEdgePhonebasesetting (string phoneBaseId);
  
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> GetTelephonyProvidersEdgePhonebasesettingWithHttpInfo (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> GetTelephonyProvidersEdgePhonebasesettingAsync (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetTelephonyProvidersEdgePhonebasesettingAsyncWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>PhoneBase</returns>
        PhoneBase PutTelephonyProvidersEdgePhonebasesetting (string phoneBaseId, PhoneBase body = null);
  
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> PutTelephonyProvidersEdgePhonebasesettingWithHttpInfo (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> PutTelephonyProvidersEdgePhonebasesettingAsync (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PutTelephonyProvidersEdgePhonebasesettingAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null);
        
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>string</returns>
        string DeleteTelephonyProvidersEdgePhonebasesetting (string phoneBaseId);
  
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteTelephonyProvidersEdgePhonebasesettingWithHttpInfo (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgePhonebasesettingAsync (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgePhonebasesettingAsyncWithHttpInfo (string phoneBaseId);
        
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
        PhoneEntityListing GetTelephonyProvidersEdgePhones (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);
  
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
        ApiResponse<PhoneEntityListing> GetTelephonyProvidersEdgePhonesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);

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
        System.Threading.Tasks.Task<PhoneEntityListing> GetTelephonyProvidersEdgePhonesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);

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
        System.Threading.Tasks.Task<ApiResponse<PhoneEntityListing>> GetTelephonyProvidersEdgePhonesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);
        
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Phone</returns>
        Phone PostTelephonyProvidersEdgePhones (Phone body = null);
  
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> PostTelephonyProvidersEdgePhonesWithHttpInfo (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> PostTelephonyProvidersEdgePhonesAsync (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> PostTelephonyProvidersEdgePhonesAsyncWithHttpInfo (Phone body = null);
        
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns></returns>
        void PostTelephonyProvidersEdgePhonesReboot (PhonesReboot body = null);
  
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostTelephonyProvidersEdgePhonesRebootWithHttpInfo (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostTelephonyProvidersEdgePhonesRebootAsync (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyProvidersEdgePhonesRebootAsyncWithHttpInfo (PhonesReboot body = null);
        
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Phone</returns>
        Phone GetTelephonyProvidersEdgePhonesTemplate (string phoneBaseSettingsId);
  
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> GetTelephonyProvidersEdgePhonesTemplateWithHttpInfo (string phoneBaseSettingsId);

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> GetTelephonyProvidersEdgePhonesTemplateAsync (string phoneBaseSettingsId);

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> GetTelephonyProvidersEdgePhonesTemplateAsyncWithHttpInfo (string phoneBaseSettingsId);
        
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Phone</returns>
        Phone GetTelephonyProvidersEdgePhone (string phoneId);
  
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> GetTelephonyProvidersEdgePhoneWithHttpInfo (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> GetTelephonyProvidersEdgePhoneAsync (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> GetTelephonyProvidersEdgePhoneAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Phone</returns>
        Phone PutTelephonyProvidersEdgePhone (string phoneId, Phone body = null);
  
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> PutTelephonyProvidersEdgePhoneWithHttpInfo (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> PutTelephonyProvidersEdgePhoneAsync (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> PutTelephonyProvidersEdgePhoneAsyncWithHttpInfo (string phoneId, Phone body = null);
        
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>string</returns>
        string DeleteTelephonyProvidersEdgePhone (string phoneId);
  
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteTelephonyProvidersEdgePhoneWithHttpInfo (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgePhoneAsync (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgePhoneAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns></returns>
        void PostTelephonyProvidersEdgePhoneReboot (string phoneId);
  
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostTelephonyProvidersEdgePhoneRebootWithHttpInfo (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostTelephonyProvidersEdgePhoneRebootAsync (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyProvidersEdgePhoneRebootAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>TimeZoneEntityListing</returns>
        TimeZoneEntityListing GetTelephonyProvidersEdgeTimezones (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        ApiResponse<TimeZoneEntityListing> GetTelephonyProvidersEdgeTimezonesWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        System.Threading.Tasks.Task<TimeZoneEntityListing> GetTelephonyProvidersEdgeTimezonesAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> GetTelephonyProvidersEdgeTimezonesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
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
        TrunkBase GetTelephonyProvidersEdgeTrunkbasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<TrunkBase> GetTelephonyProvidersEdgeTrunkbasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<TrunkBase> GetTelephonyProvidersEdgeTrunkbasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetTelephonyProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>TrunkBase</returns>
        TrunkBase PostTelephonyProvidersEdgeTrunkbasesettings (TrunkBase body = null);
  
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> PostTelephonyProvidersEdgeTrunkbasesettingsWithHttpInfo (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> PostTelephonyProvidersEdgeTrunkbasesettingsAsync (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PostTelephonyProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (TrunkBase body = null);
        
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
        TrunkMetabaseEntityListing GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabases (string type = null, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<TrunkMetabaseEntityListing> GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<TrunkMetabaseEntityListing> GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesAsync (string type = null, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<TrunkMetabaseEntityListing>> GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesAsyncWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>TrunkBase</returns>
        TrunkBase GetTelephonyProvidersEdgeTrunkbasesettingsTemplate (string trunkMetabaseId);
  
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> GetTelephonyProvidersEdgeTrunkbasesettingsTemplateWithHttpInfo (string trunkMetabaseId);

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> GetTelephonyProvidersEdgeTrunkbasesettingsTemplateAsync (string trunkMetabaseId);

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetTelephonyProvidersEdgeTrunkbasesettingsTemplateAsyncWithHttpInfo (string trunkMetabaseId);
        
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>TrunkBase</returns>
        TrunkBase GetTelephonyProvidersEdgeTrunkbasesetting (string trunkBaseSettingsId);
  
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> GetTelephonyProvidersEdgeTrunkbasesettingWithHttpInfo (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> GetTelephonyProvidersEdgeTrunkbasesettingAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetTelephonyProvidersEdgeTrunkbasesettingAsyncWithHttpInfo (string trunkBaseSettingsId);
        
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>TrunkBase</returns>
        TrunkBase PutTelephonyProvidersEdgeTrunkbasesetting (string trunkBaseSettingsId, TrunkBase body = null);
  
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> PutTelephonyProvidersEdgeTrunkbasesettingWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> PutTelephonyProvidersEdgeTrunkbasesettingAsync (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PutTelephonyProvidersEdgeTrunkbasesettingAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>string</returns>
        string DeleteTelephonyProvidersEdgeTrunkbasesetting (string trunkBaseSettingsId);
  
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteTelephonyProvidersEdgeTrunkbasesettingWithHttpInfo (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgeTrunkbasesettingAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgeTrunkbasesettingAsyncWithHttpInfo (string trunkBaseSettingsId);
        
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
        public EdgeGroupEntityListing GetTelephonyProvidersEdgeEdgegroups (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EdgeGroupEntityListing> response = GetTelephonyProvidersEdgeEdgegroupsWithHttpInfo(pageSize, pageNumber, name, sortBy);
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
        public ApiResponse< EdgeGroupEntityListing > GetTelephonyProvidersEdgeEdgegroupsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeGroupEntityListing> GetTelephonyProvidersEdgeEdgegroupsAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EdgeGroupEntityListing> response = await GetTelephonyProvidersEdgeEdgegroupsAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy);
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
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroupEntityListing>> GetTelephonyProvidersEdgeEdgegroupsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeGroupEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroupEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroupEntityListing)));
            
        }
        
        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param> 
        /// <returns>EdgeGroup</returns>
        public EdgeGroup PostTelephonyProvidersEdgeEdgegroups (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = PostTelephonyProvidersEdgeEdgegroupsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > PostTelephonyProvidersEdgeEdgegroupsWithHttpInfo (EdgeGroup body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
    
        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> PostTelephonyProvidersEdgeEdgegroupsAsync (EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = await PostTelephonyProvidersEdgeEdgegroupsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an edge group. 
        /// </summary>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PostTelephonyProvidersEdgeEdgegroupsAsyncWithHttpInfo (EdgeGroup body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeEdgegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeEdgegroups: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>EdgeGroup</returns>
        public EdgeGroup GetTelephonyProvidersEdgeEdgegroup (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> response = GetTelephonyProvidersEdgeEdgegroupWithHttpInfo(edgeGroupId);
             return response.Data;
        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > GetTelephonyProvidersEdgeEdgegroupWithHttpInfo (string edgeGroupId)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgeEdgegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeEdgegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeEdgegroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
    
        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of EdgeGroup</returns>
        public async System.Threading.Tasks.Task<EdgeGroup> GetTelephonyProvidersEdgeEdgegroupAsync (string edgeGroupId)
        {
             ApiResponse<EdgeGroup> response = await GetTelephonyProvidersEdgeEdgegroupAsyncWithHttpInfo(edgeGroupId);
             return response.Data;

        }

        /// <summary>
        /// Get edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> GetTelephonyProvidersEdgeEdgegroupAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling GetTelephonyProvidersEdgeEdgegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeEdgegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeEdgegroup: " + response.ErrorMessage, response.ErrorMessage);

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
        public EdgeGroup PutTelephonyProvidersEdgeEdgegroup (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = PutTelephonyProvidersEdgeEdgegroupWithHttpInfo(edgeGroupId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <param name="body">EdgeGroup</param> 
        /// <returns>ApiResponse of EdgeGroup</returns>
        public ApiResponse< EdgeGroup > PutTelephonyProvidersEdgeEdgegroupWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->PutTelephonyProvidersEdgeEdgegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeEdgegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeEdgegroup: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EdgeGroup> PutTelephonyProvidersEdgeEdgegroupAsync (string edgeGroupId, EdgeGroup body = null)
        {
             ApiResponse<EdgeGroup> response = await PutTelephonyProvidersEdgeEdgegroupAsyncWithHttpInfo(edgeGroupId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="body">EdgeGroup</param>
        /// <returns>Task of ApiResponse (EdgeGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeGroup>> PutTelephonyProvidersEdgeEdgegroupAsyncWithHttpInfo (string edgeGroupId, EdgeGroup body = null)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling PutTelephonyProvidersEdgeEdgegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeEdgegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeEdgegroup: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EdgeGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeGroup) Configuration.ApiClient.Deserialize(response, typeof(EdgeGroup)));
            
        }
        
        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>string</returns>
        public string DeleteTelephonyProvidersEdgeEdgegroup (string edgeGroupId)
        {
             ApiResponse<string> response = DeleteTelephonyProvidersEdgeEdgegroupWithHttpInfo(edgeGroupId);
             return response.Data;
        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteTelephonyProvidersEdgeEdgegroupWithHttpInfo (string edgeGroupId)
        {
            
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null)
                throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling TelephonyProvidersEdgeApi->DeleteTelephonyProvidersEdgeEdgegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeEdgegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeEdgegroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgeEdgegroupAsync (string edgeGroupId)
        {
             ApiResponse<string> response = await DeleteTelephonyProvidersEdgeEdgegroupAsyncWithHttpInfo(edgeGroupId);
             return response.Data;

        }

        /// <summary>
        /// Delete an edge group. 
        /// </summary>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgeEdgegroupAsyncWithHttpInfo (string edgeGroupId)
        {
            // verify the required parameter 'edgeGroupId' is set
            if (edgeGroupId == null) throw new ApiException(400, "Missing required parameter 'edgeGroupId' when calling DeleteTelephonyProvidersEdgeEdgegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeEdgegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeEdgegroup: " + response.ErrorMessage, response.ErrorMessage);

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
        public LineBaseEntityListing GetTelephonyProvidersEdgeLinebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> response = GetTelephonyProvidersEdgeLinebasesettingsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< LineBaseEntityListing > GetTelephonyProvidersEdgeLinebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinebasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<LineBaseEntityListing> GetTelephonyProvidersEdgeLinebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> response = await GetTelephonyProvidersEdgeLinebasesettingsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<LineBaseEntityListing>> GetTelephonyProvidersEdgeLinebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinebasesettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LineBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param> 
        /// <returns>LineBase</returns>
        public LineBase GetTelephonyProvidersEdgeLinebasesetting (string lineBaseId)
        {
             ApiResponse<LineBase> response = GetTelephonyProvidersEdgeLinebasesettingWithHttpInfo(lineBaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param> 
        /// <returns>ApiResponse of LineBase</returns>
        public ApiResponse< LineBase > GetTelephonyProvidersEdgeLinebasesettingWithHttpInfo (string lineBaseId)
        {
            
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgeLinebasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinebasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinebasesetting: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LineBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBase) Configuration.ApiClient.Deserialize(response, typeof(LineBase)));
            
        }
    
        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        public async System.Threading.Tasks.Task<LineBase> GetTelephonyProvidersEdgeLinebasesettingAsync (string lineBaseId)
        {
             ApiResponse<LineBase> response = await GetTelephonyProvidersEdgeLinebasesettingAsyncWithHttpInfo(lineBaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBase>> GetTelephonyProvidersEdgeLinebasesettingAsyncWithHttpInfo (string lineBaseId)
        {
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null) throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling GetTelephonyProvidersEdgeLinebasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinebasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinebasesetting: " + response.ErrorMessage, response.ErrorMessage);

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
        public LineEntityListing GetTelephonyProvidersEdgeLines (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> response = GetTelephonyProvidersEdgeLinesWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
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
        public ApiResponse< LineEntityListing > GetTelephonyProvidersEdgeLinesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLines: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLines: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<LineEntityListing> GetTelephonyProvidersEdgeLinesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> response = await GetTelephonyProvidersEdgeLinesAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
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
        public async System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> GetTelephonyProvidersEdgeLinesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLines: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLines: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LineEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param> 
        /// <returns>Line</returns>
        public Line GetTelephonyProvidersEdgeLinesTemplate (string lineBaseSettingsId)
        {
             ApiResponse<Line> response = GetTelephonyProvidersEdgeLinesTemplateWithHttpInfo(lineBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param> 
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > GetTelephonyProvidersEdgeLinesTemplateWithHttpInfo (string lineBaseSettingsId)
        {
            
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgeLinesTemplate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinesTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinesTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
    
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of Line</returns>
        public async System.Threading.Tasks.Task<Line> GetTelephonyProvidersEdgeLinesTemplateAsync (string lineBaseSettingsId)
        {
             ApiResponse<Line> response = await GetTelephonyProvidersEdgeLinesTemplateAsyncWithHttpInfo(lineBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> GetTelephonyProvidersEdgeLinesTemplateAsyncWithHttpInfo (string lineBaseSettingsId)
        {
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling GetTelephonyProvidersEdgeLinesTemplate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinesTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLinesTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
        
        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param> 
        /// <returns>Line</returns>
        public Line GetTelephonyProvidersEdgeLine (string lineId)
        {
             ApiResponse<Line> response = GetTelephonyProvidersEdgeLineWithHttpInfo(lineId);
             return response.Data;
        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param> 
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > GetTelephonyProvidersEdgeLineWithHttpInfo (string lineId)
        {
            
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgeLine");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLine: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLine: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
    
        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        public async System.Threading.Tasks.Task<Line> GetTelephonyProvidersEdgeLineAsync (string lineId)
        {
             ApiResponse<Line> response = await GetTelephonyProvidersEdgeLineAsyncWithHttpInfo(lineId);
             return response.Data;

        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> GetTelephonyProvidersEdgeLineAsyncWithHttpInfo (string lineId)
        {
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetTelephonyProvidersEdgeLine");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLine: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeLine: " + response.ErrorMessage, response.ErrorMessage);

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
        public OutboundRouteEntityListing GetTelephonyProvidersEdgeOutboundroutes (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
             ApiResponse<OutboundRouteEntityListing> response = GetTelephonyProvidersEdgeOutboundroutesWithHttpInfo(pageSize, pageNumber, name, siteId, sortBy);
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
        public ApiResponse< OutboundRouteEntityListing > GetTelephonyProvidersEdgeOutboundroutesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OutboundRouteEntityListing> GetTelephonyProvidersEdgeOutboundroutesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
        {
             ApiResponse<OutboundRouteEntityListing> response = await GetTelephonyProvidersEdgeOutboundroutesAsyncWithHttpInfo(pageSize, pageNumber, name, siteId, sortBy);
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
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRouteEntityListing>> GetTelephonyProvidersEdgeOutboundroutesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutboundRouteEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRouteEntityListing) Configuration.ApiClient.Deserialize(response, typeof(OutboundRouteEntityListing)));
            
        }
        
        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param> 
        /// <returns>OutboundRoute</returns>
        public OutboundRoute PostTelephonyProvidersEdgeOutboundroutes (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = PostTelephonyProvidersEdgeOutboundroutesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > PostTelephonyProvidersEdgeOutboundroutesWithHttpInfo (OutboundRoute body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
    
        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> PostTelephonyProvidersEdgeOutboundroutesAsync (OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = await PostTelephonyProvidersEdgeOutboundroutesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create outbound rule 
        /// </summary>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PostTelephonyProvidersEdgeOutboundroutesAsyncWithHttpInfo (OutboundRoute body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeOutboundroutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeOutboundroutes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>OutboundRoute</returns>
        public OutboundRoute GetTelephonyProvidersEdgeOutboundroute (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> response = GetTelephonyProvidersEdgeOutboundrouteWithHttpInfo(outboundRouteId);
             return response.Data;
        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > GetTelephonyProvidersEdgeOutboundrouteWithHttpInfo (string outboundRouteId)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgeOutboundroute");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeOutboundroute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeOutboundroute: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
    
        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of OutboundRoute</returns>
        public async System.Threading.Tasks.Task<OutboundRoute> GetTelephonyProvidersEdgeOutboundrouteAsync (string outboundRouteId)
        {
             ApiResponse<OutboundRoute> response = await GetTelephonyProvidersEdgeOutboundrouteAsyncWithHttpInfo(outboundRouteId);
             return response.Data;

        }

        /// <summary>
        /// Get outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> GetTelephonyProvidersEdgeOutboundrouteAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling GetTelephonyProvidersEdgeOutboundroute");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeOutboundroute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeOutboundroute: " + response.ErrorMessage, response.ErrorMessage);

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
        public OutboundRoute PutTelephonyProvidersEdgeOutboundroute (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = PutTelephonyProvidersEdgeOutboundrouteWithHttpInfo(outboundRouteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <param name="body">OutboundRoute</param> 
        /// <returns>ApiResponse of OutboundRoute</returns>
        public ApiResponse< OutboundRoute > PutTelephonyProvidersEdgeOutboundrouteWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->PutTelephonyProvidersEdgeOutboundroute");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeOutboundroute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeOutboundroute: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<OutboundRoute> PutTelephonyProvidersEdgeOutboundrouteAsync (string outboundRouteId, OutboundRoute body = null)
        {
             ApiResponse<OutboundRoute> response = await PutTelephonyProvidersEdgeOutboundrouteAsyncWithHttpInfo(outboundRouteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update outbound route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <param name="body">OutboundRoute</param>
        /// <returns>Task of ApiResponse (OutboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OutboundRoute>> PutTelephonyProvidersEdgeOutboundrouteAsyncWithHttpInfo (string outboundRouteId, OutboundRoute body = null)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling PutTelephonyProvidersEdgeOutboundroute");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeOutboundroute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeOutboundroute: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OutboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OutboundRoute) Configuration.ApiClient.Deserialize(response, typeof(OutboundRoute)));
            
        }
        
        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>string</returns>
        public string DeleteTelephonyProvidersEdgeOutboundroute (string outboundRouteId)
        {
             ApiResponse<string> response = DeleteTelephonyProvidersEdgeOutboundrouteWithHttpInfo(outboundRouteId);
             return response.Data;
        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteTelephonyProvidersEdgeOutboundrouteWithHttpInfo (string outboundRouteId)
        {
            
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null)
                throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling TelephonyProvidersEdgeApi->DeleteTelephonyProvidersEdgeOutboundroute");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeOutboundroute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeOutboundroute: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgeOutboundrouteAsync (string outboundRouteId)
        {
             ApiResponse<string> response = await DeleteTelephonyProvidersEdgeOutboundrouteAsyncWithHttpInfo(outboundRouteId);
             return response.Data;

        }

        /// <summary>
        /// Delete Outbound Route 
        /// </summary>
        /// <param name="outboundRouteId">Outbound route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgeOutboundrouteAsyncWithHttpInfo (string outboundRouteId)
        {
            // verify the required parameter 'outboundRouteId' is set
            if (outboundRouteId == null) throw new ApiException(400, "Missing required parameter 'outboundRouteId' when calling DeleteTelephonyProvidersEdgeOutboundroute");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeOutboundroute: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeOutboundroute: " + response.ErrorMessage, response.ErrorMessage);

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
        public PhoneBaseEntityListing GetTelephonyProvidersEdgePhonebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> response = GetTelephonyProvidersEdgePhonebasesettingsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< PhoneBaseEntityListing > GetTelephonyProvidersEdgePhonebasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PhoneBaseEntityListing> GetTelephonyProvidersEdgePhonebasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> response = await GetTelephonyProvidersEdgePhonebasesettingsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> GetTelephonyProvidersEdgePhonebasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase PostTelephonyProvidersEdgePhonebasesettings (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = PostTelephonyProvidersEdgePhonebasesettingsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > PostTelephonyProvidersEdgePhonebasesettingsWithHttpInfo (PhoneBase body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> PostTelephonyProvidersEdgePhonebasesettingsAsync (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = await PostTelephonyProvidersEdgePhonebasesettingsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PostTelephonyProvidersEdgePhonebasesettingsAsyncWithHttpInfo (PhoneBase body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhonebasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhonebasesettings: " + response.ErrorMessage, response.ErrorMessage);

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
        public PhoneMetaBaseEntityListing GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabases (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> response = GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabasesWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        public ApiResponse< PhoneMetaBaseEntityListing > GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabasesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabases: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabases: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PhoneMetaBaseEntityListing> GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabasesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> response = await GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabasesAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabasesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabases: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabases: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneMetaBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneMetaBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneMetaBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase GetTelephonyProvidersEdgePhonebasesettingsTemplate (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> response = GetTelephonyProvidersEdgePhonebasesettingsTemplateWithHttpInfo(phoneMetabaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > GetTelephonyProvidersEdgePhonebasesettingsTemplateWithHttpInfo (string phoneMetabaseId)
        {
            
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgePhonebasesettingsTemplate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettingsTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettingsTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> GetTelephonyProvidersEdgePhonebasesettingsTemplateAsync (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> response = await GetTelephonyProvidersEdgePhonebasesettingsTemplateAsyncWithHttpInfo(phoneMetabaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetTelephonyProvidersEdgePhonebasesettingsTemplateAsyncWithHttpInfo (string phoneMetabaseId)
        {
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null) throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling GetTelephonyProvidersEdgePhonebasesettingsTemplate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettingsTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesettingsTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase GetTelephonyProvidersEdgePhonebasesetting (string phoneBaseId)
        {
             ApiResponse<PhoneBase> response = GetTelephonyProvidersEdgePhonebasesettingWithHttpInfo(phoneBaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > GetTelephonyProvidersEdgePhonebasesettingWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgePhonebasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesetting: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> GetTelephonyProvidersEdgePhonebasesettingAsync (string phoneBaseId)
        {
             ApiResponse<PhoneBase> response = await GetTelephonyProvidersEdgePhonebasesettingAsyncWithHttpInfo(phoneBaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> GetTelephonyProvidersEdgePhonebasesettingAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling GetTelephonyProvidersEdgePhonebasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonebasesetting: " + response.ErrorMessage, response.ErrorMessage);

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
        public PhoneBase PutTelephonyProvidersEdgePhonebasesetting (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = PutTelephonyProvidersEdgePhonebasesettingWithHttpInfo(phoneBaseId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > PutTelephonyProvidersEdgePhonebasesettingWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->PutTelephonyProvidersEdgePhonebasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgePhonebasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgePhonebasesetting: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PhoneBase> PutTelephonyProvidersEdgePhonebasesettingAsync (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = await PutTelephonyProvidersEdgePhonebasesettingAsyncWithHttpInfo(phoneBaseId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> PutTelephonyProvidersEdgePhonebasesettingAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling PutTelephonyProvidersEdgePhonebasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgePhonebasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgePhonebasesetting: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>string</returns>
        public string DeleteTelephonyProvidersEdgePhonebasesetting (string phoneBaseId)
        {
             ApiResponse<string> response = DeleteTelephonyProvidersEdgePhonebasesettingWithHttpInfo(phoneBaseId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteTelephonyProvidersEdgePhonebasesettingWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgeApi->DeleteTelephonyProvidersEdgePhonebasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgePhonebasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgePhonebasesetting: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgePhonebasesettingAsync (string phoneBaseId)
        {
             ApiResponse<string> response = await DeleteTelephonyProvidersEdgePhonebasesettingAsyncWithHttpInfo(phoneBaseId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgePhonebasesettingAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling DeleteTelephonyProvidersEdgePhonebasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgePhonebasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgePhonebasesetting: " + response.ErrorMessage, response.ErrorMessage);

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
        public PhoneEntityListing GetTelephonyProvidersEdgePhones (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
             ApiResponse<PhoneEntityListing> response = GetTelephonyProvidersEdgePhonesWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
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
        public ApiResponse< PhoneEntityListing > GetTelephonyProvidersEdgePhonesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PhoneEntityListing> GetTelephonyProvidersEdgePhonesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
             ApiResponse<PhoneEntityListing> response = await GetTelephonyProvidersEdgePhonesAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
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
        public async System.Threading.Tasks.Task<ApiResponse<PhoneEntityListing>> GetTelephonyProvidersEdgePhonesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Phone</returns>
        public Phone PostTelephonyProvidersEdgePhones (Phone body = null)
        {
             ApiResponse<Phone> response = PostTelephonyProvidersEdgePhonesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > PostTelephonyProvidersEdgePhonesWithHttpInfo (Phone body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> PostTelephonyProvidersEdgePhonesAsync (Phone body = null)
        {
             ApiResponse<Phone> response = await PostTelephonyProvidersEdgePhonesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> PostTelephonyProvidersEdgePhonesAsyncWithHttpInfo (Phone body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhones: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param> 
        /// <returns></returns>
        public void PostTelephonyProvidersEdgePhonesReboot (PhonesReboot body = null)
        {
             PostTelephonyProvidersEdgePhonesRebootWithHttpInfo(body);
        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostTelephonyProvidersEdgePhonesRebootWithHttpInfo (PhonesReboot body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhonesReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhonesReboot: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostTelephonyProvidersEdgePhonesRebootAsync (PhonesReboot body = null)
        {
             await PostTelephonyProvidersEdgePhonesRebootAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyProvidersEdgePhonesRebootAsyncWithHttpInfo (PhonesReboot body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhonesReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhonesReboot: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param> 
        /// <returns>Phone</returns>
        public Phone GetTelephonyProvidersEdgePhonesTemplate (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> response = GetTelephonyProvidersEdgePhonesTemplateWithHttpInfo(phoneBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > GetTelephonyProvidersEdgePhonesTemplateWithHttpInfo (string phoneBaseSettingsId)
        {
            
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgePhonesTemplate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonesTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonesTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> GetTelephonyProvidersEdgePhonesTemplateAsync (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> response = await GetTelephonyProvidersEdgePhonesTemplateAsyncWithHttpInfo(phoneBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> GetTelephonyProvidersEdgePhonesTemplateAsyncWithHttpInfo (string phoneBaseSettingsId)
        {
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling GetTelephonyProvidersEdgePhonesTemplate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonesTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhonesTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>Phone</returns>
        public Phone GetTelephonyProvidersEdgePhone (string phoneId)
        {
             ApiResponse<Phone> response = GetTelephonyProvidersEdgePhoneWithHttpInfo(phoneId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > GetTelephonyProvidersEdgePhoneWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgePhone");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> GetTelephonyProvidersEdgePhoneAsync (string phoneId)
        {
             ApiResponse<Phone> response = await GetTelephonyProvidersEdgePhoneAsyncWithHttpInfo(phoneId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> GetTelephonyProvidersEdgePhoneAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling GetTelephonyProvidersEdgePhone");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);

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
        public Phone PutTelephonyProvidersEdgePhone (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> response = PutTelephonyProvidersEdgePhoneWithHttpInfo(phoneId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > PutTelephonyProvidersEdgePhoneWithHttpInfo (string phoneId, Phone body = null)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->PutTelephonyProvidersEdgePhone");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Phone> PutTelephonyProvidersEdgePhoneAsync (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> response = await PutTelephonyProvidersEdgePhoneAsyncWithHttpInfo(phoneId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> PutTelephonyProvidersEdgePhoneAsyncWithHttpInfo (string phoneId, Phone body = null)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling PutTelephonyProvidersEdgePhone");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>string</returns>
        public string DeleteTelephonyProvidersEdgePhone (string phoneId)
        {
             ApiResponse<string> response = DeleteTelephonyProvidersEdgePhoneWithHttpInfo(phoneId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteTelephonyProvidersEdgePhoneWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->DeleteTelephonyProvidersEdgePhone");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgePhoneAsync (string phoneId)
        {
             ApiResponse<string> response = await DeleteTelephonyProvidersEdgePhoneAsyncWithHttpInfo(phoneId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgePhoneAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling DeleteTelephonyProvidersEdgePhone");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgePhone: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgePhone: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param> 
        /// <returns></returns>
        public void PostTelephonyProvidersEdgePhoneReboot (string phoneId)
        {
             PostTelephonyProvidersEdgePhoneRebootWithHttpInfo(phoneId);
        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostTelephonyProvidersEdgePhoneRebootWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null)
                throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgeApi->PostTelephonyProvidersEdgePhoneReboot");
            
    
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhoneReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhoneReboot: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostTelephonyProvidersEdgePhoneRebootAsync (string phoneId)
        {
             await PostTelephonyProvidersEdgePhoneRebootAsyncWithHttpInfo(phoneId);

        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostTelephonyProvidersEdgePhoneRebootAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling PostTelephonyProvidersEdgePhoneReboot");
            
    
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhoneReboot: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgePhoneReboot: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public TimeZoneEntityListing GetTelephonyProvidersEdgeTimezones (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = GetTelephonyProvidersEdgeTimezonesWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        public ApiResponse< TimeZoneEntityListing > GetTelephonyProvidersEdgeTimezonesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTimezones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTimezones: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TimeZoneEntityListing> GetTelephonyProvidersEdgeTimezonesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = await GetTelephonyProvidersEdgeTimezonesAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> GetTelephonyProvidersEdgeTimezonesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTimezones: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTimezones: " + response.ErrorMessage, response.ErrorMessage);

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
        public TrunkBase GetTelephonyProvidersEdgeTrunkbasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> response = GetTelephonyProvidersEdgeTrunkbasesettingsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< TrunkBase > GetTelephonyProvidersEdgeTrunkbasesettingsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TrunkBase> GetTelephonyProvidersEdgeTrunkbasesettingsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> response = await GetTelephonyProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetTelephonyProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase PostTelephonyProvidersEdgeTrunkbasesettings (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = PostTelephonyProvidersEdgeTrunkbasesettingsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > PostTelephonyProvidersEdgeTrunkbasesettingsWithHttpInfo (TrunkBase body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> PostTelephonyProvidersEdgeTrunkbasesettingsAsync (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = await PostTelephonyProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PostTelephonyProvidersEdgeTrunkbasesettingsAsyncWithHttpInfo (TrunkBase body = null)
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
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeTrunkbasesettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostTelephonyProvidersEdgeTrunkbasesettings: " + response.ErrorMessage, response.ErrorMessage);

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
        public TrunkMetabaseEntityListing GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabases (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> response = GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesWithHttpInfo(type, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param> 
        /// <param name="pageSize"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>ApiResponse of TrunkMetabaseEntityListing</returns>
        public ApiResponse< TrunkMetabaseEntityListing > GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabases: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabases: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TrunkMetabaseEntityListing> GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesAsync (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> response = await GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesAsyncWithHttpInfo(type, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (TrunkMetabaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkMetabaseEntityListing>> GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesAsyncWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabases: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabases: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkMetabaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkMetabaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TrunkMetabaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase GetTelephonyProvidersEdgeTrunkbasesettingsTemplate (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> response = GetTelephonyProvidersEdgeTrunkbasesettingsTemplateWithHttpInfo(trunkMetabaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > GetTelephonyProvidersEdgeTrunkbasesettingsTemplateWithHttpInfo (string trunkMetabaseId)
        {
            
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null)
                throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgeTrunkbasesettingsTemplate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettingsTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettingsTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> GetTelephonyProvidersEdgeTrunkbasesettingsTemplateAsync (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> response = await GetTelephonyProvidersEdgeTrunkbasesettingsTemplateAsyncWithHttpInfo(trunkMetabaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetTelephonyProvidersEdgeTrunkbasesettingsTemplateAsyncWithHttpInfo (string trunkMetabaseId)
        {
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null) throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling GetTelephonyProvidersEdgeTrunkbasesettingsTemplate");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettingsTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesettingsTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase GetTelephonyProvidersEdgeTrunkbasesetting (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> response = GetTelephonyProvidersEdgeTrunkbasesettingWithHttpInfo(trunkBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > GetTelephonyProvidersEdgeTrunkbasesettingWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->GetTelephonyProvidersEdgeTrunkbasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesetting: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> GetTelephonyProvidersEdgeTrunkbasesettingAsync (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> response = await GetTelephonyProvidersEdgeTrunkbasesettingAsyncWithHttpInfo(trunkBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> GetTelephonyProvidersEdgeTrunkbasesettingAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling GetTelephonyProvidersEdgeTrunkbasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTelephonyProvidersEdgeTrunkbasesetting: " + response.ErrorMessage, response.ErrorMessage);

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
        public TrunkBase PutTelephonyProvidersEdgeTrunkbasesetting (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = PutTelephonyProvidersEdgeTrunkbasesettingWithHttpInfo(trunkBaseSettingsId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > PutTelephonyProvidersEdgeTrunkbasesettingWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->PutTelephonyProvidersEdgeTrunkbasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeTrunkbasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeTrunkbasesetting: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TrunkBase> PutTelephonyProvidersEdgeTrunkbasesettingAsync (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = await PutTelephonyProvidersEdgeTrunkbasesettingAsyncWithHttpInfo(trunkBaseSettingsId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> PutTelephonyProvidersEdgeTrunkbasesettingAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling PutTelephonyProvidersEdgeTrunkbasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeTrunkbasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutTelephonyProvidersEdgeTrunkbasesetting: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>string</returns>
        public string DeleteTelephonyProvidersEdgeTrunkbasesetting (string trunkBaseSettingsId)
        {
             ApiResponse<string> response = DeleteTelephonyProvidersEdgeTrunkbasesettingWithHttpInfo(trunkBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteTelephonyProvidersEdgeTrunkbasesettingWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null)
                throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeApi->DeleteTelephonyProvidersEdgeTrunkbasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeTrunkbasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeTrunkbasesetting: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteTelephonyProvidersEdgeTrunkbasesettingAsync (string trunkBaseSettingsId)
        {
             ApiResponse<string> response = await DeleteTelephonyProvidersEdgeTrunkbasesettingAsyncWithHttpInfo(trunkBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteTelephonyProvidersEdgeTrunkbasesettingAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling DeleteTelephonyProvidersEdgeTrunkbasesetting");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeTrunkbasesetting: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTelephonyProvidersEdgeTrunkbasesetting: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
