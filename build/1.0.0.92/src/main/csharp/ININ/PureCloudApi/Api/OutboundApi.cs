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
    public interface IOutboundApi
    {
        
        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="facetsOnly">Facets only</param>
        /// <returns>AuditSearchResult</returns>
        AuditSearchResult OutboundAuditsPost (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
  
        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="facetsOnly">Facets only</param>
        /// <returns>ApiResponse of AuditSearchResult</returns>
        ApiResponse<AuditSearchResult> OutboundAuditsPostWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="facetsOnly">Facets only</param>
        /// <returns>Task of AuditSearchResult</returns>
        System.Threading.Tasks.Task<AuditSearchResult> OutboundAuditsPostAsync (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="facetsOnly">Facets only</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> OutboundAuditsPostAsyncWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
        
        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>CallableTimeSetEntityListing</returns>
        CallableTimeSetEntityListing OutboundCallabletimesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of CallableTimeSetEntityListing</returns>
        ApiResponse<CallableTimeSetEntityListing> OutboundCallabletimesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of CallableTimeSetEntityListing</returns>
        System.Threading.Tasks.Task<CallableTimeSetEntityListing> OutboundCallabletimesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (CallableTimeSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> OutboundCallabletimesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet OutboundCallabletimesetsPost (CallableTimeSet body = null);
  
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> OutboundCallabletimesetsPostWithHttpInfo (CallableTimeSet body = null);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsPostAsync (CallableTimeSet body = null);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsPostAsyncWithHttpInfo (CallableTimeSet body = null);
        
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet OutboundCallabletimesetsCallabletimesetidGet (string callableTimeSetId);
  
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidGetWithHttpInfo (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidGetAsync (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsCallabletimesetidGetAsyncWithHttpInfo (string callableTimeSetId);
        
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet OutboundCallabletimesetsCallabletimesetidPut (string callableTimeSetId, CallableTimeSet body = null);
  
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidPutWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidPutAsync (string callableTimeSetId, CallableTimeSet body = null);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsCallabletimesetidPutAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null);
        
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>string</returns>
        string OutboundCallabletimesetsCallabletimesetidDelete (string callableTimeSetId);
  
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundCallabletimesetsCallabletimesetidDeleteWithHttpInfo (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundCallabletimesetsCallabletimesetidDeleteAsync (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundCallabletimesetsCallabletimesetidDeleteAsyncWithHttpInfo (string callableTimeSetId);
        
        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ResponseSetEntityListing</returns>
        ResponseSetEntityListing OutboundCallanalysisresponsesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ResponseSetEntityListing</returns>
        ApiResponse<ResponseSetEntityListing> OutboundCallanalysisresponsesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ResponseSetEntityListing</returns>
        System.Threading.Tasks.Task<ResponseSetEntityListing> OutboundCallanalysisresponsesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ResponseSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> OutboundCallanalysisresponsesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        ResponseSet OutboundCallanalysisresponsesetsPost (ResponseSet body = null);
  
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> OutboundCallanalysisresponsesetsPostWithHttpInfo (ResponseSet body = null);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsPostAsync (ResponseSet body = null);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsPostAsyncWithHttpInfo (ResponseSet body = null);
        
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        ResponseSet OutboundCallanalysisresponsesetsCallanalysissetidGet (string callAnalysisSetId);
  
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidGetWithHttpInfo (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidGetAsync (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsCallanalysissetidGetAsyncWithHttpInfo (string callAnalysisSetId);
        
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        ResponseSet OutboundCallanalysisresponsesetsCallanalysissetidPut (string callAnalysisSetId, ResponseSet body = null);
  
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidPutWithHttpInfo (string callAnalysisSetId, ResponseSet body = null);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidPutAsync (string callAnalysisSetId, ResponseSet body = null);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsCallanalysissetidPutAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body = null);
        
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>string</returns>
        string OutboundCallanalysisresponsesetsCallanalysissetidDelete (string callAnalysisSetId);
  
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundCallanalysisresponsesetsCallanalysissetidDeleteWithHttpInfo (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsync (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsyncWithHttpInfo (string callAnalysisSetId);
        
        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="dncListId">DNC list ID</param>
        /// <param name="distributionQueueId">Distribution queue ID</param>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>CampaignEntityListing</returns>
        CampaignEntityListing OutboundCampaignsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="dncListId">DNC list ID</param>
        /// <param name="distributionQueueId">Distribution queue ID</param>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of CampaignEntityListing</returns>
        ApiResponse<CampaignEntityListing> OutboundCampaignsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="dncListId">DNC list ID</param>
        /// <param name="distributionQueueId">Distribution queue ID</param>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of CampaignEntityListing</returns>
        System.Threading.Tasks.Task<CampaignEntityListing> OutboundCampaignsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="dncListId">DNC list ID</param>
        /// <param name="distributionQueueId">Distribution queue ID</param>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (CampaignEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> OutboundCampaignsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        Campaign OutboundCampaignsPost (Campaign body = null);
  
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> OutboundCampaignsPostWithHttpInfo (Campaign body = null);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> OutboundCampaignsPostAsync (Campaign body = null);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsPostAsyncWithHttpInfo (Campaign body = null);
        
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        Campaign OutboundCampaignsCampaignidGet (string campaignId);
  
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> OutboundCampaignsCampaignidGetWithHttpInfo (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> OutboundCampaignsCampaignidGetAsync (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsCampaignidGetAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        Campaign OutboundCampaignsCampaignidPut (string campaignId, Campaign body = null);
  
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> OutboundCampaignsCampaignidPutWithHttpInfo (string campaignId, Campaign body = null);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> OutboundCampaignsCampaignidPutAsync (string campaignId, Campaign body = null);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsCampaignidPutAsyncWithHttpInfo (string campaignId, Campaign body = null);
        
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string OutboundCampaignsCampaignidDelete (string campaignId);
  
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundCampaignsCampaignidDeleteWithHttpInfo (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundCampaignsCampaignidDeleteAsync (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundCampaignsCampaignidDeleteAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Send notification that an agent&#39;s state changed
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>string</returns>
        string OutboundCampaignsCampaignidAgentsUseridPut (string campaignId, string userId, Agent body = null);
  
        /// <summary>
        /// Send notification that an agent&#39;s state changed
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundCampaignsCampaignidAgentsUseridPutWithHttpInfo (string campaignId, string userId, Agent body = null);

        /// <summary>
        /// Send notification that an agent&#39;s state changed
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundCampaignsCampaignidAgentsUseridPutAsync (string campaignId, string userId, Agent body = null);

        /// <summary>
        /// Send notification that an agent&#39;s state changed
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundCampaignsCampaignidAgentsUseridPutAsyncWithHttpInfo (string campaignId, string userId, Agent body = null);
        
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ContactCallbackRequest</returns>
        ContactCallbackRequest OutboundCampaignsCampaignidCallbackSchedulePost (string campaignId, ContactCallbackRequest body = null);
  
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        ApiResponse<ContactCallbackRequest> OutboundCampaignsCampaignidCallbackSchedulePostWithHttpInfo (string campaignId, ContactCallbackRequest body = null);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        System.Threading.Tasks.Task<ContactCallbackRequest> OutboundCampaignsCampaignidCallbackSchedulePostAsync (string campaignId, ContactCallbackRequest body = null);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> OutboundCampaignsCampaignidCallbackSchedulePostAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body = null);
        
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignDiagnostics</returns>
        CampaignDiagnostics OutboundCampaignsCampaignidDiagnosticsGet (string campaignId);
  
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        ApiResponse<CampaignDiagnostics> OutboundCampaignsCampaignidDiagnosticsGetWithHttpInfo (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        System.Threading.Tasks.Task<CampaignDiagnostics> OutboundCampaignsCampaignidDiagnosticsGetAsync (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> OutboundCampaignsCampaignidDiagnosticsGetAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignStats</returns>
        CampaignStats OutboundCampaignsCampaignidStatsGet (string campaignId);
  
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        ApiResponse<CampaignStats> OutboundCampaignsCampaignidStatsGetWithHttpInfo (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        System.Threading.Tasks.Task<CampaignStats> OutboundCampaignsCampaignidStatsGetAsync (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignStats>> OutboundCampaignsCampaignidStatsGetAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ContactListEntityListing</returns>
        ContactListEntityListing OutboundContactlistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        ApiResponse<ContactListEntityListing> OutboundContactlistsGetWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ContactListEntityListing</returns>
        System.Threading.Tasks.Task<ContactListEntityListing> OutboundContactlistsGetAsync (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> OutboundContactlistsGetAsyncWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        ContactList OutboundContactlistsPost (ContactList body = null);
  
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> OutboundContactlistsPostWithHttpInfo (ContactList body = null);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> OutboundContactlistsPostAsync (ContactList body = null);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsPostAsyncWithHttpInfo (ContactList body = null);
        
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>List&lt;PenetrationRate&gt;</returns>
        List<PenetrationRate> OutboundContactlistsPenetrationratesPost (List<PenetrationRateId> body = null);
  
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>ApiResponse of List&lt;PenetrationRate&gt;</returns>
        ApiResponse<List<PenetrationRate>> OutboundContactlistsPenetrationratesPostWithHttpInfo (List<PenetrationRateId> body = null);

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>Task of List&lt;PenetrationRate&gt;</returns>
        System.Threading.Tasks.Task<List<PenetrationRate>> OutboundContactlistsPenetrationratesPostAsync (List<PenetrationRateId> body = null);

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>Task of ApiResponse (List&lt;PenetrationRate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PenetrationRate>>> OutboundContactlistsPenetrationratesPostAsyncWithHttpInfo (List<PenetrationRateId> body = null);
        
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>ContactList</returns>
        ContactList OutboundContactlistsContactlistidGet (string contactListId, bool? importStatus = null, bool? includeSize = null);
  
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> OutboundContactlistsContactlistidGetWithHttpInfo (string contactListId, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> OutboundContactlistsContactlistidGetAsync (string contactListId, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsContactlistidGetAsyncWithHttpInfo (string contactListId, bool? importStatus = null, bool? includeSize = null);
        
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        ContactList OutboundContactlistsContactlistidPut (string contactListId, ContactList body = null);
  
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> OutboundContactlistsContactlistidPutWithHttpInfo (string contactListId, ContactList body = null);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> OutboundContactlistsContactlistidPutAsync (string contactListId, ContactList body = null);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsContactlistidPutAsyncWithHttpInfo (string contactListId, ContactList body = null);
        
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string OutboundContactlistsContactlistidDelete (string contactListId);
  
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundContactlistsContactlistidDeleteWithHttpInfo (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidDeleteAsync (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidDeleteAsyncWithHttpInfo (string contactListId);
        
        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority"></param>
        /// <returns>Contact</returns>
        Contact OutboundContactlistsContactlistidContactsPost (string contactListId, List<Contact> body = null, bool? priority = null);
  
        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority"></param>
        /// <returns>ApiResponse of Contact</returns>
        ApiResponse<Contact> OutboundContactlistsContactlistidContactsPostWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null);

        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority"></param>
        /// <returns>Task of Contact</returns>
        System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsPostAsync (string contactListId, List<Contact> body = null, bool? priority = null);

        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority"></param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsPostAsyncWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null);
        
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Contact</returns>
        Contact OutboundContactlistsContactlistidContactsContactidGet (string contactListId, string contactId);
  
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of Contact</returns>
        ApiResponse<Contact> OutboundContactlistsContactlistidContactsContactidGetWithHttpInfo (string contactListId, string contactId);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of Contact</returns>
        System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsContactidGetAsync (string contactListId, string contactId);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsContactidGetAsyncWithHttpInfo (string contactListId, string contactId);
        
        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Contact</returns>
        Contact OutboundContactlistsContactlistidContactsContactidPut (string contactListId, string contactId, Contact body = null);
  
        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>ApiResponse of Contact</returns>
        ApiResponse<Contact> OutboundContactlistsContactlistidContactsContactidPutWithHttpInfo (string contactListId, string contactId, Contact body = null);

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of Contact</returns>
        System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsContactidPutAsync (string contactListId, string contactId, Contact body = null);

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsContactidPutAsyncWithHttpInfo (string contactListId, string contactId, Contact body = null);
        
        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>string</returns>
        string OutboundContactlistsContactlistidContactsContactidDelete (string contactListId, string contactId);
  
        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundContactlistsContactlistidContactsContactidDeleteWithHttpInfo (string contactListId, string contactId);

        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidContactsContactidDeleteAsync (string contactListId, string contactId);

        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidContactsContactidDeleteAsyncWithHttpInfo (string contactListId, string contactId);
        
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string OutboundContactlistsContactlistidExportPost (string contactListId);
  
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundContactlistsContactlistidExportPostWithHttpInfo (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidExportPostAsync (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidExportPostAsyncWithHttpInfo (string contactListId);
        
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus OutboundContactlistsContactlistidImportstatusGet (string contactListId);
  
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> OutboundContactlistsContactlistidImportstatusGetWithHttpInfo (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> OutboundContactlistsContactlistidImportstatusGetAsync (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> OutboundContactlistsContactlistidImportstatusGetAsyncWithHttpInfo (string contactListId);
        
        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>PenetrationRate</returns>
        PenetrationRate OutboundContactlistsContactlistidCampaignidPenetrationrateGet (string contactListId, string campaignId);
  
        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of PenetrationRate</returns>
        ApiResponse<PenetrationRate> OutboundContactlistsContactlistidCampaignidPenetrationrateGetWithHttpInfo (string contactListId, string campaignId);

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of PenetrationRate</returns>
        System.Threading.Tasks.Task<PenetrationRate> OutboundContactlistsContactlistidCampaignidPenetrationrateGetAsync (string contactListId, string campaignId);

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (PenetrationRate)</returns>
        System.Threading.Tasks.Task<ApiResponse<PenetrationRate>> OutboundContactlistsContactlistidCampaignidPenetrationrateGetAsyncWithHttpInfo (string contactListId, string campaignId);
        
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        void OutboundConversationsConversationidDncPost (string conversationId);
  
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> OutboundConversationsConversationidDncPostWithHttpInfo (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task OutboundConversationsConversationidDncPostAsync (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> OutboundConversationsConversationidDncPostAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>DncListEntityListing</returns>
        DncListEntityListing OutboundDnclistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of DncListEntityListing</returns>
        ApiResponse<DncListEntityListing> OutboundDnclistsGetWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of DncListEntityListing</returns>
        System.Threading.Tasks.Task<DncListEntityListing> OutboundDnclistsGetAsync (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> OutboundDnclistsGetAsyncWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        DncList OutboundDnclistsPost (DncList body = null);
  
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> OutboundDnclistsPostWithHttpInfo (DncList body = null);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> OutboundDnclistsPostAsync (DncList body = null);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsPostAsyncWithHttpInfo (DncList body = null);
        
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>DncList</returns>
        DncList OutboundDnclistsDnclistidGet (string dncListId, bool? importStatus = null, bool? includeSize = null);
  
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> OutboundDnclistsDnclistidGetWithHttpInfo (string dncListId, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> OutboundDnclistsDnclistidGetAsync (string dncListId, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsDnclistidGetAsyncWithHttpInfo (string dncListId, bool? importStatus = null, bool? includeSize = null);
        
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        DncList OutboundDnclistsDnclistidPut (string dncListId, DncList body = null);
  
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> OutboundDnclistsDnclistidPutWithHttpInfo (string dncListId, DncList body = null);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> OutboundDnclistsDnclistidPutAsync (string dncListId, DncList body = null);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsDnclistidPutAsyncWithHttpInfo (string dncListId, DncList body = null);
        
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string OutboundDnclistsDnclistidDelete (string dncListId);
  
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundDnclistsDnclistidDeleteWithHttpInfo (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundDnclistsDnclistidDeleteAsync (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundDnclistsDnclistidDeleteAsyncWithHttpInfo (string dncListId);
        
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string OutboundDnclistsDnclistidExportPost (string dncListId);
  
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundDnclistsDnclistidExportPostWithHttpInfo (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundDnclistsDnclistidExportPostAsync (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundDnclistsDnclistidExportPostAsyncWithHttpInfo (string dncListId);
        
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus OutboundDnclistsDnclistidImportstatusGet (string dncListId);
  
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> OutboundDnclistsDnclistidImportstatusGetWithHttpInfo (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> OutboundDnclistsDnclistidImportstatusGetAsync (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> OutboundDnclistsDnclistidImportstatusGetAsyncWithHttpInfo (string dncListId);
        
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns></returns>
        void OutboundDnclistsDnclistidPhonenumbersPost (string dncListId, List<string> body = null);
  
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> OutboundDnclistsDnclistidPhonenumbersPostWithHttpInfo (string dncListId, List<string> body = null);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task OutboundDnclistsDnclistidPhonenumbersPostAsync (string dncListId, List<string> body = null);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> OutboundDnclistsDnclistidPhonenumbersPostAsyncWithHttpInfo (string dncListId, List<string> body = null);
        
        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;Preview&gt;</returns>
        List<Preview> OutboundPreviewsGet ();
  
        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;Preview&gt;</returns>
        ApiResponse<List<Preview>> OutboundPreviewsGetWithHttpInfo ();

        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;Preview&gt;</returns>
        System.Threading.Tasks.Task<List<Preview>> OutboundPreviewsGetAsync ();

        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;Preview&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Preview>>> OutboundPreviewsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <returns>Preview</returns>
        Preview OutboundPreviewsPreviewidGet (string previewId);
  
        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <returns>ApiResponse of Preview</returns>
        ApiResponse<Preview> OutboundPreviewsPreviewidGetWithHttpInfo (string previewId);

        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of Preview</returns>
        System.Threading.Tasks.Task<Preview> OutboundPreviewsPreviewidGetAsync (string previewId);

        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of ApiResponse (Preview)</returns>
        System.Threading.Tasks.Task<ApiResponse<Preview>> OutboundPreviewsPreviewidGetAsyncWithHttpInfo (string previewId);
        
        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string OutboundPreviewsPreviewidDispositioncallPost (string previewId, DialerDispositionCallCommand body = null);
  
        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundPreviewsPreviewidDispositioncallPostWithHttpInfo (string previewId, DialerDispositionCallCommand body = null);

        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundPreviewsPreviewidDispositioncallPostAsync (string previewId, DialerDispositionCallCommand body = null);

        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundPreviewsPreviewidDispositioncallPostAsyncWithHttpInfo (string previewId, DialerDispositionCallCommand body = null);
        
        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>DialerCall</returns>
        DialerCall OutboundPreviewsPreviewidPlacecallPost (string previewId, DialerPlaceCallCommand body = null);
  
        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DialerCall</returns>
        ApiResponse<DialerCall> OutboundPreviewsPreviewidPlacecallPostWithHttpInfo (string previewId, DialerPlaceCallCommand body = null);

        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DialerCall</returns>
        System.Threading.Tasks.Task<DialerCall> OutboundPreviewsPreviewidPlacecallPostAsync (string previewId, DialerPlaceCallCommand body = null);

        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DialerCall)</returns>
        System.Threading.Tasks.Task<ApiResponse<DialerCall>> OutboundPreviewsPreviewidPlacecallPostAsyncWithHttpInfo (string previewId, DialerPlaceCallCommand body = null);
        
        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>RuleSetEntityListing</returns>
        RuleSetEntityListing OutboundRulesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of RuleSetEntityListing</returns>
        ApiResponse<RuleSetEntityListing> OutboundRulesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of RuleSetEntityListing</returns>
        System.Threading.Tasks.Task<RuleSetEntityListing> OutboundRulesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (RuleSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> OutboundRulesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        RuleSet OutboundRulesetsPost (RuleSet body = null);
  
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> OutboundRulesetsPostWithHttpInfo (RuleSet body = null);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> OutboundRulesetsPostAsync (RuleSet body = null);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsPostAsyncWithHttpInfo (RuleSet body = null);
        
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        RuleSet OutboundRulesetsRulesetidGet (string ruleSetId);
  
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> OutboundRulesetsRulesetidGetWithHttpInfo (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> OutboundRulesetsRulesetidGetAsync (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsRulesetidGetAsyncWithHttpInfo (string ruleSetId);
        
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        RuleSet OutboundRulesetsRulesetidPut (string ruleSetId, RuleSet body = null);
  
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> OutboundRulesetsRulesetidPutWithHttpInfo (string ruleSetId, RuleSet body = null);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> OutboundRulesetsRulesetidPutAsync (string ruleSetId, RuleSet body = null);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsRulesetidPutAsyncWithHttpInfo (string ruleSetId, RuleSet body = null);
        
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>string</returns>
        string OutboundRulesetsRulesetidDelete (string ruleSetId);
  
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundRulesetsRulesetidDeleteWithHttpInfo (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundRulesetsRulesetidDeleteAsync (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundRulesetsRulesetidDeleteAsyncWithHttpInfo (string ruleSetId);
        
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        List<CampaignSchedule> OutboundSchedulesCampaignsGet ();
  
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        ApiResponse<List<CampaignSchedule>> OutboundSchedulesCampaignsGetWithHttpInfo ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<CampaignSchedule>> OutboundSchedulesCampaignsGetAsync ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> OutboundSchedulesCampaignsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule OutboundSchedulesCampaignsCampaignidGet (string campaignId);
  
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> OutboundSchedulesCampaignsCampaignidGetWithHttpInfo (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> OutboundSchedulesCampaignsCampaignidGetAsync (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> OutboundSchedulesCampaignsCampaignidGetAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule OutboundSchedulesCampaignsCampaignidPut (string campaignId, CampaignSchedule body = null);
  
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> OutboundSchedulesCampaignsCampaignidPutWithHttpInfo (string campaignId, CampaignSchedule body = null);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> OutboundSchedulesCampaignsCampaignidPutAsync (string campaignId, CampaignSchedule body = null);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> OutboundSchedulesCampaignsCampaignidPutAsyncWithHttpInfo (string campaignId, CampaignSchedule body = null);
        
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string OutboundSchedulesCampaignsCampaignidDelete (string campaignId);
  
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundSchedulesCampaignsCampaignidDeleteWithHttpInfo (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundSchedulesCampaignsCampaignidDeleteAsync (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundSchedulesCampaignsCampaignidDeleteAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        List<SequenceSchedule> OutboundSchedulesSequencesGet ();
  
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        ApiResponse<List<SequenceSchedule>> OutboundSchedulesSequencesGetWithHttpInfo ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<SequenceSchedule>> OutboundSchedulesSequencesGetAsync ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> OutboundSchedulesSequencesGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule OutboundSchedulesSequencesSequenceidGet (string sequenceId);
  
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> OutboundSchedulesSequencesSequenceidGetWithHttpInfo (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> OutboundSchedulesSequencesSequenceidGetAsync (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> OutboundSchedulesSequencesSequenceidGetAsyncWithHttpInfo (string sequenceId);
        
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule OutboundSchedulesSequencesSequenceidPut (string sequenceId, SequenceSchedule body = null);
  
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> OutboundSchedulesSequencesSequenceidPutWithHttpInfo (string sequenceId, SequenceSchedule body = null);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> OutboundSchedulesSequencesSequenceidPutAsync (string sequenceId, SequenceSchedule body = null);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> OutboundSchedulesSequencesSequenceidPutAsyncWithHttpInfo (string sequenceId, SequenceSchedule body = null);
        
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>string</returns>
        string OutboundSchedulesSequencesSequenceidDelete (string sequenceId);
  
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundSchedulesSequencesSequenceidDeleteWithHttpInfo (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundSchedulesSequencesSequenceidDeleteAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundSchedulesSequencesSequenceidDeleteAsyncWithHttpInfo (string sequenceId);
        
        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>CampaignSequenceEntityListing</returns>
        CampaignSequenceEntityListing OutboundSequencesGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of CampaignSequenceEntityListing</returns>
        ApiResponse<CampaignSequenceEntityListing> OutboundSequencesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of CampaignSequenceEntityListing</returns>
        System.Threading.Tasks.Task<CampaignSequenceEntityListing> OutboundSequencesGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (CampaignSequenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> OutboundSequencesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence OutboundSequencesPost (CampaignSequence body = null);
  
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> OutboundSequencesPostWithHttpInfo (CampaignSequence body = null);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesPostAsync (CampaignSequence body = null);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesPostAsyncWithHttpInfo (CampaignSequence body = null);
        
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence OutboundSequencesSequenceidGet (string sequenceId);
  
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> OutboundSequencesSequenceidGetWithHttpInfo (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesSequenceidGetAsync (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesSequenceidGetAsyncWithHttpInfo (string sequenceId);
        
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence OutboundSequencesSequenceidPut (string sequenceId, CampaignSequence body = null);
  
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> OutboundSequencesSequenceidPutWithHttpInfo (string sequenceId, CampaignSequence body = null);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesSequenceidPutAsync (string sequenceId, CampaignSequence body = null);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesSequenceidPutAsyncWithHttpInfo (string sequenceId, CampaignSequence body = null);
        
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>string</returns>
        string OutboundSequencesSequenceidDelete (string sequenceId);
  
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundSequencesSequenceidDeleteWithHttpInfo (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundSequencesSequenceidDeleteAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundSequencesSequenceidDeleteAsyncWithHttpInfo (string sequenceId);
        
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping OutboundWrapupcodemappingsGet ();
  
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> OutboundWrapupcodemappingsGetWithHttpInfo ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> OutboundWrapupcodemappingsGetAsync ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> OutboundWrapupcodemappingsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping OutboundWrapupcodemappingsPut (WrapUpCodeMapping body = null);
  
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> OutboundWrapupcodemappingsPutWithHttpInfo (WrapUpCodeMapping body = null);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> OutboundWrapupcodemappingsPutAsync (WrapUpCodeMapping body = null);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> OutboundWrapupcodemappingsPutAsyncWithHttpInfo (WrapUpCodeMapping body = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OutboundApi : IOutboundApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OutboundApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OutboundApi(Configuration configuration = null)
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
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <param name="body">AuditSearch</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="facetsOnly">Facets only</param> 
        /// <returns>AuditSearchResult</returns>
        public AuditSearchResult OutboundAuditsPost (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> response = OutboundAuditsPostWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
             return response.Data;
        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <param name="body">AuditSearch</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="facetsOnly">Facets only</param> 
        /// <returns>ApiResponse of AuditSearchResult</returns>
        public ApiResponse< AuditSearchResult > OutboundAuditsPostWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
            
    
            var path_ = "/api/v1/outbound/audits";
    
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
            if (facetsOnly != null) queryParams.Add("facetsOnly", Configuration.ApiClient.ParameterToString(facetsOnly)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundAuditsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundAuditsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AuditSearchResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(response, typeof(AuditSearchResult)));
            
        }
    
        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="facetsOnly">Facets only</param>
        /// <returns>Task of AuditSearchResult</returns>
        public async System.Threading.Tasks.Task<AuditSearchResult> OutboundAuditsPostAsync (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> response = await OutboundAuditsPostAsyncWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
             return response.Data;

        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="facetsOnly">Facets only</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> OutboundAuditsPostAsyncWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
            
    
            var path_ = "/api/v1/outbound/audits";
    
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
            if (facetsOnly != null) queryParams.Add("facetsOnly", Configuration.ApiClient.ParameterToString(facetsOnly)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundAuditsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundAuditsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AuditSearchResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(response, typeof(AuditSearchResult)));
            
        }
        
        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>CallableTimeSetEntityListing</returns>
        public CallableTimeSetEntityListing OutboundCallabletimesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> response = OutboundCallabletimesetsGetWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of CallableTimeSetEntityListing</returns>
        public ApiResponse< CallableTimeSetEntityListing > OutboundCallabletimesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/callabletimesets";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallableTimeSetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSetEntityListing)));
            
        }
    
        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of CallableTimeSetEntityListing</returns>
        public async System.Threading.Tasks.Task<CallableTimeSetEntityListing> OutboundCallabletimesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> response = await OutboundCallabletimesetsGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (CallableTimeSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> OutboundCallabletimesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/callabletimesets";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallableTimeSetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSetEntityListing)));
            
        }
        
        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <param name="body">DialerCallableTimeSet</param> 
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet OutboundCallabletimesetsPost (CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> response = OutboundCallabletimesetsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <param name="body">DialerCallableTimeSet</param> 
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > OutboundCallabletimesetsPostWithHttpInfo (CallableTimeSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/callabletimesets";
    
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
    
        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsPostAsync (CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> response = await OutboundCallabletimesetsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsPostAsyncWithHttpInfo (CallableTimeSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/callabletimesets";
    
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
        
        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet OutboundCallabletimesetsCallabletimesetidGet (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> response = OutboundCallabletimesetsCallabletimesetidGetWithHttpInfo(callableTimeSetId);
             return response.Data;
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > OutboundCallabletimesetsCallabletimesetidGetWithHttpInfo (string callableTimeSetId)
        {
            
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null) throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundCallabletimesetsCallabletimesetidGet");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
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
            if (callableTimeSetId != null) pathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
    
        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidGetAsync (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> response = await OutboundCallabletimesetsCallabletimesetidGetAsyncWithHttpInfo(callableTimeSetId);
             return response.Data;

        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsCallabletimesetidGetAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null) throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundCallabletimesetsCallabletimesetidGet");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
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
            if (callableTimeSetId != null) pathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
        
        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <param name="body">DialerCallableTimeSet</param> 
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet OutboundCallabletimesetsCallabletimesetidPut (string callableTimeSetId, CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> response = OutboundCallabletimesetsCallabletimesetidPutWithHttpInfo(callableTimeSetId, body);
             return response.Data;
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <param name="body">DialerCallableTimeSet</param> 
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > OutboundCallabletimesetsCallabletimesetidPutWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null)
        {
            
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null) throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundCallabletimesetsCallabletimesetidPut");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
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
            if (callableTimeSetId != null) pathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
    
        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidPutAsync (string callableTimeSetId, CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> response = await OutboundCallabletimesetsCallabletimesetidPutAsyncWithHttpInfo(callableTimeSetId, body);
             return response.Data;

        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsCallabletimesetidPutAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null) throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundCallabletimesetsCallabletimesetidPut");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
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
            if (callableTimeSetId != null) pathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
        
        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <returns>string</returns>
        public string OutboundCallabletimesetsCallabletimesetidDelete (string callableTimeSetId)
        {
             ApiResponse<string> response = OutboundCallabletimesetsCallabletimesetidDeleteWithHttpInfo(callableTimeSetId);
             return response.Data;
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundCallabletimesetsCallabletimesetidDeleteWithHttpInfo (string callableTimeSetId)
        {
            
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null) throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundCallabletimesetsCallabletimesetidDelete");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
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
            if (callableTimeSetId != null) pathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundCallabletimesetsCallabletimesetidDeleteAsync (string callableTimeSetId)
        {
             ApiResponse<string> response = await OutboundCallabletimesetsCallabletimesetidDeleteAsyncWithHttpInfo(callableTimeSetId);
             return response.Data;

        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundCallabletimesetsCallabletimesetidDeleteAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null) throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundCallabletimesetsCallabletimesetidDelete");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
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
            if (callableTimeSetId != null) pathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallabletimesetsCallabletimesetidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ResponseSetEntityListing</returns>
        public ResponseSetEntityListing OutboundCallanalysisresponsesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> response = OutboundCallanalysisresponsesetsGetWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ResponseSetEntityListing</returns>
        public ApiResponse< ResponseSetEntityListing > OutboundCallanalysisresponsesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResponseSetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ResponseSetEntityListing)));
            
        }
    
        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ResponseSetEntityListing</returns>
        public async System.Threading.Tasks.Task<ResponseSetEntityListing> OutboundCallanalysisresponsesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> response = await OutboundCallanalysisresponsesetsGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ResponseSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> OutboundCallanalysisresponsesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseSetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ResponseSetEntityListing)));
            
        }
        
        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <param name="body">ResponseSet</param> 
        /// <returns>ResponseSet</returns>
        public ResponseSet OutboundCallanalysisresponsesetsPost (ResponseSet body = null)
        {
             ApiResponse<ResponseSet> response = OutboundCallanalysisresponsesetsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <param name="body">ResponseSet</param> 
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > OutboundCallanalysisresponsesetsPostWithHttpInfo (ResponseSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets";
    
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
    
        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsPostAsync (ResponseSet body = null)
        {
             ApiResponse<ResponseSet> response = await OutboundCallanalysisresponsesetsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsPostAsyncWithHttpInfo (ResponseSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets";
    
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
        
        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <returns>ResponseSet</returns>
        public ResponseSet OutboundCallanalysisresponsesetsCallanalysissetidGet (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> response = OutboundCallanalysisresponsesetsCallanalysissetidGetWithHttpInfo(callAnalysisSetId);
             return response.Data;
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > OutboundCallanalysisresponsesetsCallanalysissetidGetWithHttpInfo (string callAnalysisSetId)
        {
            
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null) throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundCallanalysisresponsesetsCallanalysissetidGet");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
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
            if (callAnalysisSetId != null) pathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
    
        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidGetAsync (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> response = await OutboundCallanalysisresponsesetsCallanalysissetidGetAsyncWithHttpInfo(callAnalysisSetId);
             return response.Data;

        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsCallanalysissetidGetAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null) throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundCallanalysisresponsesetsCallanalysissetidGet");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
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
            if (callAnalysisSetId != null) pathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
        
        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <param name="body">ResponseSet</param> 
        /// <returns>ResponseSet</returns>
        public ResponseSet OutboundCallanalysisresponsesetsCallanalysissetidPut (string callAnalysisSetId, ResponseSet body = null)
        {
             ApiResponse<ResponseSet> response = OutboundCallanalysisresponsesetsCallanalysissetidPutWithHttpInfo(callAnalysisSetId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <param name="body">ResponseSet</param> 
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > OutboundCallanalysisresponsesetsCallanalysissetidPutWithHttpInfo (string callAnalysisSetId, ResponseSet body = null)
        {
            
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null) throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundCallanalysisresponsesetsCallanalysissetidPut");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
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
            if (callAnalysisSetId != null) pathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
    
        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidPutAsync (string callAnalysisSetId, ResponseSet body = null)
        {
             ApiResponse<ResponseSet> response = await OutboundCallanalysisresponsesetsCallanalysissetidPutAsyncWithHttpInfo(callAnalysisSetId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsCallanalysissetidPutAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body = null)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null) throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundCallanalysisresponsesetsCallanalysissetidPut");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
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
            if (callAnalysisSetId != null) pathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
        
        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <returns>string</returns>
        public string OutboundCallanalysisresponsesetsCallanalysissetidDelete (string callAnalysisSetId)
        {
             ApiResponse<string> response = OutboundCallanalysisresponsesetsCallanalysissetidDeleteWithHttpInfo(callAnalysisSetId);
             return response.Data;
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundCallanalysisresponsesetsCallanalysissetidDeleteWithHttpInfo (string callAnalysisSetId)
        {
            
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null) throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundCallanalysisresponsesetsCallanalysissetidDelete");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
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
            if (callAnalysisSetId != null) pathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsync (string callAnalysisSetId)
        {
             ApiResponse<string> response = await OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsyncWithHttpInfo(callAnalysisSetId);
             return response.Data;

        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null) throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundCallanalysisresponsesetsCallanalysissetidDelete");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
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
            if (callAnalysisSetId != null) pathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="dncListId">DNC list ID</param> 
        /// <param name="distributionQueueId">Distribution queue ID</param> 
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>CampaignEntityListing</returns>
        public CampaignEntityListing OutboundCampaignsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> response = OutboundCampaignsGetWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="dncListId">DNC list ID</param> 
        /// <param name="distributionQueueId">Distribution queue ID</param> 
        /// <param name="edgeGroupId">Edge group ID</param> 
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of CampaignEntityListing</returns>
        public ApiResponse< CampaignEntityListing > OutboundCampaignsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/campaigns";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (contactListId != null) queryParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // query parameter
            if (dncListId != null) queryParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // query parameter
            if (distributionQueueId != null) queryParams.Add("distributionQueueId", Configuration.ApiClient.ParameterToString(distributionQueueId)); // query parameter
            if (edgeGroupId != null) queryParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (callAnalysisResponseSetId != null) queryParams.Add("callAnalysisResponseSetId", Configuration.ApiClient.ParameterToString(callAnalysisResponseSetId)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CampaignEntityListing)));
            
        }
    
        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="dncListId">DNC list ID</param>
        /// <param name="distributionQueueId">Distribution queue ID</param>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of CampaignEntityListing</returns>
        public async System.Threading.Tasks.Task<CampaignEntityListing> OutboundCampaignsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> response = await OutboundCampaignsGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="dncListId">DNC list ID</param>
        /// <param name="distributionQueueId">Distribution queue ID</param>
        /// <param name="edgeGroupId">Edge group ID</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (CampaignEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> OutboundCampaignsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/campaigns";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (contactListId != null) queryParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // query parameter
            if (dncListId != null) queryParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // query parameter
            if (distributionQueueId != null) queryParams.Add("distributionQueueId", Configuration.ApiClient.ParameterToString(distributionQueueId)); // query parameter
            if (edgeGroupId != null) queryParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (callAnalysisResponseSetId != null) queryParams.Add("callAnalysisResponseSetId", Configuration.ApiClient.ParameterToString(callAnalysisResponseSetId)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CampaignEntityListing)));
            
        }
        
        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <param name="body">Campaign</param> 
        /// <returns>Campaign</returns>
        public Campaign OutboundCampaignsPost (Campaign body = null)
        {
             ApiResponse<Campaign> response = OutboundCampaignsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <param name="body">Campaign</param> 
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > OutboundCampaignsPostWithHttpInfo (Campaign body = null)
        {
            
    
            var path_ = "/api/v1/outbound/campaigns";
    
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
    
        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> OutboundCampaignsPostAsync (Campaign body = null)
        {
             ApiResponse<Campaign> response = await OutboundCampaignsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsPostAsyncWithHttpInfo (Campaign body = null)
        {
            
    
            var path_ = "/api/v1/outbound/campaigns";
    
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
        
        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>Campaign</returns>
        public Campaign OutboundCampaignsCampaignidGet (string campaignId)
        {
             ApiResponse<Campaign> response = OutboundCampaignsCampaignidGetWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > OutboundCampaignsCampaignidGetWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidGet");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
    
        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> OutboundCampaignsCampaignidGetAsync (string campaignId)
        {
             ApiResponse<Campaign> response = await OutboundCampaignsCampaignidGetAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsCampaignidGetAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidGet");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
        
        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="body">Campaign</param> 
        /// <returns>Campaign</returns>
        public Campaign OutboundCampaignsCampaignidPut (string campaignId, Campaign body = null)
        {
             ApiResponse<Campaign> response = OutboundCampaignsCampaignidPutWithHttpInfo(campaignId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="body">Campaign</param> 
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > OutboundCampaignsCampaignidPutWithHttpInfo (string campaignId, Campaign body = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidPut");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
    
        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> OutboundCampaignsCampaignidPutAsync (string campaignId, Campaign body = null)
        {
             ApiResponse<Campaign> response = await OutboundCampaignsCampaignidPutAsyncWithHttpInfo(campaignId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsCampaignidPutAsyncWithHttpInfo (string campaignId, Campaign body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidPut");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
        
        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>string</returns>
        public string OutboundCampaignsCampaignidDelete (string campaignId)
        {
             ApiResponse<string> response = OutboundCampaignsCampaignidDeleteWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundCampaignsCampaignidDeleteWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidDelete");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundCampaignsCampaignidDeleteAsync (string campaignId)
        {
             ApiResponse<string> response = await OutboundCampaignsCampaignidDeleteAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundCampaignsCampaignidDeleteAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidDelete");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Send notification that an agent&#39;s state changed New agent state.
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="userId">Agent&#39;s user ID</param> 
        /// <param name="body">agent</param> 
        /// <returns>string</returns>
        public string OutboundCampaignsCampaignidAgentsUseridPut (string campaignId, string userId, Agent body = null)
        {
             ApiResponse<string> response = OutboundCampaignsCampaignidAgentsUseridPutWithHttpInfo(campaignId, userId, body);
             return response.Data;
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed New agent state.
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="userId">Agent&#39;s user ID</param> 
        /// <param name="body">agent</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundCampaignsCampaignidAgentsUseridPutWithHttpInfo (string campaignId, string userId, Agent body = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidAgentsUseridPut");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundCampaignsCampaignidAgentsUseridPut");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/agents/{userId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidAgentsUseridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidAgentsUseridPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Send notification that an agent&#39;s state changed New agent state.
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundCampaignsCampaignidAgentsUseridPutAsync (string campaignId, string userId, Agent body = null)
        {
             ApiResponse<string> response = await OutboundCampaignsCampaignidAgentsUseridPutAsyncWithHttpInfo(campaignId, userId, body);
             return response.Data;

        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed New agent state.
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundCampaignsCampaignidAgentsUseridPutAsyncWithHttpInfo (string campaignId, string userId, Agent body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidAgentsUseridPut");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundCampaignsCampaignidAgentsUseridPut");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/agents/{userId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidAgentsUseridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidAgentsUseridPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="body">ContactCallbackRequest</param> 
        /// <returns>ContactCallbackRequest</returns>
        public ContactCallbackRequest OutboundCampaignsCampaignidCallbackSchedulePost (string campaignId, ContactCallbackRequest body = null)
        {
             ApiResponse<ContactCallbackRequest> response = OutboundCampaignsCampaignidCallbackSchedulePostWithHttpInfo(campaignId, body);
             return response.Data;
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="body">ContactCallbackRequest</param> 
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        public ApiResponse< ContactCallbackRequest > OutboundCampaignsCampaignidCallbackSchedulePostWithHttpInfo (string campaignId, ContactCallbackRequest body = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidCallbackSchedulePost");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/callback/schedule";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidCallbackSchedulePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidCallbackSchedulePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactCallbackRequest>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(response, typeof(ContactCallbackRequest)));
            
        }
    
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        public async System.Threading.Tasks.Task<ContactCallbackRequest> OutboundCampaignsCampaignidCallbackSchedulePostAsync (string campaignId, ContactCallbackRequest body = null)
        {
             ApiResponse<ContactCallbackRequest> response = await OutboundCampaignsCampaignidCallbackSchedulePostAsyncWithHttpInfo(campaignId, body);
             return response.Data;

        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> OutboundCampaignsCampaignidCallbackSchedulePostAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidCallbackSchedulePost");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/callback/schedule";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidCallbackSchedulePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidCallbackSchedulePost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactCallbackRequest>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(response, typeof(ContactCallbackRequest)));
            
        }
        
        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>CampaignDiagnostics</returns>
        public CampaignDiagnostics OutboundCampaignsCampaignidDiagnosticsGet (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> response = OutboundCampaignsCampaignidDiagnosticsGetWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        public ApiResponse< CampaignDiagnostics > OutboundCampaignsCampaignidDiagnosticsGetWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidDiagnosticsGet");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/diagnostics";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidDiagnosticsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidDiagnosticsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignDiagnostics>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(response, typeof(CampaignDiagnostics)));
            
        }
    
        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        public async System.Threading.Tasks.Task<CampaignDiagnostics> OutboundCampaignsCampaignidDiagnosticsGetAsync (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> response = await OutboundCampaignsCampaignidDiagnosticsGetAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> OutboundCampaignsCampaignidDiagnosticsGetAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidDiagnosticsGet");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/diagnostics";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidDiagnosticsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidDiagnosticsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignDiagnostics>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(response, typeof(CampaignDiagnostics)));
            
        }
        
        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>CampaignStats</returns>
        public CampaignStats OutboundCampaignsCampaignidStatsGet (string campaignId)
        {
             ApiResponse<CampaignStats> response = OutboundCampaignsCampaignidStatsGetWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of CampaignStats</returns>
        public ApiResponse< CampaignStats > OutboundCampaignsCampaignidStatsGetWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidStatsGet");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/stats";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidStatsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidStatsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignStats>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignStats) Configuration.ApiClient.Deserialize(response, typeof(CampaignStats)));
            
        }
    
        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        public async System.Threading.Tasks.Task<CampaignStats> OutboundCampaignsCampaignidStatsGetAsync (string campaignId)
        {
             ApiResponse<CampaignStats> response = await OutboundCampaignsCampaignidStatsGetAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignStats>> OutboundCampaignsCampaignidStatsGetAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundCampaignsCampaignidStatsGet");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/stats";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidStatsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundCampaignsCampaignidStatsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignStats>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignStats) Configuration.ApiClient.Deserialize(response, typeof(CampaignStats)));
            
        }
        
        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ContactListEntityListing</returns>
        public ContactListEntityListing OutboundContactlistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> response = OutboundContactlistsGetWithHttpInfo(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        public ApiResponse< ContactListEntityListing > OutboundContactlistsGetWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists";
    
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
            
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactListEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ContactListEntityListing)));
            
        }
    
        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ContactListEntityListing</returns>
        public async System.Threading.Tasks.Task<ContactListEntityListing> OutboundContactlistsGetAsync (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> response = await OutboundContactlistsGetAsyncWithHttpInfo(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> OutboundContactlistsGetAsyncWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists";
    
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
            
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactListEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ContactListEntityListing)));
            
        }
        
        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <param name="body">ContactList</param> 
        /// <returns>ContactList</returns>
        public ContactList OutboundContactlistsPost (ContactList body = null)
        {
             ApiResponse<ContactList> response = OutboundContactlistsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <param name="body">ContactList</param> 
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > OutboundContactlistsPostWithHttpInfo (ContactList body = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists";
    
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
    
        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> OutboundContactlistsPostAsync (ContactList body = null)
        {
             ApiResponse<ContactList> response = await OutboundContactlistsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsPostAsyncWithHttpInfo (ContactList body = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists";
    
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
        
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <param name="body">PenetrationRateIdentifierList</param> 
        /// <returns>List&lt;PenetrationRate&gt;</returns>
        public List<PenetrationRate> OutboundContactlistsPenetrationratesPost (List<PenetrationRateId> body = null)
        {
             ApiResponse<List<PenetrationRate>> response = OutboundContactlistsPenetrationratesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <param name="body">PenetrationRateIdentifierList</param> 
        /// <returns>ApiResponse of List&lt;PenetrationRate&gt;</returns>
        public ApiResponse< List<PenetrationRate> > OutboundContactlistsPenetrationratesPostWithHttpInfo (List<PenetrationRateId> body = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists/penetrationrates";
    
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsPenetrationratesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsPenetrationratesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<PenetrationRate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PenetrationRate>) Configuration.ApiClient.Deserialize(response, typeof(List<PenetrationRate>)));
            
        }
    
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>Task of List&lt;PenetrationRate&gt;</returns>
        public async System.Threading.Tasks.Task<List<PenetrationRate>> OutboundContactlistsPenetrationratesPostAsync (List<PenetrationRateId> body = null)
        {
             ApiResponse<List<PenetrationRate>> response = await OutboundContactlistsPenetrationratesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>Task of ApiResponse (List&lt;PenetrationRate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PenetrationRate>>> OutboundContactlistsPenetrationratesPostAsyncWithHttpInfo (List<PenetrationRateId> body = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists/penetrationrates";
    
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsPenetrationratesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsPenetrationratesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<PenetrationRate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PenetrationRate>) Configuration.ApiClient.Deserialize(response, typeof(List<PenetrationRate>)));
            
        }
        
        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <returns>ContactList</returns>
        public ContactList OutboundContactlistsContactlistidGet (string contactListId, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> response = OutboundContactlistsContactlistidGetWithHttpInfo(contactListId, importStatus, includeSize);
             return response.Data;
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > OutboundContactlistsContactlistidGetWithHttpInfo (string contactListId, bool? importStatus = null, bool? includeSize = null)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidGet");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
    
        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> OutboundContactlistsContactlistidGetAsync (string contactListId, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> response = await OutboundContactlistsContactlistidGetAsyncWithHttpInfo(contactListId, importStatus, includeSize);
             return response.Data;

        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsContactlistidGetAsyncWithHttpInfo (string contactListId, bool? importStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidGet");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
        
        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="body">ContactList</param> 
        /// <returns>ContactList</returns>
        public ContactList OutboundContactlistsContactlistidPut (string contactListId, ContactList body = null)
        {
             ApiResponse<ContactList> response = OutboundContactlistsContactlistidPutWithHttpInfo(contactListId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="body">ContactList</param> 
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > OutboundContactlistsContactlistidPutWithHttpInfo (string contactListId, ContactList body = null)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidPut");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
    
        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> OutboundContactlistsContactlistidPutAsync (string contactListId, ContactList body = null)
        {
             ApiResponse<ContactList> response = await OutboundContactlistsContactlistidPutAsyncWithHttpInfo(contactListId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsContactlistidPutAsyncWithHttpInfo (string contactListId, ContactList body = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidPut");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
        
        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>string</returns>
        public string OutboundContactlistsContactlistidDelete (string contactListId)
        {
             ApiResponse<string> response = OutboundContactlistsContactlistidDeleteWithHttpInfo(contactListId);
             return response.Data;
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundContactlistsContactlistidDeleteWithHttpInfo (string contactListId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidDelete");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidDeleteAsync (string contactListId)
        {
             ApiResponse<string> response = await OutboundContactlistsContactlistidDeleteAsyncWithHttpInfo(contactListId);
             return response.Data;

        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidDeleteAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidDelete");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="body">Contact</param> 
        /// <param name="priority"></param> 
        /// <returns>Contact</returns>
        public Contact OutboundContactlistsContactlistidContactsPost (string contactListId, List<Contact> body = null, bool? priority = null)
        {
             ApiResponse<Contact> response = OutboundContactlistsContactlistidContactsPostWithHttpInfo(contactListId, body, priority);
             return response.Data;
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="body">Contact</param> 
        /// <param name="priority"></param> 
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > OutboundContactlistsContactlistidContactsPostWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidContactsPost");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            if (priority != null) queryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Contact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(response, typeof(Contact)));
            
        }
    
        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority"></param>
        /// <returns>Task of Contact</returns>
        public async System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsPostAsync (string contactListId, List<Contact> body = null, bool? priority = null)
        {
             ApiResponse<Contact> response = await OutboundContactlistsContactlistidContactsPostAsyncWithHttpInfo(contactListId, body, priority);
             return response.Data;

        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority"></param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsPostAsyncWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidContactsPost");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            if (priority != null) queryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Contact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(response, typeof(Contact)));
            
        }
        
        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="contactId">Contact ID</param> 
        /// <returns>Contact</returns>
        public Contact OutboundContactlistsContactlistidContactsContactidGet (string contactListId, string contactId)
        {
             ApiResponse<Contact> response = OutboundContactlistsContactlistidContactsContactidGetWithHttpInfo(contactListId, contactId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="contactId">Contact ID</param> 
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > OutboundContactlistsContactlistidContactsContactidGetWithHttpInfo (string contactListId, string contactId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidContactsContactidGet");
            
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundContactlistsContactlistidContactsContactidGet");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Contact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(response, typeof(Contact)));
            
        }
    
        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of Contact</returns>
        public async System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsContactidGetAsync (string contactListId, string contactId)
        {
             ApiResponse<Contact> response = await OutboundContactlistsContactlistidContactsContactidGetAsyncWithHttpInfo(contactListId, contactId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsContactidGetAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidContactsContactidGet");
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundContactlistsContactlistidContactsContactidGet");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Contact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(response, typeof(Contact)));
            
        }
        
        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="contactId">Contact ID</param> 
        /// <param name="body">Contact</param> 
        /// <returns>Contact</returns>
        public Contact OutboundContactlistsContactlistidContactsContactidPut (string contactListId, string contactId, Contact body = null)
        {
             ApiResponse<Contact> response = OutboundContactlistsContactlistidContactsContactidPutWithHttpInfo(contactListId, contactId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="contactId">Contact ID</param> 
        /// <param name="body">Contact</param> 
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > OutboundContactlistsContactlistidContactsContactidPutWithHttpInfo (string contactListId, string contactId, Contact body = null)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidContactsContactidPut");
            
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundContactlistsContactlistidContactsContactidPut");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Contact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(response, typeof(Contact)));
            
        }
    
        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of Contact</returns>
        public async System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsContactidPutAsync (string contactListId, string contactId, Contact body = null)
        {
             ApiResponse<Contact> response = await OutboundContactlistsContactlistidContactsContactidPutAsyncWithHttpInfo(contactListId, contactId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsContactidPutAsyncWithHttpInfo (string contactListId, string contactId, Contact body = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidContactsContactidPut");
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundContactlistsContactlistidContactsContactidPut");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Contact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(response, typeof(Contact)));
            
        }
        
        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="contactId">Contact ID</param> 
        /// <returns>string</returns>
        public string OutboundContactlistsContactlistidContactsContactidDelete (string contactListId, string contactId)
        {
             ApiResponse<string> response = OutboundContactlistsContactlistidContactsContactidDeleteWithHttpInfo(contactListId, contactId);
             return response.Data;
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="contactId">Contact ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundContactlistsContactlistidContactsContactidDeleteWithHttpInfo (string contactListId, string contactId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidContactsContactidDelete");
            
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundContactlistsContactlistidContactsContactidDelete");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidContactsContactidDeleteAsync (string contactListId, string contactId)
        {
             ApiResponse<string> response = await OutboundContactlistsContactlistidContactsContactidDeleteAsyncWithHttpInfo(contactListId, contactId);
             return response.Data;

        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidContactsContactidDeleteAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidContactsContactidDelete");
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundContactlistsContactlistidContactsContactidDelete");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidContactsContactidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>string</returns>
        public string OutboundContactlistsContactlistidExportPost (string contactListId)
        {
             ApiResponse<string> response = OutboundContactlistsContactlistidExportPostWithHttpInfo(contactListId);
             return response.Data;
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundContactlistsContactlistidExportPostWithHttpInfo (string contactListId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidExportPost");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/export";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidExportPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidExportPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidExportPostAsync (string contactListId)
        {
             ApiResponse<string> response = await OutboundContactlistsContactlistidExportPostAsyncWithHttpInfo(contactListId);
             return response.Data;

        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidExportPostAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidExportPost");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/export";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidExportPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidExportPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>ImportStatus</returns>
        public ImportStatus OutboundContactlistsContactlistidImportstatusGet (string contactListId)
        {
             ApiResponse<ImportStatus> response = OutboundContactlistsContactlistidImportstatusGetWithHttpInfo(contactListId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > OutboundContactlistsContactlistidImportstatusGetWithHttpInfo (string contactListId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidImportstatusGet");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/importstatus";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidImportstatusGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidImportstatusGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ImportStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(response, typeof(ImportStatus)));
            
        }
    
        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        public async System.Threading.Tasks.Task<ImportStatus> OutboundContactlistsContactlistidImportstatusGetAsync (string contactListId)
        {
             ApiResponse<ImportStatus> response = await OutboundContactlistsContactlistidImportstatusGetAsyncWithHttpInfo(contactListId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> OutboundContactlistsContactlistidImportstatusGetAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidImportstatusGet");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/importstatus";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidImportstatusGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidImportstatusGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ImportStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(response, typeof(ImportStatus)));
            
        }
        
        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>PenetrationRate</returns>
        public PenetrationRate OutboundContactlistsContactlistidCampaignidPenetrationrateGet (string contactListId, string campaignId)
        {
             ApiResponse<PenetrationRate> response = OutboundContactlistsContactlistidCampaignidPenetrationrateGetWithHttpInfo(contactListId, campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of PenetrationRate</returns>
        public ApiResponse< PenetrationRate > OutboundContactlistsContactlistidCampaignidPenetrationrateGetWithHttpInfo (string contactListId, string campaignId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet");
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/{campaignId}/penetrationrate";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PenetrationRate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PenetrationRate) Configuration.ApiClient.Deserialize(response, typeof(PenetrationRate)));
            
        }
    
        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of PenetrationRate</returns>
        public async System.Threading.Tasks.Task<PenetrationRate> OutboundContactlistsContactlistidCampaignidPenetrationrateGetAsync (string contactListId, string campaignId)
        {
             ApiResponse<PenetrationRate> response = await OutboundContactlistsContactlistidCampaignidPenetrationrateGetAsyncWithHttpInfo(contactListId, campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (PenetrationRate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PenetrationRate>> OutboundContactlistsContactlistidCampaignidPenetrationrateGetAsyncWithHttpInfo (string contactListId, string campaignId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet");
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/{campaignId}/penetrationrate";
    
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
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PenetrationRate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PenetrationRate) Configuration.ApiClient.Deserialize(response, typeof(PenetrationRate)));
            
        }
        
        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <returns></returns>
        public void OutboundConversationsConversationidDncPost (string conversationId)
        {
             OutboundConversationsConversationidDncPostWithHttpInfo(conversationId);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> OutboundConversationsConversationidDncPostWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundConversationsConversationidDncPost");
            
    
            var path_ = "/api/v1/outbound/conversations/{conversationId}/dnc";
    
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
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundConversationsConversationidDncPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundConversationsConversationidDncPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task OutboundConversationsConversationidDncPostAsync (string conversationId)
        {
             await OutboundConversationsConversationidDncPostAsyncWithHttpInfo(conversationId);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> OutboundConversationsConversationidDncPostAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundConversationsConversationidDncPost");
            
    
            var path_ = "/api/v1/outbound/conversations/{conversationId}/dnc";
    
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
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundConversationsConversationidDncPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundConversationsConversationidDncPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>DncListEntityListing</returns>
        public DncListEntityListing OutboundDnclistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> response = OutboundDnclistsGetWithHttpInfo(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of DncListEntityListing</returns>
        public ApiResponse< DncListEntityListing > OutboundDnclistsGetWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/dnclists";
    
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
            
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DncListEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncListEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DncListEntityListing)));
            
        }
    
        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of DncListEntityListing</returns>
        public async System.Threading.Tasks.Task<DncListEntityListing> OutboundDnclistsGetAsync (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> response = await OutboundDnclistsGetAsyncWithHttpInfo(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> OutboundDnclistsGetAsyncWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/dnclists";
    
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
            
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DncListEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncListEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DncListEntityListing)));
            
        }
        
        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <param name="body">DncList</param> 
        /// <returns>DncList</returns>
        public DncList OutboundDnclistsPost (DncList body = null)
        {
             ApiResponse<DncList> response = OutboundDnclistsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <param name="body">DncList</param> 
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > OutboundDnclistsPostWithHttpInfo (DncList body = null)
        {
            
    
            var path_ = "/api/v1/outbound/dnclists";
    
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
    
        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> OutboundDnclistsPostAsync (DncList body = null)
        {
             ApiResponse<DncList> response = await OutboundDnclistsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsPostAsyncWithHttpInfo (DncList body = null)
        {
            
    
            var path_ = "/api/v1/outbound/dnclists";
    
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
        
        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <returns>DncList</returns>
        public DncList OutboundDnclistsDnclistidGet (string dncListId, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> response = OutboundDnclistsDnclistidGetWithHttpInfo(dncListId, importStatus, includeSize);
             return response.Data;
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > OutboundDnclistsDnclistidGetWithHttpInfo (string dncListId, bool? importStatus = null, bool? includeSize = null)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidGet");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
    
        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> OutboundDnclistsDnclistidGetAsync (string dncListId, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> response = await OutboundDnclistsDnclistidGetAsyncWithHttpInfo(dncListId, importStatus, includeSize);
             return response.Data;

        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsDnclistidGetAsyncWithHttpInfo (string dncListId, bool? importStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidGet");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
        
        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="body">DncList</param> 
        /// <returns>DncList</returns>
        public DncList OutboundDnclistsDnclistidPut (string dncListId, DncList body = null)
        {
             ApiResponse<DncList> response = OutboundDnclistsDnclistidPutWithHttpInfo(dncListId, body);
             return response.Data;
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="body">DncList</param> 
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > OutboundDnclistsDnclistidPutWithHttpInfo (string dncListId, DncList body = null)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidPut");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
    
        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> OutboundDnclistsDnclistidPutAsync (string dncListId, DncList body = null)
        {
             ApiResponse<DncList> response = await OutboundDnclistsDnclistidPutAsyncWithHttpInfo(dncListId, body);
             return response.Data;

        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsDnclistidPutAsyncWithHttpInfo (string dncListId, DncList body = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidPut");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
        
        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>string</returns>
        public string OutboundDnclistsDnclistidDelete (string dncListId)
        {
             ApiResponse<string> response = OutboundDnclistsDnclistidDeleteWithHttpInfo(dncListId);
             return response.Data;
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundDnclistsDnclistidDeleteWithHttpInfo (string dncListId)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidDelete");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundDnclistsDnclistidDeleteAsync (string dncListId)
        {
             ApiResponse<string> response = await OutboundDnclistsDnclistidDeleteAsyncWithHttpInfo(dncListId);
             return response.Data;

        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundDnclistsDnclistidDeleteAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidDelete");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>string</returns>
        public string OutboundDnclistsDnclistidExportPost (string dncListId)
        {
             ApiResponse<string> response = OutboundDnclistsDnclistidExportPostWithHttpInfo(dncListId);
             return response.Data;
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundDnclistsDnclistidExportPostWithHttpInfo (string dncListId)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidExportPost");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/export";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidExportPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidExportPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundDnclistsDnclistidExportPostAsync (string dncListId)
        {
             ApiResponse<string> response = await OutboundDnclistsDnclistidExportPostAsyncWithHttpInfo(dncListId);
             return response.Data;

        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundDnclistsDnclistidExportPostAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidExportPost");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/export";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidExportPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidExportPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>ImportStatus</returns>
        public ImportStatus OutboundDnclistsDnclistidImportstatusGet (string dncListId)
        {
             ApiResponse<ImportStatus> response = OutboundDnclistsDnclistidImportstatusGetWithHttpInfo(dncListId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > OutboundDnclistsDnclistidImportstatusGetWithHttpInfo (string dncListId)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidImportstatusGet");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/importstatus";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidImportstatusGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidImportstatusGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ImportStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(response, typeof(ImportStatus)));
            
        }
    
        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        public async System.Threading.Tasks.Task<ImportStatus> OutboundDnclistsDnclistidImportstatusGetAsync (string dncListId)
        {
             ApiResponse<ImportStatus> response = await OutboundDnclistsDnclistidImportstatusGetAsyncWithHttpInfo(dncListId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> OutboundDnclistsDnclistidImportstatusGetAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidImportstatusGet");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/importstatus";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidImportstatusGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidImportstatusGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ImportStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(response, typeof(ImportStatus)));
            
        }
        
        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="body">DNC Phone Numbers</param> 
        /// <returns></returns>
        public void OutboundDnclistsDnclistidPhonenumbersPost (string dncListId, List<string> body = null)
        {
             OutboundDnclistsDnclistidPhonenumbersPostWithHttpInfo(dncListId, body);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="body">DNC Phone Numbers</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> OutboundDnclistsDnclistidPhonenumbersPostWithHttpInfo (string dncListId, List<string> body = null)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidPhonenumbersPost");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/phonenumbers";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidPhonenumbersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidPhonenumbersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task OutboundDnclistsDnclistidPhonenumbersPostAsync (string dncListId, List<string> body = null)
        {
             await OutboundDnclistsDnclistidPhonenumbersPostAsyncWithHttpInfo(dncListId, body);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> OutboundDnclistsDnclistidPhonenumbersPostAsyncWithHttpInfo (string dncListId, List<string> body = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundDnclistsDnclistidPhonenumbersPost");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/phonenumbers";
    
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
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidPhonenumbersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundDnclistsDnclistidPhonenumbersPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <returns>List&lt;Preview&gt;</returns>
        public List<Preview> OutboundPreviewsGet ()
        {
             ApiResponse<List<Preview>> response = OutboundPreviewsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <returns>ApiResponse of List&lt;Preview&gt;</returns>
        public ApiResponse< List<Preview> > OutboundPreviewsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/previews";
    
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
                throw new ApiException (statusCode, "Error calling OutboundPreviewsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundPreviewsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Preview>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Preview>) Configuration.ApiClient.Deserialize(response, typeof(List<Preview>)));
            
        }
    
        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <returns>Task of List&lt;Preview&gt;</returns>
        public async System.Threading.Tasks.Task<List<Preview>> OutboundPreviewsGetAsync ()
        {
             ApiResponse<List<Preview>> response = await OutboundPreviewsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;Preview&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Preview>>> OutboundPreviewsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/previews";
    
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
                throw new ApiException (statusCode, "Error calling OutboundPreviewsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundPreviewsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Preview>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Preview>) Configuration.ApiClient.Deserialize(response, typeof(List<Preview>)));
            
        }
        
        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <returns>Preview</returns>
        public Preview OutboundPreviewsPreviewidGet (string previewId)
        {
             ApiResponse<Preview> response = OutboundPreviewsPreviewidGetWithHttpInfo(previewId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <returns>ApiResponse of Preview</returns>
        public ApiResponse< Preview > OutboundPreviewsPreviewidGetWithHttpInfo (string previewId)
        {
            
            // verify the required parameter 'previewId' is set
            if (previewId == null) throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundPreviewsPreviewidGet");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}";
    
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
            if (previewId != null) pathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Preview>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Preview) Configuration.ApiClient.Deserialize(response, typeof(Preview)));
            
        }
    
        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of Preview</returns>
        public async System.Threading.Tasks.Task<Preview> OutboundPreviewsPreviewidGetAsync (string previewId)
        {
             ApiResponse<Preview> response = await OutboundPreviewsPreviewidGetAsyncWithHttpInfo(previewId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of ApiResponse (Preview)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Preview>> OutboundPreviewsPreviewidGetAsyncWithHttpInfo (string previewId)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null) throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundPreviewsPreviewidGet");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}";
    
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
            if (previewId != null) pathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Preview>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Preview) Configuration.ApiClient.Deserialize(response, typeof(Preview)));
            
        }
        
        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <param name="body"></param> 
        /// <returns>string</returns>
        public string OutboundPreviewsPreviewidDispositioncallPost (string previewId, DialerDispositionCallCommand body = null)
        {
             ApiResponse<string> response = OutboundPreviewsPreviewidDispositioncallPostWithHttpInfo(previewId, body);
             return response.Data;
        }

        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundPreviewsPreviewidDispositioncallPostWithHttpInfo (string previewId, DialerDispositionCallCommand body = null)
        {
            
            // verify the required parameter 'previewId' is set
            if (previewId == null) throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundPreviewsPreviewidDispositioncallPost");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}/dispositioncall";
    
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
            if (previewId != null) pathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidDispositioncallPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidDispositioncallPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundPreviewsPreviewidDispositioncallPostAsync (string previewId, DialerDispositionCallCommand body = null)
        {
             ApiResponse<string> response = await OutboundPreviewsPreviewidDispositioncallPostAsyncWithHttpInfo(previewId, body);
             return response.Data;

        }

        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundPreviewsPreviewidDispositioncallPostAsyncWithHttpInfo (string previewId, DialerDispositionCallCommand body = null)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null) throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundPreviewsPreviewidDispositioncallPost");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}/dispositioncall";
    
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
            if (previewId != null) pathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidDispositioncallPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidDispositioncallPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// place preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <param name="body"></param> 
        /// <returns>DialerCall</returns>
        public DialerCall OutboundPreviewsPreviewidPlacecallPost (string previewId, DialerPlaceCallCommand body = null)
        {
             ApiResponse<DialerCall> response = OutboundPreviewsPreviewidPlacecallPostWithHttpInfo(previewId, body);
             return response.Data;
        }

        /// <summary>
        /// place preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DialerCall</returns>
        public ApiResponse< DialerCall > OutboundPreviewsPreviewidPlacecallPostWithHttpInfo (string previewId, DialerPlaceCallCommand body = null)
        {
            
            // verify the required parameter 'previewId' is set
            if (previewId == null) throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundPreviewsPreviewidPlacecallPost");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}/placecall";
    
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
            if (previewId != null) pathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidPlacecallPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidPlacecallPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DialerCall>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DialerCall) Configuration.ApiClient.Deserialize(response, typeof(DialerCall)));
            
        }
    
        /// <summary>
        /// place preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DialerCall</returns>
        public async System.Threading.Tasks.Task<DialerCall> OutboundPreviewsPreviewidPlacecallPostAsync (string previewId, DialerPlaceCallCommand body = null)
        {
             ApiResponse<DialerCall> response = await OutboundPreviewsPreviewidPlacecallPostAsyncWithHttpInfo(previewId, body);
             return response.Data;

        }

        /// <summary>
        /// place preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DialerCall)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DialerCall>> OutboundPreviewsPreviewidPlacecallPostAsyncWithHttpInfo (string previewId, DialerPlaceCallCommand body = null)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null) throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundPreviewsPreviewidPlacecallPost");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}/placecall";
    
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
            if (previewId != null) pathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidPlacecallPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundPreviewsPreviewidPlacecallPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DialerCall>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DialerCall) Configuration.ApiClient.Deserialize(response, typeof(DialerCall)));
            
        }
        
        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>RuleSetEntityListing</returns>
        public RuleSetEntityListing OutboundRulesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> response = OutboundRulesetsGetWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of RuleSetEntityListing</returns>
        public ApiResponse< RuleSetEntityListing > OutboundRulesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/rulesets";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RuleSetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(RuleSetEntityListing)));
            
        }
    
        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of RuleSetEntityListing</returns>
        public async System.Threading.Tasks.Task<RuleSetEntityListing> OutboundRulesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> response = await OutboundRulesetsGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (RuleSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> OutboundRulesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/rulesets";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RuleSetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(RuleSetEntityListing)));
            
        }
        
        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <param name="body">RuleSet</param> 
        /// <returns>RuleSet</returns>
        public RuleSet OutboundRulesetsPost (RuleSet body = null)
        {
             ApiResponse<RuleSet> response = OutboundRulesetsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <param name="body">RuleSet</param> 
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > OutboundRulesetsPostWithHttpInfo (RuleSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/rulesets";
    
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
    
        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> OutboundRulesetsPostAsync (RuleSet body = null)
        {
             ApiResponse<RuleSet> response = await OutboundRulesetsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsPostAsyncWithHttpInfo (RuleSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/rulesets";
    
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
        
        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <returns>RuleSet</returns>
        public RuleSet OutboundRulesetsRulesetidGet (string ruleSetId)
        {
             ApiResponse<RuleSet> response = OutboundRulesetsRulesetidGetWithHttpInfo(ruleSetId);
             return response.Data;
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > OutboundRulesetsRulesetidGetWithHttpInfo (string ruleSetId)
        {
            
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null) throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundRulesetsRulesetidGet");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
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
            if (ruleSetId != null) pathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
    
        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> OutboundRulesetsRulesetidGetAsync (string ruleSetId)
        {
             ApiResponse<RuleSet> response = await OutboundRulesetsRulesetidGetAsyncWithHttpInfo(ruleSetId);
             return response.Data;

        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsRulesetidGetAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null) throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundRulesetsRulesetidGet");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
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
            if (ruleSetId != null) pathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
        
        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <param name="body">RuleSet</param> 
        /// <returns>RuleSet</returns>
        public RuleSet OutboundRulesetsRulesetidPut (string ruleSetId, RuleSet body = null)
        {
             ApiResponse<RuleSet> response = OutboundRulesetsRulesetidPutWithHttpInfo(ruleSetId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <param name="body">RuleSet</param> 
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > OutboundRulesetsRulesetidPutWithHttpInfo (string ruleSetId, RuleSet body = null)
        {
            
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null) throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundRulesetsRulesetidPut");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
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
            if (ruleSetId != null) pathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
    
        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> OutboundRulesetsRulesetidPutAsync (string ruleSetId, RuleSet body = null)
        {
             ApiResponse<RuleSet> response = await OutboundRulesetsRulesetidPutAsyncWithHttpInfo(ruleSetId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsRulesetidPutAsyncWithHttpInfo (string ruleSetId, RuleSet body = null)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null) throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundRulesetsRulesetidPut");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
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
            if (ruleSetId != null) pathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
        
        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <returns>string</returns>
        public string OutboundRulesetsRulesetidDelete (string ruleSetId)
        {
             ApiResponse<string> response = OutboundRulesetsRulesetidDeleteWithHttpInfo(ruleSetId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundRulesetsRulesetidDeleteWithHttpInfo (string ruleSetId)
        {
            
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null) throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundRulesetsRulesetidDelete");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
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
            if (ruleSetId != null) pathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundRulesetsRulesetidDeleteAsync (string ruleSetId)
        {
             ApiResponse<string> response = await OutboundRulesetsRulesetidDeleteAsyncWithHttpInfo(ruleSetId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundRulesetsRulesetidDeleteAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null) throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundRulesetsRulesetidDelete");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
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
            if (ruleSetId != null) pathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundRulesetsRulesetidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        public List<CampaignSchedule> OutboundSchedulesCampaignsGet ()
        {
             ApiResponse<List<CampaignSchedule>> response = OutboundSchedulesCampaignsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        public ApiResponse< List<CampaignSchedule> > OutboundSchedulesCampaignsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns";
    
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<CampaignSchedule>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(response, typeof(List<CampaignSchedule>)));
            
        }
    
        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<CampaignSchedule>> OutboundSchedulesCampaignsGetAsync ()
        {
             ApiResponse<List<CampaignSchedule>> response = await OutboundSchedulesCampaignsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> OutboundSchedulesCampaignsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns";
    
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<CampaignSchedule>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(response, typeof(List<CampaignSchedule>)));
            
        }
        
        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule OutboundSchedulesCampaignsCampaignidGet (string campaignId)
        {
             ApiResponse<CampaignSchedule> response = OutboundSchedulesCampaignsCampaignidGetWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > OutboundSchedulesCampaignsCampaignidGetWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundSchedulesCampaignsCampaignidGet");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(response, typeof(CampaignSchedule)));
            
        }
    
        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        public async System.Threading.Tasks.Task<CampaignSchedule> OutboundSchedulesCampaignsCampaignidGetAsync (string campaignId)
        {
             ApiResponse<CampaignSchedule> response = await OutboundSchedulesCampaignsCampaignidGetAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> OutboundSchedulesCampaignsCampaignidGetAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundSchedulesCampaignsCampaignidGet");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(response, typeof(CampaignSchedule)));
            
        }
        
        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="body">CampaignSchedule</param> 
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule OutboundSchedulesCampaignsCampaignidPut (string campaignId, CampaignSchedule body = null)
        {
             ApiResponse<CampaignSchedule> response = OutboundSchedulesCampaignsCampaignidPutWithHttpInfo(campaignId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="body">CampaignSchedule</param> 
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > OutboundSchedulesCampaignsCampaignidPutWithHttpInfo (string campaignId, CampaignSchedule body = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundSchedulesCampaignsCampaignidPut");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(response, typeof(CampaignSchedule)));
            
        }
    
        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of CampaignSchedule</returns>
        public async System.Threading.Tasks.Task<CampaignSchedule> OutboundSchedulesCampaignsCampaignidPutAsync (string campaignId, CampaignSchedule body = null)
        {
             ApiResponse<CampaignSchedule> response = await OutboundSchedulesCampaignsCampaignidPutAsyncWithHttpInfo(campaignId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> OutboundSchedulesCampaignsCampaignidPutAsyncWithHttpInfo (string campaignId, CampaignSchedule body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundSchedulesCampaignsCampaignidPut");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(response, typeof(CampaignSchedule)));
            
        }
        
        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>string</returns>
        public string OutboundSchedulesCampaignsCampaignidDelete (string campaignId)
        {
             ApiResponse<string> response = OutboundSchedulesCampaignsCampaignidDeleteWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundSchedulesCampaignsCampaignidDeleteWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundSchedulesCampaignsCampaignidDelete");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundSchedulesCampaignsCampaignidDeleteAsync (string campaignId)
        {
             ApiResponse<string> response = await OutboundSchedulesCampaignsCampaignidDeleteAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundSchedulesCampaignsCampaignidDeleteAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundSchedulesCampaignsCampaignidDelete");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
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
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesCampaignsCampaignidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        public List<SequenceSchedule> OutboundSchedulesSequencesGet ()
        {
             ApiResponse<List<SequenceSchedule>> response = OutboundSchedulesSequencesGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        public ApiResponse< List<SequenceSchedule> > OutboundSchedulesSequencesGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/schedules/sequences";
    
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<SequenceSchedule>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(response, typeof(List<SequenceSchedule>)));
            
        }
    
        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<SequenceSchedule>> OutboundSchedulesSequencesGetAsync ()
        {
             ApiResponse<List<SequenceSchedule>> response = await OutboundSchedulesSequencesGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> OutboundSchedulesSequencesGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/schedules/sequences";
    
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<SequenceSchedule>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(response, typeof(List<SequenceSchedule>)));
            
        }
        
        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule OutboundSchedulesSequencesSequenceidGet (string sequenceId)
        {
             ApiResponse<SequenceSchedule> response = OutboundSchedulesSequencesSequenceidGetWithHttpInfo(sequenceId);
             return response.Data;
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > OutboundSchedulesSequencesSequenceidGetWithHttpInfo (string sequenceId)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSchedulesSequencesSequenceidGet");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SequenceSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(response, typeof(SequenceSchedule)));
            
        }
    
        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        public async System.Threading.Tasks.Task<SequenceSchedule> OutboundSchedulesSequencesSequenceidGetAsync (string sequenceId)
        {
             ApiResponse<SequenceSchedule> response = await OutboundSchedulesSequencesSequenceidGetAsyncWithHttpInfo(sequenceId);
             return response.Data;

        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> OutboundSchedulesSequencesSequenceidGetAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSchedulesSequencesSequenceidGet");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(response, typeof(SequenceSchedule)));
            
        }
        
        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <param name="body">SequenceSchedule</param> 
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule OutboundSchedulesSequencesSequenceidPut (string sequenceId, SequenceSchedule body = null)
        {
             ApiResponse<SequenceSchedule> response = OutboundSchedulesSequencesSequenceidPutWithHttpInfo(sequenceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <param name="body">SequenceSchedule</param> 
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > OutboundSchedulesSequencesSequenceidPutWithHttpInfo (string sequenceId, SequenceSchedule body = null)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSchedulesSequencesSequenceidPut");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SequenceSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(response, typeof(SequenceSchedule)));
            
        }
    
        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of SequenceSchedule</returns>
        public async System.Threading.Tasks.Task<SequenceSchedule> OutboundSchedulesSequencesSequenceidPutAsync (string sequenceId, SequenceSchedule body = null)
        {
             ApiResponse<SequenceSchedule> response = await OutboundSchedulesSequencesSequenceidPutAsyncWithHttpInfo(sequenceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> OutboundSchedulesSequencesSequenceidPutAsyncWithHttpInfo (string sequenceId, SequenceSchedule body = null)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSchedulesSequencesSequenceidPut");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(response, typeof(SequenceSchedule)));
            
        }
        
        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <returns>string</returns>
        public string OutboundSchedulesSequencesSequenceidDelete (string sequenceId)
        {
             ApiResponse<string> response = OutboundSchedulesSequencesSequenceidDeleteWithHttpInfo(sequenceId);
             return response.Data;
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundSchedulesSequencesSequenceidDeleteWithHttpInfo (string sequenceId)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSchedulesSequencesSequenceidDelete");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundSchedulesSequencesSequenceidDeleteAsync (string sequenceId)
        {
             ApiResponse<string> response = await OutboundSchedulesSequencesSequenceidDeleteAsyncWithHttpInfo(sequenceId);
             return response.Data;

        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundSchedulesSequencesSequenceidDeleteAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSchedulesSequencesSequenceidDelete");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSchedulesSequencesSequenceidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>CampaignSequenceEntityListing</returns>
        public CampaignSequenceEntityListing OutboundSequencesGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> response = OutboundSequencesGetWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of CampaignSequenceEntityListing</returns>
        public ApiResponse< CampaignSequenceEntityListing > OutboundSequencesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/sequences";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignSequenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequenceEntityListing)));
            
        }
    
        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of CampaignSequenceEntityListing</returns>
        public async System.Threading.Tasks.Task<CampaignSequenceEntityListing> OutboundSequencesGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> response = await OutboundSequencesGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (CampaignSequenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> OutboundSequencesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/sequences";
    
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
            if (filterType != null) queryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSequenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequenceEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>CampaignSequence</returns>
        public CampaignSequence OutboundSequencesPost (CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> response = OutboundSequencesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > OutboundSequencesPostWithHttpInfo (CampaignSequence body = null)
        {
            
    
            var path_ = "/api/v1/outbound/sequences";
    
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
    
        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesPostAsync (CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> response = await OutboundSequencesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesPostAsyncWithHttpInfo (CampaignSequence body = null)
        {
            
    
            var path_ = "/api/v1/outbound/sequences";
    
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
        
        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <returns>CampaignSequence</returns>
        public CampaignSequence OutboundSequencesSequenceidGet (string sequenceId)
        {
             ApiResponse<CampaignSequence> response = OutboundSequencesSequenceidGetWithHttpInfo(sequenceId);
             return response.Data;
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > OutboundSequencesSequenceidGetWithHttpInfo (string sequenceId)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSequencesSequenceidGet");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
    
        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesSequenceidGetAsync (string sequenceId)
        {
             ApiResponse<CampaignSequence> response = await OutboundSequencesSequenceidGetAsyncWithHttpInfo(sequenceId);
             return response.Data;

        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesSequenceidGetAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSequencesSequenceidGet");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
        
        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <param name="body">Organization</param> 
        /// <returns>CampaignSequence</returns>
        public CampaignSequence OutboundSequencesSequenceidPut (string sequenceId, CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> response = OutboundSequencesSequenceidPutWithHttpInfo(sequenceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > OutboundSequencesSequenceidPutWithHttpInfo (string sequenceId, CampaignSequence body = null)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSequencesSequenceidPut");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
    
        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesSequenceidPutAsync (string sequenceId, CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> response = await OutboundSequencesSequenceidPutAsyncWithHttpInfo(sequenceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesSequenceidPutAsyncWithHttpInfo (string sequenceId, CampaignSequence body = null)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSequencesSequenceidPut");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
        
        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <returns>string</returns>
        public string OutboundSequencesSequenceidDelete (string sequenceId)
        {
             ApiResponse<string> response = OutboundSequencesSequenceidDeleteWithHttpInfo(sequenceId);
             return response.Data;
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundSequencesSequenceidDeleteWithHttpInfo (string sequenceId)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSequencesSequenceidDelete");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundSequencesSequenceidDeleteAsync (string sequenceId)
        {
             ApiResponse<string> response = await OutboundSequencesSequenceidDeleteAsyncWithHttpInfo(sequenceId);
             return response.Data;

        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundSequencesSequenceidDeleteAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundSequencesSequenceidDelete");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
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
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundSequencesSequenceidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping OutboundWrapupcodemappingsGet ()
        {
             ApiResponse<WrapUpCodeMapping> response = OutboundWrapupcodemappingsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > OutboundWrapupcodemappingsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/wrapupcodemappings";
    
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
                throw new ApiException (statusCode, "Error calling OutboundWrapupcodemappingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundWrapupcodemappingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapUpCodeMapping>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(response, typeof(WrapUpCodeMapping)));
            
        }
    
        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> OutboundWrapupcodemappingsGetAsync ()
        {
             ApiResponse<WrapUpCodeMapping> response = await OutboundWrapupcodemappingsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> OutboundWrapupcodemappingsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/wrapupcodemappings";
    
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
                throw new ApiException (statusCode, "Error calling OutboundWrapupcodemappingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundWrapupcodemappingsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(response, typeof(WrapUpCodeMapping)));
            
        }
        
        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <param name="body">wrapUpCodeMapping</param> 
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping OutboundWrapupcodemappingsPut (WrapUpCodeMapping body = null)
        {
             ApiResponse<WrapUpCodeMapping> response = OutboundWrapupcodemappingsPutWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <param name="body">wrapUpCodeMapping</param> 
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > OutboundWrapupcodemappingsPutWithHttpInfo (WrapUpCodeMapping body = null)
        {
            
    
            var path_ = "/api/v1/outbound/wrapupcodemappings";
    
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
                throw new ApiException (statusCode, "Error calling OutboundWrapupcodemappingsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundWrapupcodemappingsPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapUpCodeMapping>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(response, typeof(WrapUpCodeMapping)));
            
        }
    
        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> OutboundWrapupcodemappingsPutAsync (WrapUpCodeMapping body = null)
        {
             ApiResponse<WrapUpCodeMapping> response = await OutboundWrapupcodemappingsPutAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> OutboundWrapupcodemappingsPutAsyncWithHttpInfo (WrapUpCodeMapping body = null)
        {
            
    
            var path_ = "/api/v1/outbound/wrapupcodemappings";
    
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
                throw new ApiException (statusCode, "Error calling OutboundWrapupcodemappingsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OutboundWrapupcodemappingsPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(response, typeof(WrapUpCodeMapping)));
            
        }
        
    }
    
}
